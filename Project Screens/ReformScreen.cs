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
    public partial class ReformScreen : Form
    {
        private void FullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        public ReformScreen()
        {
            InitializeComponent();
            FullScreen();
        }


        // Events for handlling Add new item boxes style
        protected void Add_Enter(object sender, EventArgs e)
        {
            ImageActivator.ADD_ActivateImage((Button)sender);
        }
        protected void Add_Leave(object sender, EventArgs e)
        {
            ImageActivator.ADD_DeactivateImage((Button)sender);
        }

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


        private void CloseEnter(object sender, EventArgs e)
        {
            ImageActivator.CloseAll_ActivateImage((PictureBox)sender);
        }
        private void CloseLeave(object sender, EventArgs e)
        {
            ImageActivator.CloseAll_DeactivateImage((PictureBox)sender);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
