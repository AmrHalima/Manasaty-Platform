using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Manasaty_Platform.Controllers;
using Manasaty_Platform.Models;
using Manasaty_Platform.Models.concrete_classes;

namespace Manasaty_Platform.Views
{
    public partial class StuHomeForm : Form
    {
        StudentController studentController = new StudentController();
        Student student = new Student();
        List<Chapter> chapters = new List<Chapter>();
        Chapter currentChapter = new Chapter();

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


        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            base.Close();
        }

        private void userControlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StuHomeForm_Load(object sender, EventArgs e)
        {

            chapters = studentController.EnrolledIn(student);
            chaptersComboBox.Items.AddRange(chapters.Select(chapter => chapter.Title).ToArray());
            nameLabel.Text =  student.FirstName + " " + student.LastName;


        }
        //last edited
        private void ChaptersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void chaptersComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedName = chaptersComboBox.SelectedItem?.ToString();

            if (selectedName != null)
            {

                for (int i = 0; i < chapters.Count; i++)
                {
                    if (chapters[i]?.Title == selectedName)
                    {

                        currentChapter = chapters[i];


                    }
                }
            }
            descriptionLabel.Text = currentChapter.Description;
            durationLabel.Text = currentChapter.Duration.ToString();
            videoPlaybackPanel.Visible = true;
            titleLabel.Text = currentChapter.Title;
            webViewer.Source = new Uri(currentChapter.Link);//note: link should be youtube embed link not just regular youtube link 

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
