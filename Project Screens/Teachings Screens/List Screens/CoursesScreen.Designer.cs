namespace DeskEtu.Project_Screens.Teachings_Screens.List_Screens
{
    partial class CoursesScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMentors = new System.Windows.Forms.Label();
            this.lblTeachings = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.cbFind_Course = new System.Windows.Forms.ComboBox();
            this.pbFind_Course = new System.Windows.Forms.PictureBox();
            this.lvCourses = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQA_Structure
            // 
            this.btnQA_Structure.FlatAppearance.BorderSize = 0;
            this.btnQA_Structure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnQA_Structure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            // 
            // btnQA_Employees
            // 
            this.btnQA_Employees.FlatAppearance.BorderSize = 0;
            this.btnQA_Employees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnQA_Employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            // 
            // btnQA_Sessions
            // 
    
            // btnQA_Teaching
            // 
            this.btnQA_Teaching.FlatAppearance.BorderSize = 0;
            this.btnQA_Teaching.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnQA_Teaching.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            // 
            // btnQA_Enrollment
            // 
            this.btnQA_Enrollment.FlatAppearance.BorderSize = 0;
            this.btnQA_Enrollment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.btnQA_Enrollment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            // 
            // lblMentors
            // 
            this.lblMentors.AutoSize = true;
            this.lblMentors.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentors.ForeColor = System.Drawing.Color.Gray;
            this.lblMentors.Location = new System.Drawing.Point(915, 29);
            this.lblMentors.Name = "lblMentors";
            this.lblMentors.Size = new System.Drawing.Size(96, 29);
            this.lblMentors.TabIndex = 54;
            this.lblMentors.Text = "Mentors";
            // 
            // lblTeachings
            // 
            this.lblTeachings.AutoSize = true;
            this.lblTeachings.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachings.ForeColor = System.Drawing.Color.Gray;
            this.lblTeachings.Location = new System.Drawing.Point(1096, 29);
            this.lblTeachings.Name = "lblTeachings";
            this.lblTeachings.Size = new System.Drawing.Size(115, 29);
            this.lblTeachings.TabIndex = 53;
            this.lblTeachings.Text = "Teachings";
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCourses.Location = new System.Drawing.Point(763, 29);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(96, 29);
            this.lblCourses.TabIndex = 56;
            this.lblCourses.Text = "Courses";
            // 
            // cbFind_Course
            // 
            this.cbFind_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Course.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Course.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Course.FormattingEnabled = true;
            this.cbFind_Course.Location = new System.Drawing.Point(547, 133);
            this.cbFind_Course.Name = "cbFind_Course";
            this.cbFind_Course.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Course.TabIndex = 58;
            this.cbFind_Course.Tag = "Find Course";
            this.cbFind_Course.Text = "Find Course";
            this.cbFind_Course.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Course
            // 
            this.pbFind_Course.BackColor = System.Drawing.Color.White;
            this.pbFind_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Course.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Course.Location = new System.Drawing.Point(534, 119);
            this.pbFind_Course.Name = "pbFind_Course";
            this.pbFind_Course.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Course.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Course.TabIndex = 57;
            this.pbFind_Course.TabStop = false;
            // 
            // lvCourses
            // 
            this.lvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCourses.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCourses.ForeColor = System.Drawing.Color.DimGray;
            this.lvCourses.HideSelection = false;
            this.lvCourses.Location = new System.Drawing.Point(141, 217);
            this.lvCourses.Name = "lvCourses";
            this.lvCourses.Size = new System.Drawing.Size(1175, 490);
            this.lvCourses.TabIndex = 59;
            this.lvCourses.UseCompatibleStateImageBehavior = false;
            this.lvCourses.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(868, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 60;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindSingleRecord_Click);
            // 
            // CoursesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 671);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvCourses);
            this.Controls.Add(this.cbFind_Course);
            this.Controls.Add(this.pbFind_Course);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblMentors);
            this.Controls.Add(this.lblTeachings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoursesScreen";
            this.Text = "CoursesScreen";
            this.Load += new System.EventHandler(this.CoursesScreen_Load);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.lblTeachings, 0);
            this.Controls.SetChildIndex(this.lblMentors, 0);
            this.Controls.SetChildIndex(this.lblCourses, 0);
            this.Controls.SetChildIndex(this.pbFind_Course, 0);
            this.Controls.SetChildIndex(this.cbFind_Course, 0);
            this.Controls.SetChildIndex(this.lvCourses, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMentors;
        private System.Windows.Forms.Label lblTeachings;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.ComboBox cbFind_Course;
        private System.Windows.Forms.PictureBox pbFind_Course;
        public System.Windows.Forms.ListView lvCourses;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}