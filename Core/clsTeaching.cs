using DeskEtu.Additional;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsCourse;
using static DeskEtu.Core.clsMentors;

namespace DeskEtu.Core
{
    internal class clsTeaching
    {
        public stTeaching TeachingRecord = new stTeaching();



        // Struct record methods
        static stMentorDetails _ConvertToMentorStruct(string[] Records)
        {
            stMentorDetails Record = new stMentorDetails();
            Record.MentorID = Convert.ToInt32(Records[0]);
            Record.MentorName = Records[1];

            return Record;
        }
        static stTeaching _ConvertToStruct(string[] Records)
        {
            stTeaching Record = new stTeaching();
            Record._TeachingID = Convert.ToInt32(Records[0]);
            Record._YearNumber = Records[1];
            Record._CourseName = Records[2];
            Record._MentorID = Convert.ToInt32(Records[3]);
            Record._MentorName = Records[4];

            return Record;
        }
        public static stTeaching _ConvertLineToTeachingStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stTeaching Record = _ConvertToStruct(Records);

            return Record;
        }
        static stTeaching _ConvertToStruct(clsTeaching Records)
        {
            stTeaching Record = new stTeaching();
            Record._TeachingID = Records.TeachingRecord._TeachingID;
            Record._YearNumber = Records.TeachingRecord._YearNumber;
            Record._CourseName = Records.TeachingRecord._CourseName;
            Record._MentorID = Records.TeachingRecord._MentorID;
            Record._MentorName = Records.TeachingRecord._MentorName;


            return Record;
        }

        // Save & upload data
        static clsTeaching _ConvertLineToCohortObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stTeaching Record = _ConvertToStruct(Records);

