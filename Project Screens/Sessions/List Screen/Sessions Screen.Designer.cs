namespace DeskEtu
{
    partial class Sessions_Screen
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
            this.lblResults = new System.Windows.Forms.Label();
            this.cbFind_Sessions = new System.Windows.Forms.ComboBox();
            this.pbFind_sessions = new System.Windows.Forms.PictureBox();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnUpdateSession = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lvSessions = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_sessions)).BeginInit();
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
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblResults.Location = new System.Drawing.Point(1103, 30);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(103, 29);
            this.lblResults.TabIndex = 40;
            this.lblResults.Text = "Sessions";
            // 
            // cbFind_Sessions
            // 
            this.cbFind_Sessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Sessions.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Sessions.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Sessions.FormattingEnabled = true;
            this.cbFind_Sessions.Location = new System.Drawing.Point(939, 133);
            this.cbFind_Sessions.Name = "cbFind_Sessions";
            this.cbFind_Sessions.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Sessions.TabIndex = 39;
            this.cbFind_Sessions.Tag = "Find Session";
            this.cbFind_Sessions.Text = "Find Session";
            this.cbFind_Sessions.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_sessions
            // 
            this.pbFind_sessions.BackColor = System.Drawing.Color.White;
            this.pbFind_sessions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_sessions.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_sessions.Location = new System.Drawing.Point(927, 119);
            this.pbFind_sessions.Name = "pbFind_sessions";
            this.pbFind_sessions.Size = new System.Drawing.Size(389, 61);
            this.pbFind_sessions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_sessions.TabIndex = 38;
            this.pbFind_sessions.TabStop = false;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.BackColor = System.Drawing.Color.White;
            this.btnDeleteSession.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnDeleteSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteSession.FlatAppearance.BorderSize = 0;
            this.btnDeleteSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSession.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSession.Location = new System.Drawing.Point(460, 123);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(160, 53);
            this.btnDeleteSession.TabIndex = 37;
            this.btnDeleteSession.Text = "Delete";
            this.btnDeleteSession.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSession
            // 
            this.btnUpdateSession.BackColor = System.Drawing.Color.White;
            this.btnUpdateSession.BackgroundImage = global::DeskEtu.Properties.Resources.U_D_1;
            this.btnUpdateSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateSession.FlatAppearance.BorderSize = 0;
            this.btnUpdateSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSession.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSession.Location = new System.Drawing.Point(282, 123);
            this.btnUpdateSession.Name = "btnUpdateSession";
            this.btnUpdateSession.Size = new System.Drawing.Size(160, 53);
            this.btnUpdateSession.TabIndex = 36;
            this.btnUpdateSession.Text = "Update";
            this.btnUpdateSession.UseVisualStyleBackColor = false;
            this.btnUpdateSession.Click += new System.EventHandler(this.UpdateSession_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.BackColor = System.Drawing.Color.White;
            this.btnAddSession.BackgroundImage = global::DeskEtu.Properties.Resources.Add_1;
            this.btnAddSession.FlatAppearance.BorderSize = 0;
            this.btnAddSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSession.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSession.Location = new System.Drawing.Point(141, 127);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(123, 45);
            this.btnAddSession.TabIndex = 35;
            this.btnAddSession.Text = "Create";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.AddSession_Click);
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
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // lvSessions
            // 
            this.lvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSessions.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSessions.ForeColor = System.Drawing.Color.DimGray;
            this.lvSessions.HideSelection = false;
            this.lvSessions.Location = new System.Drawing.Point(141, 217);
            this.lvSessions.Name = "lvSessions";
            this.lvSessions.Size = new System.Drawing.Size(1175, 490);
            this.lvSessions.TabIndex = 59;
            this.lvSessions.UseCompatibleStateImageBehavior = false;
            this.lvSessions.View = System.Windows.Forms.View.Details;
            // 
            // pbFindSingleRecord
            // 
            this.pbFindSingleRecord.BackColor = System.Drawing.Color.White;
            this.pbFindSingleRecord.Image = global::DeskEtu.Properties.Resources.Find_1;
            this.pbFindSingleRecord.Location = new System.Drawing.Point(1261, 129);
            this.pbFindSingleRecord.Name = "pbFindSingleRecord";
            this.pbFindSingleRecord.Size = new System.Drawing.Size(40, 40);
            this.pbFindSingleRecord.TabIndex = 60;
            this.pbFindSingleRecord.TabStop = false;
            this.pbFindSingleRecord.Click += new System.EventHandler(this.pbFindRecord_Click);
            // 
            // Sessions_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvSessions);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cbFind_Sessions);
            this.Controls.Add(this.pbFind_sessions);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.btnUpdateSession);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sessions_Screen";
            this.Text = "Sessions_Screen";
            this.Load += new System.EventHandler(this.SessionsScreen_Load);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.btnAddSession, 0);
            this.Controls.SetChildIndex(this.btnUpdateSession, 0);
            this.Controls.SetChildIndex(this.btnDeleteSession, 0);
            this.Controls.SetChildIndex(this.pbFind_sessions, 0);
            this.Controls.SetChildIndex(this.cbFind_Sessions, 0);
            this.Controls.SetChildIndex(this.lblResults, 0);
            this.Controls.SetChildIndex(this.lvSessions, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_sessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cbFind_Sessions;
        private System.Windows.Forms.PictureBox pbFind_sessions;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnUpdateSession;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.ListView lvSessions;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}