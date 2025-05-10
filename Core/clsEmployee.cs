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
    internal class clsEmployee : clsPerson
    {
        public stEmployee Employee;
        public clsEmployee(stPerson Person, stEmployee Employee) : base(Person)
        {
            this.Employee = Employee;
        }


        // Struct record methods
        static stEmployee _ConvertToStruct(string[] Records)
        {
            stEmployee Record = new stEmployee();
            Record.EmployeeID = Convert.ToInt32(Records[0]);
            Record.Person._Name = Records[1];
            Record.Person._Gender = Records[2];
            Record.Person._DateOfBirth = Convert.ToDateTime(Records[3]);
            Record.Person._Email = Records[4];
            Record.Person._Phone = Records[5];
            Record.Salary = Convert.ToSingle(Records[6]);
            Record.UserName = Records[7];
            Record.Password = Records[8];

            return Record;
        }
        static stEmployee _ConvertToStruct(clsEmployee Records)
        {
            stEmployee Record = new stEmployee(); // لاحظ هنا انني لم اهيئه هل هذا مقبول
            Record.EmployeeID = Records.Employee.EmployeeID;
            Record.Person._Name = Records.Employee.Person._Name;
            Record.Person._Gender = Records.Employee.Person._Gender;
            Record.Person._DateOfBirth = Records.Employee.Person._DateOfBirth;
            Record.Person._Email = Records.Employee.Person._Email;
            Record.Person._Phone = Records.Employee.Person._Phone;
            Record.Salary = Records.Employee.Salary;
            Record.UserName = Records.Employee.UserName;
            Record.Password = Records.Employee.Password;
            return Record;
        }

        // Save & upload data
        static clsEmployee _ConvertLineToEmployeeObject(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stEmployee Record = _ConvertToStruct(Records);

            return new clsEmployee(Record.Person, Record);
        }
        public static List<clsEmployee> _LoadEmployeeDataFromFile()
        {
            List<clsEmployee> ListOfRecords = new List<clsEmployee>();

            if (!File.Exists("Employee.txt"))
            {
                using (FileStream FS = File.Create("Employee.txt"))
                {
                    return ListOfRecords;
                }
            }
            else
            {
                using (StreamReader Records = new StreamReader("Employee.txt"))
                {
                    string LineRecord;

                    while ((LineRecord = Records.ReadLine()) != null)
                    {
                        clsEmployee Data = _ConvertLineToEmployeeObject(LineRecord);
                        ListOfRecords.Add(Data);
                    }
                    Records.Close();
                    return ListOfRecords;

                }
            }

        }
        static void _AddToTable(stEmployee Record, ListView Lv)
        {
            ListViewItem Item = new ListViewItem(Record.EmployeeID.ToString());
            Item.SubItems.Add(Record.Person._Name.ToString());
            Item.SubItems.Add(Record.Person._Gender.ToString());
            Item.SubItems.Add(Record.Person._DateOfBirth.ToString("dd-MM-yyyy"));
            Item.SubItems.Add(Record.Person._Email.ToString());
            Item.SubItems.Add(Record.Person._Phone.ToString());
            Item.SubItems.Add(Record.Salary.ToString());
            Item.SubItems.Add(Record.UserName);
            Item.SubItems.Add(Record.Password);
            Lv.Items.Add(Item);
        }
        public static stEmployee _ConvertLineToEmployeeStruct(string LineOfRecord, string Delim = "#//#")
        {

            string[] Records = LineOfRecord.Split(new string[] { "#//#" }, StringSplitOptions.None);

            stEmployee Record = _ConvertToStruct(Records);

            return Record;
        }
        static public stEmployee FindStructRecord(string EmployeeID)
        {
            using (StreamReader EmployeeRecords = new StreamReader("Employee.txt"))
            {
                string LineRecord;
                stEmployee Record = new stEmployee();
                while ((LineRecord = EmployeeRecords.ReadLine()) != null)
                {
                    Record = _ConvertLineToEmployeeStruct(LineRecord);

                    if (Record.EmployeeID.ToString() == EmployeeID)
                        return Record;
                }
                Record.EmployeeID = -99;
                return Record;

            }

        }
        public static void UploadRecords(ListView Lv)
        {
            List<clsEmployee> Records = _LoadEmployeeDataFromFile();

            foreach (clsEmployee Record in Records)
            {
                stEmployee CurrentRecord = _ConvertToStruct(Record);
                _AddToTable(CurrentRecord, Lv);
            }
        }
    }
}
