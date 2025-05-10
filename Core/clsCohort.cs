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



namespace DeskEtu.Core
{
    internal class clsCohort
    {
        public stCohort CohortRecord = new stCohort();

        // Struct record methods
        static stCohort _ConvertToStruct(string[] Records)
        {
            stCohort Record = new stCohort();
            Record._CohortID = Convert.ToInt32(Records[0]);
            Record._YearNumber = Convert.ToInt32(Records[1]);
            Record._GroupNumber = Convert.ToInt32(Records[2]);
            Record._CohortNumber = Convert.ToInt32(Records[3]);

            return Record;
        }
        static stCohort _ConvertToStruct(clsCohort Records)
        {
            stCohort Record = new stCohort();
            Record._CohortID = Records.CohortRecord._CohortID;
            Record._YearNumber = Records.CohortRecord._YearNumber;
            Record._GroupNumber = Records.CohortRecord._GroupNumber;
            Record._CohortNumber = Records.CohortRecord._CohortNumber;


            return Record;
        }

        // Save & upload data
        static clsCohort _ConvertLineToCohortObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stCohort Record = _ConvertToStruct(Records);

            return new clsCohort(Record);
        }
        public static List<clsCohort> _LoadCohortsDataFromFile()
        {
            List<clsCohort> ListOfRecords = new List<clsCohort>();

            if (!File.Exists("Cohorts.txt"))
            {
                using (FileStream FS = File.Create("Cohorts.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Cohorts.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsCohort Data = _ConvertLineToCohortObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }

        }
        static string _ConvertCohortObjectToLine(clsCohort Cohort, string Seperator = "#//#")
        {
            string RecordData = "";
            RecordData += Cohort.CohortRecord._CohortID + Seperator;
            RecordData += Cohort.CohortRecord._YearNumber + Seperator;
            RecordData += Cohort.CohortRecord._GroupNumber + Seperator;
            RecordData += Cohort.CohortRecord._CohortNumber;

            return RecordData;
        }
        static void _SaveDataFromListToFile(List<clsCohort> Records)
        {

            string RecordLine = "";

            using (StreamWriter GroupRecords = new StreamWriter("Groups.txt"))
            {
                foreach (clsCohort Record in Records)
                {
                    if (Record.CohortRecord._MarkedForDelete != true)
                    {
                        RecordLine = _ConvertCohortObjectToLine(Record);

                        GroupRecords.WriteLine(RecordLine);
                    }
                }
            }
        }

        // Perform Create opperation methods
        static string _GetLine(stCohort CohortRecord)
        {
            return CohortRecord._CohortID + "#//#" + CohortRecord._YearNumber + "#//#" + CohortRecord._GroupNumber + "#//#" + CohortRecord._CohortNumber;
        }
        static Boolean _LoadThanCheckIfExists(stCohort FullRecord)
        {
            List<clsCohort> Records = _LoadCohortsDataFromFile();

            if (Records.Count == 0)
                return true;

            foreach (clsCohort Record in Records)
            {
                if ((Record.CohortRecord._YearNumber == FullRecord._YearNumber) && (Record.CohortRecord._GroupNumber == FullRecord._GroupNumber) && (Record.CohortRecord._CohortNumber == FullRecord._CohortNumber))
                {
                    return false;
                }
            }
            return true;
        }
        static void _SaveNewLine(string NewLine)
        {
            using (StreamWriter Record = new StreamWriter("Cohorts.txt", true))
            {
                Record.WriteLine(NewLine);
            }
        }
        static void _AddToTable(stCohort Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record._CohortID.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());
            Item.SubItems.Add(Record._GroupNumber.ToString());
            Item.SubItems.Add(Record._CohortNumber.ToString());
            Lv.Items.Add(Item);
        }
        static stCohort _GetFullRecord(int CohortID,string Year, string GroupNumber , string CohortNumber)
        {
            stCohort Record = new stCohort();

            Record._CohortID = CohortID;
            Record._YearNumber = Convert.ToInt32(Year);
            Record._GroupNumber = Convert.ToInt32(GroupNumber);
            Record._CohortNumber = Convert.ToInt32(CohortNumber);

            return Record;
        }

        // Perform Update opperation methods
        static void _UpdateTable(stCohort Record, ListView Lv)
        {
            Lv.SelectedItems[0].Text = Record._CohortID.ToString();
            Lv.SelectedItems[0].SubItems[1].Text = Record._YearNumber.ToString();
            Lv.SelectedItems[0].SubItems[2].Text = Record._GroupNumber.ToString();
            Lv.SelectedItems[0].SubItems[3].Text = Record._CohortNumber.ToString();

        }
        static void _UpdataDataSource(stCohort UpdatedRecord)
        {
            List<clsCohort> Records = _LoadCohortsDataFromFile();

            foreach (clsCohort Record in Records)
            {
                if ((Record.CohortRecord._CohortID == UpdatedRecord._CohortID))
                {
                    Record.CohortRecord._YearNumber = UpdatedRecord._YearNumber;
                    Record.CohortRecord._GroupNumber = UpdatedRecord._GroupNumber;
                    Record.CohortRecord._CohortNumber = UpdatedRecord._CohortNumber;

                    break;
                }
            }
            _SaveDataFromListToFile(Records);
        }



        // Public Members
        public clsCohort(stCohort Record)
        {
            CohortRecord._CohortID = Record._CohortID;
            CohortRecord._YearNumber = Record._YearNumber;
            CohortRecord._GroupNumber = Record._GroupNumber;
            CohortRecord._CohortNumber = Record._CohortNumber;

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
        static public bool AddRecord(stCohort InitialRecord, ListView Lv)
        {
            clsLastNums LastIDs = new clsLastNums();

            LastIDs.IDs.LastCohort += 1;

            stCohort FullRecord = _GetFullRecord(LastIDs.IDs.LastCohort , InitialRecord._YearNumber.ToString(), InitialRecord._GroupNumber.ToString(), InitialRecord._CohortNumber.ToString());

            if (_LoadThanCheckIfExists(FullRecord))
            {
                LastIDs.UpdateRecord();
                _AddToTable(FullRecord, Lv);
                _SaveNewLine(_GetLine(FullRecord));
                return true;
            }
            else
            {
                LastIDs.IDs.LastCohort -= 1;
                return false;
            }
        }
        static public bool UpdateRecord(stCohort UpdatedRecord, ListView Lv)
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
        static public stCohort FindStructRecord(string CohortID)
        {
            using (StreamReader GroupRecords = new StreamReader("Cohorts.txt"))
            {
                string LineRecord;
                stCohort Record = new stCohort();
                while ((LineRecord = GroupRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToCohortStruct(LineRecord);

                    if (Record._CohortID.ToString() == CohortID)
                        return Record;
                }
                Record._CohortID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsCohort> Records = clsCohort._LoadCohortsDataFromFile();

            foreach (clsCohort Record in Records)
            {
                stCohort CurrentRecord = _ConvertToStruct(Record);

                _AddToTable(CurrentRecord, Lv);
            }
        }
        public static stCohort _ConvertLineToCohortStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stCohort Record = _ConvertToStruct(Records);

            return Record;
        }
        public static string GetLineOfRecords(string ID, string Year, string Group , string Cohort, string Separator = "#//#")
        {
            return ID + Separator + Year + Separator + Group + Separator + Cohort;
        }


    }
}
