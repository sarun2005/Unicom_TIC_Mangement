namespace Unicom_TIC.Views.StudentView
{
    partial class Student_Details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentStudentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TableLayoutPanel();
            this.StudentFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentMale = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentCourse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentDOB = new System.Windows.Forms.DateTimePicker();
            this.StudentAddress = new System.Windows.Forms.TextBox();
            this.StudentLastName = new System.Windows.Forms.TextBox();
            this.StudentFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.s.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentStudentID
            // 
            this.StudentStudentID.Location = new System.Drawing.Point(178, 3);
            this.StudentStudentID.Name = "StudentStudentID";
            this.StudentStudentID.Size = new System.Drawing.Size(224, 20);
            this.StudentStudentID.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Student ID";
            // 
            // s
            // 
            this.s.ColumnCount = 3;
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23214F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.s.Controls.Add(this.StudentFemale, 2, 0);
            this.s.Controls.Add(this.label4, 0, 0);
            this.s.Controls.Add(this.StudentMale, 1, 0);
            this.s.Location = new System.Drawing.Point(250, 545);
            this.s.Name = "s";
            this.s.RowCount = 1;
            this.s.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.s.Size = new System.Drawing.Size(448, 41);
            this.s.TabIndex = 38;
            // 
            // StudentFemale
            // 
            this.StudentFemale.AutoSize = true;
            this.StudentFemale.Location = new System.Drawing.Point(301, 3);
            this.StudentFemale.Name = "StudentFemale";
            this.StudentFemale.Size = new System.Drawing.Size(59, 17);
            this.StudentFemale.TabIndex = 16;
            this.StudentFemale.TabStop = true;
            this.StudentFemale.Text = "Female";
            this.StudentFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // StudentMale
            // 
            this.StudentMale.AutoSize = true;
            this.StudentMale.Location = new System.Drawing.Point(179, 3);
            this.StudentMale.Name = "StudentMale";
            this.StudentMale.Size = new System.Drawing.Size(48, 17);
            this.StudentMale.TabIndex = 15;
            this.StudentMale.TabStop = true;
            this.StudentMale.Text = "Male";
            this.StudentMale.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StudentStudentID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StudentCourse, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.StudentPhoneNumber, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.StudentEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.StudentDOB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.StudentAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.StudentLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StudentFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(250, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 325);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // StudentCourse
            // 
            this.StudentCourse.FormattingEnabled = true;
            this.StudentCourse.Location = new System.Drawing.Point(178, 283);
            this.StudentCourse.Name = "StudentCourse";
            this.StudentCourse.Size = new System.Drawing.Size(225, 21);
            this.StudentCourse.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Course";
            // 
            // StudentPhoneNumber
            // 
            this.StudentPhoneNumber.Location = new System.Drawing.Point(178, 243);
            this.StudentPhoneNumber.Name = "StudentPhoneNumber";
            this.StudentPhoneNumber.Size = new System.Drawing.Size(224, 20);
            this.StudentPhoneNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone Number";
            // 
            // StudentEmail
            // 
            this.StudentEmail.Location = new System.Drawing.Point(178, 203);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(224, 20);
            this.StudentEmail.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // StudentDOB
            // 
            this.StudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StudentDOB.Location = new System.Drawing.Point(178, 163);
            this.StudentDOB.Name = "StudentDOB";
            this.StudentDOB.Size = new System.Drawing.Size(224, 20);
            this.StudentDOB.TabIndex = 15;
            // 
            // StudentAddress
            // 
            this.StudentAddress.Location = new System.Drawing.Point(178, 123);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(224, 20);
            this.StudentAddress.TabIndex = 10;
            // 
            // StudentLastName
            // 
            this.StudentLastName.Location = new System.Drawing.Point(178, 83);
            this.StudentLastName.Name = "StudentLastName";
            this.StudentLastName.Size = new System.Drawing.Size(224, 20);
            this.StudentLastName.TabIndex = 9;
            // 
            // StudentFirstName
            // 
            this.StudentFirstName.Location = new System.Drawing.Point(178, 43);
            this.StudentFirstName.Name = "StudentFirstName";
            this.StudentFirstName.Size = new System.Drawing.Size(224, 20);
            this.StudentFirstName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Your Details";
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.s);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Student_Details";
            this.Size = new System.Drawing.Size(988, 720);
            this.Load += new System.EventHandler(this.Student_Details_Load);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentStudentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel s;
        private System.Windows.Forms.RadioButton StudentFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton StudentMale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker StudentDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentLastName;
        private System.Windows.Forms.TextBox StudentPhoneNumber;
        private System.Windows.Forms.TextBox StudentFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentEmail;
        private System.Windows.Forms.ComboBox StudentCourse;
        private System.Windows.Forms.Label label1;
    }
}
