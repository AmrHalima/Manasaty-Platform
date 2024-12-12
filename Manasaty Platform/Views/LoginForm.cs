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
using System.Windows.Forms;
using System.Data.SqlClient;
using Manasaty_Platform.Controllers;
using Manasaty_Platform.Models;

namespace Manasaty_Platform.Views
{
    public partial class LoginForm : Form
    {
        UserController userController = new UserController();
        StudentController studentController = new StudentController();
        internal static Student student = new Student();
        internal static User user = new User();
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string email=emailTextbox.Text.Trim().ToLower();
            string password=passwordTextbox.Text.Trim();
            //later we will display a label instead of messagebox
            if(string.IsNullOrEmpty(email) || !User.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextbox.Focus();
                return;
            }
            if(string.IsNullOrEmpty(password) || password.Length<8)//can be optimized with validating event
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextbox.Focus();
                return;
            }

            user = userController.UserFound(email, password);
            if (!(user==null))
            {
                if (user.Id==020001)
                {
                    TrHomeForm trHomeForm = new TrHomeForm();
                    trHomeForm.Show();
                    this.Hide();
                    return;
                }
                AssisHomeForm assisHomeForm = new AssisHomeForm();
                assisHomeForm.Show();
                this.Hide();
            }
            student = studentController.StudentFound(email, password);
            if (!(student == null))
            {
                StuHomeForm studentHomeForm = new StuHomeForm();
                studentHomeForm.Show();
                this.Hide();
            }
            // MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
    }

}

