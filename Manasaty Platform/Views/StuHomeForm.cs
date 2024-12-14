using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Manasaty_Platform.Controllers;
using Manasaty_Platform.Models;
using Manasaty_Platform.Models.concrete_classes;
using static System.Net.WebRequestMethods;

namespace Manasaty_Platform.Views
{
    public partial class StuHomeForm : Form
    {
        StudentController studentController = new StudentController();
        Student student = new Student();
        List <Chapter> chapters = new List<Chapter>();
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
        }

        private void userControlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StuHomeForm_Load(object sender, EventArgs e)
        {
            chapters = studentController.EnrolledIn(student);
            chaptersComboBox.Items.AddRange(chapters.Select(chapter => chapter.Title).ToArray());
            greating.Text = greating.Text+student.FirstName+" "+student.LastName;


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
            titleLabel.Text = currentChapter.Title;
             string urlString = currentChapter.Link;
            string html = "<html>";
            html += "<head>";
            html += "<meta http-equiv='X-UA-Compatible' content='IE=edge' />";
            html += "</head>";
            html += "<body>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='702' height='384' frameborder='0' allowfullscreen></iframe>";
            html += "</body>";
            html += "</html>";

            this.webBrowser1.DocumentText = string.Format(html, urlString.Split('=')[1]);

            if (Uri.TryCreate(urlString, UriKind.Absolute, out Uri uriResult) 
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
        {
            // Load the URL into the WebBrowser control
            webBrowser1.Navigate(uriResult);
        }
        else
        {
            MessageBox.Show("Invalid URL format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
    }
}
