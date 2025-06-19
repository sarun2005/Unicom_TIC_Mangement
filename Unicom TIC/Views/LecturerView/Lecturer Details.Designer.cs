namespace Unicom_TIC.Views.LecturerView
{
    partial class Lecturer_Details
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
            this.s = new System.Windows.Forms.TableLayoutPanel();
            this.LecturerFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LecturerMale = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.LecturerLecturerID = new System.Windows.Forms.TextBox();
            this.LecturerPhoneNumber = new System.Windows.Forms.TextBox();
            this.LecturerEmail = new System.Windows.Forms.TextBox();
            this.LecturerSubject = new System.Windows.Forms.ComboBox();
            this.LecturerDOB = new System.Windows.Forms.DateTimePicker();
            this.LecturerAddress = new System.Windows.Forms.TextBox();
            this.LecturerLastName = new System.Windows.Forms.TextBox();
            this.LecturerFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.s.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.ColumnCount = 3;
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23214F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.s.Controls.Add(this.LecturerFemale, 2, 0);
            this.s.Controls.Add(this.label4, 0, 0);
            this.s.Controls.Add(this.LecturerMale, 1, 0);
            this.s.Location = new System.Drawing.Point(134, 534);
            this.s.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.s.Name = "s";
            this.s.RowCount = 1;
            this.s.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.s.Size = new System.Drawing.Size(522, 41);
            this.s.TabIndex = 31;
            // 
            // LecturerFemale
            // 
            this.LecturerFemale.AutoSize = true;
            this.LecturerFemale.Location = new System.Drawing.Point(351, 3);
            this.LecturerFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerFemale.Name = "LecturerFemale";
            this.LecturerFemale.Size = new System.Drawing.Size(65, 17);
            this.LecturerFemale.TabIndex = 16;
            this.LecturerFemale.TabStop = true;
            this.LecturerFemale.Text = "Female";
            this.LecturerFemale.UseVisualStyleBackColor = true;
            this.LecturerFemale.CheckedChanged += new System.EventHandler(this.LecturerFemale_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // LecturerMale
            // 
            this.LecturerMale.AutoSize = true;
            this.LecturerMale.Location = new System.Drawing.Point(209, 3);
            this.LecturerMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerMale.Name = "LecturerMale";
            this.LecturerMale.Size = new System.Drawing.Size(52, 17);
            this.LecturerMale.TabIndex = 15;
            this.LecturerMale.TabStop = true;
            this.LecturerMale.Text = "Male";
            this.LecturerMale.UseVisualStyleBackColor = true;
            this.LecturerMale.CheckedChanged += new System.EventHandler(this.LecturerMale_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LecturerLecturerID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LecturerPhoneNumber, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LecturerEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.LecturerSubject, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LecturerDOB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LecturerAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LecturerLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LecturerFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 207);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 324);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Lecturer ID";
            // 
            // LecturerLecturerID
            // 
            this.LecturerLecturerID.Location = new System.Drawing.Point(207, 3);
            this.LecturerLecturerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerLecturerID.Name = "LecturerLecturerID";
            this.LecturerLecturerID.Size = new System.Drawing.Size(260, 20);
            this.LecturerLecturerID.TabIndex = 33;
            this.LecturerLecturerID.TextChanged += new System.EventHandler(this.LecturerLecturerID_TextChanged);
            // 
            // LecturerPhoneNumber
            // 
            this.LecturerPhoneNumber.Location = new System.Drawing.Point(207, 283);
            this.LecturerPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerPhoneNumber.Name = "LecturerPhoneNumber";
            this.LecturerPhoneNumber.Size = new System.Drawing.Size(260, 20);
            this.LecturerPhoneNumber.TabIndex = 11;
            this.LecturerPhoneNumber.TextChanged += new System.EventHandler(this.LecturerPhoneNumber_TextChanged);
            // 
            // LecturerEmail
            // 
            this.LecturerEmail.Location = new System.Drawing.Point(207, 243);
            this.LecturerEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerEmail.Name = "LecturerEmail";
            this.LecturerEmail.Size = new System.Drawing.Size(260, 20);
            this.LecturerEmail.TabIndex = 18;
            this.LecturerEmail.TextChanged += new System.EventHandler(this.LecturerEmail_TextChanged);
            // 
            // LecturerSubject
            // 
            this.LecturerSubject.FormattingEnabled = true;
            this.LecturerSubject.Location = new System.Drawing.Point(207, 203);
            this.LecturerSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerSubject.Name = "LecturerSubject";
            this.LecturerSubject.Size = new System.Drawing.Size(260, 21);
            this.LecturerSubject.TabIndex = 2;
            this.LecturerSubject.SelectedIndexChanged += new System.EventHandler(this.LecturerSubject_SelectedIndexChanged);
            // 
            // LecturerDOB
            // 
            this.LecturerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LecturerDOB.Location = new System.Drawing.Point(207, 163);
            this.LecturerDOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerDOB.Name = "LecturerDOB";
            this.LecturerDOB.Size = new System.Drawing.Size(260, 20);
            this.LecturerDOB.TabIndex = 15;
            this.LecturerDOB.ValueChanged += new System.EventHandler(this.LecturerDOB_ValueChanged);
            // 
            // LecturerAddress
            // 
            this.LecturerAddress.Location = new System.Drawing.Point(207, 123);
            this.LecturerAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerAddress.Name = "LecturerAddress";
            this.LecturerAddress.Size = new System.Drawing.Size(260, 20);
            this.LecturerAddress.TabIndex = 10;
            this.LecturerAddress.TextChanged += new System.EventHandler(this.LecturerAddress_TextChanged);
            // 
            // LecturerLastName
            // 
            this.LecturerLastName.Location = new System.Drawing.Point(207, 83);
            this.LecturerLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerLastName.Name = "LecturerLastName";
            this.LecturerLastName.Size = new System.Drawing.Size(260, 20);
            this.LecturerLastName.TabIndex = 9;
            this.LecturerLastName.TextChanged += new System.EventHandler(this.AdminLecturerAddLastName_TextChanged);
            // 
            // LecturerFirstName
            // 
            this.LecturerFirstName.Location = new System.Drawing.Point(207, 43);
            this.LecturerFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LecturerFirstName.Name = "LecturerFirstName";
            this.LecturerFirstName.Size = new System.Drawing.Size(260, 20);
            this.LecturerFirstName.TabIndex = 3;
            this.LecturerFirstName.TextChanged += new System.EventHandler(this.LecturerFirstName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Subject";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Your Details";
            // 
            // Lecturer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.s);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Lecturer_Details";
            this.Size = new System.Drawing.Size(815, 669);
            this.Load += new System.EventHandler(this.Lecturer_Details_Load);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel s;
        private System.Windows.Forms.RadioButton LecturerFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton LecturerMale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker LecturerDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LecturerLastName;
        private System.Windows.Forms.TextBox LecturerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LecturerAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LecturerSubject;
        private System.Windows.Forms.TextBox LecturerEmail;
        private System.Windows.Forms.TextBox LecturerPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LecturerLecturerID;
    }
}
