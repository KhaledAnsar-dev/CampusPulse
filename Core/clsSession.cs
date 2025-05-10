using DeskEtu.Additional;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsGroup;
using static DeskEtu.Core.clsCohort;
using static DeskEtu.Core.clsCourse;
using static DeskEtu.Core.clsTeaching;

using System.Windows.Forms;

namespace DeskEtu.Core
{
    internal class clsSession
    {
        public stSession SessionRecord = new stSession();

        static stSession _ConvertToStruct(string[] Records)
        {
            stSession Record = new stSession
            {
                _SessionID = int.Parse(Records[0]),
                _YearNumber = int.Parse(Records[1]),
                _GroupNumber = int.Parse(Records[2]),
                _CohortNumber = int.Parse(Records[3]),
                _CourseName = Records[4],
                _MentorID = int.Parse(Records[5]),
                _MentorName = Records[6],
            };

            return Record;
        }

        static stSession _ConvertLineToSessionStruct(string LineOfRecord, string Delim = "#//#")
        {
            string[] Records = LineOfRecord.Split(new string[] { Delim }, StringSplitOptions.None);
            return _ConvertToStruct(Records);
        }

        static clsSession _ConvertLineToSessionObject(string LineOfRecord, string Delim = "#//#")
        {
            stSession Record = _ConvertLineToSessionStruct(LineOfRecord, Delim);
            return new clsSession(Record);
        }

