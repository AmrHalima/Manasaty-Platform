using Manasaty_Platform.UserConroles;
using System;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Manasaty_Platform.Views
{
    public partial class StuHomeForm : Form
    {
        public StuHomeForm()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControle(uc);
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
            UC_Home uc = new UC_Home();
            addUserControle(uc);
        }

        private void myAccountButton_Click(object sender, EventArgs e)
        {
            UC_MyAccount uc = new UC_MyAccount();
            addUserControle(uc);
        }

        private void myCoursesButton_Click(object sender, EventArgs e)
        {
            UC_MyCourses uc = new UC_MyCourses();
            addUserControle(uc);

        }

        private void detailsOfMyDaysButton_Click_1(object sender, EventArgs e)
        {
            UC_DetailsOfMyDays uc = new UC_DetailsOfMyDays();
            addUserControle(uc);
        }
        

        private void SubscriptionsButton_Click(object sender, EventArgs e)
        {
            UC_Subscriptions uc = new UC_Subscriptions();
            addUserControle(uc);
        }

        private void examesResultButton_Click(object sender, EventArgs e)
        {
            UC_ExamsResult uc = new UC_ExamsResult();
            addUserControle(uc);
        }

        private void homeworkResultButton_Click(object sender, EventArgs e)
        {
            UC_HomeworkResult uc = new UC_HomeworkResult();
            addUserControle(uc);
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            UC_Store uc = new UC_Store();
            addUserControle(uc);
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
