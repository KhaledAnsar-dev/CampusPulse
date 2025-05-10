using DeskEtu.Core;
using DeskEtu.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Core.clsEmployee;

namespace DeskEtu
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        // Username & Password 
        void TextBoxsStyleChange(TextBox TXT)
        {
            switch (TXT.Tag.ToString())
            {
                case "Username":
                    {
                        StyleManager.TextBox_ActivateStyle(txtUserName , Color.FromArgb(240, 247, 247));
                        StyleManager.TextBox_DeactivateStyle(txtPassword);
                        break;
                    }
                default:
                    {
                        StyleManager.TextBox_ActivateStyle(txtPassword, Color.FromArgb(240, 247, 247));
                        StyleManager.TextBox_DeactivateStyle(txtUserName);
                        break;
                    }
            }
        }
        void PictureBoxsImagesChange(TextBox TXT)
        {
            switch (TXT.Tag.ToString())
            {
                case "Username":
                    {
                        ImageActivator.PicBox_ActivateImage(pbUsername);
                        ImageActivator.PicBox_DeactivateImage(pbPassword);
                        break;
                    }
                default:
                    {
                        ImageActivator.PicBox_ActivateImage(pbPassword);
                        ImageActivator.PicBox_DeactivateImage(pbUsername);
                        break;
                    }
            }
        }
        void TXT_Click(TextBox TXT)
        {
            TextBoxsStyleChange(TXT);
            PictureBoxsImagesChange(TXT);
        }

        // Login Events
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        private void LogoutMouseEnter(object sender, EventArgs e)
        {
            ImageActivator.Logout_ActivateImage((Button)sender);
        }
        private void LogoutMouseLeave(object sender, EventArgs e)
        {
            ImageActivator.Logout_DeactivateImage((Button)sender);
        }
        private void LoginMouseEnter(object sender, EventArgs e)
        {
            ImageActivator.Login_ActivateImage((Button)sender);
        }
        private void LoginMouseLeave(object sender, EventArgs e)
        {
            ImageActivator.Login_DeactivateImage((Button)sender);

        }
        private void TextBox_Click(object sender, EventArgs e)
        {
            TXT_Click((TextBox)sender);
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            StyleManager.TextBox_WhenLeave((TextBox)sender);
        }


        bool Login()
        {
            List<clsEmployee> EmployeesList = _LoadEmployeeDataFromFile();

            string User = txtUserName.Text;
            string Password = txtPassword.Text;


            if (User == txtUserName.Tag.ToString() && Password == txtPassword.Tag.ToString())
            {
                return false;
            }
            else
            {
                foreach(clsEmployee Employee in EmployeesList)
                {
                    if(Employee.Employee.UserName == User && Employee.Employee.Password == Password)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(Login())
            {
                MainScreen Main = new MainScreen(txtUserName.Text);
                Main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
      
        }
        private void pbLogout_Click(object sender, EventArgs e)
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

        private void LoginInputsValidation(object sender, CancelEventArgs e)
        {
            TextBox FullText = (TextBox)sender;
            if (!clsInputValidate.IsLoginValide(FullText.Text))
            {
                MessageBox.Show("Wrong Characters");
                FullText.Text = FullText.Tag.ToString();
            }
        }
    }
}
