namespace HMS_Final
{
    partial class Appointment
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
            patientSearch = new Button();
            doctorSearch = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            AppointmentsPage = new TabPage();
            appointmentDataGrid = new DataGridView();
            detailsPage = new TabPage();
            detailLayoutPanel = new TableLayoutPanel();
            appointmentID = new Label();
            patientName = new Label();
            appointmentRoom = new Label();
            appointmentNoteLabel = new Label();
            appointmentDateTime = new Label();
            doctorName = new Label();
            NotesArea = new Label();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            AppointmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentDataGrid).BeginInit();
            detailsPage.SuspendLayout();
            detailLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = SystemColors.ActiveCaption;
            controlPanel.Controls.Add(pictureBox1);
            controlPanel.Controls.Add(patientSearch);
            controlPanel.Controls.Add(doctorSearch);
            controlPanel.Controls.Add(textBox1);
            controlPanel.Dock = DockStyle.Left;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(414, 645);
            controlPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_3031293;
            pictureBox1.Location = new Point(84, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // patientSearch
            // 
            patientSearch.Location = new Point(256, 470);
            patientSearch.Name = "patientSearch";
            patientSearch.Size = new Size(101, 40);
            patientSearch.TabIndex = 1;
            patientSearch.Text = "Patient";
            patientSearch.UseVisualStyleBackColor = true;
            patientSearch.Click += patientSearch_Click;
            // 
            // doctorSearch
            // 
            doctorSearch.Location = new Point(62, 470);
            doctorSearch.Name = "doctorSearch";
            doctorSearch.Size = new Size(101, 40);
            doctorSearch.TabIndex = 1;
            doctorSearch.Text = "Doctor";
            doctorSearch.UseVisualStyleBackColor = true;
            doctorSearch.Click += doctorSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(420, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 645);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AppointmentsPage);
            tabControl1.Controls.Add(detailsPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 645);
            tabControl1.TabIndex = 0;
            // 
            // AppointmentsPage
            // 
            AppointmentsPage.Controls.Add(appointmentDataGrid);
            AppointmentsPage.Location = new Point(4, 29);
            AppointmentsPage.Name = "AppointmentsPage";
            AppointmentsPage.Padding = new Padding(3);
            AppointmentsPage.Size = new Size(834, 612);
            AppointmentsPage.TabIndex = 0;
            AppointmentsPage.Text = "Appointments";
            AppointmentsPage.UseVisualStyleBackColor = true;
            // 
            // appointmentDataGrid
            // 
            appointmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentDataGrid.Dock = DockStyle.Fill;
            appointmentDataGrid.Location = new Point(3, 3);
            appointmentDataGrid.Name = "appointmentDataGrid";
            appointmentDataGrid.ReadOnly = true;
            appointmentDataGrid.RowHeadersWidth = 51;
            appointmentDataGrid.Size = new Size(828, 606);
            appointmentDataGrid.TabIndex = 2;
            appointmentDataGrid.CellDoubleClick += appointmentDataGrid_CellDoubleClick;
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
            detailLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.38041F));
            detailLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.6195869F));
            detailLayoutPanel.Controls.Add(appointmentID, 0, 0);
            detailLayoutPanel.Controls.Add(patientName, 0, 1);
            detailLayoutPanel.Controls.Add(appointmentRoom, 0, 2);
            detailLayoutPanel.Controls.Add(appointmentNoteLabel, 0, 3);
            detailLayoutPanel.Controls.Add(appointmentDateTime, 1, 0);
            detailLayoutPanel.Controls.Add(doctorName, 1, 1);
            detailLayoutPanel.Controls.Add(NotesArea, 0, 4);
            detailLayoutPanel.Location = new Point(15, 16);
            detailLayoutPanel.Name = "detailLayoutPanel";
            detailLayoutPanel.RowCount = 5;
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.201389F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.020833F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1527777F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1944447F));
            detailLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 52.4305573F));
            detailLayoutPanel.Size = new Size(801, 576);
            detailLayoutPanel.TabIndex = 0;
            // 
            // appointmentID
            // 
            appointmentID.Anchor = AnchorStyles.Left;
            appointmentID.AutoSize = true;
            appointmentID.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            appointmentID.Location = new Point(3, 8);
            appointmentID.Name = "appointmentID";
            appointmentID.Size = new Size(46, 37);
            appointmentID.TabIndex = 0;
            appointmentID.Text = "ID";
            appointmentID.Click += AppID_Click;
            // 
            // patientName
            // 
            patientName.Anchor = AnchorStyles.Left;
            patientName.AutoSize = true;
            patientName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            patientName.Location = new Point(3, 72);
            patientName.Name = "patientName";
            patientName.Size = new Size(186, 37);
            patientName.TabIndex = 0;
            patientName.Text = "patientName";
            // 
            // appointmentRoom
            // 
            appointmentRoom.Anchor = AnchorStyles.Left;
            appointmentRoom.AutoSize = true;
            appointmentRoom.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            appointmentRoom.Location = new Point(3, 144);
            appointmentRoom.Name = "appointmentRoom";
            appointmentRoom.Size = new Size(147, 37);
            appointmentRoom.TabIndex = 0;
            appointmentRoom.Text = "MEDICINE";
            // 
            // appointmentNoteLabel
            // 
            appointmentNoteLabel.Anchor = AnchorStyles.Left;
            appointmentNoteLabel.AutoSize = true;
            appointmentNoteLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            appointmentNoteLabel.Location = new Point(3, 217);
            appointmentNoteLabel.Name = "appointmentNoteLabel";
            appointmentNoteLabel.Size = new Size(102, 37);
            appointmentNoteLabel.TabIndex = 0;
            appointmentNoteLabel.Text = "NOTES";
            // 
            // appointmentDateTime
            // 
            appointmentDateTime.Anchor = AnchorStyles.Left;
            appointmentDateTime.AutoSize = true;
            appointmentDateTime.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            appointmentDateTime.Location = new Point(382, 8);
            appointmentDateTime.Name = "appointmentDateTime";
            appointmentDateTime.Size = new Size(84, 37);
            appointmentDateTime.TabIndex = 0;
            appointmentDateTime.Text = "DATE";
            appointmentDateTime.Click += AppID_Click;
            // 
            // doctorName
            // 
            doctorName.Anchor = AnchorStyles.Left;
            doctorName.AutoSize = true;
            doctorName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            doctorName.Location = new Point(382, 72);
            doctorName.Name = "doctorName";
            doctorName.Size = new Size(207, 37);
            doctorName.TabIndex = 0;
            doctorName.Text = "DOCTORNAME";
            // 
            // NotesArea
            // 
            NotesArea.Anchor = AnchorStyles.None;
            NotesArea.Location = new Point(8, 289);
            NotesArea.Name = "NotesArea";
            NotesArea.Size = new Size(362, 272);
            NotesArea.TabIndex = 1;
            NotesArea.Text = "test";
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 645);
            Controls.Add(panel2);
            Controls.Add(controlPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1262, 645);
            Name = "Appointment";
            Text = "Appointment";
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            AppointmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentDataGrid).EndInit();
            detailsPage.ResumeLayout(false);
            detailLayoutPanel.ResumeLayout(false);
            detailLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel controlPanel;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage AppointmentsPage;
        private TabPage detailsPage;
        private Button patientSearch;
        private Button doctorSearch;
        private TextBox textBox1;
        private DataGridView appointmentDataGrid;
        private TableLayoutPanel detailLayoutPanel;
        private Label appointmentID;
        private Label patientName;
        private Label appointmentRoom;
        private Label appointmentNoteLabel;
        private Label appointmentDateTime;
        private Label doctorName;
        private Label NotesArea;
        private PictureBox pictureBox1;
    }
}