namespace DeskEtu
{
    partial class TeachingScreen
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
            this.cbFind_Teaching = new System.Windows.Forms.ComboBox();
            this.pbFind_Teaching = new System.Windows.Forms.PictureBox();
            this.btnDeleteTeaching = new System.Windows.Forms.Button();
            this.btnUpdateTeaching = new System.Windows.Forms.Button();
            this.btnAddTeaching = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lvTeachings = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Teaching)).BeginInit();
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
            // lblMentors
            // 
            this.lblMentors.AutoSize = true;
            this.lblMentors.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblMentors.Location = new System.Drawing.Point(915, 29);
            this.lblMentors.Name = "lblMentors";
            this.lblMentors.Size = new System.Drawing.Size(96, 29);
            this.lblMentors.TabIndex = 41;
            this.lblMentors.Text = "Mentors";
            // 
            // lblTeachings
            // 
            this.lblTeachings.AutoSize = true;
            this.lblTeachings.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblTeachings.Location = new System.Drawing.Point(1096, 29);
            this.lblTeachings.Name = "lblTeachings";
            this.lblTeachings.Size = new System.Drawing.Size(115, 29);
            this.lblTeachings.TabIndex = 40;
            this.lblTeachings.Text = "Teachings";
            // 
            // cbFind_Teaching
            // 
            this.cbFind_Teaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Teaching.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Teaching.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Teaching.FormattingEnabled = true;
            this.cbFind_Teaching.Location = new System.Drawing.Point(939, 133);
            this.cbFind_Teaching.Name = "cbFind_Teaching";
            this.cbFind_Teaching.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Teaching.TabIndex = 39;
            this.cbFind_Teaching.Tag = "Find Teaching";
            this.cbFind_Teaching.Text = "Find Teaching";
            this.cbFind_Teaching.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Teaching
            // 
            this.pbFind_Teaching.BackColor = System.Drawing.Color.White;
            this.pbFind_Teaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Teaching.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Teaching.Location = new System.Drawing.Point(927, 119);
            this.pbFind_Teaching.Name = "pbFind_Teaching";
            this.pbFind_Teaching.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Teaching.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Teaching.TabIndex = 38;
            this.pbFind_Teaching.TabStop = false;
            // 
            // btnDeleteTeaching
            // 
            this.btnDeleteTeaching.BackColor = System.Drawing.Color.White;
            this.btnDeleteTeaching.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnDeleteTeaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteTeaching.FlatAppearance.BorderSize = 0;
            this.btnDeleteTeaching.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteTeaching.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteTeaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeaching.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeaching.Location = new System.Drawing.Point(460, 123);
            this.btnDeleteTeaching.Name = "btnDeleteTeaching";
            this.btnDeleteTeaching.Size = new System.Drawing.Size(160, 53);
            this.btnDeleteTeaching.TabIndex = 37;
            this.btnDeleteTeaching.Text = "Delete";
            this.btnDeleteTeaching.UseVisualStyleBackColor = false;
            this.btnDeleteTeaching.Click += new System.EventHandler(this.btnDeleteTeaching_Click);
            // 
            // btnUpdateTeaching
            // 
            this.btnUpdateTeaching.BackColor = System.Drawing.Color.White;
            this.btnUpdateTeaching.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnUpdateTeaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateTeaching.FlatAppearance.BorderSize = 0;
            this.btnUpdateTeaching.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateTeaching.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateTeaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTeaching.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeaching.Location = new System.Drawing.Point(282, 123);
            this.btnUpdateTeaching.Name = "btnUpdateTeaching";
            this.btnUpdateTeaching.Size = new System.Drawing.Size(160, 53);
            this.btnUpdateTeaching.TabIndex = 36;
            this.btnUpdateTeaching.Text = "Update";
            this.btnUpdateTeaching.UseVisualStyleBackColor = false;
            this.btnUpdateTeaching.Click += new System.EventHandler(this.UpdateTeaching_Click);
            // 
            // btnAddTeaching
            // 
            this.btnAddTeaching.BackColor = System.Drawing.Color.White;
            this.btnAddTeaching.BackgroundImage = global::DeskEtu.Properties.Resources.Add_1;
            this.btnAddTeaching.FlatAppearance.BorderSize = 0;
            this.btnAddTeaching.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddTeaching.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddTeaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeaching.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeaching.Location = new System.Drawing.Point(141, 127);
            this.btnAddTeaching.Name = "btnAddTeaching";
            this.btnAddTeaching.Size = new System.Drawing.Size(123, 45);
            this.btnAddTeaching.TabIndex = 35;
            this.btnAddTeaching.Text = "Create";
            this.btnAddTeaching.UseVisualStyleBackColor = false;
            this.btnAddTeaching.Click += new System.EventHandler(this.AddTeaching_Click);
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
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCourses.Location = new System.Drawing.Point(763, 29);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(96, 29);
            this.lblCourses.TabIndex = 57;
            this.lblCourses.Text = "Courses";
            // 
            // lvTeachings
            // 
            this.lvTeachings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTeachings.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTeachings.ForeColor = System.Drawing.Color.DimGray;
            this.lvTeachings.HideSelection = false;
            this.lvTeachings.Location = new System.Drawing.Point(141, 217);
            this.lvTeachings.Name = "lvTeachings";
            this.lvTeachings.Size = new System.Drawing.Size(1175, 490);
            this.lvTeachings.TabIndex = 58;
            this.lvTeachings.UseCompatibleStateImageBehavior = false;
            this.lvTeachings.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(1261, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 59;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindRecord_Click);
            // 
            // TeachingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvTeachings);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblMentors);
            this.Controls.Add(this.lblTeachings);
            this.Controls.Add(this.cbFind_Teaching);
            this.Controls.Add(this.pbFind_Teaching);
            this.Controls.Add(this.btnDeleteTeaching);
            this.Controls.Add(this.btnUpdateTeaching);
            this.Controls.Add(this.btnAddTeaching);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeachingScreen";
            this.Text = "TeachingScreen";
            this.Load += new System.EventHandler(this.TeachingsScreen_Load);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.btnAddTeaching, 0);
            this.Controls.SetChildIndex(this.btnUpdateTeaching, 0);
            this.Controls.SetChildIndex(this.btnDeleteTeaching, 0);
            this.Controls.SetChildIndex(this.pbFind_Teaching, 0);
            this.Controls.SetChildIndex(this.cbFind_Teaching, 0);
            this.Controls.SetChildIndex(this.lblTeachings, 0);
            this.Controls.SetChildIndex(this.lblMentors, 0);
            this.Controls.SetChildIndex(this.lblCourses, 0);
            this.Controls.SetChildIndex(this.lvTeachings, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Teaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMentors;
        private System.Windows.Forms.Label lblTeachings;
        private System.Windows.Forms.ComboBox cbFind_Teaching;
        private System.Windows.Forms.PictureBox pbFind_Teaching;
        private System.Windows.Forms.Button btnDeleteTeaching;
        private System.Windows.Forms.Button btnUpdateTeaching;
        private System.Windows.Forms.Button btnAddTeaching;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCourses;
        public System.Windows.Forms.ListView lvTeachings;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}