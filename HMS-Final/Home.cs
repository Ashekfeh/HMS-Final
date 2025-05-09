﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormProvider.MainForm.loadForm(FormProvider.Doctor);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormProvider.MainForm.loadForm(FormProvider.Patient);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormProvider.MainForm.loadForm(FormProvider.Appointment);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormProvider.MainForm.loadForm(FormProvider.Prescription);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void departmentPicture_Click(object sender, EventArgs e)
        {
            FormProvider.MainForm.loadForm(FormProvider.Department);
        }
    }
}
