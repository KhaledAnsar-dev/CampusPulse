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
using DeskEtu.Core;
using static DeskEtu.Core.clsGroup;
using static DeskEtu.Core.clsCohort;

using static DeskEtu.Additional.clsStructs;

using static DeskEtu.Libraries.clsInputValidate;
using System.IO;
using DeskEtu.Additional;

namespace DeskEtu
{
    public partial class GroupsScreen : ListScreen
    {
        public GroupsScreen()
        {
            InitializeComponent();

            btnAddGroup.MouseEnter += Add_Enter;
            btnAddGroup.MouseLeave += Add_Leave;

            btnUpdateGroup.MouseEnter += Update_Delete_Enter;
            btnUpdateGroup.MouseLeave += Update_Delete_Leave;

            btnDeleteGroup.MouseEnter += Update_Delete_Enter;
            btnDeleteGroup.MouseLeave += Update_Delete_Leave;

            ImageActivator.QA_Structure_ActivateImage(btnQA_Structure);
            btnQA_Structure.Enabled = false;

            NavigationManager Menu = new NavigationManager();

            lblCohorts.Click += Menu.GoToCohorts_Click;

            lblCohorts.MouseEnter += Menu.MenuHovring;
            lblCohorts.MouseLeave += Menu.MenuLeft;

            // Activate Search Bar
            cbFind_Group.Click += SearchBarClick;
            cbFind_Group.MouseLeave += SearchBarLeave;
            pbFind_Group.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;
        }

        // Get a copy of table data set to perform find opperation more quickly
        List<ListViewItem> TempRecords = new List<ListViewItem>();


        public void GenerateColumnsForlvGroups()
        {
            lvGroups.Columns.Add("Group ID", 390, HorizontalAlignment.Center);
            lvGroups.Columns.Add("Year Number", 380, HorizontalAlignment.Center);
            lvGroups.Columns.Add("Group Number", 380, HorizontalAlignment.Center);
            lvGroups.GridLines = true;
        }

        private void GroupsScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvGroups();

            clsGroup.UploadRecords(lvGroups);

            foreach (ListViewItem GetRecord in lvGroups.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            ReformGroups Page = new ReformGroups(this.lvGroups);
            Page.ShowDialog();
        }
        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (lvGroups.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            } 
            if (lvGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {
                if (IsUsed())
                {
                    MessageBox.Show("This group is used in other cohorts and cannot be edited.");
                    return;

                }

                stGroup SelectedRecord = new stGroup();

                SelectedRecord._GroupID = Convert.ToInt32(lvGroups.SelectedItems[0].Text);
                SelectedRecord._YearNumber = Convert.ToInt32(lvGroups.SelectedItems[0].SubItems[1].Text);
                SelectedRecord._GroupNumber = Convert.ToInt32(lvGroups.SelectedItems[0].SubItems[2].Text);

                ReformGroups Page = new ReformGroups(this.lvGroups , SelectedRecord);
                Page.ShowDialog();
            }
        }

        // Get the Data copy after searching 
        private void FillTable(object sender, EventArgs e)
        {
            if (lvGroups.Items.Count > 1)
                return;

            if (cbFind_Group.Text == cbFind_Group.Tag.ToString() || cbFind_Group.Text == "")
            {
                lvGroups.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvGroups.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Group.Text == cbFind_Group.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Group.Text))
            {
                stGroup Record = clsGroup.FindStructRecord(cbFind_Group.Text);

                // -99 means is not found
                if (Record._GroupID != -99)
                {
                    lvGroups.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record._GroupID.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());
                    Item.SubItems.Add(Record._GroupNumber.ToString());

                    lvGroups.Items.Add(Item);
                }
                else
                {
                    cbFind_Group.Text = cbFind_Group.Tag.ToString();
                    MessageBox.Show("Group Not Found");
                }
            }
            else
            {
                cbFind_Group.Text = cbFind_Group.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }

        }

        bool IsUsed()
        {
            List<clsCohort> Records = _LoadCohortsDataFromFile();

            foreach (clsCohort Record in Records)
            {
                if (lvGroups.SelectedItems[0].SubItems[1].Text == Record.CohortRecord._YearNumber.ToString() && lvGroups.SelectedItems[0].SubItems[2].Text == Record.CohortRecord._GroupNumber.ToString())
                {
                    return true;
                }
            }

            return false;
        }
        void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter("Groups.txt", false))
            {
                foreach (ListViewItem item in lvGroups.Items)
                {
                    string line = GetLineOfRecords(item.Text, item.SubItems[1].Text, item.SubItems[2].Text);
                    writer.WriteLine(line);
                }
            }
        }
        void DeleteGroup()
        {
            if (lvGroups.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {

                if (MessageBox.Show("Are you sure you want to delete this group?", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (IsUsed())
                    {
                        MessageBox.Show("This group is used in other cohorts and cannot be deleted.");
                        return;

                    }

                    lvGroups.SelectedItems[0].Remove();
                    UpdateFile();


                }

            }
        }
        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            DeleteGroup();

        }
    }
}
