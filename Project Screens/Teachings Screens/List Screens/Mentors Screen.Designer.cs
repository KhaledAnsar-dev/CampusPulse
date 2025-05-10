namespace DeskEtu
{
    partial class Mentors_Screen
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
            this.lblResults = new System.Windows.Forms.Label();
            this.cbFind_Mentor = new System.Windows.Forms.ComboBox();
            this.pbFind_Mentor = new System.Windows.Forms.PictureBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lvMentors = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Mentor)).BeginInit();
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
            this.lblMentors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblMentors.Location = new System.Drawing.Point(915, 29);
            this.lblMentors.Name = "lblMentors";
            this.lblMentors.Size = new System.Drawing.Size(96, 29);
            this.lblMentors.TabIndex = 41;
            this.lblMentors.Text = "Mentors";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Gray;
            this.lblResults.Location = new System.Drawing.Point(1096, 29);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(115, 29);
            this.lblResults.TabIndex = 40;
            this.lblResults.Text = "Teachings";
            // 
            // cbFind_Mentor
            // 
            this.cbFind_Mentor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Mentor.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Mentor.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Mentor.FormattingEnabled = true;
            this.cbFind_Mentor.Location = new System.Drawing.Point(547, 133);
            this.cbFind_Mentor.Name = "cbFind_Mentor";
            this.cbFind_Mentor.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Mentor.TabIndex = 39;
            this.cbFind_Mentor.Tag = "Find Mentor";
            this.cbFind_Mentor.Text = "Find Mentor";
            this.cbFind_Mentor.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Mentor
            // 
            this.pbFind_Mentor.BackColor = System.Drawing.Color.White;
            this.pbFind_Mentor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Mentor.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Mentor.Location = new System.Drawing.Point(534, 119);
            this.pbFind_Mentor.Name = "pbFind_Mentor";
            this.pbFind_Mentor.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Mentor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Mentor.TabIndex = 38;
            this.pbFind_Mentor.TabStop = false;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.Gray;
            this.lblCourses.Location = new System.Drawing.Point(763, 29);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(96, 29);
            this.lblCourses.TabIndex = 58;
            this.lblCourses.Text = "Courses";
            // 
            // lvMentors
            // 
            this.lvMentors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMentors.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMentors.ForeColor = System.Drawing.Color.DimGray;
            this.lvMentors.HideSelection = false;
            this.lvMentors.Location = new System.Drawing.Point(141, 217);
            this.lvMentors.Name = "lvMentors";
            this.lvMentors.Size = new System.Drawing.Size(1175, 490);
            this.lvMentors.TabIndex = 60;
            this.lvMentors.UseCompatibleStateImageBehavior = false;
            this.lvMentors.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(868, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 61;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindSingleRecord_Click);
            // 
            // Mentors_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvMentors);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblMentors);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cbFind_Mentor);
            this.Controls.Add(this.pbFind_Mentor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mentors_Screen";
            this.Text = "Mentors_Screen";
            this.Load += new System.EventHandler(this.Mentors_Screen_Load);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.pbFind_Mentor, 0);
            this.Controls.SetChildIndex(this.cbFind_Mentor, 0);
            this.Controls.SetChildIndex(this.lblResults, 0);
            this.Controls.SetChildIndex(this.lblMentors, 0);
            this.Controls.SetChildIndex(this.lblCourses, 0);
            this.Controls.SetChildIndex(this.lvMentors, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Mentor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMentors;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cbFind_Mentor;
        private System.Windows.Forms.PictureBox pbFind_Mentor;
        private System.Windows.Forms.Label lblCourses;
        public System.Windows.Forms.ListView lvMentors;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}