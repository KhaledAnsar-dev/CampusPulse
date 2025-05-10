using DeskEtu.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsEnrollment;
using static DeskEtu.Core.clsTeaching;
using static DeskEtu.Core.clsStudent;
using static DeskEtu.StyleManager;

namespace DeskEtu.Project_Screens.Enrollments_Screens.Manipulation_Screens
{
    public partial class ReformEnrollment : ReformScreen
    {
        public ReformEnrollment(ListView Lv )
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

            cbFind_Student.Click += SearchBarClick;
            cbFind_Student.MouseLeave += SearchBarLeave;
            pbFind_Student.MouseEnter += SearchBarEnter;

            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;

            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;

            ListViewControl = Lv;
            btnDone.Tag = "Add";
        }

        public ReformEnrollment(ListView Lv , stEnrollment SelectedRecord)
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

            cbFind_Student.Click += SearchBarClick;
            cbFind_Student.MouseLeave += SearchBarLeave;
            pbFind_Student.MouseEnter += SearchBarEnter;

            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;

            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;

            ListViewControl = Lv;

            btnDone.Tag = "Update";



            // Show retrieved data
            cbFind_Year.Text = SelectedRecord._YearNumber.ToString();
            cbFind_Group.Text = SelectedRecord._GroupNumber.ToString();
            cbFind_Cohort.Text = SelectedRecord._CohortNumber.ToString();
            cbFind_Course.Text = SelectedRecord._CourseName.ToString();
            cbFind_Mentor.Text = SelectedRecord._MentorID.ToString() + " - " + SelectedRecord._MentorName;
            cbFind_Student.Text = SelectedRecord._StudentID.ToString() + " - " + SelectedRecord._StudentName;

