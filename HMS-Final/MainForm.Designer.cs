namespace HMS_Final
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenuStrip = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            doctorsToolStripMenuItem = new ToolStripMenuItem();
            patientsToolStripMenuItem = new ToolStripMenuItem();
            appointmentsToolStripMenuItem = new ToolStripMenuItem();
            prescriptionsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, doctorsToolStripMenuItem, patientsToolStripMenuItem, appointmentsToolStripMenuItem, prescriptionsToolStripMenuItem, logOutToolStripMenuItem, settingsToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1262, 28);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "MainMenustrip";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // doctorsToolStripMenuItem
            // 
            doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            doctorsToolStripMenuItem.Size = new Size(75, 24);
            doctorsToolStripMenuItem.Text = "Doctors";
            doctorsToolStripMenuItem.Click += doctorsToolStripMenuItem_Click;
            // 
            // patientsToolStripMenuItem
            // 
            patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            patientsToolStripMenuItem.Size = new Size(74, 24);
            patientsToolStripMenuItem.Text = "Patients";
            patientsToolStripMenuItem.Click += patientsToolStripMenuItem_Click;
            // 
            // appointmentsToolStripMenuItem
            // 
            appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            appointmentsToolStripMenuItem.Size = new Size(117, 24);
            appointmentsToolStripMenuItem.Text = "Appointments";
            appointmentsToolStripMenuItem.Click += appointmentsToolStripMenuItem_Click;
            // 
            // prescriptionsToolStripMenuItem
            // 
            prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            prescriptionsToolStripMenuItem.Size = new Size(107, 24);
            prescriptionsToolStripMenuItem.Text = "Prescriptions";
            prescriptionsToolStripMenuItem.Click += prescriptionsToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 28);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1262, 645);
            mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(mainPanel);
            Controls.Add(MainMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem doctorsToolStripMenuItem;
        private ToolStripMenuItem patientsToolStripMenuItem;
        private ToolStripMenuItem appointmentsToolStripMenuItem;
        private ToolStripMenuItem prescriptionsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Panel mainPanel;
    }
}