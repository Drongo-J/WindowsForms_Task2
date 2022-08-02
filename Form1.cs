using Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms_Task2
{
    public partial class Form1 : Form
    {
        CustomComboBox cb = new CustomComboBox();

        bool validName = true;
        bool validMail = true;
        bool validPassword = true;
        bool validRepassword = true;
        bool validGender = true;
        bool validAge = true;

        public Form1()
        {
            InitializeComponent();

            // Warning Label
            warningLabel.ForeColor = Color.Red;
            warningLabel.BackColor = Color.Transparent;
            warningLabel.Font = new Font("Palatino Linotype", 10.50f);
            warningLabel.Text = String.Empty;

            // Headline
            signUpLbl.BackColor = Color.Transparent;
            joinUsLabel.BackColor = Color.Transparent;

            // Name
            NameTextBox.BackColor = Color.FromArgb(14, 122, 250);
            NameTextBox.ForeColor = Color.White;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Palatino Linotype", 11.50f);
            NameTextBox.Text = " Your Name";
            NameTextBox.Height = 30;
            NameTextBox.AutoSize = false;

            // Gender (Custom Combo Box)
            cb.Items.Add(" Male");
            cb.Items.Add(" Female");
            cb.Items.Add(" I prefer not to say");
            cb.BackColor = Color.FromArgb(14, 122, 250);
            cb.ForeColor = Color.White;
            cb.Location = new Point(260, 247);
            cb.Font = new Font("Palatino Linotype", 11.50f);
            cb.Width += 36;
            cb.Text = " Gender";
            cb.DropDownStyle = ComboBoxStyle.DropDown;
            cb.MouseEnter += Cb_MouseEnter; ;
            Controls.Add(cb);

            // Mail
            MailTextBox.Location = new Point(MailTextBox.Location.X + 10, MailTextBox.Location.Y);
            MailTextBox.Width += 4;
            MailTextBox.BackColor = Color.FromArgb(14, 122, 250);
            MailTextBox.ForeColor = Color.White;
            MailTextBox.BorderStyle = BorderStyle.FixedSingle;
            MailTextBox.Font = new Font("Palatino Linotype", 11.50f);
            MailTextBox.Text = " Your Email";
            MailTextBox.Height = 27;
            MailTextBox.AutoSize = false;

            // Password
            PasswordTextBox.BackColor = Color.FromArgb(14, 122, 250);
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Palatino Linotype", 11.50f);
            PasswordTextBox.Text = " Password";
            PasswordTextBox.Height = 27;
            PasswordTextBox.AutoSize = false;

            // Re Enter Password
            PasswordReEnterTextBox.Width = MailTextBox.Width;
            PasswordReEnterTextBox.Location = new Point(PasswordReEnterTextBox.Location.X + 10, PasswordReEnterTextBox.Location.Y);
            PasswordReEnterTextBox.BackColor = Color.FromArgb(14, 122, 250);
            PasswordReEnterTextBox.ForeColor = Color.White;
            PasswordReEnterTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordReEnterTextBox.Font = new Font("Palatino Linotype", 11.50f);
            PasswordReEnterTextBox.Text = " Re Enter Password";
            PasswordReEnterTextBox.Height = 27;
            PasswordReEnterTextBox.AutoSize = false;

            // Sign Up Button
            SignUpButton.BackColor = Color.FromArgb(3, 59, 118);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Font = new Font("Palatino Linotype", 11.50f);
            SignUpButton.Text = " Sign Up";
            SignUpButton.Height = 30;
            SignUpButton.AutoSize = false;

            // Age
            ageMaskedTextBox.BackColor = Color.FromArgb(14, 122, 250);
            ageMaskedTextBox.ForeColor = Color.White;
            ageMaskedTextBox.Font = new Font("Palatino Linotype", 11.50f);
            ageMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;

            ageLbl.Text = "(Age)";
            ageLbl.ForeColor = Color.FromArgb(3, 59, 118);
            ageLbl.Font = new Font("Palatino Linotype", 11.50f, FontStyle.Bold);

            // Bith Date
            dateOfBirthlbl.Text = "(Date Of Birth)";
            dateOfBirthlbl.ForeColor = Color.FromArgb(3, 59, 118);
            dateOfBirthlbl.Font = new Font("Palatino Linotype", 11.50f, FontStyle.Bold);
        }


        // Gender Combo Box - Enter 
        private void Cb_MouseEnter(object sender, EventArgs e)
        {
            cb.ForeColor = Color.White;
        }


        // Name Text Box - Enter, Leave, Click
        private void NameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (validName)
            {
                NameTextBox.ForeColor = Color.White;
            }
            else
            {
                NameTextBox.ForeColor = Color.Red;
            }

            if (NameTextBox.Text.Trim() == "Your Name")
            {
                NameTextBox.Text = String.Empty;
                NameTextBox.Text += "  ";
            }
        }

        private void NameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim() == String.Empty)
            {
                NameTextBox.Text = " Your Name";
            }
        }
        private void NameTextBox_Click(object sender, EventArgs e)
        {
            NameTextBox.ForeColor = Color.White;
        }

        // Mail Text Box - Enter, Leave, Click
        private void MailTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (validMail)
            {
                MailTextBox.ForeColor = Color.White;
            }
            else
            {
                MailTextBox.ForeColor = Color.Red;
            }

            if (MailTextBox.Text.Trim() == "Your Email")
            {
                MailTextBox.Text = String.Empty;
                MailTextBox.Text += "  ";
            }
        }

        private void MailTextBox_MouseLeave_1(object sender, EventArgs e)
        {
            if (MailTextBox.Text.Trim() == String.Empty)
            {
                MailTextBox.Text = " Your Email";
            }
        }

        private void MailTextBox_Click(object sender, EventArgs e)
        {
            MailTextBox.ForeColor = Color.White;
        }

        // Password Text Box - Enter, Leave, Click
        private void PasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (validPassword)
            {
                PasswordTextBox.ForeColor = Color.White;
            }
            else
            {
                PasswordTextBox.ForeColor = Color.Red;
            }

            if (PasswordTextBox.Text.Trim() == "Password")
            {
                PasswordTextBox.Text = String.Empty;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void PasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.PasswordChar = '\0';
            }
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.ForeColor = Color.White;
        }


        // Re Enter Password Text Box - Enter, Leave, Click
        private void PasswordReEnterTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (validRepassword)
            {
                PasswordReEnterTextBox.ForeColor = Color.White;
            }
            else
            {
                PasswordReEnterTextBox.ForeColor = Color.Red;
            }


            if (PasswordReEnterTextBox.Text.Trim() == "Re Enter Password")
            {
                PasswordReEnterTextBox.Text = String.Empty;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void PasswordReEnterTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (PasswordReEnterTextBox.Text.Trim() == string.Empty)
            {
                PasswordReEnterTextBox.Text = " Re Enter Password";
                PasswordReEnterTextBox.PasswordChar = '\0';
            }
        }

        private void PasswordReEnterTextBox_Click(object sender, EventArgs e)
        {
            PasswordReEnterTextBox.PasswordChar = '*';
            PasswordReEnterTextBox.ForeColor = Color.White;
        }

        // Age Masked Text Box - Enter, Click
        private void ageMaskedTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (validAge)
            {
                ageLbl.ForeColor = Color.FromArgb(3, 59, 118);
            }
            else
            {
                ageLbl.ForeColor = Color.Red;
            }
        }

        private void ageMaskedTextBox_Click(object sender, EventArgs e)
        {
            ageMaskedTextBox.ForeColor = Color.White;
        }

        // Sign Up Button - Click
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string email = MailTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string repassword = PasswordReEnterTextBox.Text.Trim();
            string age = ageMaskedTextBox.Text.ToString().Trim();
            string dateOfBirth = dateOfBirthPicker.Text.Trim();
            string gender = String.Empty;

            // Gender Validation
            if (cb.SelectedIndex != -1)
            {
                gender = cb.SelectedItem.ToString().Trim();
                validGender = true;
            }
            else
            {
                cb.ForeColor = Color.Red;
                validGender = false;
            }

            // Name Validation
            if (name == "Your Name")
            {
                validName = false;
                NameTextBox.ForeColor = Color.Red;
            }
            else
            {
                validName = true;
            }

            // Mail Validation
            if (email == "Your Email")
            {
                validMail = false;
                MailTextBox.ForeColor = Color.Red;
            }
            else
            {
                validMail = true;
            }

            // Password Validation
            if (password == "Password")
            {
                validPassword = false;
                PasswordTextBox.ForeColor = Color.Red;
            }
            else
            {
                validPassword = true;
            }

            // Repassword Validation
            if (repassword == "Re Enter Password")
            {
                validRepassword = false;
                PasswordReEnterTextBox.ForeColor = Color.Red;
            }
            else
            {
                validRepassword = true;
            }

            // Age Validation
            if (ageMaskedTextBox.Text.Trim().Length == 0)
            {
                validAge = false;
                ageLbl.ForeColor = Color.Red;
            }
            else
            {
                ageLbl.ForeColor = Color.FromArgb(3, 59, 118);
                validAge = true;
            }

            // Password and Repassors Check
            if (password != repassword)
            {
                warningLabel.Text = "Passwords does not match!";
            }
            else
            {
                if (validName && validMail && validGender && validPassword && validRepassword && validAge)
                {
                    User user = new User(name, email, password, age, dateOfBirth, gender);
                    JsonSerialization.SerializeUser(user);
                    this.Close();
                }
            }
        }
    }
}
