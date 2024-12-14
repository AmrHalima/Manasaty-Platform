using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Manasaty_Platform.Controllers;
using Manasaty_Platform.Models;


namespace Manasaty_Platform.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            string Fname = firstname_TextBox.Text.Trim().ToLower();
            string Sname = secondname_textbox.Text.Trim().ToLower();
            string email = email_TextBox.Text.Trim().ToLower();
            string password = password_TextBox.Text.Trim();
            string gender = gender_ComboBox.SelectedItem?.ToString();
            string phone = phone_TextBox.Text.Trim();
            string parent_phone = Parentphone_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(Fname))
            {
                MessageBox.Show("Please enter Your first name.", "Invalid first name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstname_TextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Sname))
            {
                MessageBox.Show("Please enter Your second name.", "Invalid second name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                secondname_textbox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(email) || !User.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email_TextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_TextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Enter all valid data", "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gender_ComboBox.Focus();
                return;

            }
            if (string.IsNullOrEmpty(phone) || phone.Length < 11 || !User.IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a phone number", "Invalid phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone_TextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(parent_phone) || parent_phone.Length < 11 || !User.IsValidPhoneNumber(parent_phone))
            {
                MessageBox.Show("Please enter a parent phone number", "Invalid parent phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Parentphone_TextBox.Focus();
                return;
            }
            Student student = new Student(Fname, Sname, email, password, gender, phone, parent_phone);
            StudentController sc = new StudentController();
            student.Password = sc.HashPassword(student.Password);
            sc.AddStudent(student);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void firstname_TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_TextBox.Text))
            {
                firstname_TextBox.PlaceholderText = "First name *";
                firstname_TextBox.PlaceholderForeColor = Color.Red;                
            }
        }

        private void secondname_textbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(secondname_textbox.Text))
            {
                firstname_TextBox.PlaceholderText = "Second name *";
                firstname_TextBox.PlaceholderForeColor = Color.Red;
            }
        }

        
    }
}
