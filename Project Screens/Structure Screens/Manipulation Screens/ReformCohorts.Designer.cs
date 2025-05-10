namespace DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens
{
    partial class ReformCohorts
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
            this.txtEnter_Cohort = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.pbEnter_Cohort = new System.Windows.Forms.PictureBox();
            this.cbFind_Year = new System.Windows.Forms.ComboBox();
            this.pbFind_Year = new System.Windows.Forms.PictureBox();
            this.cbFind_Group = new System.Windows.Forms.ComboBox();
            this.pbFind_Group = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter_Cohort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeskEtu.Properties.Resources.Reform_Cohorts_Teaching_Tk;
            this.pictureBox1.Location = new System.Drawing.Point(426, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEnter_Cohort
            // 
            this.txtEnter_Cohort.BackColor = System.Drawing.Color.White;
            this.txtEnter_Cohort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnter_Cohort.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter_Cohort.ForeColor = System.Drawing.Color.Gray;
            this.txtEnter_Cohort.Location = new System.Drawing.Point(521, 424);
            this.txtEnter_Cohort.MaxLength = 999;
            this.txtEnter_Cohort.Multiline = true;
            this.txtEnter_Cohort.Name = "txtEnter_Cohort";
            this.txtEnter_Cohort.Size = new System.Drawing.Size(285, 28);
            this.txtEnter_Cohort.TabIndex = 55;
            this.txtEnter_Cohort.Tag = "01";
            this.txtEnter_Cohort.Text = "01";
            this.txtEnter_Cohort.Validating += new System.ComponentModel.CancelEventHandler(this.NumberValidation);
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
            this.btnDone.Location = new System.Drawing.Point(819, 531);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(123, 45);
            this.btnDone.TabIndex = 54;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pbEnter_Cohort
            // 
            this.pbEnter_Cohort.BackColor = System.Drawing.Color.White;
            this.pbEnter_Cohort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEnter_Cohort.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbEnter_Cohort.Location = new System.Drawing.Point(508, 408);
            this.pbEnter_Cohort.Name = "pbEnter_Cohort";
            this.pbEnter_Cohort.Size = new System.Drawing.Size(389, 61);
            this.pbEnter_Cohort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEnter_Cohort.TabIndex = 53;
            this.pbEnter_Cohort.TabStop = false;
            // 
            // cbFind_Year
            // 
            this.cbFind_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Year.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Year.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Year.FormattingEnabled = true;
            this.cbFind_Year.Location = new System.Drawing.Point(521, 256);
            this.cbFind_Year.Name = "cbFind_Year";
            this.cbFind_Year.Size = new System.Drawing.Size(305, 33);
            this.cbFind_Year.TabIndex = 52;
            this.cbFind_Year.Tag = "Year";
            this.cbFind_Year.Text = "Year";
            this.cbFind_Year.SelectedIndexChanged += new System.EventHandler(this.LoadGroupsWhenEnter);
            this.cbFind_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Year
            // 
            this.pbFind_Year.BackColor = System.Drawing.Color.White;
            this.pbFind_Year.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Year.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Year.Location = new System.Drawing.Point(508, 242);
            this.pbFind_Year.Name = "pbFind_Year";
            this.pbFind_Year.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Year.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Year.TabIndex = 51;
            this.pbFind_Year.TabStop = false;
            // 
            // cbFind_Group
            // 
            this.cbFind_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Group.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Group.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Group.FormattingEnabled = true;
            this.cbFind_Group.Location = new System.Drawing.Point(521, 339);
            this.cbFind_Group.Name = "cbFind_Group";
            this.cbFind_Group.Size = new System.Drawing.Size(290, 33);
            this.cbFind_Group.TabIndex = 57;
            this.cbFind_Group.Tag = "Group";
            this.cbFind_Group.Text = "Group";
            this.cbFind_Group.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Group
            // 
            this.pbFind_Group.BackColor = System.Drawing.Color.White;
            this.pbFind_Group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Group.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Group.Location = new System.Drawing.Point(508, 325);
            this.pbFind_Group.Name = "pbFind_Group";
            this.pbFind_Group.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Group.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Group.TabIndex = 56;
            this.pbFind_Group.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(812, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 102;
            this.label3.Text = "Cohort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(817, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(832, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 100;
            this.label1.Text = "Year";
            // 
            // ReformCohorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFind_Group);
            this.Controls.Add(this.pbFind_Group);
            this.Controls.Add(this.txtEnter_Cohort);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pbEnter_Cohort);
            this.Controls.Add(this.cbFind_Year);
            this.Controls.Add(this.pbFind_Year);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReformCohorts";
            this.Text = "ReformCohorts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.FormOpen);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pbFind_Year, 0);
            this.Controls.SetChildIndex(this.cbFind_Year, 0);
            this.Controls.SetChildIndex(this.pbEnter_Cohort, 0);
            this.Controls.SetChildIndex(this.btnDone, 0);
            this.Controls.SetChildIndex(this.txtEnter_Cohort, 0);
            this.Controls.SetChildIndex(this.pbFind_Group, 0);
            this.Controls.SetChildIndex(this.cbFind_Group, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter_Cohort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEnter_Cohort;
        public System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pbEnter_Cohort;
        private System.Windows.Forms.ComboBox cbFind_Year;
        private System.Windows.Forms.PictureBox pbFind_Year;
        private System.Windows.Forms.ComboBox cbFind_Group;
        private System.Windows.Forms.PictureBox pbFind_Group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}