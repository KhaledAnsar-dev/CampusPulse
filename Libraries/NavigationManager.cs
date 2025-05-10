using DeskEtu.Project_Screens.Employees_Screens.Manipulation_Screens;
using DeskEtu.Project_Screens.Enrollments_Screens.Manipulation_Screens;
using DeskEtu.Project_Screens.Sessions.Manipulation_Screens;
using DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens;
using DeskEtu.Project_Screens.Teachings_Screens.List_Screens;
using DeskEtu.Project_Screens.Teachings_Screens.Manipulation_Screens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskEtu
{
    internal class NavigationManager
    {

        public NavigationManager()
        {
        }


        // Navigation Between List Screens
        public void GoToStudents_Click(object sender, EventArgs e)
        {
            StudentsScreen Student = new StudentsScreen();
            Student.ShowDialog();
        }
        public void GoToEnrollments_Click(object sender, EventArgs e)
        {
            EnrollmentsScreen Enroll = new EnrollmentsScreen();
            Enroll.ShowDialog();
        }
        public void GoToTeachings_Click(object sender, EventArgs e)
        {
            TeachingScreen Teach = new TeachingScreen();
            Teach.ShowDialog();
        }
        public void GoToMonitors_Click(object sender, EventArgs e)
        {
            Mentors_Screen Mentoring = new Mentors_Screen();
            Mentoring.ShowDialog();
        }
        public void GoToCourses_Click(object sender, EventArgs e)
        {
            CoursesScreen Courses = new CoursesScreen();
            Courses.ShowDialog();
        }
   
        public void GoToGroups_Click(object sender, EventArgs e)
        {
            GroupsScreen Groups = new GroupsScreen();
            Groups.ShowDialog();
        }
        public void GoToCohorts_Click(object sender, EventArgs e)
        {
            CohortsScreen Cohorts = new CohortsScreen();
            Cohorts.ShowDialog();
        }
        public void GoToEmployees_Click(object sender, EventArgs e)
        {
            EmployeesScreen Groups = new EmployeesScreen();
            Groups.ShowDialog();
        }
        public void GoToSessions_Click(object sender, EventArgs e)
        {
            Sessions_Screen Sessions = new Sessions_Screen();
            Sessions.ShowDialog();
        }

        // Navigation To Reform Screens

     
        public void Open_Employees_Create_Click(object sender, EventArgs e)
        {
            ReformEmployees Page = new ReformEmployees();
            Page.ShowDialog();
        }







        // Navigation - Style
        public void MenuHovring(object sender, EventArgs e)
        {
            StyleManager.Label_ActivateStyle((Label)sender);
        }
        public void MenuLeft(object sender, EventArgs e)
        {
            StyleManager.Label_DeactivateStyle((Label)sender);
        }

    }


}
