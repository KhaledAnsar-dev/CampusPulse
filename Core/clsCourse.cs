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
    internal class clsCourse
    {
        stCourse CourseRecord ;

        // Struct record methods
        static stCourse _ConvertToStruct(string[] Records)
        {
            stCourse Record = new stCourse();
            Record._CourseID = Convert.ToInt32(Records[0]);
            Record._CourseName = Records[1];
            Record._YearNumber = Convert.ToInt32(Records[2]);
            Record._CreditHours = Convert.ToInt32(Records[3]);

            return Record;
        }
        static stCourse _ConvertToStruct(clsCourse Records)
        {
            stCourse Record = new stCourse();
            Record._CourseID = Records.CourseRecord._CourseID;
            Record._CourseName = Records.CourseRecord._CourseName;
            Record._YearNumber = Records.CourseRecord._YearNumber;
            Record._CreditHours= Records.CourseRecord._CreditHours;
            return Record;
        }

        // Save & upload data
        static clsCourse _ConvertLineToCourseObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stCourse Record = _ConvertToStruct(Records);

            return new clsCourse(Record);
        }
        static List<clsCourse> _LoadCoursesDataFromFile()
        {
            List<clsCourse> ListOfRecords = new List<clsCourse>();

            if (!File.Exists("Courses.txt"))
            {
                using (FileStream FS = File.Create("Courses.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Courses.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsCourse Data = _ConvertLineToCourseObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }

        }
        static void _AddToTable(stCourse Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record._CourseID.ToString());
            Item.SubItems.Add(Record._CourseName.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());
            Item.SubItems.Add(Record._CreditHours.ToString());
            Lv.Items.Add(Item);
        }
        public clsCourse(stCourse Record)
        {
            this.CourseRecord = Record;
        }

        public static stCourse _ConvertLineToCourseStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stCourse Record = _ConvertToStruct(Records);

            return Record;
        }
        static public stCourse FindStructRecord(string CourseID)
        {
            using (StreamReader GroupRecords = new StreamReader("Courses.txt"))
            {
                string LineRecord;
                stCourse Record = new stCourse();
                while ((LineRecord = GroupRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToCourseStruct(LineRecord);

                    if (Record._CourseID.ToString() == CourseID)
                        return Record;
                }
                Record._CourseID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsCourse> Records =  _LoadCoursesDataFromFile();

            foreach (clsCourse Record in Records)
            {
                stCourse CurrentRecord = _ConvertToStruct(Record);
                _AddToTable(CurrentRecord, Lv);
            }
        }
    }
}
