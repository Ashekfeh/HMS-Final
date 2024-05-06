namespace HMS_Final
{
    partial class Patient
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
            docListPanel = new Panel();
            searchPanel = new Panel();
            refreshButton = new Button();
            patientSearchBox = new TextBox();
            searchType = new ComboBox();
            patientDataGrid = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            IDLabel = new Label();
            nameLabel = new Label();
            patientID = new TextBox();
            onMedicine = new Label();
            onMedication = new TextBox();
            patientName = new TextBox();
            phoneLabel = new Label();
            patientPhone = new MaskedTextBox();
            patientAddress = new TextBox();
            addressLabel = new Label();
            genderLabel = new Label();
            patientGender = new TextBox();
            bloodTypeLabel = new Label();
            bloodTypeCombo = new ComboBox();
            appointmentButton = new Button();
            prescriptionButton = new Button();
            medicalHistory = new Button();
            addButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            docDetailsPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            docListPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            docDetailsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // docListPanel
            // 
            docListPanel.BackColor = Color.Transparent;
            docListPanel.Controls.Add(searchPanel);
            docListPanel.Controls.Add(patientDataGrid);
            docListPanel.Dock = DockStyle.Bottom;
            docListPanel.Location = new Point(0, 298);
            docListPanel.Name = "docListPanel";
            docListPanel.Size = new Size(1262, 347);
            docListPanel.TabIndex = 4;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.IndianRed;
            searchPanel.Controls.Add(refreshButton);
            searchPanel.Controls.Add(patientSearchBox);
            searchPanel.Controls.Add(searchType);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(0, 0);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1262, 61);
            searchPanel.TabIndex = 0;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(1081, 15);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(83, 27);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // patientSearchBox
            // 
            patientSearchBox.Location = new Point(185, 15);
            patientSearchBox.Name = "patientSearchBox";
            patientSearchBox.Size = new Size(214, 27);
            patientSearchBox.TabIndex = 1;
            patientSearchBox.TextChanged += patientSearchBox_KeyPress;
            // 
            // searchType
            // 
            searchType.DropDownStyle = ComboBoxStyle.DropDownList;
            searchType.FormattingEnabled = true;
            searchType.Items.AddRange(new object[] { "By ID", "By Name" });
            searchType.Location = new Point(59, 14);
            searchType.Name = "searchType";
            searchType.Size = new Size(120, 28);
            searchType.TabIndex = 0;
            // 
            // patientDataGrid
            // 
            patientDataGrid.AllowUserToAddRows = false;
            patientDataGrid.AllowUserToDeleteRows = false;
            patientDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientDataGrid.BackgroundColor = SystemColors.Control;
            patientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientDataGrid.Dock = DockStyle.Bottom;
            patientDataGrid.EnableHeadersVisualStyles = false;
            patientDataGrid.Location = new Point(0, 67);
            patientDataGrid.Name = "patientDataGrid";
            patientDataGrid.ReadOnly = true;
            patientDataGrid.RowHeadersWidth = 51;
            patientDataGrid.ScrollBars = ScrollBars.Vertical;
            patientDataGrid.Size = new Size(1262, 280);
            patientDataGrid.TabIndex = 1;
            patientDataGrid.CellDoubleClick += patientDataGrid_CellDoubleClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.2560654F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.7439346F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel1.Controls.Add(IDLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(patientID, 1, 0);
            tableLayoutPanel1.Controls.Add(onMedicine, 3, 1);
            tableLayoutPanel1.Controls.Add(onMedication, 4, 1);
            tableLayoutPanel1.Controls.Add(patientName, 1, 1);
            tableLayoutPanel1.Controls.Add(phoneLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(patientPhone, 4, 0);
            tableLayoutPanel1.Controls.Add(patientAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(addressLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(genderLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(patientGender, 1, 2);
            tableLayoutPanel1.Controls.Add(bloodTypeLabel, 3, 2);
            tableLayoutPanel1.Controls.Add(bloodTypeCombo, 4, 2);
            tableLayoutPanel1.Location = new Point(12, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(789, 277);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.Left;
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IDLabel.Location = new Point(3, 20);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(33, 28);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nameLabel.Location = new Point(3, 89);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(73, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // patientID
            // 
            patientID.Anchor = AnchorStyles.Left;
            patientID.BorderStyle = BorderStyle.None;
            patientID.ForeColor = SystemColors.InactiveCaptionText;
            patientID.Location = new Point(101, 24);
            patientID.Name = "patientID";
            patientID.ReadOnly = true;
            patientID.Size = new Size(170, 20);
            patientID.TabIndex = 3;
            patientID.Text = "test";
            // 
            // onMedicine
            // 
            onMedicine.Anchor = AnchorStyles.Left;
            onMedicine.AutoSize = true;
            onMedicine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            onMedicine.Location = new Point(367, 89);
            onMedicine.Name = "onMedicine";
            onMedicine.Size = new Size(157, 28);
            onMedicine.TabIndex = 0;
            onMedicine.Text = "On Medication:";
            // 
            // onMedication
            // 
            onMedication.Anchor = AnchorStyles.Left;
            onMedication.BorderStyle = BorderStyle.None;
            onMedication.Location = new Point(582, 93);
            onMedication.Name = "onMedication";
            onMedication.ReadOnly = true;
            onMedication.Size = new Size(170, 20);
            onMedication.TabIndex = 3;
            onMedication.Text = "test";
            // 
            // patientName
            // 
            patientName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            patientName.BorderStyle = BorderStyle.None;
            patientName.Location = new Point(101, 95);
            patientName.Multiline = true;
            patientName.Name = "patientName";
            patientName.ReadOnly = true;
            patientName.Size = new Size(260, 40);
            patientName.TabIndex = 3;
            patientName.Text = "test";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.Left;
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            phoneLabel.Location = new Point(367, 20);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(76, 28);
            phoneLabel.TabIndex = 0;
            phoneLabel.Text = "Phone:";
            // 
            // patientPhone
            // 
            patientPhone.Anchor = AnchorStyles.Left;
            patientPhone.BorderStyle = BorderStyle.None;
            patientPhone.Location = new Point(582, 24);
            patientPhone.Mask = "(999) 000-0000";
            patientPhone.Name = "patientPhone";
            patientPhone.ReadOnly = true;
            patientPhone.Size = new Size(142, 20);
            patientPhone.TabIndex = 2;
            // 
            // patientAddress
            // 
            patientAddress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            patientAddress.BorderStyle = BorderStyle.None;
            patientAddress.ForeColor = SystemColors.InactiveCaptionText;
            patientAddress.Location = new Point(101, 230);
            patientAddress.Multiline = true;
            patientAddress.Name = "patientAddress";
            patientAddress.ReadOnly = true;
            patientAddress.Size = new Size(260, 44);
            patientAddress.TabIndex = 3;
            patientAddress.Text = "test";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Left;
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addressLabel.Location = new Point(3, 228);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(92, 28);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.Left;
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            genderLabel.Location = new Point(3, 158);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(86, 28);
            genderLabel.TabIndex = 0;
            genderLabel.Text = "Gender:";
            // 
            // patientGender
            // 
            patientGender.Anchor = AnchorStyles.Left;
            patientGender.BorderStyle = BorderStyle.None;
            patientGender.ForeColor = SystemColors.InactiveCaptionText;
            patientGender.Location = new Point(101, 162);
            patientGender.Name = "patientGender";
            patientGender.ReadOnly = true;
            patientGender.Size = new Size(170, 20);
            patientGender.TabIndex = 3;
            patientGender.Text = "test";
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.Anchor = AnchorStyles.Left;
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bloodTypeLabel.Location = new Point(367, 158);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(123, 28);
            bloodTypeLabel.TabIndex = 0;
            bloodTypeLabel.Text = "Blood Type:";
            // 
            // bloodTypeCombo
            // 
            bloodTypeCombo.Anchor = AnchorStyles.Left;
            bloodTypeCombo.Enabled = false;
            bloodTypeCombo.FormattingEnabled = true;
            bloodTypeCombo.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-" });
            bloodTypeCombo.Location = new Point(582, 158);
            bloodTypeCombo.Name = "bloodTypeCombo";
            bloodTypeCombo.Size = new Size(81, 28);
            bloodTypeCombo.TabIndex = 4;
            // 
            // appointmentButton
            // 
            appointmentButton.Anchor = AnchorStyles.None;
            appointmentButton.FlatStyle = FlatStyle.System;
            appointmentButton.Location = new Point(871, 114);
            appointmentButton.Name = "appointmentButton";
            appointmentButton.Size = new Size(142, 43);
            appointmentButton.TabIndex = 5;
            appointmentButton.Text = "Appointments";
            appointmentButton.UseVisualStyleBackColor = true;
            appointmentButton.Click += appointmentButton_Click;
            // 
            // prescriptionButton
            // 
            prescriptionButton.Anchor = AnchorStyles.None;
            prescriptionButton.FlatStyle = FlatStyle.System;
            prescriptionButton.Location = new Point(871, 25);
            prescriptionButton.Name = "prescriptionButton";
            prescriptionButton.Size = new Size(142, 43);
            prescriptionButton.TabIndex = 5;
            prescriptionButton.Text = "Prescriptions";
            prescriptionButton.UseVisualStyleBackColor = true;
            prescriptionButton.Click += prescriptionButton_Click;
            // 
            // medicalHistory
            // 
            medicalHistory.Anchor = AnchorStyles.None;
            medicalHistory.FlatStyle = FlatStyle.System;
            medicalHistory.Location = new Point(871, 195);
            medicalHistory.Name = "medicalHistory";
            medicalHistory.Size = new Size(142, 43);
            medicalHistory.TabIndex = 5;
            medicalHistory.Text = "Medical History";
            medicalHistory.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.ForestGreen;
            addButton.Location = new Point(1105, 13);
            addButton.Name = "addButton";
            addButton.Size = new Size(136, 51);
            addButton.TabIndex = 2;
            addButton.Text = "➕ Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            deleteButton.ForeColor = Color.IndianRed;
            deleteButton.Location = new Point(1105, 76);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(136, 51);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "➖ Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.White;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            editButton.ForeColor = SystemColors.Highlight;
            editButton.Location = new Point(1105, 139);
            editButton.Name = "editButton";
            editButton.Size = new Size(136, 51);
            editButton.TabIndex = 3;
            editButton.Text = "🖊️ Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Enabled = false;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            saveButton.ForeColor = Color.Goldenrod;
            saveButton.Location = new Point(1105, 202);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(136, 51);
            saveButton.TabIndex = 3;
            saveButton.Text = "💾 Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // docDetailsPanel
            // 
            docDetailsPanel.BackColor = Color.Transparent;
            docDetailsPanel.Controls.Add(saveButton);
            docDetailsPanel.Controls.Add(editButton);
            docDetailsPanel.Controls.Add(deleteButton);
            docDetailsPanel.Controls.Add(addButton);
            docDetailsPanel.Controls.Add(tableLayoutPanel1);
            docDetailsPanel.Controls.Add(medicalHistory);
            docDetailsPanel.Controls.Add(prescriptionButton);
            docDetailsPanel.Controls.Add(appointmentButton);
            docDetailsPanel.Location = new Point(0, 2);
            docDetailsPanel.Name = "docDetailsPanel";
            docDetailsPanel.Size = new Size(1262, 304);
            docDetailsPanel.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.39056F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6094418F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 645);
            Controls.Add(docListPanel);
            Controls.Add(docDetailsPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1262, 645);
            Name = "Patient";
            Text = "Patient";
            docListPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            docDetailsPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel docListPanel;
        private Panel searchPanel;
        private Button refreshButton;
        private TextBox patientSearchBox;
        private ComboBox searchType;
        private DataGridView patientDataGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private Label IDLabel;
        private Label addressLabel;
        private Label nameLabel;
        private Label phoneLabel;
        private MaskedTextBox patientPhone;
        private TextBox patientID;
        private TextBox patientName;
        private TextBox patientAddress;
        private Button addButton;
        private Button deleteButton;
        private Button editButton;
        private Button saveButton;
        private Panel docDetailsPanel;
        private Label onMedicine;
        private TextBox onMedication;
        private Button appointmentButton;
        private Button prescriptionButton;
        private Label genderLabel;
        private TextBox patientGender;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Button medicalHistory;
        private Label bloodTypeLabel;
        private ComboBox bloodTypeCombo;
    }
}