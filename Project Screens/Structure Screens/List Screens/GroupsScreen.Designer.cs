namespace DeskEtu
{
    partial class GroupsScreen
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
            this.lblGroups = new System.Windows.Forms.Label();
            this.cbFind_Group = new System.Windows.Forms.ComboBox();
            this.pbFind_Group = new System.Windows.Forms.PictureBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.lvGroups = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.lblCohorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCohorts.Location = new System.Drawing.Point(946, 29);
            this.lblCohorts.Name = "lblCohorts";
            this.lblCohorts.Size = new System.Drawing.Size(93, 29);
            this.lblCohorts.TabIndex = 42;
            this.lblCohorts.Text = "Cohorts";
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblGroups.Location = new System.Drawing.Point(1118, 29);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(86, 29);
            this.lblGroups.TabIndex = 41;
            this.lblGroups.Text = "Groups";
            // 
            // cbFind_Group
            // 
            this.cbFind_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Group.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Group.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Group.FormattingEnabled = true;
            this.cbFind_Group.Location = new System.Drawing.Point(939, 133);
            this.cbFind_Group.Name = "cbFind_Group";
            this.cbFind_Group.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Group.TabIndex = 39;
            this.cbFind_Group.Tag = "Find Group";
            this.cbFind_Group.Text = "Find Group";
            this.cbFind_Group.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Group
            // 
            this.pbFind_Group.BackColor = System.Drawing.Color.White;
            this.pbFind_Group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Group.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Group.Location = new System.Drawing.Point(927, 119);
            this.pbFind_Group.Name = "pbFind_Group";
            this.pbFind_Group.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Group.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Group.TabIndex = 38;
            this.pbFind_Group.TabStop = false;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.White;
            this.btnDeleteGroup.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnDeleteGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteGroup.FlatAppearance.BorderSize = 0;
            this.btnDeleteGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGroup.Location = new System.Drawing.Point(460, 123);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(160, 53);
            this.btnDeleteGroup.TabIndex = 37;
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.BackColor = System.Drawing.Color.White;
            this.btnUpdateGroup.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnUpdateGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateGroup.FlatAppearance.BorderSize = 0;
            this.btnUpdateGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGroup.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGroup.Location = new System.Drawing.Point(282, 123);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(160, 53);
            this.btnUpdateGroup.TabIndex = 36;
            this.btnUpdateGroup.Text = "Update";
            this.btnUpdateGroup.UseVisualStyleBackColor = false;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.White;
            this.btnAddGroup.BackgroundImage = global::DeskEtu.Properties.Resources.Add_1;
            this.btnAddGroup.FlatAppearance.BorderSize = 0;
            this.btnAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.Location = new System.Drawing.Point(141, 127);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(123, 45);
            this.btnAddGroup.TabIndex = 35;
            this.btnAddGroup.Text = "Create";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // lvGroups
            // 
            this.lvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGroups.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGroups.ForeColor = System.Drawing.Color.DimGray;
            this.lvGroups.HideSelection = false;
            this.lvGroups.Location = new System.Drawing.Point(141, 217);
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(1175, 490);
            this.lvGroups.TabIndex = 43;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            this.lvGroups.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(1261, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 46;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindRecord_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::DeskEtu.Properties.Resources.Main_Button;
            this.pictureBox4.Location = new System.Drawing.Point(1081, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // GroupsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvGroups);
            this.Controls.Add(this.cbFind_Group);
            this.Controls.Add(this.pbFind_Group);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnUpdateGroup);
            this.Controls.Add(this.lblCohorts);
            this.Controls.Add(this.lblGroups);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupsScreen";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.GroupsScreen_Load);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.btnAddGroup, 0);
            this.Controls.SetChildIndex(this.lblGroups, 0);
            this.Controls.SetChildIndex(this.lblCohorts, 0);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.btnUpdateGroup, 0);
            this.Controls.SetChildIndex(this.btnDeleteGroup, 0);
            this.Controls.SetChildIndex(this.pbFind_Group, 0);
            this.Controls.SetChildIndex(this.cbFind_Group, 0);
            this.Controls.SetChildIndex(this.lvGroups, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCohorts;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.ComboBox cbFind_Group;
        private System.Windows.Forms.PictureBox pbFind_Group;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Button btnAddGroup;
        public System.Windows.Forms.ListView lvGroups;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}