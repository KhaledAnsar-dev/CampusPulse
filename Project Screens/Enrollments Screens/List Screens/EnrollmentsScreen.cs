using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Libraries.clsInputValidate;
using static DeskEtu.Core.clsEnrollment;
using DeskEtu.Project_Screens.Enrollments_Screens.Manipulation_Screens;
using DeskEtu.Core;
using System.IO;

namespace DeskEtu
{
    public partial class EnrollmentsScreen : ListScreen
    {
        public EnrollmentsScreen()
        {
            InitializeComponent();

            btnAddEnrollmnet.MouseEnter += Add_Enter;
            btnAddEnrollmnet.MouseLeave += Add_Leave;

            btnUpdateEnrollment.MouseEnter += Update_Delete_Enter;
            btnUpdateEnrollment.MouseLeave += Update_Delete_Leave;

            btnDeleteEnrollment.MouseEnter += Update_Delete_Enter;
            btnDeleteEnrollment.MouseLeave += Update_Delete_Leave;

            // Activate Menu

            NavigationManager Menu = new NavigationManager();

            lblStudents.Click += Menu.GoToStudents_Click;

            lblStudents.MouseEnter += Menu.MenuHovring;
            lblStudents.MouseLeave += Menu.MenuLeft;

  

            //
            ImageActivator.QA_Enrollments_ActivateImage(btnQA_Enrollment);
            btnQA_Enrollment.Enabled = false;

    
            // Activate Search Bar
            cbFind_Enrollment.Click += SearchBarClick;
            cbFind_Enrollment.MouseLeave += SearchBarLeave;
            pbFind_Enrollment.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;
        }
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvTeachings()
        {
            lvEnrollments.Columns.Add("Enrollment ID", 180, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Year", 100, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Group", 100, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Cohort", 100, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Course Name", 400, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Mentor ID", 100, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Mentor Name", 350, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Student ID", 150, HorizontalAlignment.Center);
            lvEnrollments.Columns.Add("Student Name", 350, HorizontalAlignment.Center);

            lvEnrollments.GridLines = true;
        }


        // Get the Data copy after searching 
        private void FillTable(object sender, EventArgs e)
        {
            if (lvEnrollments.Items.Count > 1)
                return;

            if (cbFind_Enrollment.Text == cbFind_Enrollment.Tag.ToString() || cbFind_Enrollment.Text == "")
            {
                lvEnrollments.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvEnrollments.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Enrollment.Text == cbFind_Enrollment.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Enrollment.Text))
            {
                stEnrollment Record = FindStructRecord(cbFind_Enrollment.Text);

                // -99 means is not found
                if (Record._EnrollmentID != -99)
                {
                    lvEnrollments.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record._EnrollmentID.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());
                    Item.SubItems.Add(Record._GroupNumber.ToString());
                    Item.SubItems.Add(Record._CohortNumber.ToString());
                    Item.SubItems.Add(Record._CourseName);
                    Item.SubItems.Add(Record._MentorID.ToString());
                    Item.SubItems.Add(Record._MentorName);
                    Item.SubItems.Add(Record._StudentID.ToString());
                    Item.SubItems.Add(Record._StudentName);
                    Item.SubItems.Add(Record._ExamGrade);

                    lvEnrollments.Items.Add(Item);
                }
                else
                {
                    cbFind_Enrollment.Text = cbFind_Enrollment.Tag.ToString();
                    MessageBox.Show("Enrollment Not Found");
                }
            }
            else
            {
                cbFind_Enrollment.Text = cbFind_Enrollment.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }
        private void EnrollmentScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvTeachings();

            UploadRecords(lvEnrollments);

            foreach (ListViewItem GetRecord in lvEnrollments.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void AddEnrollment_Click(object sender, EventArgs e)
        {
            ReformEnrollment Page = new ReformEnrollment(this.lvEnrollments);
            Page.ShowDialog();
        }
        private void UpdateEnrollment_Click(object sender, EventArgs e)
        {
            if (lvEnrollments.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvEnrollments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {

                stEnrollment SelectedRecord = new stEnrollment();

                SelectedRecord._EnrollmentID = Convert.ToInt32(lvEnrollments.SelectedItems[0].Text);
                SelectedRecord._YearNumber = Convert.ToInt32(lvEnrollments.SelectedItems[0].SubItems[1].Text);
                SelectedRecord._GroupNumber = Convert.ToInt32(lvEnrollments.SelectedItems[0].SubItems[2].Text);
                SelectedRecord._CohortNumber = Convert.ToInt32(lvEnrollments.SelectedItems[0].SubItems[3].Text);
                SelectedRecord._CourseName = lvEnrollments.SelectedItems[0].SubItems[4].Text;
                SelectedRecord._MentorID = Convert.ToInt32(lvEnrollments.SelectedItems[0].SubItems[5].Text);
                SelectedRecord._MentorName = lvEnrollments.SelectedItems[0].SubItems[6].Text;
                SelectedRecord._StudentID = Convert.ToInt32(lvEnrollments.SelectedItems[0].SubItems[7].Text);
                SelectedRecord._StudentName = lvEnrollments.SelectedItems[0].SubItems[8].Text;

                ReformEnrollment Page = new ReformEnrollment(this.lvEnrollments, SelectedRecord);
                Page.ShowDialog();
            }
        }
        void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter("Enrollments.txt", false))
            {
                foreach (ListViewItem item in lvEnrollments.Items)
                {
                    string line = clsEnrollment.GetLineOfRecords(item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text);
                    writer.WriteLine(line);
                }
            }
        }
        void DeleteEnrollmnet()
        {
            if (lvEnrollments.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvEnrollments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {

                if (MessageBox.Show("Are you sure you want to delete this enrollment?", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    lvEnrollments.SelectedItems[0].Remove();
                    UpdateFile();


                }

            }
        }
        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            DeleteEnrollmnet();
        }
    }
}
