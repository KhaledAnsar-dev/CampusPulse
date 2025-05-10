using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeskEtu.Additional.clsStructs;
using System.Windows.Forms;

namespace DeskEtu.Core
{
    internal class clsStudent : clsPerson
    {
        stStudent Student;
        public clsStudent(stPerson Person, stStudent Student) : base(Person)
        {
            this.Student = Student;
        }


        // Struct record methods
        static stStudent _ConvertToStruct(string[] Records)
        {
            stStudent Record = new stStudent();
            Record.StudentID = Convert.ToInt32(Records[0]);
            Record.Person._Name = Records[1];
            Record.Person._Gender = Records[2];
            Record.Person._DateOfBirth = Convert.ToDateTime(Records[3]);
            Record.Person._Email = Records[4];
            Record.Person._Phone = Records[5];
            Record._YearNumber = int.Parse(Records[6]);
            return Record;
        }
        static stStudent _ConvertLineToStudentStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stStudent Record = _ConvertToStruct(Records);

            return Record;
        }
        static stStudent _ConvertToStruct(clsStudent Records)
        {
            stStudent Record = new stStudent();
            Record.StudentID = Records.Student.StudentID;
            Record.Person._Name = Records.Student.Person._Name;
            Record.Person._Gender = Records.Student.Person._Gender;
            Record.Person._DateOfBirth = Records.Student.Person._DateOfBirth;
            Record.Person._Email = Records.Student.Person._Email;
            Record.Person._Phone = Records.Student.Person._Phone;
            Record._YearNumber = Records.Student._YearNumber;

            return Record;
        }

        // Save & upload data
        static clsStudent _ConvertLineToMentorObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stStudent Record = _ConvertToStruct(Records);

            return new clsStudent(Record.Person, Record);
        }
        static List<clsStudent> _LoadMentorsDataFromFile()
        {
            List<clsStudent> ListOfRecords = new List<clsStudent>();

            if (!File.Exists("Students.txt"))
            {
                using (FileStream FS = File.Create("Students.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Students.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsStudent Data = _ConvertLineToMentorObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }

        }
        static void _AddToTable(stStudent Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record.StudentID.ToString());
            Item.SubItems.Add(Record.Person._Name.ToString());
            Item.SubItems.Add(Record.Person._Gender.ToString());
            Item.SubItems.Add(Record.Person._DateOfBirth.ToString("dd-MM-yyyy"));
            Item.SubItems.Add(Record.Person._Email.ToString());
            Item.SubItems.Add(Record.Person._Phone.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());

            Lv.Items.Add(Item);
        }
        static public stStudent FindStructRecord(string MentorID)
        {
            using (StreamReader MentorRecords = new StreamReader("Students.txt"))
            {
                string LineRecord;
                stStudent Record = new stStudent();
                while ((LineRecord = MentorRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToStudentStruct(LineRecord);

                    if (Record.StudentID.ToString() == MentorID)
                        return Record;
                }
                Record.StudentID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsStudent> Records = _LoadMentorsDataFromFile();

            foreach (clsStudent Record in Records)
            {
                stStudent CurrentRecord = _ConvertToStruct(Record);
                _AddToTable(CurrentRecord, Lv);
            }
        }



        static stStudentDetails _ConvertToStudentStruct(string[] Records)
        {
            stStudentDetails Record = new stStudentDetails();
            Record.StudentID = Convert.ToInt32(Records[0]);
            Record.StudentName = Records[1];

            return Record;
        }
        public static stStudentDetails _ConvertLineToStudentDetailsStruct(string LineOfRecord, string Delim = " - ")
        {

            string[] Records = LineOfRecord.Split(new string[] { Delim }, StringSplitOptions.None);

            stStudentDetails Record = _ConvertToStudentStruct(Records);

            return Record;
        }


        static public List<string> GetStudents(int Year)
        {
            List<string> Students = new List<string>();

            using (StreamReader Records = new StreamReader("Students.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    stStudent Student = _ConvertLineToStudentStruct(LineRecord);

                    if (Student._YearNumber == Year)
                        Students.Add(Student.StudentID + " - " + Student.Person._Name);
                }
                Records.Close();
                return Students;

            }

        }

    }
}
