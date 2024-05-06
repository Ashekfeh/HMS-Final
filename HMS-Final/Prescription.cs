using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Final
{
    public partial class Prescription : Form
    {
        public void goToPrescription(string id)
        {
            const string sqlconnectionsting = "Data Source=DESKTOP-321K8J9;Initial Catalog=HostpitalManagementSystem;Integrated Security=True;Trust Server Certificate=True";

            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Prescription.ID, Doctor.Name, Patient.Name, Prescription.Date, Prescription.Medicine FROM Prescription INNER JOIN Doctor on Doctor.ID = Prescription.DoctorID INNER JOIN Patient ON Patient.ID = Prescription.PatientID WHERE PatientID =@ID";
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);
            FormProvider.Prescription.prescriptionDataGrid.DataSource = data;
            con.Close();
        }

        public string sqlconnectionsting = "Data Source=DESKTOP-321K8J9;Initial Catalog=HostpitalManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        public Prescription()
        {
            InitializeComponent();
        }

        private void prescriptionSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Prescription.ID, Doctor.Name, Patient.Name AS [PatientName], Prescription.Date, Prescription.Medicine FROM Prescription INNER JOIN Doctor on Doctor.ID = Prescription.DoctorID INNER JOIN Patient ON Patient.ID = Prescription.PatientID WHERE Prescription.ID =@ID";
            cmd.Parameters.AddWithValue("@ID", searchBox1.Text);
            cmd.ExecuteNonQuery();

            DataTable data = new DataTable();
            

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);
            data.Columns[2].ColumnName = "Patient";
            prescriptionDataGrid.DataSource = data;
            con.Close();
        }

        private void patientSearch_Click(object sender, EventArgs e)
        {
            goToPrescription(searchBox1.Text);
        }

        private void prescriptionDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)prescriptionDataGrid.CurrentRow.Cells[0].Value;
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Prescription.ID, Doctor.Name, Patient.Name, Prescription.Date, Prescription.Medicine FROM Prescription INNER JOIN Doctor on Doctor.ID = Prescription.DoctorID INNER JOIN Patient ON Patient.ID = Prescription.PatientID WHERE Prescription.ID =@ID";
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prescriptionID.Text = reader.GetValue(0).ToString();
                doctorName.Text = reader.GetValue(1).ToString().TrimEnd();
                patientName.Text = reader.GetValue(2).ToString().TrimEnd();
                prescriptionDate.Text = reader.GetValue(3).ToString().TrimEnd();
                medication.Text = reader.GetString(4).TrimEnd();
            }
            tabControl1.SelectedTab = detailsPage;
        }
    }
}
