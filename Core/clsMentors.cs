using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;

namespace DeskEtu.Core
{
    internal class clsMentors : clsPerson
    {
        stMentor Mentor;
        public clsMentors(stPerson Person , stMentor Mentor) : base(Person)
        {
            this.Mentor = Mentor;
        }


        // Struct record methods
        static stMentor _ConvertToStruct(string[] Records)
        {
            stMentor Record = new stMentor();
            Record.MentorID = Convert.ToInt32(Records[0]);
            Record.Person._Name = Records[1];
            Record.Person._Gender = Records[2];
            Record.Person._DateOfBirth = Convert.ToDateTime(Records[3]);
            Record.Person._Email = Records[4];
            Record.Person._Phone = Records[5];
            Record.Salary = Convert.ToSingle(Records[6]);
            return Record;
        }
        static stMentor _ConvertToStruct(clsMentors Records)
        {
            stMentor Record = new stMentor(); // لاحظ هنا انني لم اهيئه هل هذا مقبول
            Record.MentorID = Records.Mentor.MentorID;
            Record.Person._Name = Records.Mentor.Person._Name;
            Record.Person._Gender = Records.Mentor.Person._Gender;
            Record.Person._DateOfBirth = Records.Mentor.Person._DateOfBirth;
            Record.Person._Email = Records.Mentor.Person._Email;
            Record.Person._Phone = Records.Mentor.Person._Phone;
            Record.Salary = Records.Mentor.Salary;
            return Record;
        }

        // Save & upload data
        static clsMentors _ConvertLineToMentorObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stMentor Record = _ConvertToStruct(Records);

            return new clsMentors(Record.Person , Record);
        }
        static List<clsMentors> _LoadMentorsDataFromFile()
        {
            List<clsMentors> ListOfRecords = new List<clsMentors>();

            if (!File.Exists("Mentors.txt"))
            {
                using (FileStream FS = File.Create("Mentors.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Mentors.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsMentors Data = _ConvertLineToMentorObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }

        }
        static void _AddToTable(stMentor Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record.MentorID.ToString());
            Item.SubItems.Add(Record.Person._Name.ToString());
            Item.SubItems.Add(Record.Person._Gender.ToString());
            Item.SubItems.Add(Record.Person._DateOfBirth.ToString("dd-MM-yyyy"));
            Item.SubItems.Add(Record.Person._Email.ToString());
            Item.SubItems.Add(Record.Person._Phone.ToString());
            Item.SubItems.Add(Record.Salary.ToString());
            Lv.Items.Add(Item);
        }
        public static stMentor _ConvertLineToMentorStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stMentor Record = _ConvertToStruct(Records);

            return Record;
        }
        static public stMentor FindStructRecord(string MentorID)
        {
            using (StreamReader MentorRecords = new StreamReader("Mentors.txt"))
            {
                string LineRecord;
                stMentor Record = new stMentor() ;
                while ((LineRecord = MentorRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToMentorStruct(LineRecord);

                    if (Record.MentorID.ToString() == MentorID)
                        return Record;
                }
                Record.MentorID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsMentors> Records = _LoadMentorsDataFromFile();

            foreach (clsMentors Record in Records)
            {
                stMentor CurrentRecord = _ConvertToStruct(Record);
                _AddToTable(CurrentRecord, Lv);
            }
        }
    }
}
