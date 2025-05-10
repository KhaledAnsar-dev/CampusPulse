using DeskEtu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskEtu
{
    public partial class ListScreen : Form
    {
        public ListScreen()
        {
            InitializeComponent();

            NavigationManager QA_Menu = new NavigationManager();

            btnQA_Enrollment.Click += QA_Menu.GoToEnrollments_Click;
            btnQA_Teaching.Click += QA_Menu.GoToTeachings_Click;
            btnQA_Employees.Click += QA_Menu.GoToEmployees_Click;
            btnQA_Structure.Click += QA_Menu.GoToGroups_Click;
        }

        private void FullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        
        // Quick Access

        // Handle Style
        protected void DeactivateQuickAccessBar()
        {
            btnQA_Enrollment.Enabled = false;
            btnQA_Teaching.Enabled = false;
            btnQA_Employees.Enabled = false;
            btnQA_Structure.Enabled = false;

            btnQA_Enrollment.BackgroundImage = Resources.QA_Enrollments_3;
            btnQA_Teaching.BackgroundImage = Resources.QA_Teaching_3;
            btnQA_Employees.BackgroundImage = Resources.QA_Employees_3;
            btnQA_Structure.BackgroundImage = Resources.QA_Structre_3;
        }
        private void ListScreen_Load(object sender, EventArgs e)
        {
            FullScreen();
        }
        private void QA_Enrollments_Enter(object sender, EventArgs e)
        {
            ImageActivator.QA_Enrollments_ActivateImage((Button)sender);
        }
        private void QA_Enrollments_Leave(object sender, EventArgs e)
        {
            ImageActivator.QA_Enrollments_DeactivateImage((Button)sender);

        }
        private void QA_Teachings_Enter(object sender, EventArgs e)
        {
            ImageActivator.QA_Teachings_ActivateImage((Button)sender);
        }
        private void QA_Teachings_Leave(object sender, EventArgs e)
        {
            ImageActivator.QA_Teachings_DeactivateImage((Button)sender);

        }
        private void QA_Sessions_Enter(object sender, EventArgs e)
        {
            ImageActivator.QA_Sessions_ActivateImage((Button)sender);
        }
        private void QA_Sessions_Leave(object sender, EventArgs e)
        {
            ImageActivator.QA_Sessions_DeactivateImage((Button)sender);

        }
        private void QA_Employees_Enter(object sender, EventArgs e)
        {
            ImageActivator.QA_Employees_ActivateImage((Button)sender);
        }
        private void QA_Employees_Leave(object sender, EventArgs e)
        {
            ImageActivator.QA_Employees_DeactivateImage((Button)sender);

        }
        private void QA_Structure_Enter(object sender, EventArgs e)
        {
            ImageActivator.QA_Structure_ActivateImage((Button)sender);
        }
        private void QA_Structure_Leave(object sender, EventArgs e)
        {
            ImageActivator.QA_Structure_DeactivateImage((Button)sender);

        }
        
        // Handle Navigation



        // Crud Events
        protected void Add_Enter(object sender, EventArgs e)
        {
            ImageActivator.ADD_ActivateImage((Button)sender);
        }
        protected void Add_Leave(object sender, EventArgs e)
        {
            ImageActivator.ADD_DeactivateImage((Button)sender);
        }
        protected void Update_Delete_Enter(object sender, EventArgs e)
        {
            ImageActivator.Update_Delete_ActivateImage((Button)sender);
        }
        protected void Update_Delete_Leave(object sender, EventArgs e)
        {
            ImageActivator.Update_Delete_DeactivateImage((Button)sender);
        }

        // Handle Search Bar Style
        protected void InputBoxClick(object sender, EventArgs e)
        {
            StyleManager.TextBox_ActivateStyle((TextBox)sender, Color.White);

        }
        protected void InputBoxLeave(object sender, EventArgs e)
        {
            StyleManager.TextBox_DeactivateStyle((TextBox)sender);
        }
        protected void InputBoxEnter(object sender, EventArgs e)
        {
            ImageActivator.SearchBar_ActivateImage((PictureBox)sender);
        }

        protected void SearchBarClick(object sender, EventArgs e)
        {
            StyleManager.ComboBox_ActivateStyle((ComboBox)sender);
        }
        protected void SearchBarEnter(object sender, EventArgs e)
        {
            ImageActivator.SearchBar_ActivateImage((PictureBox)sender);
        }
        protected void SearchBarLeave(object sender, EventArgs e)
        {
            StyleManager.ComboBox_DeactivateStyle((ComboBox)sender);

        }

        protected void FindIconEnter(object sender, EventArgs e)
        {
            ImageActivator.FindIcon_ActivateImage((PictureBox)sender);
        }

        protected void FindIconLeave(object sender, EventArgs e)
        {
            ImageActivator.FindIcon_DeactivateImage((PictureBox)sender);

        }
        // Close Button



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseEnter(object sender, EventArgs e)
        {
            ImageActivator.CloseAll_ActivateImage((PictureBox)sender);
        }

        private void CloseLeave(object sender, EventArgs e)
        {
            ImageActivator.CloseAll_DeactivateImage((PictureBox)sender);
        }

     
    }
}
