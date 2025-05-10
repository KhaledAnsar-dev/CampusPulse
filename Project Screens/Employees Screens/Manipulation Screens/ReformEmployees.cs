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

namespace DeskEtu.Project_Screens.Employees_Screens.Manipulation_Screens
{
    public partial class ReformEmployees : ReformScreen
    {
        public ReformEmployees()
        {
            InitializeComponent();

            btnAddNewEmployee.MouseEnter += Add_Enter;
            btnAddNewEmployee.MouseLeave += Add_Leave;

            txtEnter_Name.Click += InputBoxClick;
            txtEnter_Name.MouseLeave += InputBoxLeave;
            pbEnter_Name.MouseEnter += InputBoxEnter;

            cbEnter_Gender.Click += SearchBarClick;
            cbEnter_Gender.MouseLeave += SearchBarLeave;
            pbEnter_Gender.MouseEnter += InputBoxEnter;

            txtEnter_Email.Click += InputBoxClick;
            txtEnter_Email.MouseLeave += InputBoxLeave;
            pbEnter_Email.MouseEnter += InputBoxEnter;

            txtEnter_Phone.Click += InputBoxClick;
            txtEnter_Phone.MouseLeave += InputBoxLeave;
            pbEnter_Phone.MouseEnter += InputBoxEnter;

            txtEnter_Salary.Click += InputBoxClick;
            txtEnter_Salary.MouseLeave += InputBoxLeave;
            pbEnter_Salary.MouseEnter += InputBoxEnter;

        }

        // Inputs Validation
        private void NameValidating(object sender, CancelEventArgs e)
        {
            TextBox FullText = (TextBox)sender;

            if (FullText.Text == FullText.Tag.ToString())
                return;

            if (!clsInputValidate.IsNameValide(FullText.Text))
            {
                MessageBox.Show("Wrong Characters");
                FullText.Text = FullText.Tag.ToString();
            }
        }
        private void PhoneValidating(object sender, CancelEventArgs e)
        {
            TextBox FullText = (TextBox)sender;

            if (FullText.Text == FullText.Tag.ToString())
                return;

            if (!clsInputValidate.IsPhoneValide(FullText.Text))
            {
                MessageBox.Show("Wrong Characters");
                FullText.Text = FullText.Tag.ToString();
            }
        }
        private void SalaryValidating(object sender, CancelEventArgs e)
        {
            TextBox FullText = (TextBox)sender;

            if (FullText.Text == FullText.Tag.ToString())
                return;

            if (!clsInputValidate.IsSalaryValide(FullText.Text))
            {
                MessageBox.Show("Wrong Characters");
                FullText.Text = FullText.Tag.ToString();
            }
        }
        private void EmailValidating(object sender, CancelEventArgs e)
        {

            TextBox FullText = (TextBox)sender;

            if (FullText.Text == FullText.Tag.ToString())
                return;

            if (!clsInputValidate.IsEmailValide(FullText.Text))
            {
                MessageBox.Show("Wrong Characters");
                FullText.Text = FullText.Tag.ToString();
            }
        }
    }
}
