using DeskEtu.Core;
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
using static DeskEtu.Core.clsSession;
using static DeskEtu.Core.clsTeaching;
using static DeskEtu.StyleManager;

namespace DeskEtu.Project_Screens.Sessions.Manipulation_Screens
{
    public partial class ReformSessions : ReformScreen
    {
        public ReformSessions(ListView Lv)
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

            cbFind_Cohort.Click += SearchBarClick;
            cbFind_Cohort.MouseLeave += SearchBarLeave;
            pbFind_Cohort.MouseEnter += SearchBarEnter;

            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;

            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;

            ListViewControl = Lv;

            btnDone.Tag = "Add";
        }

        public ReformSessions(ListView Lv, stSession SelectedRecord)
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

            cbFind_Cohort.Click += SearchBarClick;
            cbFind_Cohort.MouseLeave += SearchBarLeave;
            pbFind_Cohort.MouseEnter += SearchBarEnter;

            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;

            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;

            ListViewControl = Lv;

            // Show retrieved data
            cbFind_Year.Text = SelectedRecord._YearNumber.ToString();
            cbFind_Group.Text = SelectedRecord._GroupNumber.ToString();
            cbFind_Cohort.Text = SelectedRecord._CohortNumber.ToString();
            cbFind_Course.Text = SelectedRecord._CourseName.ToString();
            cbFind_Mentor.Text = SelectedRecord._MentorID.ToString() + " - " + SelectedRecord._MentorName;

            // Save a copy of data set
            _SelectedRecord = SelectedRecord;

