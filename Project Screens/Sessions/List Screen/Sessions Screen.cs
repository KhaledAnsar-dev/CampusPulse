using DeskEtu.Project_Screens.Teachings_Screens.Manipulation_Screens;
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
using static DeskEtu.Libraries.clsInputValidate;
using static DeskEtu.Core.clsSession;
using DeskEtu.Project_Screens.Sessions.Manipulation_Screens;

namespace DeskEtu
{
    public partial class Sessions_Screen : ListScreen
    {
        public Sessions_Screen()
        {
            InitializeComponent();

            btnAddSession.MouseEnter += Add_Enter;
            btnAddSession.MouseLeave += Add_Leave;

            btnUpdateSession.MouseEnter += Update_Delete_Enter;
            btnUpdateSession.MouseLeave += Update_Delete_Leave;

            btnDeleteSession.MouseEnter += Update_Delete_Enter;
            btnDeleteSession.MouseLeave += Update_Delete_Leave;

   
        

            // Activate Search Bar
            cbFind_Sessions.Click += SearchBarClick;
            cbFind_Sessions.MouseLeave += SearchBarLeave;
            pbFind_sessions.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;
        }

        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvTeachings()
        {
            lvSessions.Columns.Add("Session ID", 110, HorizontalAlignment.Center);
            lvSessions.Columns.Add("Year", 100, HorizontalAlignment.Center);
            lvSessions.Columns.Add("Group", 100, HorizontalAlignment.Center);
            lvSessions.Columns.Add("Cohort", 100, HorizontalAlignment.Center);
            lvSessions.Columns.Add("Course Name", 390, HorizontalAlignment.Center);
            lvSessions.Columns.Add("Mentor ID", 100, HorizontalAlignment.Center);
            lvSessions.Columns.Add("Mentor Name", 270, HorizontalAlignment.Center);


          
            lvSessions.GridLines = true;
        }


        // Get the Data copy after searching 
        private void FillTable(object sender, EventArgs e)
        {
            if (lvSessions.Items.Count > 1)
                return;

            if (cbFind_Sessions.Text == cbFind_Sessions.Tag.ToString() || cbFind_Sessions.Text == "")
            {
                lvSessions.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvSessions.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Sessions.Text == cbFind_Sessions.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Sessions.Text))
            {
                stSession Record = FindStructRecord(cbFind_Sessions.Text);

                // -99 means is not found
                if (Record._SessionID != -99)
                {
                    lvSessions.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record._SessionID.ToString());
                    Item.SubItems.Add(Record._YearNumber.ToString());
                    Item.SubItems.Add(Record._GroupNumber.ToString());
                    Item.SubItems.Add(Record._CohortNumber.ToString());
                    Item.SubItems.Add(Record._CourseName);
                    Item.SubItems.Add(Record._MentorID.ToString());
                    Item.SubItems.Add(Record._MentorName);

                    lvSessions.Items.Add(Item);
                }
                else
                {
                    cbFind_Sessions.Text = cbFind_Sessions.Tag.ToString();
                    MessageBox.Show("Session Not Found");
                }
            }
            else
            {
                cbFind_Sessions.Text = cbFind_Sessions.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }

        private void SessionsScreen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvTeachings();

            UploadRecords(lvSessions);

            foreach (ListViewItem GetRecord in lvSessions.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void AddSession_Click(object sender, EventArgs e)
        {
            ReformSessions Page = new ReformSessions(this.lvSessions);
            Page.ShowDialog();
        }
        private void UpdateSession_Click(object sender, EventArgs e)
        {
            if (lvSessions.Items.Count == 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            if (lvSessions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an item");
                return;
            }
            else
            {

                stSession SelectedRecord = new stSession();

                SelectedRecord._SessionID = Convert.ToInt32(lvSessions.SelectedItems[0].Text);
                SelectedRecord._YearNumber = Convert.ToInt32(lvSessions.SelectedItems[0].SubItems[1].Text);
                SelectedRecord._GroupNumber = Convert.ToInt32(lvSessions.SelectedItems[0].SubItems[2].Text);
                SelectedRecord._CohortNumber = Convert.ToInt32(lvSessions.SelectedItems[0].SubItems[3].Text);
                SelectedRecord._CourseName = lvSessions.SelectedItems[0].SubItems[4].Text;
                SelectedRecord._MentorID = Convert.ToInt32(lvSessions.SelectedItems[0].SubItems[5].Text);
                SelectedRecord._MentorName = lvSessions.SelectedItems[0].SubItems[6].Text;

                ReformSessions Page = new ReformSessions(this.lvSessions, SelectedRecord);
                Page.ShowDialog();
            }
        }
    }
}
