using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using DeskEtu.Additional;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;

namespace DeskEtu.Core
{
    internal class clsGroup
    {
        // Private members
        stGroup GroupRecord = new stGroup();
        

        // Struct record methods
        static stGroup _ConvertToStruct(string[] Records)
        {
            stGroup Record = new stGroup();
            Record._GroupID = Convert.ToInt32(Records[0]);
            Record._YearNumber = Convert.ToInt32(Records[1]);
            Record._GroupNumber = Convert.ToInt32(Records[2]);

            return Record;
        }
        static stGroup _ConvertToStruct(clsGroup Records)
        {
            stGroup Record = new stGroup();
            Record._GroupID = Records.GroupRecord._GroupID;
            Record._YearNumber = Records.GroupRecord._YearNumber;
            Record._GroupNumber = Records.GroupRecord._GroupNumber;

            return Record;
        }

        // Save & upload data
        static clsGroup _ConvertLineToGroupObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" } ,StringSplitOptions.None);

            stGroup Record = _ConvertToStruct(Records);  

            return new clsGroup(Record);
        }
        static List<clsGroup> _LoadGroupsDataFromFile()
        {
            List<clsGroup> ListOfRecords = new List<clsGroup>() ;

            if(!File.Exists("Groups.txt"))
            {
                using(FileStream FS = File.Create("Groups.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Groups.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsGroup Data = _ConvertLineToGroupObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }
            
        }
        static string _ConvertGroupObjectToLine(clsGroup Group, string Seperator = "#//#")
        {
            string RecordData = "";
            RecordData += Group.GroupRecord._GroupID + Seperator;
            RecordData += Group.GroupRecord._YearNumber + Seperator;
            RecordData += Group.GroupRecord._GroupNumber;

            return RecordData;
        }
        static void _SaveDataFromListToFile(List<clsGroup> GroupData)
        {

            string RecordLine = "";

            using(StreamWriter GroupRecords = new StreamWriter("Groups.txt"))
            {
                foreach(clsGroup Group in GroupData)
                {
                    if(Group.GroupRecord._MarkedForDelete != true)
                    {
                        RecordLine = _ConvertGroupObjectToLine(Group);

                        GroupRecords.WriteLine(RecordLine);
                    }
                }
            }
        }

        // Perform Create opperation methods
        static string _GetLine(stGroup GroupRecord)
        {
            return GroupRecord._GroupID + "#//#" + GroupRecord._YearNumber + "#//#" + GroupRecord._GroupNumber;
        }
        static Boolean _LoadThanCheckIfExists(stGroup FullRecord)
        {
            List<clsGroup> Records = _LoadGroupsDataFromFile();

            if(Records.Count == 0)
                return true;

            foreach(clsGroup Record in Records)
            {
                if((Record.GroupRecord._YearNumber == FullRecord._YearNumber) && (Record.GroupRecord._GroupNumber == FullRecord._GroupNumber))
                {
                    return false;
                }
            }
            return true;
        }
        public static void _SaveNewLine(string NewLine, bool append = true)
        {
            using(StreamWriter Record = new StreamWriter("Groups.txt" , append))
            {
                Record.WriteLine(NewLine);
            }
        }

        public static void TxtEvacuation()
        {
            File.WriteAllText("Groups.txt", string.Empty);
        }
        static void _AddToTable(stGroup Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record._GroupID.ToString());
            Item.SubItems.Add(Record._YearNumber.ToString());
            Item.SubItems.Add(Record._GroupNumber.ToString());

            Lv.Items.Add(Item);
        }
        public static stGroup _GetFullRecord(int GroupID ,string Year, string GroupNumber)
        {
            stGroup Record = new stGroup();

            Record._GroupID = GroupID;
            Record._YearNumber = Convert.ToInt32(Year);
            Record._GroupNumber = Convert.ToInt32(GroupNumber);

            return Record;
        }

        // Perform Update opperation methods
        static void _UpdateTable(stGroup Record, ListView Lv)
        {
            Lv.SelectedItems[0].Text = Record._GroupID.ToString();
            Lv.SelectedItems[0].SubItems[1].Text = Record._YearNumber.ToString();
            Lv.SelectedItems[0].SubItems[2].Text = Record._GroupNumber.ToString();
        }
        static void _UpdataDataSource(stGroup UpdatedRecord)
        {
            List<clsGroup> Records = _LoadGroupsDataFromFile();

            foreach (clsGroup Record in Records)
            {
                if ((Record.GroupRecord._GroupID == UpdatedRecord._GroupID))
                {
                    Record.GroupRecord._YearNumber = UpdatedRecord._YearNumber;
                    Record.GroupRecord._GroupNumber = UpdatedRecord._GroupNumber;
                    break;
                }
            }
            _SaveDataFromListToFile(Records);
        }



        // Public Members
        public static stGroup _ConvertLineToGroupStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stGroup Record = _ConvertToStruct(Records);

            return Record;
        }
        static public List<int> GetYears()
        {
            List<int> ListOfRecords = new List<int>();

            using (StreamReader Records = new StreamReader("Years.txt"))
            {
                string LineRecord;

                while ((LineRecord = Records.ReadLine()) != null)
                {
                    ListOfRecords.Add(Convert.ToInt32(LineRecord));
                }
                Records.Close();
                return ListOfRecords;

            }

        }
        public clsGroup(stGroup Record)
        {
            GroupRecord._GroupID = Record._GroupID;
            GroupRecord._YearNumber = Record._YearNumber;
            GroupRecord._GroupNumber = Record._GroupNumber;
        }
        static public bool AddRecord(stGroup InitialRecord , ListView Lv)
        {
            clsLastNums LastIDs = new clsLastNums();

            LastIDs.IDs.LastGroup += 1;

            stGroup FullRecord = _GetFullRecord(LastIDs.IDs.LastGroup , InitialRecord._YearNumber.ToString(), InitialRecord._GroupNumber.ToString()); 

            if(_LoadThanCheckIfExists(FullRecord))
            {
                LastIDs.UpdateRecord();
                _AddToTable(FullRecord, Lv);
                _SaveNewLine(_GetLine(FullRecord));
                return true;
            }
            else
            {
                LastIDs.IDs.LastGroup -= 1;
                return false;
            }
        }
        static public bool UpdateRecord(stGroup UpdatedRecord, ListView Lv)
        {
            if (_LoadThanCheckIfExists(UpdatedRecord))
            {
                _UpdateTable(UpdatedRecord , Lv);
                _UpdataDataSource(UpdatedRecord);
                return true;

            }
            else
                return false;
        }
        static public stGroup FindStructRecord(string GroupID)
        {
            using (StreamReader GroupRecords = new StreamReader("Groups.txt"))
            {
                string LineRecord;
                stGroup Record = new stGroup();
                while ((LineRecord = GroupRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToGroupStruct(LineRecord);

                    if (Record._GroupID.ToString() == GroupID)
                        return Record;
                }
                Record._GroupID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsGroup> Records = clsGroup._LoadGroupsDataFromFile();

            foreach (clsGroup Record in Records)
            {
                stGroup CurrentRecord = _ConvertToStruct(Record);

                _AddToTable(CurrentRecord, Lv);
            }
        }

        public static string GetLineOfRecords(string ID , string Year , string Group , string Separator = "#//#")
        {
            return ID + Separator + Year + Separator + Group;
        }
        /*
                 static public clsGroup Find(string GroupID)
        {
            //List<clsGroup> ListOfGroupObjects = new List<clsGroup>();
            using (StreamReader GroupRecords = new StreamReader("Groups.txt"))
            {
                string LineRecord;
                clsGroup Record = null;

                while ((LineRecord = GroupRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToGroupObject(LineRecord);

                    if (Record.GroupRecord._GroupID.ToString() == GroupID)
                        return Record;
                }
            }
            return null;
        }

         */
    }
}
