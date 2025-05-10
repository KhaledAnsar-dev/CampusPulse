using DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeskEtu.Core.clsCohort;
using static DeskEtu.Core.clsEnrollment;

using static DeskEtu.Additional.clsStructs;
using static DeskEtu.Libraries.clsInputValidate;
using DeskEtu.Core;
using System.IO;
using DeskEtu.Additional;

namespace DeskEtu
{
    public partial class CohortsScreen : ListScreen
    {
        public CohortsScreen()
        {
            InitializeComponent();

            DeactivateQuickAccessBar();
            btnAddCohort.MouseEnter += Add_Enter;
            btnAddCohort.MouseLeave += Add_Leave;

            btnUpdateCohort.MouseEnter += Update_Delete_Enter;
            btnUpdateCohort.MouseLeave += Update_Delete_Leave;

            btnDeleteCohort.MouseEnter += Update_Delete_Enter;
            btnDeleteCohort.MouseLeave += Update_Delete_Leave;


            // Activate Search Bar
            cbFind_Cohort.Click += SearchBarClick;
            cbFind_Cohort.MouseLeave += SearchBarLeave;
            pbFind_Cohort.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;
        }

        // Get a copy of table data set to perform find opperation more quickly
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvCohorts()
        {
            lvCohorts.Columns.Add("Cohort ID", 290, HorizontalAlignment.Center);
            lvCohorts.Columns.Add("Year Number", 280, HorizontalAlignment.Center);
            lvCohorts.Columns.Add("Group Number", 280, HorizontalAlignment.Center);
            lvCohorts.Columns.Add("Cohort Number", 300, HorizontalAlignment.Center);

            lvCohorts.GridLines = true;
        }


        // Get the Data copy after searching 
        private void FillTable(object sender, EventArgs e)
        {
            if (lvCohorts.Items.Count > 1)
                return;

            if (cbFind_Cohort.Text == cbFind_Cohort.Tag.ToString() || cbFind_Cohort.Text == "")
            {
                lvCohorts.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvCohorts.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Cohort.Text == cbFind_Cohort.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Cohort.Text))
            {
                stCohort Record = clsCohort.FindStructRecord(cbFind_Cohort.Text);

                // -99 means is not found
                if (Record._CohortID != -99)
                {
                    lvCohorts.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record._CohortID.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());
                    Item.SubItems.Add(Record._GroupNumber.ToString());
                    Item.SubItems.Add(Record._CohortNumber.ToString());

                    lvCohorts.Items.Add(Item);
                }
                else
                {
                    cbFind_Cohort.Text = cbFind_Cohort.Tag.ToString();
                    MessageBox.Show("Cohort Not Found");
                }
            }
            else
            {
                cbFind_Cohort.Text = cbFind_Cohort.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }

        }

        private void CohortsScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvCohorts();

            clsCohort.UploadRecords(lvCohorts);

            foreach (ListViewItem GetRecord in lvCohorts.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }

        private void AddCohort_Click(object sender, EventArgs e)
        {
            ReformCohorts Page = new ReformCohorts(this.lvCohorts);
            Page.ShowDialog();
        }

        private void UpdateCohort_Click(object sender, EventArgs e)
        {
            if (lvCohorts.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvCohorts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {
                if (IsUsed())
                {
                    MessageBox.Show("This cohort is used in other enrollments and cannot be edited.");
                    return;

                }

                stCohort SelectedRecord = new stCohort();

                SelectedRecord._CohortID = Convert.ToInt32(lvCohorts.SelectedItems[0].Text);
                SelectedRecord._YearNumber = Convert.ToInt32(lvCohorts.SelectedItems[0].SubItems[1].Text);
                SelectedRecord._GroupNumber = Convert.ToInt32(lvCohorts.SelectedItems[0].SubItems[2].Text);
                SelectedRecord._CohortNumber = Convert.ToInt32(lvCohorts.SelectedItems[0].SubItems[3].Text);

                ReformCohorts Page = new ReformCohorts(this.lvCohorts, SelectedRecord);
                Page.ShowDialog();
            }
        }

        bool IsUsed()
        {
            List<clsEnrollment> Records = _LoadEnrollmentsDataFromFile();

            foreach (clsEnrollment Record in Records)
            {
                if (lvCohorts.SelectedItems[0].SubItems[1].Text == Record.EnrollmentRecord._YearNumber.ToString() && lvCohorts.SelectedItems[0].SubItems[2].Text == Record.EnrollmentRecord._GroupNumber.ToString() && lvCohorts.SelectedItems[0].SubItems[3].Text == Record.EnrollmentRecord._CohortNumber.ToString())
                {
                    return true;
                }
            }

            return false;
        }
        void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter("Cohorts.txt", false))
            {
                foreach (ListViewItem item in lvCohorts.Items)
                {
                    string line = clsCohort.GetLineOfRecords(item.Text, item.SubItems[1].Text, item.SubItems[2].Text , item.SubItems[3].Text);
                    writer.WriteLine(line);
                }
            }
        }
        void DeleteCohort()
        {
            if (lvCohorts.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvCohorts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {

                if (MessageBox.Show("Are you sure you want to delete this cohort?", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (IsUsed())
                    {
                        MessageBox.Show("This cohort is used in other enrollments and cannot be deleted.");
                        return;

                    }

                    lvCohorts.SelectedItems[0].Remove();
                    UpdateFile();
                }

            }
        }

        private void btnDeleteCohort_Click(object sender, EventArgs e)
        {
            DeleteCohort();
        }
    }
}
