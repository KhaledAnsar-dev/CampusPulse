using DeskEtu.Core;
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
using static DeskEtu.Core.clsStudent;
using static DeskEtu.Libraries.clsInputValidate;


namespace DeskEtu
{
    public partial class StudentsScreen : ListScreen
    {
        public StudentsScreen()
        {
            InitializeComponent();

            DeactivateQuickAccessBar();

            // Activate Search Bar
            cbFind_Students.Click += SearchBarClick;
            cbFind_Students.MouseLeave += SearchBarLeave;
            pbFind_Students.MouseEnter += SearchBarEnter;

            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;
        }
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvCourses()
        {
            lvStudents.Columns.Add("Student ID", 120, HorizontalAlignment.Center);
            lvStudents.Columns.Add("Student Name", 250, HorizontalAlignment.Center);
            lvStudents.Columns.Add("Gender", 100, HorizontalAlignment.Center);
            lvStudents.Columns.Add("Date of birth", 160, HorizontalAlignment.Center);
            lvStudents.Columns.Add("Email", 300, HorizontalAlignment.Center);
            lvStudents.Columns.Add("Phone", 140, HorizontalAlignment.Center);
            lvStudents.Columns.Add("Year", 80, HorizontalAlignment.Center);

            lvStudents.GridLines = true;
        }
        private void StudentsScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvCourses();
            UploadRecords(lvStudents);

            foreach (ListViewItem GetRecord in lvStudents.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void FillTable(object sender, EventArgs e)
        {
            if (lvStudents.Items.Count > 1)
                return;

            if (cbFind_Students.Text == cbFind_Students.Tag.ToString() || cbFind_Students.Text == "")
            {
                lvStudents.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvStudents.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindSingleRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Students.Text == cbFind_Students.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Students.Text))
            {
                stStudent Record = FindStructRecord(cbFind_Students.Text);

                // -99 means is not found
                if (Record.StudentID != -99)
                {
                    lvStudents.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record.StudentID.ToString());
                    Item.SubItems.Add(Record.Person._Name.ToString());
                    Item.SubItems.Add(Record.Person._Gender.ToString());
                    Item.SubItems.Add(Record.Person._DateOfBirth.ToString("dd-MM-yyyy"));
                    Item.SubItems.Add(Record.Person._Email.ToString());
                    Item.SubItems.Add(Record.Person._Phone.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());

                    lvStudents.Items.Add(Item);
                }
                else
                {
                    cbFind_Students.Text = cbFind_Students.Tag.ToString();
                    MessageBox.Show("Course Not Found");
                }
            }
            else
            {
                cbFind_Students.Text = cbFind_Students.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }

    }
}
