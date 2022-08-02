namespace WindowsForms_Task2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signUpLbl = new System.Windows.Forms.Label();
            this.joinUsLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordReEnterTextBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.ageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ageLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateOfBirthPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateOfBirthlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpLbl
            // 
            this.signUpLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.Location = new System.Drawing.Point(371, 139);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(100, 32);
            this.signUpLbl.TabIndex = 1;
            this.signUpLbl.Text = "Sign Up";
            // 
            // joinUsLabel
            // 
            this.joinUsLabel.AutoSize = true;
            this.joinUsLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinUsLabel.Location = new System.Drawing.Point(377, 167);
            this.joinUsLabel.Name = "joinUsLabel";
            this.joinUsLabel.Size = new System.Drawing.Size(72, 17);
            this.joinUsLabel.TabIndex = 2;
            this.joinUsLabel.Text = "Join with us";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(260, 210);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(329, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            this.NameTextBox.MouseEnter += new System.EventHandler(this.NameTextBox_MouseEnter);
            this.NameTextBox.MouseLeave += new System.EventHandler(this.NameTextBox_MouseLeave);
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(418, 247);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(157, 20);
            this.MailTextBox.TabIndex = 6;
            this.MailTextBox.Click += new System.EventHandler(this.MailTextBox_Click);
            this.MailTextBox.MouseEnter += new System.EventHandler(this.MailTextBox_MouseEnter);
            this.MailTextBox.MouseLeave += new System.EventHandler(this.MailTextBox_MouseLeave_1);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(260, 282);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.MouseEnter += new System.EventHandler(this.PasswordTextBox_MouseEnter);
            this.PasswordTextBox.MouseLeave += new System.EventHandler(this.PasswordTextBox_MouseLeave);
            // 
            // PasswordReEnterTextBox
            // 
            this.PasswordReEnterTextBox.Location = new System.Drawing.Point(418, 282);
            this.PasswordReEnterTextBox.Name = "PasswordReEnterTextBox";
            this.PasswordReEnterTextBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordReEnterTextBox.TabIndex = 8;
            this.PasswordReEnterTextBox.Click += new System.EventHandler(this.PasswordReEnterTextBox_Click);
            this.PasswordReEnterTextBox.MouseEnter += new System.EventHandler(this.PasswordReEnterTextBox_MouseEnter);
            this.PasswordReEnterTextBox.MouseLeave += new System.EventHandler(this.PasswordReEnterTextBox_MouseLeave);
            // 
            // SignUpButton
            // 
            this.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(59)))), ((int)(((byte)(118)))));
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(260, 404);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(329, 20);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(-15, -15);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 10;
            // 
            // ageMaskedTextBox
            // 
            this.ageMaskedTextBox.Location = new System.Drawing.Point(260, 316);
            this.ageMaskedTextBox.Mask = " 000";
            this.ageMaskedTextBox.Name = "ageMaskedTextBox";
            this.ageMaskedTextBox.Size = new System.Drawing.Size(157, 20);
            this.ageMaskedTextBox.TabIndex = 11;
            this.ageMaskedTextBox.ValidatingType = typeof(int);
            this.ageMaskedTextBox.Click += new System.EventHandler(this.ageMaskedTextBox_Click);
            this.ageMaskedTextBox.MouseEnter += new System.EventHandler(this.ageMaskedTextBox_MouseEnter);
            // 
            // ageLbl
            // 
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ageLbl.Location = new System.Drawing.Point(427, 317);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(86, 15);
            this.ageLbl.TabIndex = 12;
            this.ageLbl.Text = "guna2HtmlLabel1";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Checked = true;
            this.dateOfBirthPicker.CustomizableEdges.TopLeft = false;
            this.dateOfBirthPicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateOfBirthPicker.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(260, 352);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(157, 28);
            this.dateOfBirthPicker.TabIndex = 13;
            this.dateOfBirthPicker.Value = new System.DateTime(2022, 7, 31, 13, 20, 36, 996);
            // 
            // dateOfBirthlbl
            // 
            this.dateOfBirthlbl.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthlbl.Location = new System.Drawing.Point(426, 354);
            this.dateOfBirthlbl.Name = "dateOfBirthlbl";
            this.dateOfBirthlbl.Size = new System.Drawing.Size(86, 15);
            this.dateOfBirthlbl.TabIndex = 14;
            this.dateOfBirthlbl.Text = "guna2HtmlLabel1";
            // 
            // warningLabel
            // 
            this.warningLabel.Location = new System.Drawing.Point(257, 382);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(329, 19);
            this.warningLabel.TabIndex = 15;
            this.warningLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 529);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.dateOfBirthlbl);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.ageMaskedTextBox);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PasswordReEnterTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.joinUsLabel);
            this.Controls.Add(this.signUpLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Label joinUsLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PasswordReEnterTextBox;
        private Guna.UI2.WinForms.Guna2Button SignUpButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox ageMaskedTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ageLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel dateOfBirthlbl;
        public Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label warningLabel;
    }
}

