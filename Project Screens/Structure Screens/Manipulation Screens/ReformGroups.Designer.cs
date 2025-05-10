namespace DeskEtu.Project_Screens.Structure_Screens.Manipulation_Screens
{
    partial class ReformGroups
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
            this.cbFind_Year = new System.Windows.Forms.ComboBox();
            this.pbFind_Year = new System.Windows.Forms.PictureBox();
            this.pbEnter_Group = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtEnter_Group = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeskEtu.Properties.Resources.Reform_Groups_Tk;
            this.pictureBox1.Location = new System.Drawing.Point(409, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 366);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbFind_Year
            // 
            this.cbFind_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Year.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Year.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Year.FormattingEnabled = true;
            this.cbFind_Year.Location = new System.Drawing.Point(504, 283);
            this.cbFind_Year.Name = "cbFind_Year";
            this.cbFind_Year.Size = new System.Drawing.Size(305, 33);
            this.cbFind_Year.TabIndex = 47;
            this.cbFind_Year.Tag = "Year";
            this.cbFind_Year.Text = "Year";
            this.cbFind_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StopTyping);
            // 
            // pbFind_Year
            // 
            this.pbFind_Year.BackColor = System.Drawing.Color.White;
            this.pbFind_Year.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Year.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Year.Location = new System.Drawing.Point(491, 269);
            this.pbFind_Year.Name = "pbFind_Year";
            this.pbFind_Year.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Year.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Year.TabIndex = 46;
            this.pbFind_Year.TabStop = false;
            // 
            // pbEnter_Group
            // 
            this.pbEnter_Group.BackColor = System.Drawing.Color.White;
            this.pbEnter_Group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEnter_Group.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbEnter_Group.Location = new System.Drawing.Point(491, 361);
            this.pbEnter_Group.Name = "pbEnter_Group";
            this.pbEnter_Group.Size = new System.Drawing.Size(389, 61);
            this.pbEnter_Group.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEnter_Group.TabIndex = 48;
            this.pbEnter_Group.TabStop = false;
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
            this.btnDone.Location = new System.Drawing.Point(807, 481);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(123, 45);
            this.btnDone.TabIndex = 49;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtEnter_Group
            // 
            this.txtEnter_Group.BackColor = System.Drawing.Color.White;
            this.txtEnter_Group.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnter_Group.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter_Group.ForeColor = System.Drawing.Color.Gray;
            this.txtEnter_Group.Location = new System.Drawing.Point(504, 377);
            this.txtEnter_Group.MaxLength = 999;
            this.txtEnter_Group.Multiline = true;
            this.txtEnter_Group.Name = "txtEnter_Group";
            this.txtEnter_Group.Size = new System.Drawing.Size(362, 28);
            this.txtEnter_Group.TabIndex = 50;
            this.txtEnter_Group.Tag = "01";
            this.txtEnter_Group.Text = "01";
            this.txtEnter_Group.Validating += new System.ComponentModel.CancelEventHandler(this.GroupNumberValidation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(800, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 103;
            this.label2.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(815, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 102;
            this.label1.Text = "Year";
            // 
            // ReformGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnter_Group);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pbEnter_Group);
            this.Controls.Add(this.cbFind_Year);
            this.Controls.Add(this.pbFind_Year);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReformGroups";
            this.Text = "ReformGroups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReformGroups_FormClosing);
            this.Load += new System.EventHandler(this.ReformGroups_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pbFind_Year, 0);
            this.Controls.SetChildIndex(this.cbFind_Year, 0);
            this.Controls.SetChildIndex(this.pbEnter_Group, 0);
            this.Controls.SetChildIndex(this.btnDone, 0);
            this.Controls.SetChildIndex(this.txtEnter_Group, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFind_Year;
        private System.Windows.Forms.PictureBox pbFind_Year;
        private System.Windows.Forms.PictureBox pbEnter_Group;
        public System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtEnter_Group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}