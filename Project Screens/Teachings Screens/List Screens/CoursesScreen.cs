using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Core.clsCourse;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Libraries.clsInputValidate;

namespace DeskEtu.Project_Screens.Teachings_Screens.List_Screens
{
    public partial class CoursesScreen : ListScreen
    {
        public CoursesScreen()
        {
            InitializeComponent();
            DeactivateQuickAccessBar();

            // Activate Search Bar
            cbFind_Course.Click += SearchBarClick;
            cbFind_Course.MouseLeave += SearchBarLeave;
            pbFind_Course.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;

        }
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvCourses()
        {
            lvCourses.Columns.Add("Course ID", 290, HorizontalAlignment.Center);
            lvCourses.Columns.Add("Course Name", 380, HorizontalAlignment.Center);
            lvCourses.Columns.Add("Year Number", 180, HorizontalAlignment.Center);
            lvCourses.Columns.Add("Credit Hours", 300, HorizontalAlignment.Center);

            lvCourses.GridLines = true;
        }
        private void FillTable(object sender, EventArgs e)
        {
            if (lvCourses.Items.Count > 1)
                return;

            if (cbFind_Course.Text == cbFind_Course.Tag.ToString() || cbFind_Course.Text == "")
            {
                lvCourses.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvCourses.Items.Add(GetRecord);
                }
            }
        }
        private void CoursesScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvCourses();
            UploadRecords(lvCourses);

            foreach (ListViewItem GetRecord in lvCourses.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void pbFindSingleRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Course.Text == cbFind_Course.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Course.Text))
            {
                stCourse Record = FindStructRecord(cbFind_Course.Text);

                // -99 means is not found
                if (Record._CourseID != -99)
                {
                    lvCourses.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record._CourseID.ToString());
                    Item.SubItems.Add(Record._CourseName.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());
                    Item.SubItems.Add(Record._CreditHours.ToString());

                    lvCourses.Items.Add(Item);
                }
                else
                {
                    cbFind_Course.Text = cbFind_Course.Tag.ToString();
                    MessageBox.Show("Course Not Found");
                }
            }
            else
            {
                cbFind_Course.Text = cbFind_Course.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }
    }
}
