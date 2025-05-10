using DeskEtu.Core;
using DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens;
using DeskEtu.Project_Screens.Teachings_Screens.Manipulation_Screens;
using DeskEtu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Core.clsTeaching;
using static DeskEtu.Core.clsEnrollment;
using static DeskEtu.Libraries.clsInputValidate;

namespace DeskEtu
{
    public partial class TeachingScreen : ListScreen
    {
        public TeachingScreen()
        {
            InitializeComponent();

            btnAddTeaching.MouseEnter += Add_Enter;
            btnAddTeaching.MouseLeave += Add_Leave;

            btnUpdateTeaching.MouseEnter += Update_Delete_Enter;
            btnUpdateTeaching.MouseLeave += Update_Delete_Leave;

            btnDeleteTeaching.MouseEnter += Update_Delete_Enter;
            btnDeleteTeaching.MouseLeave += Update_Delete_Leave;
            // Activate Menu

            NavigationManager Menu = new NavigationManager();

            lblMentors.Click += Menu.GoToMonitors_Click;

            lblMentors.MouseEnter += Menu.MenuHovring;
            lblMentors.MouseLeave += Menu.MenuLeft;

            lblCourses.Click += Menu.GoToCourses_Click;

            lblCourses.MouseEnter += Menu.MenuHovring;
            lblCourses.MouseLeave += Menu.MenuLeft;

            //
            ImageActivator.QA_Teachings_ActivateImage(btnQA_Teaching);
            btnQA_Teaching.Enabled = false;


            // Activate Search Bar
            cbFind_Teaching.Click += SearchBarClick;
            cbFind_Teaching.MouseLeave += SearchBarLeave;
            pbFind_Teaching.MouseEnter += SearchBarEnter;

            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;
        }

        // Get a copy of table data set to perform find opperation more quickly
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvTeachings()
        {
            lvTeachings.Columns.Add("Teaching ID", 190, HorizontalAlignment.Center);
            lvTeachings.Columns.Add("Year Number", 180, HorizontalAlignment.Center);
            lvTeachings.Columns.Add("Course Name", 400, HorizontalAlignment.Center);
            lvTeachings.Columns.Add("Mentor ID", 100, HorizontalAlignment.Center);
            lvTeachings.Columns.Add("Mentor Name", 280, HorizontalAlignment.Center);

            lvTeachings.GridLines = true;
        }


        // Get the Data copy after searching 
        private void FillTable(object sender, EventArgs e)
        {
            if (lvTeachings.Items.Count > 1)
                return;

            if (cbFind_Teaching.Text == cbFind_Teaching.Tag.ToString() || cbFind_Teaching.Text == "")
            {
                lvTeachings.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvTeachings.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Teaching.Text == cbFind_Teaching.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Teaching.Text))
            {
                stTeaching Record = clsTeaching.FindStructRecord(cbFind_Teaching.Text);

                // -99 means is not found
                if (Record._TeachingID != -99)
                {
                    lvTeachings.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record._TeachingID.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());
                    Item.SubItems.Add(Record._CourseName);
                    Item.SubItems.Add(Record._MentorID.ToString());
                    Item.SubItems.Add(Record._MentorName);

                    lvTeachings.Items.Add(Item);
                }
                else
                {
                    cbFind_Teaching.Text = cbFind_Teaching.Tag.ToString();
                    MessageBox.Show("Teaching Not Found");
                }
            }
            else
            {
                cbFind_Teaching.Text = cbFind_Teaching.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }

        private void TeachingsScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvTeachings();

            clsTeaching.UploadRecords(lvTeachings);

            foreach (ListViewItem GetRecord in lvTeachings.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void AddTeaching_Click(object sender, EventArgs e)
        {
            ReformTeachings Page = new ReformTeachings(this.lvTeachings);
            Page.ShowDialog();
        }
        private void UpdateTeaching_Click(object sender, EventArgs e)
        {
            if (lvTeachings.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvTeachings.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {
                if (IsUsed())
                {
                    MessageBox.Show("This teaching is used in other cohorts and cannot be edited.");
                    return;

                }

                stTeaching SelectedRecord = new stTeaching();

                SelectedRecord._TeachingID = Convert.ToInt32(lvTeachings.SelectedItems[0].Text);
                SelectedRecord._YearNumber = lvTeachings.SelectedItems[0].SubItems[1].Text;
                SelectedRecord._CourseName = lvTeachings.SelectedItems[0].SubItems[2].Text;
                SelectedRecord._MentorID = Convert.ToInt32(lvTeachings.SelectedItems[0].SubItems[3].Text);
                SelectedRecord._MentorName = lvTeachings.SelectedItems[0].SubItems[4].Text;

                ReformTeachings Page = new ReformTeachings(this.lvTeachings, SelectedRecord);
                Page.ShowDialog();
            }
        }


        bool IsUsed()
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();

            foreach (clsEnrollment Record in Records)
            {
                if (lvTeachings.SelectedItems[0].SubItems[1].Text == Record.EnrollmentRecord._YearNumber.ToString() && lvTeachings.SelectedItems[0].SubItems[2].Text == Record.EnrollmentRecord._CourseName.ToString() && lvTeachings.SelectedItems[0].SubItems[3].Text == Record.EnrollmentRecord._MentorID.ToString())
                {
                    return true;
                }
            }

            return false;
        }
        void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter("Teaching.txt", false))
            {
                foreach (ListViewItem item in lvTeachings.Items)
                {
                    string line = clsTeaching.GetLineOfRecords(item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text , item.SubItems[4].Text);
                    writer.WriteLine(line);
                }
            }
        }
        void DeleteTeaching()
        {
            if (lvTeachings.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvTeachings.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {

                if (MessageBox.Show("Are you sure you want to delete this teaching?", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (IsUsed())
                    {
                        MessageBox.Show("This teaching is used in other cohorts and cannot be deleted.");
                        return;

                    }

                    lvTeachings.SelectedItems[0].Remove();
                    UpdateFile();


                }

            }
        }

        private void btnDeleteTeaching_Click(object sender, EventArgs e)
        {
            DeleteTeaching();
        }
    }
}
