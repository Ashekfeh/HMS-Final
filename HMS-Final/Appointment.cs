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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HMS_Final
{
    public partial class Appointment : Form
    {
        public string sqlconnectionsting = "Data Source=DESKTOP-321K8J9;Initial Catalog=HostpitalManagementSystem;Integrated Security=True;Trust Server Certificate=True";

        public void goToAppointment(string id)
        {
            const string sqlconnectionsting = "Data Source=DESKTOP-321K8J9;Initial Catalog=HostpitalManagementSystem;Integrated Security=True;Trust Server Certificate=True";

            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Appointment.ID, Doctor.Name, Patient.Name, Appointment.DateTime, Appointment.Room FROM Appointment INNER JOIN Doctor on Doctor.ID = Appointment.DoctorID INNER JOIN Patient ON Patient.ID = Appointment.PatientID WHERE PatientID =@ID";
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);
            FormProvider.Appointment.appointmentDataGrid.DataSource = data;
            con.Close();
        }
        public Appointment()
        {
            InitializeComponent();
            textBox1.PlaceholderText = "Search By ID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppID_Click(object sender, EventArgs e)
        {

        }

        private void doctorSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Appointment.ID, Doctor.Name, Patient.Name, Appointment.DateTime, Appointment.Room FROM Appointment INNER JOIN Doctor on Doctor.ID = Appointment.DoctorID INNER JOIN Patient ON Patient.ID = Appointment.PatientID WHERE DoctorID =@ID";
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.ExecuteNonQuery();

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data);

            appointmentDataGrid.DataSource = data;
            con.Close();
        }

        private void appointmentDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)appointmentDataGrid.CurrentRow.Cells[0].Value;
            SqlConnection con = new SqlConnection(sqlconnectionsting);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Appointment.ID, Doctor.Name, Patient.Name, Appointment.DateTime, Appointment.Room, Appointment.Notes FROM Appointment INNER JOIN Doctor on Doctor.ID = Appointment.DoctorID INNER JOIN Patient ON Patient.ID = Appointment.PatientID WHERE Appointment.ID =@ID";
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appointmentID.Text = reader.GetValue(0).ToString();
                doctorName.Text = reader.GetValue(1).ToString().TrimEnd();
                patientName.Text = reader.GetValue(2).ToString().TrimEnd();
                appointmentDateTime.Text = reader.GetValue(3).ToString().TrimEnd();
                appointmentRoom.Text = reader.GetString(4).TrimEnd();
                NotesArea.Text = reader.GetString(5).TrimEnd();
            }
            tabControl1.SelectedTab = detailsPage;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void patientSearch_Click(object sender, EventArgs e)
        {
            goToAppointment(textBox1.Text);
        }
    }
}
