using DeskEtu.Core;
using DeskEtu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsEmployee;
using static DeskEtu.Libraries.clsInputValidate;

namespace DeskEtu
{
    public partial class EmployeesScreen : ListScreen
    {
        public EmployeesScreen()
        {
            InitializeComponent();

            //
            ImageActivator.QA_Employees_ActivateImage(btnQA_Employees);
            btnQA_Employees.Enabled = false;  
            
     
            // Activate Search Bar
            cbFind_Employee.Click += SearchBarClick;
            cbFind_Employee.MouseLeave += SearchBarLeave;
            pbFind_Employee.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;

        }
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvCourses()
        {
            lvEmployee.Columns.Add("Employee ID", 100, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Employee Name", 200, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Gender", 100, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Date of birth", 200, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Email", 330, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Phone", 120, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Salary", 100, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("UserName", 200, HorizontalAlignment.Center);
            lvEmployee.Columns.Add("Pasword", 200, HorizontalAlignment.Center);
            lvEmployee.GridLines = true;
        }
        private void Employee_Screen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvCourses();
            UploadRecords(lvEmployee);

            foreach (ListViewItem GetRecord in lvEmployee.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void FillTable(object sender, EventArgs e)
        {
            if (lvEmployee.Items.Count > 1)
                return;

            if (cbFind_Employee.Text == cbFind_Employee.Tag.ToString() || cbFind_Employee.Text == "")
            {
                lvEmployee.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvEmployee.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindSingleRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Employee.Text == cbFind_Employee.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Employee.Text))
            {
                stEmployee Record = FindStructRecord(cbFind_Employee.Text);

                // -99 means is not found
                if (Record.EmployeeID != -99)
                {
                    lvEmployee.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record.EmployeeID.ToString());
                    Item.SubItems.Add(Record.Person._Name.ToString());
                    Item.SubItems.Add(Record.Person._Gender.ToString());
                    Item.SubItems.Add(Record.Person._DateOfBirth.ToString("dd-MM-yyyy"));
                    Item.SubItems.Add(Record.Person._Email.ToString());
                    Item.SubItems.Add(Record.Person._Phone.ToString());
                    Item.SubItems.Add(Record.Salary.ToString());
                    Item.SubItems.Add(Record.UserName);
                    Item.SubItems.Add(Record.Password);

                    lvEmployee.Items.Add(Item);
                }
                else
                {
                    cbFind_Employee.Text = cbFind_Employee.Tag.ToString();
                    MessageBox.Show("Employee Not Found");
                }
            }
            else
            {
                cbFind_Employee.Text = cbFind_Employee.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }


    }
}
