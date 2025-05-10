namespace DeskEtu
{
    partial class EmployeesScreen
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cbFind_Employee = new System.Windows.Forms.ComboBox();
            this.pbFind_Employee = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.pbFindSingleRecord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Employee)).BeginInit();
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
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.lblEmployee.Location = new System.Drawing.Point(1090, 29);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(123, 29);
            this.lblEmployee.TabIndex = 47;
            this.lblEmployee.Text = "Employees";
            // 
            // cbFind_Employee
            // 
            this.cbFind_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind_Employee.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind_Employee.ForeColor = System.Drawing.Color.Gray;
            this.cbFind_Employee.FormattingEnabled = true;
            this.cbFind_Employee.Location = new System.Drawing.Point(547, 133);
            this.cbFind_Employee.Name = "cbFind_Employee";
            this.cbFind_Employee.Size = new System.Drawing.Size(362, 33);
            this.cbFind_Employee.TabIndex = 45;
            this.cbFind_Employee.Tag = "Find Employee";
            this.cbFind_Employee.Text = "Find Employee";
            this.cbFind_Employee.TextChanged += new System.EventHandler(this.FillTable);
            // 
            // pbFind_Employee
            // 
            this.pbFind_Employee.BackColor = System.Drawing.Color.White;
            this.pbFind_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFind_Employee.Image = global::DeskEtu.Properties.Resources.Search_bar_1;
            this.pbFind_Employee.Location = new System.Drawing.Point(534, 119);
            this.pbFind_Employee.Name = "pbFind_Employee";
            this.pbFind_Employee.Size = new System.Drawing.Size(389, 61);
            this.pbFind_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind_Employee.TabIndex = 44;
            this.pbFind_Employee.TabStop = false;
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
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // lvEmployee
            // 
            this.lvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEmployee.Font = new System.Drawing.Font("SF Pro Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.lvEmployee.HideSelection = false;
            this.lvEmployee.Location = new System.Drawing.Point(141, 217);
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(1175, 490);
            this.lvEmployee.TabIndex = 61;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.View = System.Windows.Forms.View.Details;
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
            // EmployeesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pbFindSingleRecord);
            this.Controls.Add(this.lvEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cbFind_Employee);
            this.Controls.Add(this.pbFind_Employee);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesScreen";
            this.Text = "EmployeesScreen";
            this.Load += new System.EventHandler(this.Employee_Screen_Load);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.btnQA_Enrollment, 0);
            this.Controls.SetChildIndex(this.btnQA_Teaching, 0);
            this.Controls.SetChildIndex(this.btnQA_Employees, 0);
            this.Controls.SetChildIndex(this.btnQA_Structure, 0);
            this.Controls.SetChildIndex(this.pbFind_Employee, 0);
            this.Controls.SetChildIndex(this.cbFind_Employee, 0);
            this.Controls.SetChildIndex(this.lblEmployee, 0);
            this.Controls.SetChildIndex(this.lvEmployee, 0);
            this.Controls.SetChildIndex(this.pbFindSingleRecord, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFind_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindSingleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbFind_Employee;
        private System.Windows.Forms.PictureBox pbFind_Employee;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.PictureBox pbFindSingleRecord;
    }
}