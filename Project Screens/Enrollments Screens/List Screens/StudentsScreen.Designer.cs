namespace DeskEtu
{
    partial class StudentsScreen
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
            this.pbFind_Students = new System.Windows.Forms.PictureBox();
            this.cbFind_Students = new System.Windows.Forms.ComboBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblEnrollments = new System.Windows.Forms.Label();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Students)).BeginInit();
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
            // pbFind_Students
            // 
            this.pbFind_Students.BackColor = System.Drawing.Color.White;
            this.pbFind_Students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Students.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Students.Location = new System.Drawing.Point(534, 119);
            this.pbFind_Students.Name = "pbFind_Students";
            this.pbFind_Students.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Students.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Students.TabIndex = 30;
            this.pbFind_Students.TabStop = false;
            // 
            // cbFind_Students
            // 
            this.cbFind_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Students.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Students.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Students.FormattingEnabled = true;
            this.cbFind_Students.Location = new System.Drawing.Point(547, 133);
            this.cbFind_Students.Name = "cbFind_Students";
            this.cbFind_Students.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Students.TabIndex = 31;
            this.cbFind_Students.Tag = "Find Student";
            this.cbFind_Students.Text = "Find Student";
            this.cbFind_Students.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblStudents.Location = new System.Drawing.Point(920, 29);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(103, 29);
            this.lblStudents.TabIndex = 54;
            this.lblStudents.Text = "Students";
            // 
            // lblEnrollments
            // 
            this.lblEnrollments.AutoSize = true;
            this.lblEnrollments.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollments.ForeColor = System.Drawing.Color.Gray;
            this.lblEnrollments.Location = new System.Drawing.Point(1090, 29);
            this.lblEnrollments.Name = "lblEnrollments";
            this.lblEnrollments.Size = new System.Drawing.Size(130, 29);
            this.lblEnrollments.TabIndex = 52;
            this.lblEnrollments.Text = "Enrollments";
            // 
            // lvStudents
            // 
            this.lvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStudents.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStudents.ForeColor = System.Drawing.Color.DimGray;
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(141, 217);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(1175, 490);
            this.lvStudents.TabIndex = 61;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(868, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 62;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindSingleRecord_Click);
            // 
            // StudentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblEnrollments);
            this.Controls.Add(this.cbFind_Students);
            this.Controls.Add(this.pbFind_Students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsScreen";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentsScreen_Load);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.pbFind_Students, 0);
            this.Controls.SetChildIndex(this.cbFind_Students, 0);
            this.Controls.SetChildIndex(this.lblEnrollments, 0);
            this.Controls.SetChildIndex(this.lblStudents, 0);
            this.Controls.SetChildIndex(this.lvStudents, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFind_Students;
        private System.Windows.Forms.ComboBox cbFind_Students;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblEnrollments;
        public System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}