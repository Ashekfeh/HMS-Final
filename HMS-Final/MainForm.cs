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
    public partial class MainForm : Form
    {
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        public MainForm()
        {
            InitializeComponent();
            this.loadForm(FormProvider.HomeForm);
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormProvider.LoginForm.Show();
                this.Close();
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(FormProvider.HomeForm);
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(FormProvider.Patient);
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(FormProvider.Doctor);
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(FormProvider.Appointment);
        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(FormProvider.Prescription);
        }
    }
}
