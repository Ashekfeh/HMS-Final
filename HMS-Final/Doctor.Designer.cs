namespace HMS_Final
{
    partial class Doctor
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
            label1 = new Label();
            refreshButton = new Button();
            isActiveCheckBox = new CheckBox();
            departmentComboBox = new ComboBox();
            searchBox = new TextBox();
            searchType = new ComboBox();
            docDataGrid = new DataGridView();
            docDetailsPanel = new Panel();
            button1 = new Button();
            saveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            docPicture = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            IDLabel = new Label();
            addressLabel = new Label();
            nameLabel = new Label();
            docDepartment = new ComboBox();
            depLabel = new Label();
            phoneLabel = new Label();
            hireDateLabel = new Label();
            fireDateLabel = new Label();
            qualButton = new Button();
            qualLable = new Label();
            docHireDate = new MaskedTextBox();
            docFireDate = new MaskedTextBox();
            docPhone = new MaskedTextBox();
            docID = new TextBox();
            docName = new TextBox();
            docAddress = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            docListPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docDataGrid).BeginInit();
            docDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docPicture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // docListPanel
            // 
            docListPanel.BackColor = Color.Transparent;
            docListPanel.Controls.Add(searchPanel);
            docListPanel.Controls.Add(docDataGrid);
            docListPanel.Dock = DockStyle.Bottom;
            docListPanel.Location = new Point(0, 288);
            docListPanel.Name = "docListPanel";
            docListPanel.Size = new Size(1262, 357);
            docListPanel.TabIndex = 1;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.IndianRed;
            searchPanel.Controls.Add(label1);
            searchPanel.Controls.Add(refreshButton);
            searchPanel.Controls.Add(isActiveCheckBox);
            searchPanel.Controls.Add(departmentComboBox);
            searchPanel.Controls.Add(searchBox);
            searchPanel.Controls.Add(searchType);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(0, 0);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1262, 61);
            searchPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 18);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 5;
            label1.Text = "Filter By Department";
            // 
            // refreshButton
            // 
            refreshButton.Enabled = false;
            refreshButton.Location = new Point(405, 15);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(83, 27);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += searchButton_Click;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Location = new Point(978, 16);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(72, 24);
            isActiveCheckBox.TabIndex = 3;
            isActiveCheckBox.Text = "Active";
            isActiveCheckBox.UseVisualStyleBackColor = true;
            isActiveCheckBox.CheckedChanged += isActiveCheckBox_CheckedChanged;
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(733, 14);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(139, 28);
            departmentComboBox.TabIndex = 2;
            departmentComboBox.SelectedIndexChanged += departmentComboBox_SelectedIndexChanged;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(185, 15);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(214, 27);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += SearchBox_KeyPress;
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
            searchType.SelectedIndexChanged += searchType_SelectedIndexChanged;
            // 
            // docDataGrid
            // 
            docDataGrid.AllowUserToAddRows = false;
            docDataGrid.AllowUserToDeleteRows = false;
            docDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            docDataGrid.BackgroundColor = SystemColors.Control;
            docDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            docDataGrid.Dock = DockStyle.Bottom;
            docDataGrid.EnableHeadersVisualStyles = false;
            docDataGrid.Location = new Point(0, 67);
            docDataGrid.Name = "docDataGrid";
            docDataGrid.ReadOnly = true;
            docDataGrid.RowHeadersWidth = 51;
            docDataGrid.ScrollBars = ScrollBars.Vertical;
            docDataGrid.Size = new Size(1262, 290);
            docDataGrid.TabIndex = 1;
            docDataGrid.CellDoubleClick += docDataGrid_CellDoubleClick;
            // 
            // docDetailsPanel
            // 
            docDetailsPanel.BackColor = Color.Transparent;
            docDetailsPanel.Controls.Add(button1);
            docDetailsPanel.Controls.Add(saveButton);
            docDetailsPanel.Controls.Add(editButton);
            docDetailsPanel.Controls.Add(deleteButton);
            docDetailsPanel.Controls.Add(addButton);
            docDetailsPanel.Controls.Add(docPicture);
            docDetailsPanel.Controls.Add(tableLayoutPanel1);
            docDetailsPanel.Dock = DockStyle.Top;
            docDetailsPanel.Location = new Point(0, 0);
            docDetailsPanel.Name = "docDetailsPanel";
            docDetailsPanel.Size = new Size(1262, 282);
            docDetailsPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(14, 220);
            button1.Name = "button1";
            button1.Size = new Size(180, 57);
            button1.TabIndex = 4;
            button1.Text = "Add Image";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
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
            editButton.Click += editButton_Click;
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
            // docPicture
            // 
            docPicture.Image = Properties.Resources.doctor_2875035;
            docPicture.Location = new Point(14, 13);
            docPicture.Name = "docPicture";
            docPicture.Size = new Size(180, 201);
            docPicture.SizeMode = PictureBoxSizeMode.Zoom;
            docPicture.TabIndex = 1;
            docPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.Controls.Add(IDLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(addressLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(docDepartment, 1, 2);
            tableLayoutPanel1.Controls.Add(depLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(phoneLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(hireDateLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(fireDateLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(qualButton, 3, 3);
            tableLayoutPanel1.Controls.Add(qualLable, 2, 3);
            tableLayoutPanel1.Controls.Add(docHireDate, 3, 1);
            tableLayoutPanel1.Controls.Add(docFireDate, 3, 2);
            tableLayoutPanel1.Controls.Add(docPhone, 1, 3);
            tableLayoutPanel1.Controls.Add(docID, 1, 0);
            tableLayoutPanel1.Controls.Add(docName, 1, 1);
            tableLayoutPanel1.Controls.Add(docAddress, 3, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 4, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 4, 1);
            tableLayoutPanel1.Location = new Point(205, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(894, 264);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.Left;
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IDLabel.Location = new Point(3, 19);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(33, 28);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Left;
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addressLabel.Location = new Point(374, 19);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(92, 28);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nameLabel.Location = new Point(3, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(73, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // docDepartment
            // 
            docDepartment.Anchor = AnchorStyles.Left;
            docDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            docDepartment.Enabled = false;
            docDepartment.FormattingEnabled = true;
            docDepartment.Location = new Point(141, 151);
            docDepartment.Name = "docDepartment";
            docDepartment.Size = new Size(139, 28);
            docDepartment.TabIndex = 2;
            docDepartment.SelectedIndexChanged += departmentComboBox_SelectedIndexChanged;
            // 
            // depLabel
            // 
            depLabel.Anchor = AnchorStyles.Left;
            depLabel.AutoSize = true;
            depLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            depLabel.Location = new Point(3, 151);
            depLabel.Name = "depLabel";
            depLabel.Size = new Size(132, 28);
            depLabel.TabIndex = 0;
            depLabel.Text = "Department:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.Left;
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            phoneLabel.Location = new Point(3, 217);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(76, 28);
            phoneLabel.TabIndex = 0;
            phoneLabel.Text = "Phone:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.Anchor = AnchorStyles.Left;
            hireDateLabel.AutoSize = true;
            hireDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hireDateLabel.Location = new Point(374, 85);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new Size(127, 28);
            hireDateLabel.TabIndex = 0;
            hireDateLabel.Text = "Hiring Date:";
            // 
            // fireDateLabel
            // 
            fireDateLabel.Anchor = AnchorStyles.Left;
            fireDateLabel.AutoSize = true;
            fireDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fireDateLabel.Location = new Point(374, 151);
            fireDateLabel.Name = "fireDateLabel";
            fireDateLabel.Size = new Size(122, 28);
            fireDateLabel.TabIndex = 0;
            fireDateLabel.Text = "Firing Date:";
            // 
            // qualButton
            // 
            qualButton.Anchor = AnchorStyles.Left;
            qualButton.Location = new Point(529, 216);
            qualButton.Name = "qualButton";
            qualButton.Size = new Size(152, 30);
            qualButton.TabIndex = 1;
            qualButton.Text = "Qualifications";
            qualButton.UseVisualStyleBackColor = true;
            qualButton.Click += qualButton_Click;
            // 
            // qualLable
            // 
            qualLable.Anchor = AnchorStyles.Left;
            qualLable.AutoSize = true;
            qualLable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            qualLable.Location = new Point(374, 217);
            qualLable.Name = "qualLable";
            qualLable.Size = new Size(149, 28);
            qualLable.TabIndex = 0;
            qualLable.Text = "Qualifications:";
            // 
            // docHireDate
            // 
            docHireDate.Anchor = AnchorStyles.Left;
            docHireDate.BorderStyle = BorderStyle.None;
            docHireDate.Location = new Point(529, 89);
            docHireDate.Mask = "00/00/0000";
            docHireDate.Name = "docHireDate";
            docHireDate.ReadOnly = true;
            docHireDate.Size = new Size(142, 20);
            docHireDate.TabIndex = 2;
            docHireDate.ValidatingType = typeof(DateTime);
            // 
            // docFireDate
            // 
            docFireDate.Anchor = AnchorStyles.Left;
            docFireDate.BorderStyle = BorderStyle.None;
            docFireDate.Location = new Point(529, 155);
            docFireDate.Mask = "00/00/0000";
            docFireDate.Name = "docFireDate";
            docFireDate.ReadOnly = true;
            docFireDate.Size = new Size(142, 20);
            docFireDate.TabIndex = 2;
            docFireDate.ValidatingType = typeof(DateTime);
            // 
            // docPhone
            // 
            docPhone.Anchor = AnchorStyles.Left;
            docPhone.BorderStyle = BorderStyle.None;
            docPhone.Location = new Point(141, 221);
            docPhone.Mask = "(999) 000-0000";
            docPhone.Name = "docPhone";
            docPhone.ReadOnly = true;
            docPhone.Size = new Size(142, 20);
            docPhone.TabIndex = 2;
            // 
            // docID
            // 
            docID.Anchor = AnchorStyles.Left;
            docID.BorderStyle = BorderStyle.None;
            docID.ForeColor = SystemColors.InactiveCaptionText;
            docID.Location = new Point(141, 23);
            docID.Name = "docID";
            docID.ReadOnly = true;
            docID.Size = new Size(170, 20);
            docID.TabIndex = 3;
            docID.Text = "test";
            // 
            // docName
            // 
            docName.Anchor = AnchorStyles.Left;
            docName.BorderStyle = BorderStyle.None;
            docName.Location = new Point(141, 89);
            docName.Name = "docName";
            docName.ReadOnly = true;
            docName.Size = new Size(170, 20);
            docName.TabIndex = 3;
            docName.Text = "test";
            // 
            // docAddress
            // 
            docAddress.Anchor = AnchorStyles.Left;
            docAddress.BorderStyle = BorderStyle.None;
            docAddress.ForeColor = SystemColors.InactiveCaptionText;
            docAddress.Location = new Point(529, 23);
            docAddress.Name = "docAddress";
            docAddress.ReadOnly = true;
            docAddress.Size = new Size(170, 20);
            docAddress.TabIndex = 3;
            docAddress.Text = "test";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Left;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Location = new Point(762, 151);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(123, 27);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(762, 85);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 645);
            Controls.Add(docDetailsPanel);
            Controls.Add(docListPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1262, 645);
            Name = "Doctor";
            Text = "Doctor";
            Load += Doctor_Load;
            docListPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)docDataGrid).EndInit();
            docDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)docPicture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel docListPanel;
        private Panel docDetailsPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox docPicture;
        private Label IDLabel;
        private Label addressLabel;
        private Label nameLabel;
        private Label depLabel;
        private Label phoneLabel;
        private Label hireDateLabel;
        private Label fireDateLabel;
        private Button qualButton;
        private Panel searchPanel;
        private ComboBox searchType;
        private TextBox searchBox;
        private DataGridView docDataGrid;
        private CheckBox isActiveCheckBox;
        private ComboBox departmentComboBox;
        private Button refreshButton;
        private Label label1;
        private Button editButton;
        private Button deleteButton;
        private Button addButton;
        private Label qualLable;
        private MaskedTextBox docHireDate;
        private MaskedTextBox docFireDate;
        private MaskedTextBox docPhone;
        private Button button1;
        private Button saveButton;
        private TextBox docID;
        private TextBox docName;
        private TextBox docAddress;
        private ComboBox docDepartment;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}