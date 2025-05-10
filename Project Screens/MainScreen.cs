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
    public partial class MainScreen : Form
    {
        public MainScreen(string User)
        {
            InitializeComponent();

            // Activate Enrollment button

            NavigationManager Menu = new NavigationManager();
            btnEnrollmenrs.Click += Menu.GoToEnrollments_Click;
            btnTeachings.Click += Menu.GoToTeachings_Click;
            btnEmployees.Click += Menu.GoToEmployees_Click;
            btnStructure.Click += Menu.GoToGroups_Click;
            lblCurrentUser.Text = User;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Events
        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            this.label4.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }
        private void EnrollmentsMouseEnter(object sender, EventArgs e)
        {
            ImageActivator.Enrollments_ActivateImage((Button)sender);
            StyleManager.LabelChangeBackColor(lblEnter, Color.FromArgb(0,102,102));

        }
        private void EnrolmmentsMouseLeave(object sender, EventArgs e)
        {
            ImageActivator.Enrollments_DeactivateImage((Button)sender);
            StyleManager.LabelChangeBackColor(lblEnter, Color.FromArgb(0,84,87));

        }
        private void TeachingsEnter(object sender, EventArgs e)
        {
            ImageActivator.Teachings_ActivateImage((Button)sender);
        }
        private void TeachingsLeave(object sender, EventArgs e)
        {
            ImageActivator.Teachings_DeactivateImage((Button)sender);
        }
     
        private void EmployeesEnter(object sender, EventArgs e)
        {
            ImageActivator.Employees_ActivateImage((Button)sender);
        }
        private void EmployeesLeave(object sender, EventArgs e)
        {
            ImageActivator.Employees_DeactivateImage((Button)sender);
        }
        private void StructureEnter(object sender, EventArgs e)
        {
            ImageActivator.Structure_ActivateImage((Button)sender);
        }
        private void StructureLeave(object sender, EventArgs e)
        {
            ImageActivator.Structure_DeactivateImage((Button)sender);
        }

        private void CommonScr_Click(object sender, EventArgs e)
        {
            ListScreen List = new ListScreen();
            List.ShowDialog();
        }



        private void CloseEnter(object sender, EventArgs e)
        {
            ImageActivator.CloseAll_ActivateImage((PictureBox)sender);
        }

        private void CloseLeave(object sender, EventArgs e)
        {
            ImageActivator.CloseAll_DeactivateImage((PictureBox)sender);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
