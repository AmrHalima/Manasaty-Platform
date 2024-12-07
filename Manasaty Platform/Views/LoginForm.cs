using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Manasaty_Platform.Models;

namespace Manasaty_Platform.Views
{
    public partial class LoginForm : Form
    {
        Student student = new Student();
        Teacher teacher = new Teacher();
        Assistant assistant = new Assistant();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string email=emailTextbox.Text.Trim();
            string password=passwordTextbox.Text.Trim();
            
            if(string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextbox.Focus();
                return;
            }
            if(string.IsNullOrEmpty(password) || password.Length<8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextbox.Focus();
                return;
            }

            string hashedPassword = HashPassword(password);
            StuHomeForm studentHomeForm = new StuHomeForm();
            studentHomeForm.Show();
            this.Hide();
           // MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //function to check isvalidemail
        private bool IsValidEmail(string email)
        {
            // Regular expression for validating email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        //function to hash the password befor implement it in database
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void Exist_ControlBox_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //function to check valid data in databse
        //private bool isfound_database()
    }
    
}