            // Save a copy of data set
            _SelectedRecord = SelectedRecord;
        }


        // Data memeber
        stEnrollment _SelectedRecord;

        List<int> _Years = new List<int>();
        List<int> _Groups = new List<int>();
        List<int> _Cohorts = new List<int>();
        List<string> _Courses = new List<string>();
        List<string> _Mentors = new List<string>();
        List<string> _Students = new List<string>();



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

            _Cohorts = GetCohortFor(SelectedYear, SelectedGroup);

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
        void LoadStudents()
        {
            cbFind_Student.Items.Clear();

            // Get Year values
            int SelectedYear = Convert.ToInt32(cbFind_Year.SelectedItem.ToString());
            _Students = GetStudents(SelectedYear);

            foreach (string Student in _Students)
            {
                cbFind_Student.Items.Add(Student);
            }
        }
        stEnrollment GetEnrollmentRecord()
        {
            stEnrollment Enrollment = new stEnrollment();

            stStudentDetails StudentInfo = _ConvertLineToStudentDetailsStruct(cbFind_Student.Text);
            stMentorDetails MentorInfo = _ConvertLineToMentorDetailsStruct(cbFind_Mentor.Text);


            Enrollment._YearNumber = int.Parse(cbFind_Year.Text);    
            Enrollment._StudentID = StudentInfo.StudentID;
            Enrollment._StudentName = StudentInfo.StudentName;
            Enrollment._MentorID = MentorInfo.MentorID;
            Enrollment._MentorName = MentorInfo.MentorName;
            Enrollment._GroupNumber = int.Parse(cbFind_Group.Text);
            Enrollment._CohortNumber = int.Parse(cbFind_Cohort.Text);
            Enrollment._CourseName = cbFind_Course.Text;


            return Enrollment;

        }
        
        bool DoesEnrollmentExist(List<clsEnrollment> Records , stEnrollment FullRecord)
        {
            foreach (clsEnrollment Record in Records)
            {
                if (Record.EnrollmentRecord._YearNumber == FullRecord._YearNumber &&
                Record.EnrollmentRecord._GroupNumber == FullRecord._GroupNumber &&
                Record.EnrollmentRecord._CohortNumber == FullRecord._CohortNumber &&
                Record.EnrollmentRecord._CourseName == FullRecord._CourseName &&
                Record.EnrollmentRecord._MentorID == FullRecord._MentorID &&
                Record.EnrollmentRecord._MentorName == FullRecord._MentorName &&
                Record.EnrollmentRecord._StudentID == FullRecord._StudentID &&
                Record.EnrollmentRecord._StudentName == FullRecord._StudentName)
                {
                    return true;
                }
            }
            return false;
        }
        bool DoesStudentExist(List<clsEnrollment> Records, stEnrollment FullRecord)
        {
            foreach (clsEnrollment Record in Records)
            {
                if (Record.EnrollmentRecord._StudentID == FullRecord._StudentID &&
                Record.EnrollmentRecord._StudentName == FullRecord._StudentName)
                {
                    return true;
                }
            }
            return false;
        }

        bool DoesStudentEnrollInDefCohort(List<clsEnrollment> Records, stEnrollment FullRecord)
        {
            List<clsEnrollment> Enrollments = _LoadEnrollmentsDataFromFile();

            if (Enrollments.Count == 0)
                return false;

            foreach (clsEnrollment Enrollment in Enrollments)
            {
                if (Enrollment.EnrollmentRecord._GroupNumber == FullRecord._GroupNumber && Enrollment.EnrollmentRecord._CohortNumber == FullRecord._CohortNumber && Enrollment.EnrollmentRecord._StudentID == FullRecord._StudentID)
                    return false;
            }
            return true;
        }

        void BackToIntialValueAndStyle()
        {
            cbFind_Year.Text = cbFind_Year.Tag.ToString();
            cbFind_Course.Text = cbFind_Course.Tag.ToString();
            cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();
            cbFind_Group.Text = cbFind_Group.Tag.ToString();
            cbFind_Cohort.Text = cbFind_Cohort.Tag.ToString();
            cbFind_Student.Text = cbFind_Student.Tag.ToString();
            ComboBox_DeactivateStyle(cbFind_Year);
            ComboBox_DeactivateStyle(cbFind_Group);
            ComboBox_DeactivateStyle(cbFind_Cohort);
            ComboBox_DeactivateStyle(cbFind_Course);
            ComboBox_DeactivateStyle(cbFind_Mentor);
            ComboBox_DeactivateStyle(cbFind_Student);
        }



        void AddRecord()
        {
            if (cbFind_Year.Text != cbFind_Year.Tag.ToString() && cbFind_Group.Text != cbFind_Group.Tag.ToString() && cbFind_Cohort.Text != cbFind_Cohort.Tag.ToString() && cbFind_Course.Text != cbFind_Course.Tag.ToString() && cbFind_Mentor.Text != cbFind_Mentor.Tag.ToString())
            {
                stMentorDetails MentorDetails;
                MentorDetails = _ConvertLineToMentorDetailsStruct(cbFind_Mentor.Text);
                
                stStudentDetails StudentDetails;
                StudentDetails = _ConvertLineToStudentDetailsStruct(cbFind_Student.Text);

                _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                _SelectedRecord._GroupNumber = Convert.ToInt32(cbFind_Group.Text);
                _SelectedRecord._CohortNumber = Convert.ToInt32(cbFind_Cohort.Text);
                _SelectedRecord._CourseName = cbFind_Course.Text;
                _SelectedRecord._MentorID = MentorDetails.MentorID;
                _SelectedRecord._MentorName = MentorDetails.MentorName;
                _SelectedRecord._StudentID = StudentDetails.StudentID;
                _SelectedRecord._StudentName = StudentDetails.StudentName;
                _SelectedRecord._ExamGrade = "0";

                if (clsEnrollment.AddRecord(_SelectedRecord, ListViewControl))
                {
                    stResult Result = new stResult();

                    Result._YearNumber = _SelectedRecord._YearNumber;
                    Result._StudentID = _SelectedRecord._StudentID;
                    Result._StudentName = _SelectedRecord._StudentName;
                    Result._TotalGrade = _SelectedRecord._ExamGrade;

                    BackToIntialValueAndStyle();
                    MessageBox.Show("Added successfully");
                }
                else
                    MessageBox.Show("Result exists try another one");
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
                
                stStudentDetails StudentDetails;
                StudentDetails = _ConvertLineToStudentDetailsStruct(cbFind_Student.Text);

                _SelectedRecord._YearNumber = Convert.ToInt32(cbFind_Year.Text);
                _SelectedRecord._GroupNumber = Convert.ToInt32(cbFind_Group.Text);
                _SelectedRecord._CohortNumber = Convert.ToInt32(cbFind_Cohort.Text);
                _SelectedRecord._CourseName = cbFind_Course.Text;
                _SelectedRecord._MentorID = MentorDetails.MentorID;
                _SelectedRecord._MentorName = MentorDetails.MentorName;
                _SelectedRecord._StudentID = StudentDetails.StudentID;
                _SelectedRecord._StudentName = StudentDetails.StudentName;

                if (clsEnrollment.UpdateRecord(_SelectedRecord, ListViewControl))
                {
                    stResult Result = new stResult();

                    Result._YearNumber = _SelectedRecord._YearNumber;
                    Result._StudentID = _SelectedRecord._StudentID;
                    Result._StudentName = _SelectedRecord._StudentName;
                    Result._TotalGrade = _SelectedRecord._ExamGrade;
                    BackToIntialValueAndStyle();

                    MessageBox.Show("Updated successfully");
                }
                else
                    MessageBox.Show("Result exists try another one");
            }
            else
                MessageBox.Show("Can not update with same values");
        }

        void Done()
        {
            if (cbFind_Year.SelectedItem == null)
            {
                MessageBox.Show("Choose a year");
                return;
            }

            if (cbFind_Course.SelectedItem == null)
            {
                MessageBox.Show("Enrollment must has a course");
                return;
            }

            if (cbFind_Mentor.SelectedItem == null)
            {
                MessageBox.Show("Enrollment must has a mentor");
                return;
            }

            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();

            stEnrollment FullRecord = GetEnrollmentRecord();

            if (DoesEnrollmentExist(Records, FullRecord))
            {
                MessageBox.Show("Enrollment already exists");

                return;
            }

            if (DoesStudentExist(Records, FullRecord))
            {
                if (DoesStudentEnrollInDefCohort(Records, FullRecord))
                {
                    MessageBox.Show("Student can not enroll in multiple cohorts");

                    return;
                }
            }

            if (btnDone.Tag.ToString() == "Add")
            {
                AddRecord();
            }
            else
            {
                UpdateRecord();
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Done();
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

        private void LoadGroupsAndCoursesAndStudentsWhenChanged(object sender, EventArgs e)
        {
            if (cbFind_Year.SelectedIndex == -1)
                return;

            LoadGroups();
            LoadCourses();
            LoadStudents();
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
