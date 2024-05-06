namespace HMS_Final
{
    partial class Prescription
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
            controlPanel = new Panel();
            pictureBox1 = new PictureBox();
            prescriptionSearch = new Button();
            patientSearch = new Button();
            searchBox1 = new TextBox();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            PrescriptionPage = new TabPage();
            prescriptionDataGrid = new DataGridView();
            detailsPage = new TabPage();
            detailLayoutPanel = new TableLayoutPanel();
            prescriptionID = new Label();
            patientName = new Label();
            medicineLabel = new Label();
            prescriptionDate = new Label();
            doctorName = new Label();
            medication = new Label();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            PrescriptionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionDataGrid).BeginInit();
            detailsPage.SuspendLayout();
            detailLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = SystemColors.ActiveCaption;
            controlPanel.Controls.Add(pictureBox1);
            controlPanel.Controls.Add(prescriptionSearch);
            controlPanel.Controls.Add(patientSearch);
            controlPanel.Controls.Add(searchBox1);
            controlPanel.Dock = DockStyle.Left;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(414, 645);
            controlPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medical_prescription_5873129;
            pictureBox1.Location = new Point(99, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // prescriptionSearch
            // 
            prescriptionSearch.Location = new Point(225, 470);
            prescriptionSearch.Name = "prescriptionSearch";
            prescriptionSearch.Size = new Size(132, 40);
            prescriptionSearch.TabIndex = 1;
            prescriptionSearch.Text = "Prescription ID";
            prescriptionSearch.UseVisualStyleBackColor = true;
            prescriptionSearch.Click += prescriptionSearch_Click;
            // 
            // patientSearch
            // 
            patientSearch.Location = new Point(62, 470);
            patientSearch.Name = "patientSearch";
            patientSearch.Size = new Size(101, 40);
            patientSearch.TabIndex = 1;
            patientSearch.Text = "Patient";
            patientSearch.UseVisualStyleBackColor = true;
            patientSearch.Click += patientSearch_Click;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(62, 415);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(295, 27);
            searchBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(420, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 645);
            panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PrescriptionPage);
            tabControl1.Controls.Add(detailsPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 645);
            tabControl1.TabIndex = 0;
            // 
            // PrescriptionPage
            // 
            PrescriptionPage.Controls.Add(prescriptionDataGrid);
            PrescriptionPage.Location = new Point(4, 29);
            PrescriptionPage.Name = "PrescriptionPage";
            PrescriptionPage.Padding = new Padding(3);
            PrescriptionPage.Size = new Size(834, 612);
            PrescriptionPage.TabIndex = 0;
            PrescriptionPage.Text = "Prescription";
            PrescriptionPage.UseVisualStyleBackColor = true;
            // 
            // prescriptionDataGrid
            // 
            prescriptionDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prescriptionDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionDataGrid.Dock = DockStyle.Fill;
            prescriptionDataGrid.Location = new Point(3, 3);
            prescriptionDataGrid.Name = "prescriptionDataGrid";
            prescriptionDataGrid.ReadOnly = true;
            prescriptionDataGrid.RowHeadersWidth = 51;
            prescriptionDataGrid.Size = new Size(828, 606);
            prescriptionDataGrid.TabIndex = 2;
            prescriptionDataGrid.CellDoubleClick += prescriptionDataGrid_CellDoubleClick;
            // 
            // detailsPage
            // 
            detailsPage.Controls.Add(detailLayoutPanel);
            detailsPage.Location = new Point(4, 29);
            detailsPage.Name = "detailsPage";
            detailsPage.Padding = new Padding(3);
            detailsPage.Size = new Size(834, 612);
            detailsPage.TabIndex = 1;
            detailsPage.Text = "Details";
            detailsPage.UseVisualStyleBackColor = true;
            // 
            // detailLayoutPanel
            // 
            detailLayoutPanel.ColumnCount = 2;
            detailLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.3158569F));
            detailLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.6841431F));
            detailLayoutPanel.Controls.Add(prescriptionID, 0, 0);
            detailLayoutPanel.Controls.Add(patientName, 0, 1);
            detailLayoutPanel.Controls.Add(medicineLabel, 0, 2);
            detailLayoutPanel.Controls.Add(prescriptionDate, 1, 0);
            detailLayoutPanel.Controls.Add(doctorName, 1, 1);
            detailLayoutPanel.Controls.Add(medication, 0, 3);
            detailLayoutPanel.Location = new Point(15, 16);
            detailLayoutPanel.Name = "detailLayoutPanel";
            detailLayoutPanel.RowCount = 4;
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3263893F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4027786F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 44.09722F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            detailLayoutPanel.Size = new Size(801, 576);
            detailLayoutPanel.TabIndex = 0;
            // 
            // prescriptionID
            // 
            prescriptionID.Anchor = AnchorStyles.Left;
            prescriptionID.AutoSize = true;
            prescriptionID.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            prescriptionID.Location = new Point(3, 17);
            prescriptionID.Name = "prescriptionID";
            prescriptionID.Size = new Size(46, 37);
            prescriptionID.TabIndex = 0;
            prescriptionID.Text = "ID";
            // 
            // patientName
            // 
            patientName.Anchor = AnchorStyles.Left;
            patientName.AutoSize = true;
            patientName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            patientName.Location = new Point(3, 105);
            patientName.Name = "patientName";
            patientName.Size = new Size(186, 37);
            patientName.TabIndex = 0;
            patientName.Text = "patientName";
            // 
            // medicineLabel
            // 
            medicineLabel.Anchor = AnchorStyles.Left;
            medicineLabel.AutoSize = true;
            medicineLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            medicineLabel.Location = new Point(3, 230);
            medicineLabel.Name = "medicineLabel";
            medicineLabel.Size = new Size(147, 37);
            medicineLabel.TabIndex = 0;
            medicineLabel.Text = "MEDICINE";
            // 
            // prescriptionDate
            // 
            prescriptionDate.Anchor = AnchorStyles.Left;
            prescriptionDate.AutoSize = true;
            prescriptionDate.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            prescriptionDate.Location = new Point(382, 17);
            prescriptionDate.Name = "prescriptionDate";
            prescriptionDate.Size = new Size(149, 37);
            prescriptionDate.TabIndex = 0;
            prescriptionDate.Text = "DATETIME";
            // 
            // doctorName
            // 
            doctorName.Anchor = AnchorStyles.Left;
            doctorName.AutoSize = true;
            doctorName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            doctorName.Location = new Point(382, 105);
            doctorName.Name = "doctorName";
            doctorName.Size = new Size(207, 37);
            doctorName.TabIndex = 0;
            doctorName.Text = "DOCTORNAME";
            // 
            // medication
            // 
            medication.Anchor = AnchorStyles.None;
            medication.Location = new Point(14, 343);
            medication.Name = "medication";
            medication.Size = new Size(350, 211);
            medication.TabIndex = 1;
            medication.Text = "MEDICATION";
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 645);
            Controls.Add(panel2);
            Controls.Add(controlPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1262, 645);
            Name = "Prescription";
            Text = "Prescription";
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            PrescriptionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)prescriptionDataGrid).EndInit();
            detailsPage.ResumeLayout(false);
            detailLayoutPanel.ResumeLayout(false);
            detailLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel controlPanel;
        private PictureBox pictureBox1;
        private Button prescriptionSearch;
        private Button patientSearch;
        private TextBox searchBox1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage PrescriptionPage;
        private DataGridView prescriptionDataGrid;
        private TabPage detailsPage;
        private TableLayoutPanel detailLayoutPanel;
        private Label prescriptionID;
        private Label patientName;
        private Label medicineLabel;
        private Label prescriptionDate;
        private Label doctorName;
        private Label medication;
    }
}