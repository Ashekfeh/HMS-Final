using Microsoft.Data.SqlClient;

namespace HMS_Final
{
    public partial class Login : Form
    {
        private bool isDragging = false;
        private Point lastLocation;

        private string defaultLogin = "admin";

        public Login()
        {
            InitializeComponent();
        }
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }
        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void revealPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = revealPassword.Checked ? '\0' : '*';
        }

        private void formLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-321K8J9;"
                + "Initial Catalog=HostpitalManagementSystem;" +
                "Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM HMSuser WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@password", passwordBox.Text);
            cmd.Parameters.AddWithValue("@username", usernameBox.Text);
            int count = (int)cmd.ExecuteScalar();

            con.Close();

            if (count > 0 || (usernameBox.Text == defaultLogin && passwordBox.Text == defaultLogin))
            {
                this.Hide();
                passwordBox.Text = "";
                FormProvider.MainForm.Show();
            }
            else
            {
                MessageBox.Show("Password or username are incorrect", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
