using DeskEtu.Additional;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsGroup;
using static DeskEtu.Core.clsCohort;
using static DeskEtu.Core.clsTeaching;
using static DeskEtu.Core.clsStudent;

namespace DeskEtu.Core
{
    internal class clsEnrollment
    {

        public stEnrollment EnrollmentRecord = new stEnrollment();

        static stEnrollment _ConvertToStruct(string[] Records)
        {
            stEnrollment Record = new stEnrollment
            {
                _EnrollmentID = int.Parse(Records[0]),
                _YearNumber = int.Parse(Records[1]),
                _GroupNumber = int.Parse(Records[2]),
                _CohortNumber = int.Parse(Records[3]),
                _CourseName = Records[4],
                _MentorID = int.Parse(Records[5]),
                _MentorName = Records[6],
                _StudentID = int.Parse(Records[7]),
                _StudentName = Records[8],

            };

            return Record;
        }

        static stEnrollment _ConvertLineToEnrollmentStruct(string LineOfRecord, string Delim = "#//#")
        {
            string[] Records = LineOfRecord.Split(new string[] { Delim }, StringSplitOptions.None);
            return _ConvertToStruct(Records);
        }

        static clsEnrollment _ConvertLineToEnrollmentObject(string LineOfRecord, string Delim = "#//#")
        {
            stEnrollment Record = _ConvertLineToEnrollmentStruct(LineOfRecord, Delim);
            return new clsEnrollment(Record);
        }


        static string _ConvertEnrollmentObjectToLine(clsEnrollment Enrollment, string Seperator = "#//#")
        {
            stEnrollment record = Enrollment.EnrollmentRecord;
            return $"{record._EnrollmentID}{Seperator}{record._YearNumber}{Seperator}{record._GroupNumber}{Seperator}{record._CohortNumber}{Seperator}{record._CourseName}{Seperator}{record._MentorID}{Seperator}{record._MentorName}{Seperator}{record._StudentID}{Seperator}{record._StudentName}{Seperator}{record._ExamGrade}";
        }

        static void _SaveDataFromListToFile(List<clsEnrollment> Records)
        {
            using (StreamWriter RecordFile = new StreamWriter("Enrollments.txt", false)) // false لإعادة كتابة الملف
            {
                foreach (clsEnrollment Record in Records)
                {
                    if (Record.EnrollmentRecord._MarkedForDelete != true)
                    {
                        string RecordLine = _ConvertEnrollmentObjectToLine(Record);
                        RecordFile.WriteLine(RecordLine);
                    }
                }
            }
        }

        static string _GetLine(stEnrollment EnrollmentRecord)
        {
            return $"{EnrollmentRecord._EnrollmentID}#//#{EnrollmentRecord._YearNumber}#//#{EnrollmentRecord._GroupNumber}#//#{EnrollmentRecord._CohortNumber}#//#{EnrollmentRecord._CourseName}#//#{EnrollmentRecord._MentorID}#//#{EnrollmentRecord._MentorName}#//#{EnrollmentRecord._StudentID}#//#{EnrollmentRecord._StudentName}#//#{EnrollmentRecord._ExamGrade}";
        }