            return new clsTeaching(Record);
        }
        static string _ConvertCohortObjectToLine(clsTeaching Cohort, string Seperator = "#//#")
        {
            string RecordData = "";
            RecordData += Cohort.TeachingRecord._TeachingID + Seperator;
            RecordData += Cohort.TeachingRecord._YearNumber + Seperator;
            RecordData += Cohort.TeachingRecord._CourseName + Seperator;
            RecordData += Cohort.TeachingRecord._MentorID + Seperator;
            RecordData += Cohort.TeachingRecord._MentorName;

            return RecordData;
        }
        static void _SaveDataFromListToFile(List<clsTeaching> Records)
        {

            string RecordLine = "";

            using (StreamWriter GroupRecords = new StreamWriter("Teaching.txt"))
            {
                foreach (clsTeaching Record in Records)
                {
                    if (Record.TeachingRecord._MarkedForDelete != true)
                    {
                        RecordLine = _ConvertCohortObjectToLine(Record);

                        GroupRecords.WriteLine(RecordLine);
                    }
                }
            }
        }

        // Perform Create opperation methods
        static string _GetLine(stTeaching CohortRecord)
        {
            return CohortRecord._TeachingID + "#//#" + CohortRecord._YearNumber + "#//#" + CohortRecord._CourseName + "#//#" + CohortRecord._MentorID + "#//#" + CohortRecord._MentorName;
        }
        static Boolean _LoadThanCheckIfExists(stTeaching FullRecord)
        {
            List<clsTeaching> Records = _LoadTeachingsDataFromFile();

            if (Records.Count == 0)
                return true;

            foreach (clsTeaching Record in Records)
            {
                if ((Record.TeachingRecord._YearNumber == FullRecord._YearNumber) && (Record.TeachingRecord._CourseName == FullRecord._CourseName) && (Record.TeachingRecord._MentorID == FullRecord._MentorID) && (Record.TeachingRecord._MentorName == FullRecord._MentorName))
                {
                    return false;
                }
            }
            return true;
        }
        static void _SaveNewLine(string NewLine)
        {
            using (StreamWriter Record = new StreamWriter("Teaching.txt", true))
            {
                Record.WriteLine(NewLine);
            }
        }
        static void _AddToTable(stTeaching Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record._TeachingID.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());
            Item.SubItems.Add(Record._CourseName.ToString());
            Item.SubItems.Add(Record._MentorID.ToString());
            Item.SubItems.Add(Record._MentorName.ToString());
            Lv.Items.Add(Item);
        }
        static stTeaching _GetFullRecord(int TeachingID, string Year, string Course, string MentorID, string MentorName)
        {
            stTeaching Record = new stTeaching();

            Record._TeachingID = TeachingID;
            Record._YearNumber = Year;
            Record._CourseName = Course;
            Record._MentorID = Convert.ToInt32(MentorID);
            Record._MentorName = MentorName;

            return Record;
        }

        // Perform Update opperation methods
        static void _UpdateTable(stTeaching Record, ListView Lv)
        {
            Lv.SelectedItems[0].Text = Record._TeachingID.ToString();
            Lv.SelectedItems[0].SubItems[1].Text = Record._YearNumber.ToString();
            Lv.SelectedItems[0].SubItems[2].Text = Record._CourseName.ToString();
            Lv.SelectedItems[0].SubItems[3].Text = Record._MentorID.ToString();
            Lv.SelectedItems[0].SubItems[4].Text = Record._MentorName.ToString();

        }
        static void _UpdataDataSource(stTeaching UpdatedRecord)
        {
            List<clsTeaching> Records = _LoadTeachingsDataFromFile();

            foreach (clsTeaching Record in Records)
            {
                if ((Record.TeachingRecord._TeachingID == UpdatedRecord._TeachingID))
                {
                    Record.TeachingRecord._YearNumber = UpdatedRecord._YearNumber;
                    Record.TeachingRecord._CourseName = UpdatedRecord._CourseName;
                    Record.TeachingRecord._MentorID = UpdatedRecord._MentorID;
                    Record.TeachingRecord._MentorName = UpdatedRecord._MentorName;

                    break;
                }
            }
            _SaveDataFromListToFile(Records);
        }



        // Public Members
        public clsTeaching(stTeaching Record)
        {
            TeachingRecord = Record;

        }

        public static List<clsTeaching> _LoadTeachingsDataFromFile()
        {
            List<clsTeaching> ListOfRecords = new List<clsTeaching>();

            if (!File.Exists("Teaching.txt"))
            {
                using (FileStream FS = File.Create("Teaching.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Teaching.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsTeaching Data = _ConvertLineToCohortObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }

        }

        static public List<int> GetYears()
        {
            List<int> Years = new List<int>();

            using (StreamReader Records = new StreamReader("Years.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    Years.Add(Convert.ToInt32(LineRecord));
                }
                Records.Close();
                return Years;

            }

        }
        static public List<string> GetMentors()
        {
            List<string> Mentors = new List<string>();

            using (StreamReader Records = new StreamReader("Mentors.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    stMentor MentorDetails = _ConvertLineToMentorStruct(LineRecord);
                    Mentors.Add(MentorDetails.MentorID + " - " + MentorDetails.Person._Name);
                }
                Records.Close();
                return Mentors;

            }

        }

        static public List<string> GetCoursesFor(int Year)
        {
            List<string> Courses = new List<string>();

            using (StreamReader Records = new StreamReader("Courses.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    stCourse Course = _ConvertLineToCourseStruct(LineRecord);

                    if (Course._YearNumber == Year)
                        Courses.Add(Course._CourseName);
                }
                Records.Close();
                return Courses;

            }
        }
        static public bool AddRecord(stTeaching InitialRecord, ListView Lv)
        {
            clsLastNums LastIDs = new clsLastNums();

            LastIDs.IDs.LastTeaching += 1;

            stTeaching FullRecord = _GetFullRecord(LastIDs.IDs.LastTeaching, InitialRecord._YearNumber.ToString(), InitialRecord._CourseName.ToString(), InitialRecord._MentorID.ToString(), InitialRecord._MentorName.ToString());

            if (_LoadThanCheckIfExists(FullRecord))
            {
                LastIDs.UpdateRecord();
                _AddToTable(FullRecord, Lv);
                _SaveNewLine(_GetLine(FullRecord));
                return true;
            }
            else
            {
                LastIDs.IDs.LastTeaching -= 1;
                return false;
            }
        }
        static public bool UpdateRecord(stTeaching UpdatedRecord, ListView Lv)
        {
            if (_LoadThanCheckIfExists(UpdatedRecord))
            {
                _UpdateTable(UpdatedRecord, Lv);
                _UpdataDataSource(UpdatedRecord);
                return true;

            }
            else
                return false;
        }
        static public stTeaching FindStructRecord(string TeachingID)
        {
            using (StreamReader GroupRecords = new StreamReader("Teaching.txt"))
            {
                string LineRecord;
                stTeaching Record = new stTeaching();
                while ((LineRecord = GroupRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToTeachingStruct(LineRecord);

                    if (Record._TeachingID.ToString() == TeachingID)
                        return Record;
                }
                Record._TeachingID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsTeaching> Records = clsTeaching._LoadTeachingsDataFromFile();

            foreach (clsTeaching Record in Records)
            {
                stTeaching CurrentRecord = _ConvertToStruct(Record);

                _AddToTable(CurrentRecord, Lv);
            }
        }
        public static stMentorDetails _ConvertLineToMentorDetailsStruct(string LineOfRecord, string Delim = " - ")
        {

            string[] Records = LineOfRecord.Split(new string[] { Delim }, StringSplitOptions.None);

            stMentorDetails Record = _ConvertToMentorStruct(Records);

            return Record;
        }
        public static string GetLineOfRecords(string ID, string Year, string Course, string MentorID , string MentorName, string Separator = "#//#")
        {
            return ID + Separator + Year + Separator + Course + Separator + MentorID + Separator + MentorName;
        }

    }
}
