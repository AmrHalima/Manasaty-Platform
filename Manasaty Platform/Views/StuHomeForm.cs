﻿using System;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Manasaty_Platform.Models;

namespace Manasaty_Platform.Views
{
    public partial class StuHomeForm : Form
    {
        Student student = new Student();
        public StuHomeForm()
        {
            InitializeComponent();
           
            student = LoginForm.student;


        }

    

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addUserControle(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControlePanel.Controls.Clear();
            userControlePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void myAccountButton_Click(object sender, EventArgs e)
        {
           
        }

        private void myCoursesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void detailsOfMyDaysButton_Click_1(object sender, EventArgs e)
        {
           
        }
        

        private void SubscriptionsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void examesResultButton_Click(object sender, EventArgs e)
        {
           
        }

        private void homeworkResultButton_Click(object sender, EventArgs e)
        {
           
        }

        private void storeButton_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StuHomeForm_Load(object sender, EventArgs e)
        {
            greating.Text = greating.Text+student.FirstName+student.LastName;
        }
    }
}