        static bool _LoadThanCheckIfExists(stEnrollment FullRecord)
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();
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
                    return false;
                }
            }
            return true;
        }
        static void _SaveNewLine(string NewLine)
        {
            using (StreamWriter Record = new StreamWriter("Enrollments.txt", true)) // true للإضافة إلى الملف
            {
                Record.WriteLine(NewLine);
            }
        }

        static void _AddToTable(stEnrollment Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record._EnrollmentID.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());
            Item.SubItems.Add(Record._GroupNumber.ToString());
            Item.SubItems.Add(Record._CohortNumber.ToString());
            Item.SubItems.Add(Record._CourseName);
            Item.SubItems.Add(Record._MentorID.ToString());
            Item.SubItems.Add(Record._MentorName);
            Item.SubItems.Add(Record._StudentID.ToString());
            Item.SubItems.Add(Record._StudentName);
            Item.SubItems.Add(Record._ExamGrade);

            Lv.Items.Add(Item);
        }

        static stEnrollment _GetFullRecord(int EnrollmentID, int YearNumber, int GroupNumber, int CohortNumber, string CourseName, int MentorID, string MentorName, int StudentID, string StudentName , string ExamGrade)
        {
            return new stEnrollment
            {
                _EnrollmentID = EnrollmentID,
                _YearNumber = YearNumber,
                _GroupNumber = GroupNumber,
                _CohortNumber = CohortNumber,
                _CourseName = CourseName,
                _MentorID = MentorID,
                _MentorName = MentorName,
                _StudentID = StudentID,
                _StudentName = StudentName,
                _ExamGrade = ExamGrade
            };
        }

        static void _UpdateTable(stEnrollment Record, ListView Lv)
        {
            if (Lv.SelectedItems.Count > 0)
            {
                var selectedItem = Lv.SelectedItems[0];
                selectedItem.Text = Record._EnrollmentID.ToString();
                selectedItem.SubItems[1].Text = Record._YearNumber.ToString();
                selectedItem.SubItems[2].Text = Record._GroupNumber.ToString();
                selectedItem.SubItems[3].Text = Record._CohortNumber.ToString();
                selectedItem.SubItems[4].Text = Record._CourseName;
                selectedItem.SubItems[5].Text = Record._MentorID.ToString();
                selectedItem.SubItems[6].Text = Record._MentorName;
                selectedItem.SubItems[7].Text = Record._StudentID.ToString();
                selectedItem.SubItems[8].Text = Record._StudentName;
                selectedItem.SubItems[9].Text = Record._ExamGrade;

            }
        }

        static void _UpdataDataSource(stEnrollment UpdatedRecord)
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();
            for (int i = 0; i < Records.Count; i++)
            {
                if (Records[i].EnrollmentRecord._EnrollmentID == UpdatedRecord._EnrollmentID)
                {
                    Records[i].EnrollmentRecord = UpdatedRecord;
                    break;
                }
            }
            _SaveDataFromListToFile(Records);
        }
        public clsEnrollment(stEnrollment Record)
        {
            EnrollmentRecord = Record;
        }

        public static List<clsEnrollment> _LoadEnrollmentsDataFromFile()
        {
            List<clsEnrollment> ListOfRecords = new List<clsEnrollment>();
            string filePath = "Enrollments.txt";
            if (!File.Exists(filePath))
            {
                using (FileStream FS = File.Create(filePath)) { }
                return ListOfRecords;
            }

            using (StreamReader Records = new StreamReader(filePath))
            {
                string LineRecord;
                while ((LineRecord = Records.ReadLine()) != null)
                {
                    clsEnrollment Data = _ConvertLineToEnrollmentObject(LineRecord);
                    if (Data.EnrollmentRecord._MarkedForDelete != true)
                    {
                        ListOfRecords.Add(Data);
                    }
                }
            }
            return ListOfRecords;
        }

        //static public List<int> GetYears()
        //{
        //    List<int> Years = new List<int>();

        //    using (StreamReader Records = new StreamReader("Years.txt"))
        //    {
        //        string LineRecord;

        //        while ((LineRecord = Records.ReadLine()) != null)
        //        {
        //            Years.Add(Convert.ToInt32(LineRecord));
        //        }
        //        Records.Close();
        //        return Years;

        //    }

        //}
        static public List<int> GetGroupsFor(int Year)
        {
            List<int> Groups = new List<int>();

            using (StreamReader Records = new StreamReader("Groups.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    stGroup Cohort = _ConvertLineToGroupStruct(LineRecord);

                    if (Cohort._YearNumber == Year)
                        Groups.Add(Cohort._GroupNumber);
                }
                Records.Close();
                return Groups;

            }
        }
        static public List<int> GetCohortFor(int Year, int Group)
        {
            List<int> Cohorts = new List<int>();

            using (StreamReader Records = new StreamReader("Cohorts.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    stCohort Cohort = _ConvertLineToCohortStruct(LineRecord);

                    if (Cohort._YearNumber == Year && Cohort._GroupNumber == Group)
                        Cohorts.Add(Cohort._CohortNumber);
                }
                Records.Close();
                return Cohorts;

            }
        }
        //static public List<string> GetCoursesFor(int Year)
        //{
        //    List<string> Courses = new List<string>();

        //    using (StreamReader Records = new StreamReader("Courses.txt"))
        //    {
        //        string LineRecord;

        //        while ((LineRecord = Records.ReadLine()) != null)
        //        {
        //            stCourse Course = _ConvertLineToCourseStruct(LineRecord);

        //            if (Course._YearNumber == Year)
        //                Courses.Add(Course._CourseName);
        //        }
        //        Records.Close();
        //        return Courses;

        //    }
        //}

        // 
        static public List<string> GetMentorsFor(string Course)
        {
            List<string> Mentors = new List<string>();

            using (StreamReader Records = new StreamReader("Teaching.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    stTeaching Teaching = _ConvertLineToTeachingStruct(LineRecord);

                    if (Teaching._CourseName == Course)
                        Mentors.Add(Teaching._MentorID + " - " + Teaching._MentorName);
                }
                Records.Close();
                return Mentors;

            }
        }

        public static bool AddRecord(stEnrollment InitialRecord, ListView Lv)
        {
            clsLastNums LastIDs = new clsLastNums();

            LastIDs.IDs.LastEnrollment += 1;

            stEnrollment FullRecord = _GetFullRecord(LastIDs.IDs.LastEnrollment, InitialRecord._YearNumber, InitialRecord._GroupNumber, InitialRecord._CohortNumber, InitialRecord._CourseName.ToString(), InitialRecord._MentorID, InitialRecord._MentorName.ToString() , InitialRecord._StudentID, InitialRecord._StudentName.ToString(), InitialRecord._ExamGrade);

            LastIDs.UpdateRecord();
            _AddToTable(FullRecord, Lv);
            _SaveNewLine(_GetLine(FullRecord));

            return true;

        }

        public static bool UpdateRecord(stEnrollment UpdatedRecord, ListView Lv)
        {
            if (_LoadThanCheckIfExists(UpdatedRecord))
            {
                _UpdateTable(UpdatedRecord, Lv);
                _UpdataDataSource(UpdatedRecord);
                return true;
            }
            return false;
        }

        public static stEnrollment FindStructRecord(string EnrollmentID)
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();
            foreach (var Record in Records)
            {
                if (Record.EnrollmentRecord._EnrollmentID.ToString() == EnrollmentID)
                {
                    return Record.EnrollmentRecord;
                }
            }
            return new stEnrollment { _EnrollmentID = -99 }; // يُستخدم كقيمة غير صالحة للدلالة على عدم العثور على السجل
        }

        public static void UploadRecords(ListView Lv)
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();
            foreach (var Record in Records)
            {
                _AddToTable(Record.EnrollmentRecord, Lv);
            }
        }

        public static string GetLineOfRecords(string ID, string Year, string Group, string Cohort, string Course, string MentorID, string MentorName, string StudentID, string StudentName , string Separator = "#//#")
        {
            return ID + Separator + Year + Separator + Group + Separator + Cohort + Separator + Course + Separator + MentorID + Separator + MentorName + Separator + StudentID + Separator + StudentName;
        }

    }
}
