namespace DeskEtu
{
    partial class CohortsScreen
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
            this.lblCohorts = new System.Windows.Forms.Label();
            this.lblEnrollments = new System.Windows.Forms.Label();
            this.cbFind_Cohort = new System.Windows.Forms.ComboBox();
            this.pbFind_Cohort = new System.Windows.Forms.PictureBox();
            this.btnDeleteCohort = new System.Windows.Forms.Button();
            this.btnUpdateCohort = new System.Windows.Forms.Button();
            this.btnAddCohort = new System.Windows.Forms.Button();
            this.lvCohorts = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Cohort)).BeginInit();
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
            // lblCohorts
            // 
            this.lblCohorts.AutoSize = true;
            this.lblCohorts.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCohorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblCohorts.Location = new System.Drawing.Point(946, 29);
            this.lblCohorts.Name = "lblCohorts";
            this.lblCohorts.Size = new System.Drawing.Size(93, 29);
            this.lblCohorts.TabIndex = 42;
            this.lblCohorts.Text = "Cohorts";
            // 
            // lblEnrollments
            // 
            this.lblEnrollments.AutoSize = true;
            this.lblEnrollments.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollments.ForeColor = System.Drawing.Color.Gray;
            this.lblEnrollments.Location = new System.Drawing.Point(1118, 29);
            this.lblEnrollments.Name = "lblEnrollments";
            this.lblEnrollments.Size = new System.Drawing.Size(86, 29);
            this.lblEnrollments.TabIndex = 41;
            this.lblEnrollments.Text = "Groups";
            // 
            // cbFind_Cohort
            // 
            this.cbFind_Cohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Cohort.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Cohort.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Cohort.FormattingEnabled = true;
            this.cbFind_Cohort.Location = new System.Drawing.Point(939, 133);
            this.cbFind_Cohort.Name = "cbFind_Cohort";
            this.cbFind_Cohort.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Cohort.TabIndex = 39;
            this.cbFind_Cohort.Tag = "Find Cohort";
            this.cbFind_Cohort.Text = "Find Cohort";
            this.cbFind_Cohort.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Cohort
            // 
            this.pbFind_Cohort.BackColor = System.Drawing.Color.White;
            this.pbFind_Cohort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Cohort.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Cohort.Location = new System.Drawing.Point(927, 119);
            this.pbFind_Cohort.Name = "pbFind_Cohort";
            this.pbFind_Cohort.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Cohort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Cohort.TabIndex = 38;
            this.pbFind_Cohort.TabStop = false;
            // 
            // btnDeleteCohort
            // 
            this.btnDeleteCohort.BackColor = System.Drawing.Color.White;
            this.btnDeleteCohort.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnDeleteCohort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteCohort.FlatAppearance.BorderSize = 0;
            this.btnDeleteCohort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteCohort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteCohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCohort.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCohort.Location = new System.Drawing.Point(460, 123);
            this.btnDeleteCohort.Name = "btnDeleteCohort";
            this.btnDeleteCohort.Size = new System.Drawing.Size(160, 53);
            this.btnDeleteCohort.TabIndex = 37;
            this.btnDeleteCohort.Text = "Delete";
            this.btnDeleteCohort.UseVisualStyleBackColor = false;
            this.btnDeleteCohort.Click += new System.EventHandler(this.btnDeleteCohort_Click);
            // 
            // btnUpdateCohort
            // 
            this.btnUpdateCohort.BackColor = System.Drawing.Color.White;
            this.btnUpdateCohort.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnUpdateCohort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateCohort.FlatAppearance.BorderSize = 0;
            this.btnUpdateCohort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateCohort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateCohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCohort.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCohort.Location = new System.Drawing.Point(282, 123);
            this.btnUpdateCohort.Name = "btnUpdateCohort";
            this.btnUpdateCohort.Size = new System.Drawing.Size(160, 53);
            this.btnUpdateCohort.TabIndex = 36;
            this.btnUpdateCohort.Text = "Update";
            this.btnUpdateCohort.UseVisualStyleBackColor = false;
            this.btnUpdateCohort.Click += new System.EventHandler(this.UpdateCohort_Click);
            // 
            // btnAddCohort
            // 
            this.btnAddCohort.BackColor = System.Drawing.Color.White;
            this.btnAddCohort.BackgroundImage = global::DeskEtu.Properties.Resources.Add_1;
            this.btnAddCohort.FlatAppearance.BorderSize = 0;
            this.btnAddCohort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddCohort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddCohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCohort.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCohort.Location = new System.Drawing.Point(141, 127);
            this.btnAddCohort.Name = "btnAddCohort";
            this.btnAddCohort.Size = new System.Drawing.Size(123, 45);
            this.btnAddCohort.TabIndex = 35;
            this.btnAddCohort.Text = "Create";
            this.btnAddCohort.UseVisualStyleBackColor = false;
            this.btnAddCohort.Click += new System.EventHandler(this.AddCohort_Click);
            // 
            // lvCohorts
            // 
            this.lvCohorts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCohorts.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCohorts.ForeColor = System.Drawing.Color.DimGray;
            this.lvCohorts.HideSelection = false;
            this.lvCohorts.Location = new System.Drawing.Point(141, 217);
            this.lvCohorts.Name = "lvCohorts";
            this.lvCohorts.Size = new System.Drawing.Size(1175, 490);
            this.lvCohorts.TabIndex = 44;
            this.lvCohorts.UseCompatibleStateImageBehavior = false;
            this.lvCohorts.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(1261, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 47;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindRecord_Click);
            // 
            // CohortsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvCohorts);
            this.Controls.Add(this.lblCohorts);
            this.Controls.Add(this.lblEnrollments);
            this.Controls.Add(this.cbFind_Cohort);
            this.Controls.Add(this.pbFind_Cohort);
            this.Controls.Add(this.btnDeleteCohort);
            this.Controls.Add(this.btnUpdateCohort);
            this.Controls.Add(this.btnAddCohort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CohortsScreen";
            this.Text = "CohortsScreen";
            this.Load += new System.EventHandler(this.CohortsScreen_Load);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.btnAddCohort, 0);
            this.Controls.SetChildIndex(this.btnUpdateCohort, 0);
            this.Controls.SetChildIndex(this.btnDeleteCohort, 0);
            this.Controls.SetChildIndex(this.pbFind_Cohort, 0);
            this.Controls.SetChildIndex(this.cbFind_Cohort, 0);
            this.Controls.SetChildIndex(this.lblEnrollments, 0);
            this.Controls.SetChildIndex(this.lblCohorts, 0);
            this.Controls.SetChildIndex(this.lvCohorts, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Cohort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCohorts;
        private System.Windows.Forms.Label lblEnrollments;
        private System.Windows.Forms.ComboBox cbFind_Cohort;
        private System.Windows.Forms.PictureBox pbFind_Cohort;
        private System.Windows.Forms.Button btnDeleteCohort;
        private System.Windows.Forms.Button btnUpdateCohort;
        private System.Windows.Forms.Button btnAddCohort;
        public System.Windows.Forms.ListView lvCohorts;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}