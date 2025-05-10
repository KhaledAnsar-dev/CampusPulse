namespace DeskEtu.Project_Screens.Enrollments_Screens.Manipulation_Screens
{
    partial class ReformEnrollment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFind_Cohort = new System.Windows.Forms.ComboBox();
            this.cbFind_Group = new System.Windows.Forms.ComboBox();
            this.pbFind_Group = new System.Windows.Forms.PictureBox();
            this.pbFind_Cohort = new System.Windows.Forms.PictureBox();
            this.cbFind_Mentor = new System.Windows.Forms.ComboBox();
            this.cbFind_Course = new System.Windows.Forms.ComboBox();
            this.pbFind_Course = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.pbFind_Mentor = new System.Windows.Forms.PictureBox();
            this.cbFind_Year = new System.Windows.Forms.ComboBox();
            this.pbFind_Year = new System.Windows.Forms.PictureBox();
            this.cbFind_Student = new System.Windows.Forms.ComboBox();
            this.pbFind_Student = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Cohort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Mentor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeskEtu.Properties.Resources.Reform_Enrollments_Tk;
            this.pictureBox1.Location = new System.Drawing.Point(408, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 737);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbFind_Cohort
            // 
            this.cbFind_Cohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Cohort.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Cohort.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Cohort.FormattingEnabled = true;
            this.cbFind_Cohort.Location = new System.Drawing.Point(504, 302);
            this.cbFind_Cohort.Name = "cbFind_Cohort";
            this.cbFind_Cohort.Size = new System.Drawing.Size(290, 33);
            this.cbFind_Cohort.TabIndex = 88;
            this.cbFind_Cohort.Tag = "Cohort";
            this.cbFind_Cohort.Text = "Cohort";
            this.cbFind_Cohort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // cbFind_Group
            // 
            this.cbFind_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Group.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Group.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Group.FormattingEnabled = true;
            this.cbFind_Group.Location = new System.Drawing.Point(504, 215);
            this.cbFind_Group.Name = "cbFind_Group";
            this.cbFind_Group.Size = new System.Drawing.Size(290, 33);
            this.cbFind_Group.TabIndex = 87;
            this.cbFind_Group.Tag = "Group";
            this.cbFind_Group.Text = "Group";
            this.cbFind_Group.SelectedIndexChanged += new System.EventHandler(this.LoadCohortsWhenChanged);
            this.cbFind_Group.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Group
            // 
            this.pbFind_Group.BackColor = System.Drawing.Color.White;
            this.pbFind_Group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Group.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Group.Location = new System.Drawing.Point(491, 201);
            this.pbFind_Group.Name = "pbFind_Group";
            this.pbFind_Group.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Group.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Group.TabIndex = 86;
            this.pbFind_Group.TabStop = false;
            // 
            // pbFind_Cohort
            // 
            this.pbFind_Cohort.BackColor = System.Drawing.Color.White;
            this.pbFind_Cohort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Cohort.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Cohort.Location = new System.Drawing.Point(491, 288);
            this.pbFind_Cohort.Name = "pbFind_Cohort";
            this.pbFind_Cohort.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Cohort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Cohort.TabIndex = 85;
            this.pbFind_Cohort.TabStop = false;
            // 
            // cbFind_Mentor
            // 
            this.cbFind_Mentor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Mentor.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Mentor.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Mentor.FormattingEnabled = true;
            this.cbFind_Mentor.Location = new System.Drawing.Point(504, 559);
            this.cbFind_Mentor.Name = "cbFind_Mentor";
            this.cbFind_Mentor.Size = new System.Drawing.Size(281, 33);
            this.cbFind_Mentor.TabIndex = 84;
            this.cbFind_Mentor.Tag = "Mentor";
            this.cbFind_Mentor.Text = "Mentor";
            // 
            // cbFind_Course
            // 
            this.cbFind_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Course.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Course.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Course.FormattingEnabled = true;
            this.cbFind_Course.Location = new System.Drawing.Point(504, 473);
            this.cbFind_Course.Name = "cbFind_Course";
            this.cbFind_Course.Size = new System.Drawing.Size(281, 33);
            this.cbFind_Course.TabIndex = 83;
            this.cbFind_Course.Tag = "Course";
            this.cbFind_Course.Text = "Course";
            this.cbFind_Course.SelectedIndexChanged += new System.EventHandler(this.LoadMentorsWhenChanged);
            this.cbFind_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Course
            // 
            this.pbFind_Course.BackColor = System.Drawing.Color.White;
            this.pbFind_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Course.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Course.Location = new System.Drawing.Point(491, 459);
            this.pbFind_Course.Name = "pbFind_Course";
            this.pbFind_Course.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Course.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Course.TabIndex = 82;
            this.pbFind_Course.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.BackgroundImage = global::DeskEtu.Properties.Resources.Add_1;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(807, 679);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(123, 45);
            this.btnDone.TabIndex = 81;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pbFind_Mentor
            // 
            this.pbFind_Mentor.BackColor = System.Drawing.Color.White;
            this.pbFind_Mentor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Mentor.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Mentor.Location = new System.Drawing.Point(491, 545);
            this.pbFind_Mentor.Name = "pbFind_Mentor";
            this.pbFind_Mentor.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Mentor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Mentor.TabIndex = 80;
            this.pbFind_Mentor.TabStop = false;
            // 
            // cbFind_Year
            // 
            this.cbFind_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Year.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Year.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Year.FormattingEnabled = true;
            this.cbFind_Year.Location = new System.Drawing.Point(504, 129);
            this.cbFind_Year.Name = "cbFind_Year";
            this.cbFind_Year.Size = new System.Drawing.Size(305, 33);
            this.cbFind_Year.TabIndex = 79;
            this.cbFind_Year.Tag = "Year";
            this.cbFind_Year.Text = "Year";
            this.cbFind_Year.SelectedIndexChanged += new System.EventHandler(this.LoadGroupsAndCoursesAndStudentsWhenChanged);
            this.cbFind_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Year
            // 
            this.pbFind_Year.BackColor = System.Drawing.Color.White;
            this.pbFind_Year.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Year.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Year.Location = new System.Drawing.Point(491, 115);
            this.pbFind_Year.Name = "pbFind_Year";
            this.pbFind_Year.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Year.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Year.TabIndex = 78;
            this.pbFind_Year.TabStop = false;
            // 
            // cbFind_Student
            // 
            this.cbFind_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Student.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Student.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Student.FormattingEnabled = true;
            this.cbFind_Student.Location = new System.Drawing.Point(504, 388);
            this.cbFind_Student.Name = "cbFind_Student";
            this.cbFind_Student.Size = new System.Drawing.Size(275, 33);
            this.cbFind_Student.TabIndex = 90;
            this.cbFind_Student.Tag = "Student";
            this.cbFind_Student.Text = "Student";
            this.cbFind_Student.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Student
            // 
            this.pbFind_Student.BackColor = System.Drawing.Color.White;
            this.pbFind_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Student.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Student.Location = new System.Drawing.Point(491, 374);
            this.pbFind_Student.Name = "pbFind_Student";
            this.pbFind_Student.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Student.TabIndex = 89;
            this.pbFind_Student.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(791, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 101;
            this.label5.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(785, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 100;
            this.label4.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(795, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "Cohort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(800, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(815, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(792, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 102;
            this.label6.Text = "Mentor";
            // 
            // ReformEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFind_Student);
            this.Controls.Add(this.pbFind_Student);
            this.Controls.Add(this.cbFind_Cohort);
            this.Controls.Add(this.cbFind_Group);
            this.Controls.Add(this.pbFind_Group);
            this.Controls.Add(this.pbFind_Cohort);
            this.Controls.Add(this.cbFind_Mentor);
            this.Controls.Add(this.cbFind_Course);
            this.Controls.Add(this.pbFind_Course);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pbFind_Mentor);
            this.Controls.Add(this.cbFind_Year);
            this.Controls.Add(this.pbFind_Year);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReformEnrollment";
            this.Text = "ReformEnrollment";
            this.Load += new System.EventHandler(this.FormOpen);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pbFind_Year, 0);
            this.Controls.SetChildIndex(this.cbFind_Year, 0);
            this.Controls.SetChildIndex(this.pbFind_Mentor, 0);
            this.Controls.SetChildIndex(this.btnDone, 0);
            this.Controls.SetChildIndex(this.pbFind_Course, 0);
            this.Controls.SetChildIndex(this.cbFind_Course, 0);
            this.Controls.SetChildIndex(this.cbFind_Mentor, 0);
            this.Controls.SetChildIndex(this.pbFind_Cohort, 0);
            this.Controls.SetChildIndex(this.pbFind_Group, 0);
            this.Controls.SetChildIndex(this.cbFind_Group, 0);
            this.Controls.SetChildIndex(this.cbFind_Cohort, 0);
            this.Controls.SetChildIndex(this.pbFind_Student, 0);
            this.Controls.SetChildIndex(this.cbFind_Student, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Cohort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Mentor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFind_Cohort;
        private System.Windows.Forms.ComboBox cbFind_Group;
        private System.Windows.Forms.PictureBox pbFind_Group;
        private System.Windows.Forms.PictureBox pbFind_Cohort;
        private System.Windows.Forms.ComboBox cbFind_Mentor;
        private System.Windows.Forms.ComboBox cbFind_Course;
        private System.Windows.Forms.PictureBox pbFind_Course;
        public System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pbFind_Mentor;
        private System.Windows.Forms.ComboBox cbFind_Year;
        private System.Windows.Forms.PictureBox pbFind_Year;
        private System.Windows.Forms.ComboBox cbFind_Student;
        private System.Windows.Forms.PictureBox pbFind_Student;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}