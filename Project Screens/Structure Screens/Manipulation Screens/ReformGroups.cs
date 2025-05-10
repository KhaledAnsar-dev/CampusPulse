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
using static DeskEtu.Core.clsGroup;
using static DeskEtu.Core.clsCohort;
using static DeskEtu.StyleManager;
namespace DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens
{
    public partial class ReformGroups : ReformScreen
    {
        public ReformGroups(ListView Lv)
        {
            InitializeComponent();
            btnDone.MouseEnter += Add_Enter;
            btnDone.MouseLeave += Add_Leave;

            cbFind_Year.Click += SearchBarClick;
            cbFind_Year.MouseLeave += SearchBarLeave;
            pbFind_Year.MouseEnter += SearchBarEnter;

            txtEnter_Group.Click += InputBoxClick;
            txtEnter_Group.MouseLeave += InputBoxLeave;
            pbEnter_Group.MouseEnter += InputBoxEnter;
            ListViewControl = Lv;

            btnDone.Tag = "Add";
            }
        public ReformGroups(ListView Lv, stGroup SelectedRecord)
        {
            InitializeComponent();
            btnDone.MouseEnter += Add_Enter;
            btnDone.MouseLeave += Add_Leave;

            cbFind_Year.Click += SearchBarClick;
            cbFind_Year.MouseLeave += SearchBarLeave;
            pbFind_Year.MouseEnter += SearchBarEnter;

            txtEnter_Group.Click += InputBoxClick;
            txtEnter_Group.MouseLeave += InputBoxLeave;
            pbEnter_Group.MouseEnter += InputBoxEnter;


            ListViewControl = Lv;

            // Show retrieved data
            //cbFind_Year.MouseEnter += UploadYears;

            cbFind_Year.Text = SelectedRecord._YearNumber.ToString();
            txtEnter_Group.Text = SelectedRecord._GroupNumber.ToString();

            // Save a copy of data set
            _SelectedRecord = SelectedRecord;

            btnDone.Tag = "Update";

        }

        // Data memeber
        stGroup _SelectedRecord;
        List<int> _Years = new List<int>();

        bool YearsUpload = false;

        // Table Reference
        public ListView ListViewControl = null;

        // Validations
        private void GroupNumberValidation(object sender, CancelEventArgs e)
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
        bool IsUsed()
        {
            List<clsCohort> Records = _LoadCohortsDataFromFile();

            foreach (clsCohort Record in Records)
            {
                if (_SelectedRecord._YearNumber == Record.CohortRecord._YearNumber &&
                    _SelectedRecord._GroupNumber == Record.CohortRecord._GroupNumber)
                    return true;
            }

            return false;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {

            if (btnDone.Tag.ToString() == "Add")
            {

                if (cbFind_Year.Text != cbFind_Year.Tag.ToString() && txtEnter_Group.Text != txtEnter_Group.Tag.ToString())
                {
                    _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                    _SelectedRecord._GroupNumber = Convert.ToInt32(txtEnter_Group.Text);

                    if (clsGroup.AddRecord(_SelectedRecord, ListViewControl))
                    {
                        cbFind_Year.Text = cbFind_Year.Tag.ToString();
                        txtEnter_Group.Text = txtEnter_Group.Tag.ToString();

                        ComboBox_DeactivateStyle(cbFind_Year);
                        TextBox_DeactivateStyle(txtEnter_Group);

                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Group exists try another one");
                }
                else
                    MessageBox.Show("Enter valid values");
            }
            else
            {
                if (IsUsed())
                {
                    MessageBox.Show("This group is already used with other cohorts");
                    this.Close();
                    return;
                }

                if (cbFind_Year.Text != _SelectedRecord._YearNumber.ToString() || txtEnter_Group.Text != _SelectedRecord._GroupNumber.ToString())
                {
                    _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                    _SelectedRecord._GroupNumber = Convert.ToInt32(txtEnter_Group.Text);

                    if (clsGroup.UpdateRecord(_SelectedRecord, ListViewControl))
                    {
                        cbFind_Year.Text = cbFind_Year.Tag.ToString();
                        txtEnter_Group.Text = txtEnter_Group.Tag.ToString();

                        ComboBox_DeactivateStyle(cbFind_Year);
                        TextBox_DeactivateStyle(txtEnter_Group);

                        MessageBox.Show("Updated successfully");
                    }
                    else
                        MessageBox.Show("Group exists try another one");
                }
                else
                    MessageBox.Show("Can not update with same values");
            }

        }

        void LoadYears()
        {
            // Get Year values
            if (YearsUpload)
                return;

            _Years = clsGroup.GetYears();

            foreach (int Year in _Years)
            {
                cbFind_Year.Items.Add(Year);
            }

            YearsUpload = true;
        }

        private void ReformGroups_Load(object sender, EventArgs e)
        {
            LoadYears();
        }

        private void ReformGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            YearsUpload = false;
        }

        private void StopTyping(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
