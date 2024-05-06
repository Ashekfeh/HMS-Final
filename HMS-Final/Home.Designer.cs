namespace HMS_Final
{
    partial class Home
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            departmentPicture = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentPicture).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox5, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox4, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 1, 3);
            tableLayoutPanel1.Controls.Add(departmentPicture, 1, 2);
            tableLayoutPanel1.Location = new Point(35, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1155, 557);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(119, 232);
            label1.Name = "label1";
            label1.Size = new Size(145, 46);
            label1.TabIndex = 1;
            label1.Text = "Doctors";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.patient_3359183;
            pictureBox1.Location = new Point(440, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.doctor_2875035;
            pictureBox2.Location = new Point(55, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(273, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.medical_appointment_15086971;
            pictureBox3.Location = new Point(825, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(273, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label2.Location = new Point(502, 232);
            label2.Name = "label2";
            label2.Size = new Size(148, 46);
            label2.TabIndex = 1;
            label2.Text = "Patients";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label3.Location = new Point(837, 232);
            label3.Name = "label3";
            label3.Size = new Size(249, 46);
            label3.TabIndex = 1;
            label3.Text = "Appointments";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = Properties.Resources.medical_prescription_5873129;
            pictureBox5.Location = new Point(55, 317);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(273, 154);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label5.Location = new Point(77, 510);
            label5.Name = "label5";
            label5.Size = new Size(229, 46);
            label5.TabIndex = 1;
            label5.Text = "Prescriptions";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = Properties.Resources.setting_2040504;
            pictureBox4.Location = new Point(803, 309);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(318, 170);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label4.Location = new Point(887, 510);
            label4.Name = "label4";
            label4.Size = new Size(150, 46);
            label4.TabIndex = 1;
            label4.Text = "Settings";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label6.Location = new Point(462, 510);
            label6.Name = "label6";
            label6.Size = new Size(228, 46);
            label6.TabIndex = 1;
            label6.Text = "Departments";
            // 
            // departmentPicture
            // 
            departmentPicture.Anchor = AnchorStyles.None;
            departmentPicture.Image = Properties.Resources.hospital_2135602;
            departmentPicture.Location = new Point(440, 317);
            departmentPicture.Name = "departmentPicture";
            departmentPicture.Size = new Size(273, 154);
            departmentPicture.SizeMode = PictureBoxSizeMode.Zoom;
            departmentPicture.TabIndex = 0;
            departmentPicture.TabStop = false;
            departmentPicture.Click += departmentPicture_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 598);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1244, 598);
            Name = "Home";
            Text = "Home";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label6;
        private PictureBox departmentPicture;
    }
}