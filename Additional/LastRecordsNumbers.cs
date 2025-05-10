using DeskEtu.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskEtu.Additional
{
    internal class clsLastNums
    {


        public struct stLastNums
        {
            public int LastGroup { get; set; }
            public int LastCohort { get; set; }
            public int LastTeaching { get; set; }
            public int LastSession { get; set; }
            public int LastEnrollment { get; set; }
            public int LastEmployee { get; set; }
            public int LastResult { get; set; }

        }

        public stLastNums IDs = new stLastNums(); 

        clsLastNums GetInitialValues()
        {
            clsLastNums InitialNums = new clsLastNums(0, 0, 0, 0, 0, 0,0);

            return InitialNums;

        }

        clsLastNums _ConvertLineToLastNumsLineObject(string LineOfRecord, string Delim = "#//#")
        {
            List<string> Records = new List<string>();

            string[] StringLineRecords = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            //Records = StringLineRecords.ToList();

            return new clsLastNums(Convert.ToInt32(StringLineRecords[0]), Convert.ToInt32(StringLineRecords[1]), Convert.ToInt32(StringLineRecords[2]) ,Convert.ToInt32(StringLineRecords[3]), Convert.ToInt32(StringLineRecords[4]), Convert.ToInt32(StringLineRecords[5]), Convert.ToInt32(StringLineRecords[6]));
        }
        clsLastNums _LoadLastNumsDataFromFile()
        {

            if (!File.Exists("LastNumsLine.txt"))
            {
                using (FileStream FS = File.Create("LastNumsLine.txt"))
                {
                    return GetInitialValues();
                }
            }
            else
            {
                using (StreamReader Record = new StreamReader("LastNumsLine.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Record.ReadLine()) != null)
                    {
                        return _ConvertLineToLastNumsLineObject(LineRecord);
                    }

                    // if there is no line

                    return GetInitialValues();

                }

            }

            
        }
        string _ConvertLastNumsObjectToLine(clsLastNums Record, string Seperator = "#//#")
        {
            string RecordData = "";
            RecordData += Record.IDs.LastGroup + Seperator;
            RecordData += Record.IDs.LastCohort + Seperator;
            RecordData += Record.IDs.LastTeaching + Seperator;
            RecordData += Record.IDs.LastSession + Seperator;
            RecordData += Record.IDs.LastEmployee + Seperator;
            RecordData += Record.IDs.LastEnrollment + Seperator;
            RecordData += Record.IDs.LastResult;

            return RecordData;
        }
        void _SaveDataFromListToFile(clsLastNums Record)
        {

            string RecordLine = "";

            using (StreamWriter RecordFile = new StreamWriter("LastNumsLine.txt"))
            {
                RecordLine = _ConvertLastNumsObjectToLine(Record);
                RecordFile.WriteLine(RecordLine);
            }
        }


        // راجع last nums employee and enrollment
        public void UpdateRecord()
        {
            _SaveDataFromListToFile(this);
        }
        public clsLastNums()
        {
            clsLastNums Record = _LoadLastNumsDataFromFile();

            IDs.LastGroup = Record.IDs.LastGroup;
            IDs.LastCohort = Record.IDs.LastCohort;
            IDs.LastTeaching = Record.IDs.LastTeaching;
            IDs.LastSession = Record.IDs.LastSession;
            IDs.LastEnrollment = Record.IDs.LastEnrollment;
            IDs.LastEmployee = Record.IDs.LastEmployee;
            IDs.LastResult = Record.IDs.LastResult;

        }

        public clsLastNums(int Group , int Cohort , int Teaching , int Session , int Employee, int Enrollment , int Result)
        {
            IDs.LastGroup = Group;
            IDs.LastCohort = Cohort;
            IDs.LastTeaching = Teaching;
            IDs.LastSession = Session;
            IDs.LastEnrollment = Enrollment;
            IDs.LastEmployee = Employee;
            IDs.LastResult = Result;
        }
    }
}
