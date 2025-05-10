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
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsCohort;
using static DeskEtu.Core.clsEnrollment;

using static DeskEtu.StyleManager;

namespace DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens
{
    public partial class ReformCohorts : ReformScreen
    {
        public ReformCohorts(ListView Lv)
        {
            InitializeComponent();
            btnDone.MouseEnter += Add_Enter;
            btnDone.MouseLeave += Add_Leave;

            cbFind_Year.Click += SearchBarClick;
            cbFind_Year.MouseLeave += SearchBarLeave;
            pbFind_Year.MouseEnter += SearchBarEnter;

            cbFind_Group.Click += SearchBarClick;
            cbFind_Group.MouseLeave += SearchBarLeave;
            pbFind_Group.MouseEnter += SearchBarEnter;

            txtEnter_Cohort.Click += InputBoxClick;
            txtEnter_Cohort.MouseLeave += InputBoxLeave;
            pbEnter_Cohort.MouseEnter += InputBoxEnter;

            ListViewControl = Lv;

            btnDone.Tag = "Add";
        }
        public ReformCohorts(ListView Lv, stCohort SelectedRecord)
        {
            InitializeComponent();
            btnDone.MouseEnter += Add_Enter;
            btnDone.MouseLeave += Add_Leave;

            cbFind_Year.Click += SearchBarClick;
            cbFind_Year.MouseLeave += SearchBarLeave;
            pbFind_Year.MouseEnter += SearchBarEnter;

            cbFind_Group.Click += SearchBarClick;
            cbFind_Group.MouseLeave += SearchBarLeave;
            pbFind_Group.MouseEnter += SearchBarEnter;

            txtEnter_Cohort.Click += InputBoxClick;
            txtEnter_Cohort.MouseLeave += InputBoxLeave;
            pbEnter_Cohort.MouseEnter += InputBoxEnter;


            ListViewControl = Lv;

            // Show retrieved data
            cbFind_Year.Text = SelectedRecord._YearNumber.ToString();
            cbFind_Group.Text = SelectedRecord._GroupNumber.ToString();
            txtEnter_Cohort.Text = SelectedRecord._CohortNumber.ToString();

            // Save a copy of data set
            _SelectedRecord = SelectedRecord;

            btnDone.Tag = "Update";

        }

        // Data memeber
        stCohort _SelectedRecord;

        List<int> _Years = new List<int>();
        List<int> _Groups = new List<int>();


        bool GroupsUpload = false;

        // Table Reference
        public ListView ListViewControl = null;

        // Validations
        private void NumberValidation(object sender, CancelEventArgs e)
        {
            TextBox FullText = (TextBox)sender;

            if (FullText.Text == FullText.Tag.ToString())
                return;

            if (!clsInputValidate.IsNumberValide(FullText.Text))
            {
                MessageBox.Show("Wrong Number");
                FullText.Text = FullText.Tag.ToString();
            }
        }

        // Perform Create or Update opperations
        void LoadYears()
        {
            _Years = GetYears();

            foreach (int Year in _Years)
            {
                cbFind_Year.Items.Add(Year);
            }
        }
        void LoadGroups()
        {
            cbFind_Group.Items.Clear();

            // Get Year values
            int SelectedYear = Convert.ToInt32(cbFind_Year.SelectedItem.ToString());
            _Groups = clsCohort.GetGroupsFor(SelectedYear);

            foreach (int Group in _Groups)
            {
                cbFind_Group.Items.Add(Group);
            }

        }
        bool IsUsed()
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();

            foreach (clsEnrollment Record in Records)
            {
                if (_SelectedRecord._YearNumber == Record.EnrollmentRecord._YearNumber &&
                    _SelectedRecord._GroupNumber == Record.EnrollmentRecord._GroupNumber &&
                     _SelectedRecord._CohortNumber == Record.EnrollmentRecord._CohortNumber)
                    return true;
            }

            return false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbFind_Group.SelectedItem == null)
            {
                MessageBox.Show("Cohort must has a group");
                return;
            }

            if (btnDone.Tag.ToString() == "Add")
            {

                if (cbFind_Year.Text != cbFind_Year.Tag.ToString() && txtEnter_Cohort.Text != txtEnter_Cohort.Tag.ToString())
                {
                    _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                    _SelectedRecord._GroupNumber = Convert.ToInt32(cbFind_Group.Text);
                    _SelectedRecord._CohortNumber = Convert.ToInt32(txtEnter_Cohort.Text);

                    if (clsCohort.AddRecord(_SelectedRecord, ListViewControl))
                    {
                        cbFind_Year.Text = cbFind_Year.Tag.ToString();
                        cbFind_Group.Text = cbFind_Group.Tag.ToString();
                        txtEnter_Cohort.Text = txtEnter_Cohort.Tag.ToString();

                        ComboBox_DeactivateStyle(cbFind_Year);
                        ComboBox_DeactivateStyle(cbFind_Group);
                        TextBox_DeactivateStyle(txtEnter_Cohort);

                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Cohort exists try another one");
                }
                else
                    MessageBox.Show("Enter valid values");
            }
            else
            {
                if (IsUsed())
                {
                    MessageBox.Show("This cohort is already used with other enrollments");
                    this.Close();
                    return;
                }

                if (cbFind_Year.Text != _SelectedRecord._YearNumber.ToString() || cbFind_Group.Text != _SelectedRecord._GroupNumber.ToString() || txtEnter_Cohort.Text != _SelectedRecord._CohortNumber.ToString())
                {
                    _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                    _SelectedRecord._GroupNumber = Convert.ToInt32(cbFind_Group.Text);
                    _SelectedRecord._CohortNumber = Convert.ToInt32(txtEnter_Cohort.Text);

                    if (clsCohort.UpdateRecord(_SelectedRecord, ListViewControl))
                    {
                        cbFind_Year.Text = cbFind_Year.Tag.ToString();
                        cbFind_Group.Text = cbFind_Group.Tag.ToString();
                        txtEnter_Cohort.Text = txtEnter_Cohort.Tag.ToString();

                        ComboBox_DeactivateStyle(cbFind_Year);
                        ComboBox_DeactivateStyle(cbFind_Group);
                        TextBox_DeactivateStyle(txtEnter_Cohort);

                        MessageBox.Show("Updated successfully");
                    }
                    else
                        MessageBox.Show("Cohort exists try another one");
                }
                else
                    MessageBox.Show("Can not update with same values");
            }

        }
        private void StopTyping(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void FormClose(object sender, FormClosingEventArgs e)
        {
            GroupsUpload = false;
        }
        private void FormOpen(object sender, EventArgs e)
        {
            LoadYears();
        }
        private void LoadGroupsWhenEnter(object sender, EventArgs e)
        {
            if (cbFind_Year.SelectedIndex == -1)
                return;

            LoadGroups();
        }
    }
}