            btnDone.Tag = "Update";
        }

        // Data memeber
        stSession _SelectedRecord;

        List<int> _Years = new List<int>();

        List<int> _Groups = new List<int>();

        List<int> _Cohorts = new List<int>();
        List<string> _Courses = new List<string>();
        List<string> _Mentors = new List<string>();



        // Table Reference
        public ListView ListViewControl = null;

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
            _Groups = GetGroupsFor(SelectedYear);

            foreach (int Group in _Groups)
            {
                cbFind_Group.Items.Add(Group);
            }

        }
        void LoadCohorts()
        {
            cbFind_Cohort.Items.Clear();

            // Get Year values
            int SelectedGroup = Convert.ToInt32(cbFind_Group.SelectedItem.ToString());
            int SelectedYear = Convert.ToInt32(cbFind_Year.SelectedItem.ToString());

            _Cohorts = GetCohortFor(SelectedYear,SelectedGroup);

            foreach (int Cohort in _Cohorts)
            {
                cbFind_Cohort.Items.Add(Cohort);
            }

        }
        void LoadCourses()
        {
            cbFind_Course.Items.Clear();

            // Get Year values
            if (int.TryParse(cbFind_Year.Text, out int SelectedYear))
                _Courses = GetCoursesFor(SelectedYear);

            foreach (string Course in _Courses)
            {
                cbFind_Course.Items.Add(Course);
            }

        }
        void LoadMentors()
        {
            cbFind_Mentor.Items.Clear();

            // Get Year values
                _Mentors = GetMentorsFor(cbFind_Course.SelectedItem.ToString());


            foreach (string Mentor in _Mentors)
            {
                cbFind_Mentor.Items.Add(Mentor);
            }

        }

        void AddRecord()
        {
            if (cbFind_Year.Text != cbFind_Year.Tag.ToString() && cbFind_Group.Text != cbFind_Group.Tag.ToString() && cbFind_Cohort.Text != cbFind_Cohort.Tag.ToString() && cbFind_Course.Text != cbFind_Course.Tag.ToString() && cbFind_Mentor.Text != cbFind_Mentor.Tag.ToString())
            {
                stMentorDetails MentorDetails;
                MentorDetails = _ConvertLineToMentorDetailsStruct(cbFind_Mentor.Text);

                _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                _SelectedRecord._GroupNumber = Convert.ToInt32(cbFind_Group.Text);
                _SelectedRecord._CohortNumber = Convert.ToInt32(cbFind_Cohort.Text);
                _SelectedRecord._CourseName = cbFind_Course.Text;
                _SelectedRecord._MentorID = MentorDetails.MentorID;
                _SelectedRecord._MentorName = MentorDetails.MentorName;

                if (clsSession.AddRecord(_SelectedRecord, ListViewControl))
                {
                    cbFind_Year.Text = cbFind_Year.Tag.ToString();
                    cbFind_Course.Text = cbFind_Course.Tag.ToString();
                    cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();

                    ComboBox_DeactivateStyle(cbFind_Year);
                    ComboBox_DeactivateStyle(cbFind_Group);
                    ComboBox_DeactivateStyle(cbFind_Cohort);
                    ComboBox_DeactivateStyle(cbFind_Course);
                    ComboBox_DeactivateStyle(cbFind_Mentor);
                    MessageBox.Show("Added successfully");
                }
                else
                    MessageBox.Show("Session exists try another one");
            }
            else
                MessageBox.Show("Enter valid values");
        }

        void UpdateRecord()
        {
            if (cbFind_Year.Text != _SelectedRecord._YearNumber.ToString() || cbFind_Course.Text != _SelectedRecord._CourseName || cbFind_Mentor.Text != _SelectedRecord._MentorID.ToString() + " - " + _SelectedRecord._MentorName)
            {
                stMentorDetails MentorDetails;
                MentorDetails = _ConvertLineToMentorDetailsStruct(cbFind_Mentor.Text);

                _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                _SelectedRecord._GroupNumber = Convert.ToInt32(cbFind_Group.Text);
                _SelectedRecord._CohortNumber = Convert.ToInt32(cbFind_Cohort.Text);
                _SelectedRecord._CourseName = cbFind_Course.Text;
                _SelectedRecord._MentorID = MentorDetails.MentorID;
                _SelectedRecord._MentorName = MentorDetails.MentorName;

                if (clsSession.UpdateRecord(_SelectedRecord, ListViewControl))
                {
                    cbFind_Year.Text = cbFind_Year.Tag.ToString();
                    cbFind_Course.Text = cbFind_Course.Tag.ToString();
                    cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();

                    ComboBox_DeactivateStyle(cbFind_Year);
                    ComboBox_DeactivateStyle(cbFind_Group);
                    ComboBox_DeactivateStyle(cbFind_Cohort);
                    ComboBox_DeactivateStyle(cbFind_Course);
                    ComboBox_DeactivateStyle(cbFind_Mentor);

                    MessageBox.Show("Updated successfully");
                }
                else
                    MessageBox.Show("Teaching exists try another one");
            }
            else
                MessageBox.Show("Can not update with same values");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbFind_Course.SelectedItem == null)
            {
                MessageBox.Show("Session must has a course");
                return;
            }

            if (cbFind_Mentor.SelectedItem == null)
            {
                MessageBox.Show("Session must has a mentor");
                return;
            }

            //if (IsMultiCoursePerYear())
            //{
            //    MessageBox.Show("Mentor can not teach more than one course per year");

            //    return;
            //}

            if (btnDone.Tag.ToString() == "Add")
            {
                AddRecord();
            }
            else
            {
                UpdateRecord();
            }

        }
        private void StopTyping(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void FormOpen(object sender, EventArgs e)
        {
            LoadYears();

            //if (btnDone.Tag.ToString() == "Update")
            //    LoadCourses();
        }

        private void LoadGroupsAndCoursesWhenChanged(object sender, EventArgs e)
        {
            if (cbFind_Year.SelectedIndex == -1)
                return;

            LoadGroups();
            LoadCourses();
        }
        private void LoadCohortsWhenChanged(object sender, EventArgs e)
        {
            if (cbFind_Year.SelectedIndex == -1)
                return;

            LoadCohorts();
        }

        private void LoadMentorsWhenChanged(object sender, EventArgs e)
        {
            if (cbFind_Course.SelectedIndex == -1)
                return;

            LoadMentors();
        }

    }
}
