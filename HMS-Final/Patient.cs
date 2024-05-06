using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Final
{
    public partial class Patient : Form
    {
        public string sqlconnectionsting = "Data Source=DESKTOP-321K8J9;Initial Catalog=HostpitalManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        private void loadPatientData()
        {
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT ID, Name, Gender, BloodType FROM Patient";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);

            patientDataGrid.DataSource = data;
            con.Close();
        }
        private void patientDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)patientDataGrid.CurrentRow.Cells[0].Value;
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Patient WHERE ID=@ID";
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                patientID.Text = reader.GetValue(0).ToString();
                patientName.Text = reader.GetValue(1).ToString().TrimEnd();
                patientGender.Text = reader.GetValue(2).ToString().TrimEnd();
                patientPhone.Text = reader.GetValue(3).ToString().TrimEnd();
                patientAddress.Text = reader.GetString(4).TrimEnd();

                bloodTypeCombo.SelectedIndex = bloodTypeCombo.FindString(reader.GetString(5).TrimEnd());
                onMedication.Text = reader.GetValue(6).ToString().TrimEnd();
            }

        }

        public Patient()
        {
            InitializeComponent();
            loadPatientData();

            patientID.Text = "";
            patientName.Text = "";
            patientGender.Text = "";
            onMedication.Text = "";
            patientPhone.Text = "";
            patientAddress.Text = "";
        }

        private void Search(string letter)
        {
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();

            string query = searchType.SelectedIndex == 0 ? "SELECT * FROM Patient WHERE ID LIKE '%" + letter + "%'" : "SELECT * FROM Patient WHERE Name LIKE '%" + letter + "%'";

            SqlCommand cmd = new SqlCommand(query, con);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);

            patientDataGrid.DataSource = data;
            con.Close();
        }
        private void patientSearchBox_KeyPress(object sender, EventArgs e)
        {
            string pattern = @"[a-zA-Z]+";

            patientDataGrid.Columns.Clear();
            if (searchType.SelectedIndex == 0)
            {
                if (patientSearchBox.Text == "" || Regex.IsMatch(patientSearchBox.Text, pattern))
                {
                    loadPatientData();
                }
                else
                {
                    Search(patientSearchBox.Text);
                }
            }
            else
            {
                if (patientSearchBox.Text == "")
                {
                    loadPatientData();
                }
                else
                {
                    Search(patientSearchBox.Text);
                }
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = true;

            patientID.Enabled = true;
            patientName.Enabled = true;
            patientGender.Enabled = true;
            onMedication.Enabled = true;
            patientPhone.Enabled = true;
            patientAddress.Enabled = true;
            saveButton.Enabled = true;
            bloodTypeCombo.Enabled = true;

            patientID.ReadOnly = false;
            patientName.ReadOnly = false;
            patientGender.ReadOnly = false;
            onMedication.ReadOnly = false;
            patientPhone.ReadOnly = false;
            patientAddress.ReadOnly = false;

            patientID.Text = "";
            patientName.Text = "";
            patientGender.Text = "";
            onMedication.Text = "";
            patientPhone.Text = "";
            patientAddress.Text = "";

            patientID.BackColor = SystemColors.ControlLight;
            patientName.BackColor = SystemColors.ControlLight;
            patientGender.BackColor = SystemColors.ControlLight;
            onMedication.BackColor = SystemColors.ControlLight;
            patientAddress.BackColor = SystemColors.ControlLight;
            patientPhone.BackColor = SystemColors.ControlLight;
        }
        private void appointmentButton_Click(object sender, EventArgs e)
        {
            if (patientID.Text != "")
            {
                FormProvider.MainForm.loadForm(FormProvider.Appointment);
                FormProvider.Appointment.goToAppointment(patientID.Text);
            }
            else
            {
                MessageBox.Show("BLEAZE CHOOSE A PATIENT!!!!!");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadPatientData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (patientID.Text == null || patientName.Text == null)
            {
                MessageBox.Show("Please insert missing information!", "warning", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(sqlconnectionsting);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Patient (ID, Name, Gender, Phone, Address, BloodType, Medication) values (@ID, @Name, @Gender, @Phone, @Address, @BloodType, @Medication);";

                cmd.Parameters.AddWithValue("@ID", patientID.Text);
                cmd.Parameters.AddWithValue("@Name", patientName.Text);
                cmd.Parameters.AddWithValue("@Gender", patientGender.Text);
                cmd.Parameters.AddWithValue("@BloodType", bloodTypeCombo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Medication", onMedication.Text);
                cmd.Parameters.AddWithValue("@Phone", patientPhone.Text);
                cmd.Parameters.AddWithValue("@Address", patientAddress.Text);
                cmd.ExecuteNonQuery();

                saveButton.Visible = !saveButton.Visible;

                patientID.Enabled = !patientID.Enabled;
                patientName.Enabled = !patientName.Enabled;
                patientGender.Enabled = !patientGender.Enabled;
                onMedication.Enabled = !onMedication.Enabled;
                patientPhone.Enabled = !patientPhone.Enabled;
                patientAddress.Enabled = !patientAddress.Enabled;
                saveButton.Enabled = !saveButton.Enabled;
                bloodTypeCombo.Enabled = !bloodTypeCombo.Enabled;

                patientID.ReadOnly = !patientID.ReadOnly;
                patientName.ReadOnly = !patientName.ReadOnly;
                patientGender.ReadOnly = !patientGender.ReadOnly;
                patientPhone.ReadOnly = !patientPhone.ReadOnly;
                onMedication.ReadOnly = !onMedication.ReadOnly;
                patientAddress.ReadOnly = !patientAddress.ReadOnly;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Patient WHERE ID=@ID";
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                cmd.Parameters.AddWithValue("@ID", int.Parse(patientID.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("INVALID ID ADDRESS");
            }
            patientID.Text = "";
            patientName.Text = "";

            patientPhone.Text = "";
            patientAddress.Text = "";
            loadPatientData();
        }

        private void prescriptionButton_Click(object sender, EventArgs e)
        {
            if (patientID.Text != "")
            {
                FormProvider.MainForm.loadForm(FormProvider.Prescription);
                FormProvider.Prescription.goToPrescription(patientID.Text);
            }
            else
            {
                MessageBox.Show("BLEAZE CHOOSE A PATIENT!!!!!");
            }
        }
    }
}