        static List<clsSession> _LoadSessionsDataFromFile()
        {
            List<clsSession> ListOfRecords = new List<clsSession>();
            string filePath = "Sessions.txt";
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
                    clsSession Data = _ConvertLineToSessionObject(LineRecord);
                    if (Data.SessionRecord._MarkedForDelete != true)
                    {
                        ListOfRecords.Add(Data);
                    }
                }
            }
            return ListOfRecords;
        }

        static string _ConvertSessionObjectToLine(clsSession Session, string Seperator = "#//#")
        {
            stSession record = Session.SessionRecord;
            return $"{record._SessionID}{Seperator}{record._YearNumber}{Seperator}{record._GroupNumber}{Seperator}{record._CohortNumber}{Seperator}{record._CourseName}{Seperator}{record._MentorID}{Seperator}{record._MentorName}";
        }

        static void _SaveDataFromListToFile(List<clsSession> Records)
        {
            using (StreamWriter RecordFile = new StreamWriter("Sessions.txt", false)) // false لإعادة كتابة الملف
            {
                foreach (clsSession Record in Records)
                {
                    if (Record.SessionRecord._MarkedForDelete != true)
                    {
                        string RecordLine = _ConvertSessionObjectToLine(Record);
                        RecordFile.WriteLine(RecordLine);
                    }
                }
            }
        }

        static string _GetLine(stSession SessionRecord)
        {
            return $"{SessionRecord._SessionID}#//#{SessionRecord._YearNumber}#//#{SessionRecord._GroupNumber}#//#{SessionRecord._CohortNumber}#//#{SessionRecord._CourseName}#//#{SessionRecord._MentorID}#//#{SessionRecord._MentorName}";
        }

        static bool _LoadThanCheckIfExists(stSession FullRecord)
        {
            List<clsSession> Records = _LoadSessionsDataFromFile();
            foreach (clsSession Record in Records)
            {
                if (Record.SessionRecord._YearNumber == FullRecord._YearNumber &&
                    Record.SessionRecord._GroupNumber == FullRecord._GroupNumber &&
                    Record.SessionRecord._CohortNumber == FullRecord._CohortNumber &&
                    Record.SessionRecord._CourseName == FullRecord._CourseName &&
                    Record.SessionRecord._MentorID == FullRecord._MentorID &&
                    Record.SessionRecord._MentorName == FullRecord._MentorName)
                {
                    return false;
                }
            }
            return true;
        }
        static void _SaveNewLine(string NewLine)
        {
            using (StreamWriter Record = new StreamWriter("Sessions.txt", true)) // true للإضافة إلى الملف
            {
                Record.WriteLine(NewLine);
            }
        }

        static void _AddToTable(stSession Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record._SessionID.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());
            Item.SubItems.Add(Record._GroupNumber.ToString());
            Item.SubItems.Add(Record._CohortNumber.ToString());
            Item.SubItems.Add(Record._CourseName);
            Item.SubItems.Add(Record._MentorID.ToString());
            Item.SubItems.Add(Record._MentorName);
            Lv.Items.Add(Item);
        }

        static stSession _GetFullRecord(int SessionID, int YearNumber, int GroupNumber, int CohortNumber, string CourseName, int MentorID, string MentorName)
        {
            return new stSession
            {
                _SessionID = SessionID,
                _YearNumber = YearNumber,
                _GroupNumber = GroupNumber,
                _CohortNumber = CohortNumber,
                _CourseName = CourseName,
                _MentorID = MentorID,
                _MentorName = MentorName
            };
        }

        static void _UpdateTable(stSession Record, ListView Lv)
        {
            if (Lv.SelectedItems.Count > 0)
            {
                var selectedItem = Lv.SelectedItems[0];
                selectedItem.Text = Record._SessionID.ToString();
                selectedItem.SubItems[1].Text = Record._YearNumber.ToString();
                selectedItem.SubItems[2].Text = Record._GroupNumber.ToString();
                selectedItem.SubItems[3].Text = Record._CohortNumber.ToString();
                selectedItem.SubItems[4].Text = Record._CourseName;
                selectedItem.SubItems[5].Text = Record._MentorID.ToString();
                selectedItem.SubItems[6].Text = Record._MentorName;
            }
        }

        static void _UpdataDataSource(stSession UpdatedRecord)
        {
            List<clsSession> Records = _LoadSessionsDataFromFile();
            for (int i = 0; i < Records.Count; i++)
            {
                if (Records[i].SessionRecord._SessionID == UpdatedRecord._SessionID)
                {
                    Records[i].SessionRecord = UpdatedRecord;
                    break;
                }
            }
            _SaveDataFromListToFile(Records);
        }
        public clsSession(stSession Record)
        {
            SessionRecord = Record;
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

        static public List<int> GetCohortFor(int Year , int Group)
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

        public static bool AddRecord(stSession InitialRecord, ListView Lv)
        {
            clsLastNums LastIDs = new clsLastNums();

            LastIDs.IDs.LastSession += 1;

            stSession FullRecord = _GetFullRecord(LastIDs.IDs.LastSession, InitialRecord._YearNumber, InitialRecord._GroupNumber, InitialRecord._CohortNumber, InitialRecord._CourseName.ToString(), InitialRecord._MentorID, InitialRecord._MentorName.ToString()) ;

            if (_LoadThanCheckIfExists(FullRecord))
            {
                LastIDs.UpdateRecord();
                _AddToTable(FullRecord, Lv);
                _SaveNewLine(_GetLine(FullRecord));
                return true;
            }
            else
            {
                LastIDs.IDs.LastSession -= 1;
                return false;
            }
        }

        public static bool UpdateRecord(stSession UpdatedRecord, ListView Lv)
        {
            if (_LoadThanCheckIfExists(UpdatedRecord))
            {
                _UpdateTable(UpdatedRecord, Lv);
                _UpdataDataSource(UpdatedRecord);
                return true;
            }
            return false;
        }

        public static stSession FindStructRecord(string SessionID)
        {
            List<clsSession> Records = _LoadSessionsDataFromFile();
            foreach (var Record in Records)
            {
                if (Record.SessionRecord._SessionID.ToString() == SessionID)
                {
                    return Record.SessionRecord;
                }
            }
            return new stSession { _SessionID = -99 }; // يُستخدم كقيمة غير صالحة للدلالة على عدم العثور على السجل
        }

        public static void UploadRecords(ListView Lv)
        {
            List<clsSession> Records = _LoadSessionsDataFromFile();
            foreach (var Record in Records)
            {
                _AddToTable(Record.SessionRecord, Lv);
            }
        }
    }
}
