using DeskEtu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskEtu
{
    internal class ImageActivator
    {
        // Login Screen -------------------------- 

        // PictureBoxes : For Username & Password
        public static void PicBox_ActivateImage(PictureBox PB)
        {
            PB.Image = Resources.input_2;
        }
        public static void PicBox_DeactivateImage(PictureBox PB)
        {
            PB.Image = Resources.Input_1;
        }

        // Buttons
        public static void Login_ActivateImage(Button BTN)
        {
            StyleManager.Button_ActivateStyle(BTN);
            BTN.BackgroundImage = Resources.Button_2;
        }
        public static void Login_DeactivateImage(Button BTN)
        {
            StyleManager.Button_DeactivateStyle(BTN);
            BTN.BackgroundImage = Resources.Button_1;
        }

        public static void Logout_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Logout_2;
        }
        public static void Logout_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Logout_1;
        }


        // Main Screen -------------------------- 

        // Buttons
        public static void Enrollments_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Enrollment_2;
        }
        public static void Enrollments_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Enrolmment_1;
        }
        public static void Teachings_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Teaching_2;
        }
        public static void Teachings_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Teaching_1;
        }
        public static void Sessions_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Session1_2;
        }
        public static void Sessions_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Session_1;
        }
        public static void Employees_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Employee_2;
        }
        public static void Employees_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Employee_1;
        }
        public static void Structure_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Structure1_2;
        }
        public static void Structure_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Structure_1;
        }

        // List Screen 

        public static void FindIcon_ActivateImage(PictureBox Pb)
        {
            Pb.Image = Resources.Find_2;
        }
        public static void FindIcon_DeactivateImage(PictureBox Pb)
        {
            Pb.Image = Resources.Find_1;
        }

        // PictureBoxes 

        // Close

        public static void CloseAll_ActivateImage(PictureBox PB)
        {
            PB.Image = Resources.CloseAll_2;
        }

        public static void CloseAll_DeactivateImage(PictureBox PB)
        {
            PB.Image = Resources.CloseAll_1;
        }
        public static void SearchBar_ActivateImage(PictureBox PB)
        {
            PB.Image = Resources.Search_bar_2;
        }
        public static void SearchBar_DeactivateImage(PictureBox PB)
        {
            PB.Image = Resources.Search_bar_1;
        }

        // Buttons - Quick access
        public static void QA_Enrollments_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Enrollments_2;
        }
        public static void QA_Enrollments_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Enrollments_1;
        }
        public static void QA_Teachings_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Teaching_2;
        }
        public static void QA_Teachings_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Teaching_1;
        }
        public static void QA_Sessions_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Sessions_2;
        }
        public static void QA_Sessions_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Sessions_1;
        }
        public static void QA_Employees_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Employees_2;
        }
        public static void QA_Employees_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Employees_1;
        }
        public static void QA_Structure_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Structre_2;
        }
        public static void QA_Structure_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.QA_Structre_1;
        }

        // Buttons - CRUD
        public static void ADD_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Add_2;
        }
        public static void ADD_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.Add_1;
        }
        public static void Update_Delete_ActivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.U_D_2;
        }
        public static void Update_Delete_DeactivateImage(Button BTN)
        {
            BTN.BackgroundImage = Resources.U_D_1;
        }



    }
}
