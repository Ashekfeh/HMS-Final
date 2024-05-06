namespace HMS_Final
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            LoginButton = new Button();
            revealPassword = new CheckBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(revealPassword);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(usernameBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 450);
            panel1.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.Location = new Point(121, 370);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(108, 41);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // revealPassword
            // 
            revealPassword.AutoSize = true;
            revealPassword.Location = new Point(96, 236);
            revealPassword.Name = "revealPassword";
            revealPassword.Size = new Size(138, 24);
            revealPassword.TabIndex = 4;
            revealPassword.Text = "reveal password";
            revealPassword.UseVisualStyleBackColor = true;
            revealPassword.CheckedChanged += revealPassword_CheckedChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 206);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(72, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 141);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "username";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(96, 203);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(216, 27);
            passwordBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(96, 138);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(216, 27);
            usernameBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "HMS - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button LoginButton;
        private CheckBox revealPassword;
        private PictureBox pictureBox1;
    }
}
