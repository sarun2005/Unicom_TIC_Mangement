namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Student_View_and_Delete_and_Update_New
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
            this.label2 = new System.Windows.Forms.Label();
            this.AdminUpdateStudentSearchText = new System.Windows.Forms.TextBox();
            this.AdminStudentDetails = new System.Windows.Forms.DataGridView();
            this.AdminStudentDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminStudentUpdateStudentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TableLayoutPanel();
            this.AdminStudentUpdateFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminStudentUpdateMale = new System.Windows.Forms.RadioButton();
            this.AdminStudentUpdateClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.AdminStudentUpdateAddress = new System.Windows.Forms.TextBox();
            this.AdminStudentUpdateLastName = new System.Windows.Forms.TextBox();
            this.AdminStudentUpdateFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminStudentUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AdminStudentUpdateDOB = new System.Windows.Forms.DateTimePicker();
            this.AdminStudentUpdateEmail = new System.Windows.Forms.TextBox();
            this.AdminStudentUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.AdminStudentUpdateCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStudentDetails)).BeginInit();
            this.s.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search";
            // 
            // AdminUpdateStudentSearchText
            // 
            this.AdminUpdateStudentSearchText.Location = new System.Drawing.Point(637, 75);
            this.AdminUpdateStudentSearchText.Name = "AdminUpdateStudentSearchText";
            this.AdminUpdateStudentSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminUpdateStudentSearchText.TabIndex = 19;
            this.AdminUpdateStudentSearchText.TextChanged += new System.EventHandler(this.AdminStudentSearchText_TextChanged);
            // 
            // AdminStudentDetails
            // 
            this.AdminStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStudentDetails.Location = new System.Drawing.Point(265, 399);
            this.AdminStudentDetails.Name = "AdminStudentDetails";
            this.AdminStudentDetails.Size = new System.Drawing.Size(742, 257);
            this.AdminStudentDetails.TabIndex = 18;
            // 
            // AdminStudentDelete
            // 
            this.AdminStudentDelete.Location = new System.Drawing.Point(604, 684);
            this.AdminStudentDelete.Name = "AdminStudentDelete";
            this.AdminStudentDelete.Size = new System.Drawing.Size(107, 29);
            this.AdminStudentDelete.TabIndex = 16;
            this.AdminStudentDelete.Text = "Delete";
            this.AdminStudentDelete.UseVisualStyleBackColor = true;
            this.AdminStudentDelete.Click += new System.EventHandler(this.AdminStudentDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student Details";
            // 
            // AdminStudentUpdateStudentID
            // 
            this.AdminStudentUpdateStudentID.Location = new System.Drawing.Point(191, 3);
            this.AdminStudentUpdateStudentID.Name = "AdminStudentUpdateStudentID";
            this.AdminStudentUpdateStudentID.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdateStudentID.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Student ID";
            // 
            // s
            // 
            this.s.ColumnCount = 3;
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23214F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.s.Controls.Add(this.AdminStudentUpdateFemale, 2, 0);
            this.s.Controls.Add(this.label4, 0, 0);
            this.s.Controls.Add(this.AdminStudentUpdateMale, 1, 0);
            this.s.Location = new System.Drawing.Point(441, 352);
            this.s.Name = "s";
            this.s.RowCount = 1;
            this.s.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.s.Size = new System.Drawing.Size(448, 41);
            this.s.TabIndex = 39;
            // 
            // AdminStudentUpdateFemale
            // 
            this.AdminStudentUpdateFemale.AutoSize = true;
            this.AdminStudentUpdateFemale.Location = new System.Drawing.Point(301, 3);
            this.AdminStudentUpdateFemale.Name = "AdminStudentUpdateFemale";
            this.AdminStudentUpdateFemale.Size = new System.Drawing.Size(59, 17);
            this.AdminStudentUpdateFemale.TabIndex = 16;
            this.AdminStudentUpdateFemale.TabStop = true;
            this.AdminStudentUpdateFemale.Text = "Female";
            this.AdminStudentUpdateFemale.UseVisualStyleBackColor = true;
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
            // AdminStudentUpdateMale
            // 
            this.AdminStudentUpdateMale.AutoSize = true;
            this.AdminStudentUpdateMale.Location = new System.Drawing.Point(179, 3);
            this.AdminStudentUpdateMale.Name = "AdminStudentUpdateMale";
            this.AdminStudentUpdateMale.Size = new System.Drawing.Size(48, 17);
            this.AdminStudentUpdateMale.TabIndex = 15;
            this.AdminStudentUpdateMale.TabStop = true;
            this.AdminStudentUpdateMale.Text = "Male";
            this.AdminStudentUpdateMale.UseVisualStyleBackColor = true;
            // 
            // AdminStudentUpdateClear
            // 
            this.AdminStudentUpdateClear.Location = new System.Drawing.Point(99, 684);
            this.AdminStudentUpdateClear.Name = "AdminStudentUpdateClear";
            this.AdminStudentUpdateClear.Size = new System.Drawing.Size(107, 29);
            this.AdminStudentUpdateClear.TabIndex = 38;
            this.AdminStudentUpdateClear.Text = "Clear";
            this.AdminStudentUpdateClear.UseVisualStyleBackColor = true;
            this.AdminStudentUpdateClear.Click += new System.EventHandler(this.AdminStudentUpdateClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.Controls.Add(this.AdminStudentUpdateStudentID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminStudentUpdateAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminStudentUpdateLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminStudentUpdateFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 222);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // AdminStudentUpdateAddress
            // 
            this.AdminStudentUpdateAddress.Location = new System.Drawing.Point(191, 168);
            this.AdminStudentUpdateAddress.Name = "AdminStudentUpdateAddress";
            this.AdminStudentUpdateAddress.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdateAddress.TabIndex = 10;
            // 
            // AdminStudentUpdateLastName
            // 
            this.AdminStudentUpdateLastName.Location = new System.Drawing.Point(191, 113);
            this.AdminStudentUpdateLastName.Name = "AdminStudentUpdateLastName";
            this.AdminStudentUpdateLastName.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdateLastName.TabIndex = 9;
            // 
            // AdminStudentUpdateFirstName
            // 
            this.AdminStudentUpdateFirstName.Location = new System.Drawing.Point(191, 58);
            this.AdminStudentUpdateFirstName.Name = "AdminStudentUpdateFirstName";
            this.AdminStudentUpdateFirstName.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdateFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "First Name";
            // 
            // AdminStudentUpdate
            // 
            this.AdminStudentUpdate.Location = new System.Drawing.Point(1108, 684);
            this.AdminStudentUpdate.Name = "AdminStudentUpdate";
            this.AdminStudentUpdate.Size = new System.Drawing.Size(107, 29);
            this.AdminStudentUpdate.TabIndex = 36;
            this.AdminStudentUpdate.Text = "Update";
            this.AdminStudentUpdate.UseVisualStyleBackColor = true;
            this.AdminStudentUpdate.Click += new System.EventHandler(this.AdminStudentUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AdminStudentUpdateDOB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AdminStudentUpdateEmail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AdminStudentUpdatePhoneNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.AdminStudentUpdateCourse, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(760, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 222);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Date Of Birth";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Course";
            // 
            // AdminStudentUpdateDOB
            // 
            this.AdminStudentUpdateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AdminStudentUpdateDOB.Location = new System.Drawing.Point(180, 3);
            this.AdminStudentUpdateDOB.Name = "AdminStudentUpdateDOB";
            this.AdminStudentUpdateDOB.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdateDOB.TabIndex = 15;
            // 
            // AdminStudentUpdateEmail
            // 
            this.AdminStudentUpdateEmail.Location = new System.Drawing.Point(180, 58);
            this.AdminStudentUpdateEmail.Name = "AdminStudentUpdateEmail";
            this.AdminStudentUpdateEmail.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdateEmail.TabIndex = 18;
            // 
            // AdminStudentUpdatePhoneNumber
            // 
            this.AdminStudentUpdatePhoneNumber.Location = new System.Drawing.Point(180, 113);
            this.AdminStudentUpdatePhoneNumber.Name = "AdminStudentUpdatePhoneNumber";
            this.AdminStudentUpdatePhoneNumber.Size = new System.Drawing.Size(224, 20);
            this.AdminStudentUpdatePhoneNumber.TabIndex = 11;
            // 
            // AdminStudentUpdateCourse
            // 
            this.AdminStudentUpdateCourse.FormattingEnabled = true;
            this.AdminStudentUpdateCourse.Location = new System.Drawing.Point(180, 168);
            this.AdminStudentUpdateCourse.Name = "AdminStudentUpdateCourse";
            this.AdminStudentUpdateCourse.Size = new System.Drawing.Size(225, 21);
            this.AdminStudentUpdateCourse.TabIndex = 23;
            // 
            // Admin_Student_View_and_Delete_and_Update_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.AdminStudentUpdateClear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AdminStudentUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminUpdateStudentSearchText);
            this.Controls.Add(this.AdminStudentDetails);
            this.Controls.Add(this.AdminStudentDelete);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Student_View_and_Delete_and_Update_New";
            this.Size = new System.Drawing.Size(1237, 717);
            this.Load += new System.EventHandler(this.Admin_Student_View_and_Delete_and_Update_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminStudentDetails)).EndInit();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminUpdateStudentSearchText;
        private System.Windows.Forms.DataGridView AdminStudentDetails;
        private System.Windows.Forms.Button AdminStudentDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminStudentUpdateStudentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel s;
        private System.Windows.Forms.RadioButton AdminStudentUpdateFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton AdminStudentUpdateMale;
        private System.Windows.Forms.Button AdminStudentUpdateClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminStudentUpdateLastName;
        private System.Windows.Forms.TextBox AdminStudentUpdateFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdminStudentUpdateAddress;
        private System.Windows.Forms.Button AdminStudentUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker AdminStudentUpdateDOB;
        private System.Windows.Forms.TextBox AdminStudentUpdateEmail;
        private System.Windows.Forms.TextBox AdminStudentUpdatePhoneNumber;
        private System.Windows.Forms.ComboBox AdminStudentUpdateCourse;
    }
}
