namespace DeskEtu
{
    partial class EnrollmentsScreen
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblEnrollments = new System.Windows.Forms.Label();
            this.cbFind_Enrollment = new System.Windows.Forms.ComboBox();
            this.pbFind_Enrollment = new System.Windows.Forms.PictureBox();
            this.btnDeleteEnrollment = new System.Windows.Forms.Button();
            this.btnUpdateEnrollment = new System.Windows.Forms.Button();
            this.btnAddEnrollmnet = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lvEnrollments = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Enrollment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblStudents.Location = new System.Drawing.Point(919, 29);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(107, 29);
            this.lblStudents.TabIndex = 48;
            this.lblStudents.Text = "Students";
            // 
            // lblEnrollments
            // 
            this.lblEnrollments.AutoSize = true;
            this.lblEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblEnrollments.Location = new System.Drawing.Point(1083, 30);
            this.lblEnrollments.Name = "lblEnrollments";
            this.lblEnrollments.Size = new System.Drawing.Size(141, 29);
            this.lblEnrollments.TabIndex = 46;
            this.lblEnrollments.Text = "Enrollments";
            // 
            // cbFind_Enrollment
            // 
            this.cbFind_Enrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Enrollment.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Enrollment.FormattingEnabled = true;
            this.cbFind_Enrollment.Location = new System.Drawing.Point(939, 133);
            this.cbFind_Enrollment.Name = "cbFind_Enrollment";
            this.cbFind_Enrollment.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Enrollment.TabIndex = 45;
            this.cbFind_Enrollment.Tag = "Find Enrollmnet";
            this.cbFind_Enrollment.Text = "Find Enrollmnet";
            this.cbFind_Enrollment.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Enrollment
            // 
            this.pbFind_Enrollment.BackColor = System.Drawing.Color.White;
            this.pbFind_Enrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Enrollment.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Enrollment.Location = new System.Drawing.Point(927, 119);
            this.pbFind_Enrollment.Name = "pbFind_Enrollment";
            this.pbFind_Enrollment.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Enrollment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Enrollment.TabIndex = 44;
            this.pbFind_Enrollment.TabStop = false;
            // 
            // btnDeleteEnrollment
            // 
            this.btnDeleteEnrollment.BackColor = System.Drawing.Color.White;
            this.btnDeleteEnrollment.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnDeleteEnrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteEnrollment.FlatAppearance.BorderSize = 0;
            this.btnDeleteEnrollment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteEnrollment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEnrollment.Location = new System.Drawing.Point(460, 123);
            this.btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            this.btnDeleteEnrollment.Size = new System.Drawing.Size(160, 53);
            this.btnDeleteEnrollment.TabIndex = 43;
            this.btnDeleteEnrollment.Text = "Delete";
            this.btnDeleteEnrollment.UseVisualStyleBackColor = false;
            this.btnDeleteEnrollment.Click += new System.EventHandler(this.btnDeleteEnrollment_Click);
            // 
            // btnUpdateEnrollment
            // 
            this.btnUpdateEnrollment.BackColor = System.Drawing.Color.White;
            this.btnUpdateEnrollment.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnUpdateEnrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateEnrollment.FlatAppearance.BorderSize = 0;
            this.btnUpdateEnrollment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateEnrollment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEnrollment.Location = new System.Drawing.Point(282, 123);
            this.btnUpdateEnrollment.Name = "btnUpdateEnrollment";
            this.btnUpdateEnrollment.Size = new System.Drawing.Size(160, 53);
            this.btnUpdateEnrollment.TabIndex = 42;
            this.btnUpdateEnrollment.Text = "Update";
            this.btnUpdateEnrollment.UseVisualStyleBackColor = false;
            this.btnUpdateEnrollment.Click += new System.EventHandler(this.UpdateEnrollment_Click);
            // 
            // btnAddEnrollmnet
            // 
            this.btnAddEnrollmnet.BackColor = System.Drawing.Color.White;
            this.btnAddEnrollmnet.BackgroundImage = global::DeskEtu.Properties.Resources.Add_1;
            this.btnAddEnrollmnet.FlatAppearance.BorderSize = 0;
            this.btnAddEnrollmnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddEnrollmnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddEnrollmnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEnrollmnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEnrollmnet.Location = new System.Drawing.Point(141, 127);
            this.btnAddEnrollmnet.Name = "btnAddEnrollmnet";
            this.btnAddEnrollmnet.Size = new System.Drawing.Size(123, 45);
            this.btnAddEnrollmnet.TabIndex = 41;
            this.btnAddEnrollmnet.Text = "Create";
            this.btnAddEnrollmnet.UseVisualStyleBackColor = false;
            this.btnAddEnrollmnet.Click += new System.EventHandler(this.AddEnrollment_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::DeskEtu.Properties.Resources.Main_Button;
            this.pictureBox4.Location = new System.Drawing.Point(1076, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // lvEnrollments
            // 
            this.lvEnrollments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEnrollments.ForeColor = System.Drawing.Color.DimGray;
            this.lvEnrollments.HideSelection = false;
            this.lvEnrollments.Location = new System.Drawing.Point(141, 217);
            this.lvEnrollments.Name = "lvEnrollments";
            this.lvEnrollments.Size = new System.Drawing.Size(1175, 490);
            this.lvEnrollments.TabIndex = 60;
            this.lvEnrollments.UseCompatibleStateImageBehavior = false;
            this.lvEnrollments.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(1261, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 61;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindRecord_Click);
            // 
            // EnrollmentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvEnrollments);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblEnrollments);
            this.Controls.Add(this.cbFind_Enrollment);
            this.Controls.Add(this.pbFind_Enrollment);
            this.Controls.Add(this.btnDeleteEnrollment);
            this.Controls.Add(this.btnUpdateEnrollment);
            this.Controls.Add(this.btnAddEnrollmnet);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnrollmentsScreen";
            this.Text = "Enrollmnets";
            this.Load += new System.EventHandler(this.EnrollmentScreen_Load);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.btnAddEnrollmnet, 0);
            this.Controls.SetChildIndex(this.btnUpdateEnrollment, 0);
            this.Controls.SetChildIndex(this.btnDeleteEnrollment, 0);
            this.Controls.SetChildIndex(this.pbFind_Enrollment, 0);
            this.Controls.SetChildIndex(this.cbFind_Enrollment, 0);
            this.Controls.SetChildIndex(this.lblEnrollments, 0);
            this.Controls.SetChildIndex(this.lblStudents, 0);
            this.Controls.SetChildIndex(this.lvEnrollments, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Enrollment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblEnrollments;
        private System.Windows.Forms.ComboBox cbFind_Enrollment;
        private System.Windows.Forms.PictureBox pbFind_Enrollment;
        private System.Windows.Forms.Button btnDeleteEnrollment;
        private System.Windows.Forms.Button btnUpdateEnrollment;
        public System.Windows.Forms.Button btnAddEnrollmnet;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.ListView lvEnrollments;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}