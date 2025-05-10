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
using static DeskEtu.Core.clsTeaching;
using static DeskEtu.Core.clsEnrollment;
using static DeskEtu.StyleManager;

namespace DeskEtu.Project_Screens.Teachings_Screens.Manipulation_Screens
{
    public partial class ReformTeachings : ReformScreen
    {
        public ReformTeachings(ListView Lv)
        {
            InitializeComponent();
            btnDone.MouseEnter += Add_Enter;
            btnDone.MouseLeave += Add_Leave;

            cbFind_Year.Click += SearchBarClick;
            cbFind_Year.MouseLeave += SearchBarLeave;
            pbFind_Year.MouseEnter += SearchBarEnter;

            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;

            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;

            ListViewControl = Lv;

            btnDone.Tag = "Add";
        }
        public ReformTeachings(ListView Lv, stTeaching SelectedRecord)
        {

            // اعدل كونستراكتشر ثاني 

            InitializeComponent();
            btnDone.MouseEnter += Add_Enter;
            btnDone.MouseLeave += Add_Leave;

            cbFind_Year.Click += SearchBarClick;
            cbFind_Year.MouseLeave += SearchBarLeave;
            pbFind_Year.MouseEnter += SearchBarEnter;

            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;

            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;

            ListViewControl = Lv;


            // Show retrieved data
            cbFind_Year.Text = SelectedRecord._YearNumber.ToString();
            cbFind_Course.Text = SelectedRecord._CourseName.ToString();
            cbFind_Mentor.Text = SelectedRecord._MentorID.ToString() + " - " + SelectedRecord._MentorName;

            // Save a copy of data set
            _SelectedRecord = SelectedRecord;

            btnDone.Tag = "Update";

        }

        // Data memeber
        stTeaching _SelectedRecord;

        List<int> _Years = new List<int>();
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
        void LoadCourses()
        {
            cbFind_Course.Items.Clear();

            // Get Year values
            if(int.TryParse(cbFind_Year.Text , out int SelectedYear))
                _Courses = GetCoursesFor(SelectedYear);

            foreach (string Course in _Courses)
            {
                cbFind_Course.Items.Add(Course);
            }

        }
        void LoadMentors()
        {
            _Mentors = GetMentors();

            foreach (string Mentor in _Mentors)
            {
                cbFind_Mentor.Items.Add(Mentor);
            }

        }

        void AddRecord()
        {
            if (cbFind_Year.Text != cbFind_Year.Tag.ToString() && cbFind_Mentor.Text != cbFind_Mentor.Tag.ToString())
            {
                stMentorDetails MentorDetails;
                MentorDetails = _ConvertLineToMentorDetailsStruct(cbFind_Mentor.Text);

                _SelectedRecord._YearNumber = cbFind_Year.Text;
                _SelectedRecord._CourseName = cbFind_Course.Text;
                _SelectedRecord._MentorID = MentorDetails.MentorID;
                _SelectedRecord._MentorName = MentorDetails.MentorName;

                if (clsTeaching.AddRecord(_SelectedRecord, ListViewControl))
                {
                    cbFind_Year.Text = cbFind_Year.Tag.ToString();
                    cbFind_Course.Text = cbFind_Course.Tag.ToString();
                    cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();

                    ComboBox_DeactivateStyle(cbFind_Year);
                    ComboBox_DeactivateStyle(cbFind_Course);
                    ComboBox_DeactivateStyle(cbFind_Mentor);
                    MessageBox.Show("Added successfully");
                }
                else
                    MessageBox.Show("Teaching exists try another one");
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

                _SelectedRecord._YearNumber = cbFind_Year.Text;
                _SelectedRecord._CourseName = cbFind_Course.Text;
                _SelectedRecord._MentorID = MentorDetails.MentorID;
                _SelectedRecord._MentorName = MentorDetails.MentorName;

                if (clsTeaching.UpdateRecord(_SelectedRecord, ListViewControl))
                {
                    cbFind_Year.Text = cbFind_Year.Tag.ToString();
                    cbFind_Course.Text = cbFind_Course.Tag.ToString();
                    cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();

                    ComboBox_DeactivateStyle(cbFind_Year);
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
        bool IsMultiCoursePerYear()
        {
            List<clsTeaching> Teachings = _LoadTeachingsDataFromFile();

            // Get selected mentor and year
            stMentorDetails MentorInfo = _ConvertLineToMentorDetailsStruct(cbFind_Mentor.Text);

            string Year = cbFind_Year.Text;
            int ID = MentorInfo.MentorID;


            // check if exist

            foreach(clsTeaching Teaching in Teachings)
            {
                if (Teaching.TeachingRecord._YearNumber == Year && Teaching.TeachingRecord._MentorID == ID)
                    return true;
            }

            return false;
        }

        bool IsUsed()
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();

            foreach (clsEnrollment Record in Records)
            {
                if (_SelectedRecord._YearNumber == Record.EnrollmentRecord._YearNumber.ToString() &&
                    _SelectedRecord._CourseName == Record.EnrollmentRecord._CourseName &&
                     _SelectedRecord._MentorID == Record.EnrollmentRecord._MentorID)
                    return true;
            }

            return false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbFind_Course.SelectedItem == null)
            {
                MessageBox.Show("Teaching must has a course");
                return;
            }

            if (cbFind_Mentor.SelectedItem == null)
            {
                MessageBox.Show("Teaching must has a mentor");
                return;
            }

            if(IsMultiCoursePerYear())
            {
                MessageBox.Show("Mentor can not teach more than one course per year");

                return;
            }

            if (btnDone.Tag.ToString() == "Add")
            {
                AddRecord();
            }
            else
            {
                if (IsUsed())
                {
                    MessageBox.Show("This teaching is already used with other enrollments");
                    this.Close();
                    return;
                }
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
            LoadMentors();

            if (btnDone.Tag.ToString() == "Update")
                LoadCourses();
        }
        private void LoadCoursesWhenEnter(object sender, EventArgs e)
        {
            if (cbFind_Year.SelectedIndex == -1)
                return;

            LoadCourses();
        }
    }
}
