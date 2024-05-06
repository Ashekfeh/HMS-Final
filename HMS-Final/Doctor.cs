using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HMS_Final
{
    public partial class Doctor : Form
    {
        public string sqlconnectionsting = "Data Source=DESKTOP-321K8J9;Initial Catalog=HostpitalManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        public List<string> departmentIds = new List<string>();
        public string imagePath;
        public string sasa;

        private void loadDepartments(object ComboBox)
        {
            ComboBox cb = ComboBox as ComboBox;
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT [ID], [Name] FROM [HostpitalManagementSystem].[dbo].[Department];";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb.Items.Add(reader.GetString(1));
                departmentIds.Add(reader.GetValue(0).ToString());
            }

            con.Close();
        }
        private void loadDoctorData()
        {
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (isActiveCheckBox.Checked)
            {
                cmd.CommandText = departmentComboBox.SelectedIndex == 0 ? "SELECT Doctor.ID, Doctor.Name, Department.Name, Doctor.HireDate, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID  WHERE isActive=1;" : "SELECT Doctor.ID, Doctor.Name, Department.Name, Doctor.HireDate, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID  WHERE isActive=1 AND Department=" + departmentIds[departmentComboBox.SelectedIndex - 1];
            }
            else
            {
                cmd.CommandText = departmentComboBox.SelectedIndex == 0 ? "SELECT Doctor.ID, Doctor.Name, Department.Name, Doctor.HireDate, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID;" : "SELECT Doctor.ID, Doctor.Name, Department.Name, Doctor.HireDate, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID WHERE Department=" + departmentIds[departmentComboBox.SelectedIndex - 1];
            }

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);

            docDataGrid.DataSource = data;
            con.Close();
        }
        public Doctor()
        {
            InitializeComponent();
            searchBox.PlaceholderText = "Search";
            searchType.SelectedIndex = 0;
            departmentComboBox.Items.Add("none");
            departmentComboBox.SelectedIndex = 0;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            loadDepartments(departmentComboBox);
            loadDoctorData();
        }

        private void docDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            docDepartment.Items.Clear();
            int id = (int)docDataGrid.CurrentRow.Cells[0].Value;
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Doctor.ID, Doctor.Name, Department.Name,Doctor.Phone,Doctor.Address, Doctor.HireDate, Doctor.FireDate,Doctor.Image_path, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID  WHERE Doctor.ID=@ID";
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                docID.Text = reader.GetValue(0).ToString();
                docName.Text = reader.GetValue(1).ToString().TrimEnd();

                docDepartment.Items.Add(reader.GetValue(2).ToString().TrimEnd());
                docDepartment.SelectedIndex = 0;
                docPhone.Text = reader.GetValue(3).ToString().TrimEnd();
                docAddress.Text = reader.GetValue(4).ToString().TrimEnd();
                docHireDate.Text = reader.GetDateTime(5).ToString();
                if (reader.GetValue(6) == null)
                {
                    fireDateLabel.Visible = false;
                }
                else
                {
                    docFireDate.Text = reader.GetValue(6).ToString();
                }
                docPicture.Image = reader.GetValue(7).ToString() != "" ? Image.FromFile(reader.GetValue(7).ToString()) : Properties.Resources.doctor_2875035;
            }

        }

        private void qualButton_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "E:\\Doctor.txt");
        }

        private void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            docDataGrid.Columns.Clear();
            loadDoctorData();
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.PlaceholderText = "Search " + searchType.Text;
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            docDataGrid.Columns.Clear();
            loadDoctorData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            loadDoctorData();
        }
        private void Search(string letter)
        {
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();

            string query = searchType.SelectedIndex == 0 ? "SELECT Doctor.ID, Doctor.Name, Department.Name, Doctor.HireDate, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID  WHERE Doctor.ID=" + letter : "SELECT Doctor.ID, Doctor.Name, Department.Name, Doctor.HireDate, Doctor.isActive FROM Doctor INNER JOIN Department ON Doctor.Department = Department.ID  WHERE Doctor.Name LIKE '%" + letter + "%'"; //where [fullName]\r\n like '%" +letter + "%'";

            SqlCommand cmd = new SqlCommand(query, con);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);

            docDataGrid.DataSource = data;
            con.Close();
        }
        private void SearchBox_KeyPress(object sender, EventArgs e)
        {
            string pattern = @"[a-zA-Z]+";

            docDataGrid.Columns.Clear();
            if (searchType.SelectedIndex == 0)
            {
                if (searchBox.Text == "" || Regex.IsMatch(searchBox.Text, pattern))
                {
                    loadDoctorData();
                }
                else
                {
                    Search(searchBox.Text);
                }
            }
            else
            {
                if (searchBox.Text == "")
                {
                    loadDoctorData();
                }
                else
                {
                    Search(searchBox.Text);
                }
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            sasa = "saving";

            button1.Visible = true;

            docID.Enabled = true;
            docName.Enabled = true;
            docDepartment.Enabled = true;
            docPhone.Enabled = true;
            docAddress.Enabled = true;
            docFireDate.Enabled = true;
            docHireDate.Enabled = true;
            saveButton.Enabled = true;

            docID.ReadOnly = false;
            docName.ReadOnly = false;
            docPhone.ReadOnly = false;
            docAddress.ReadOnly = false;
            docFireDate.ReadOnly = false;
            docHireDate.ReadOnly = false;

            docID.Text = "";
            docName.Text = "";
            docDepartment.Items.Clear();
            loadDepartments(docDepartment);

            docPhone.Text = "";
            docAddress.Text = "";
            docFireDate.Text = "";
            docHireDate.Text = "";
            docPicture.Image = null;

            docID.BackColor = SystemColors.ControlLight;
            docName.BackColor = SystemColors.ControlLight;
            docAddress.BackColor = SystemColors.ControlLight;
            docDepartment.BackColor = SystemColors.ControlLight;
            docPhone.BackColor = SystemColors.ControlLight;
            docHireDate.BackColor = SystemColors.ControlLight;
            docFireDate.BackColor = SystemColors.ControlLight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog image1 = new OpenFileDialog();
            if (image1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagePath = image1.FileName;
                Image image = Image.FromFile(image1.FileName);
                docPicture.Image = image;
                docPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (imagePath == "") { imagePath = Properties.Resources.doctor_2875035.ToString(); }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (docID.Text == null || docName.Text == null || docHireDate.Text == null)
            {
                MessageBox.Show("Please insert missing information!", "warning", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(sqlconnectionsting);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sasa == "saving" ? "INSERT INTO Doctor (ID, Name, Department, Phone, Address, HireDate, FireDate,Image_path, isActive) " +
                                                    "values (@docID, @docName, @docDepartment, @docPhone, @docAddress, @docHireDate, @docFireDate, @Image, 1 )" 
                                                    : "UPDATE Doctor SET Name=@docName, Department=@docDepartment, Phone=@docPhone, Address=@docAddress, HireDate=@docHireDate, FireDate=@docFireDate, Image_path=@Image, isActive = 1 WHERE ID=@docID";

                DateTime dateValue;
                if (DateTime.TryParse(docHireDate.Text, out dateValue))
                {
                    string formattedDate = dateValue.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@docHireDate", formattedDate);
                    if (DateTime.TryParse(docFireDate.Text, out dateValue))
                    {
                        string formattedFireDate = dateValue.ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@docFireDate", formattedFireDate);
                    }
                    else
                    {
                        docFireDate.Text = null;
                        cmd.Parameters.AddWithValue("@docFireDate", DBNull.Value);
                    }
                }
                else
                {
                    MessageBox.Show(docHireDate.Text);
                    MessageBox.Show("error");
                }

                cmd.Parameters.AddWithValue("@docID", docID.Text);
                cmd.Parameters.AddWithValue("@docName", docName.Text);
                cmd.Parameters.AddWithValue("@docDepartment", departmentIds[docDepartment.SelectedIndex]);
                cmd.Parameters.AddWithValue("@docPhone", docPhone.Text);
                cmd.Parameters.AddWithValue("@docAddress", docAddress.Text);
                cmd.Parameters.AddWithValue("@Image", imagePath == null ? DBNull.Value : imagePath);
                cmd.ExecuteNonQuery();

                button1.Visible = !button1.Visible;

                docID.Enabled = !docID.Enabled;
                docName.Enabled = !docName.Enabled;
                docDepartment.Enabled = !docDepartment.Enabled;
                docPhone.Enabled = !docPhone.Enabled;
                docAddress.Enabled = !docAddress.Enabled;
                docFireDate.Enabled = !docFireDate.Enabled;
                docHireDate.Enabled = !docHireDate.Enabled;
                saveButton.Enabled = !saveButton.Enabled;

                docID.ReadOnly = !docID.ReadOnly;
                docName.ReadOnly = !docName.ReadOnly;
                docPhone.ReadOnly = !docPhone.ReadOnly;
                docAddress.ReadOnly = !docAddress.ReadOnly;
                docFireDate.ReadOnly = !docFireDate.ReadOnly;
                docHireDate.ReadOnly = !docHireDate.ReadOnly;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Doctor WHERE ID=@ID";
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                cmd.Parameters.AddWithValue("@ID", int.Parse(docID.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("INVALID ID ADDRESS");
            }
            docID.Text = "";
            docName.Text = "";
            docDepartment.Items.Clear();
            loadDepartments(docDepartment);

            docPhone.Text = "";
            docAddress.Text = "";
            docFireDate.Text = "";
            docHireDate.Text = "";
            docPicture.Image = null;
            loadDoctorData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            docHireDate.Text = Convert.ToDateTime(dateTimePicker1.Value).ToString("dd-MM-yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            docFireDate.Text = Convert.ToDateTime(dateTimePicker2.Value).ToString("dd-MM-yyyy");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            sasa = "editing";
            docID.ReadOnly = !docID.ReadOnly;
            docName.ReadOnly = !docName.ReadOnly;
            docPhone.ReadOnly = !docPhone.ReadOnly;
            docAddress.ReadOnly = !docAddress.ReadOnly;
            docFireDate.ReadOnly = !docFireDate.ReadOnly;
            docHireDate.ReadOnly = !docHireDate.ReadOnly;

            button1.Visible = !button1.Visible;
            saveButton.Enabled = !saveButton.Enabled;
        }
    }
}
