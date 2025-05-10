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
using static DeskEtu.Core.clsMentors;
using static DeskEtu.Libraries.clsInputValidate;


namespace DeskEtu
{
    public partial class Mentors_Screen : ListScreen
    {
        public Mentors_Screen()
        {
            InitializeComponent();
            DeactivateQuickAccessBar();


            // Activate Search Bar
            cbFind_Mentor.Click += SearchBarClick;
            cbFind_Mentor.MouseLeave += SearchBarLeave;
            pbFind_Mentor.MouseEnter += SearchBarEnter;
            pbFindSingleRecord.MouseLeave += FindIconLeave;
            pbFindSingleRecord.MouseEnter += FindIconEnter;

        }
        List<ListViewItem> TempRecords = new List<ListViewItem>();

        public void GenerateColumnsForlvCourses()
        {
            lvMentors.Columns.Add("Mentor ID", 100, HorizontalAlignment.Center);
            lvMentors.Columns.Add("Mentor Name", 200, HorizontalAlignment.Center);
            lvMentors.Columns.Add("Gender", 100, HorizontalAlignment.Center);
            lvMentors.Columns.Add("Date of birth", 200, HorizontalAlignment.Center);
            lvMentors.Columns.Add("Email", 330, HorizontalAlignment.Center);
            lvMentors.Columns.Add("Phone", 120, HorizontalAlignment.Center);
            lvMentors.Columns.Add("Salary", 100, HorizontalAlignment.Center);

            lvMentors.GridLines = true;
        }
        private void Mentors_Screen_Load(object sender, EventArgs e)
        {
            GenerateColumnsForlvCourses();
            UploadRecords(lvMentors);

            foreach (ListViewItem GetRecord in lvMentors.Items)
            {
                TempRecords.Add(GetRecord);
            }
        }
        private void FillTable(object sender, EventArgs e)
        {
            if (lvMentors.Items.Count > 1)
                return;

            if (cbFind_Mentor.Text == cbFind_Mentor.Tag.ToString() || cbFind_Mentor.Text == "")
            {
                lvMentors.Items.Clear();
                foreach (ListViewItem GetRecord in TempRecords)
                {
                    lvMentors.Items.Add(GetRecord);
                }
            }
        }
        private void pbFindSingleRecord_Click(object sender, EventArgs e)
        {
            if (cbFind_Mentor.Text == cbFind_Mentor.Tag.ToString())
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            if (IsNumberValide(cbFind_Mentor.Text))
            {
                stMentor Record = FindStructRecord(cbFind_Mentor.Text);

                // -99 means is not found
                if (Record.MentorID != -99)
                {
                    lvMentors.Items.Clear();
                    ListViewItem Item = new ListViewItem(Record.MentorID.ToString());
                    Item.SubItems.Add(Record.Person._Name.ToString());
                    Item.SubItems.Add(Record.Person._Gender.ToString());
                    Item.SubItems.Add(Record.Person._DateOfBirth.ToString("dd-MM-yyyy"));
                    Item.SubItems.Add(Record.Person._Email.ToString());
                    Item.SubItems.Add(Record.Person._Phone.ToString());
                    Item.SubItems.Add(Record.Salary.ToString());

                    lvMentors.Items.Add(Item);
                }
                else
                {
                    cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();
                    MessageBox.Show("Course Not Found");
                }
            }
            else
            {
                cbFind_Mentor.Text = cbFind_Mentor.Tag.ToString();
                MessageBox.Show("Enter a valid ID");
            }
        }


    }
}
