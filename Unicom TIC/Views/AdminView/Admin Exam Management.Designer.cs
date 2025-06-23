namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Exam_Management
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
            this.AdminExamView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminSubjectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminExamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminExamSave = new System.Windows.Forms.Button();
            this.AdminExamUpdate = new System.Windows.Forms.Button();
            this.AdminExamDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ExamDate = new System.Windows.Forms.DateTimePicker();
            this.ExamStartTime = new System.Windows.Forms.DateTimePicker();
            this.ExamEndTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AdminExamView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminExamView
            // 
            this.AdminExamView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminExamView.Location = new System.Drawing.Point(236, 375);
            this.AdminExamView.Name = "AdminExamView";
            this.AdminExamView.Size = new System.Drawing.Size(520, 155);
            this.AdminExamView.TabIndex = 0;
            this.AdminExamView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminExamView_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.82555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.17445F));
            this.tableLayoutPanel1.Controls.Add(this.AdminSubjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminExamName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 125);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AdminSubjectName
            // 
            this.AdminSubjectName.FormattingEnabled = true;
            this.AdminSubjectName.Location = new System.Drawing.Point(118, 65);
            this.AdminSubjectName.Name = "AdminSubjectName";
            this.AdminSubjectName.Size = new System.Drawing.Size(194, 21);
            this.AdminSubjectName.TabIndex = 6;
            this.AdminSubjectName.SelectedIndexChanged += new System.EventHandler(this.AdminSubjectName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exam Name";
            // 
            // AdminExamName
            // 
            this.AdminExamName.Location = new System.Drawing.Point(118, 3);
            this.AdminExamName.Name = "AdminExamName";
            this.AdminExamName.Size = new System.Drawing.Size(194, 20);
            this.AdminExamName.TabIndex = 2;
            this.AdminExamName.TextChanged += new System.EventHandler(this.AdminExamName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exam Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdminExamSave
            // 
            this.AdminExamSave.Location = new System.Drawing.Point(805, 571);
            this.AdminExamSave.Name = "AdminExamSave";
            this.AdminExamSave.Size = new System.Drawing.Size(75, 23);
            this.AdminExamSave.TabIndex = 5;
            this.AdminExamSave.Text = "Save";
            this.AdminExamSave.UseVisualStyleBackColor = true;
            this.AdminExamSave.Click += new System.EventHandler(this.AdminExamSave_Click);
            // 
            // AdminExamUpdate
            // 
            this.AdminExamUpdate.Location = new System.Drawing.Point(442, 571);
            this.AdminExamUpdate.Name = "AdminExamUpdate";
            this.AdminExamUpdate.Size = new System.Drawing.Size(75, 23);
            this.AdminExamUpdate.TabIndex = 6;
            this.AdminExamUpdate.Text = "Update";
            this.AdminExamUpdate.UseVisualStyleBackColor = true;
            this.AdminExamUpdate.Click += new System.EventHandler(this.AdminExamUpdate_Click);
            // 
            // AdminExamDelete
            // 
            this.AdminExamDelete.Location = new System.Drawing.Point(81, 571);
            this.AdminExamDelete.Name = "AdminExamDelete";
            this.AdminExamDelete.Size = new System.Drawing.Size(75, 23);
            this.AdminExamDelete.TabIndex = 7;
            this.AdminExamDelete.Text = "Delete";
            this.AdminExamDelete.UseVisualStyleBackColor = true;
            this.AdminExamDelete.Click += new System.EventHandler(this.AdminExamDelete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.30769F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExamDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExamStartTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExamEndTime, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(499, 132);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 161);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Start Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "End Time";
            // 
            // ExamDate
            // 
            this.ExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExamDate.Location = new System.Drawing.Point(108, 3);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(218, 20);
            this.ExamDate.TabIndex = 13;
            this.ExamDate.Value = new System.DateTime(2025, 6, 20, 6, 58, 0, 0);
            // 
            // ExamStartTime
            // 
            this.ExamStartTime.CustomFormat = "\"HH:mm\"";
            this.ExamStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExamStartTime.Location = new System.Drawing.Point(108, 56);
            this.ExamStartTime.Name = "ExamStartTime";
            this.ExamStartTime.ShowUpDown = true;
            this.ExamStartTime.Size = new System.Drawing.Size(218, 20);
            this.ExamStartTime.TabIndex = 14;
            this.ExamStartTime.Value = new System.DateTime(2025, 6, 20, 6, 0, 0, 0);
            // 
            // ExamEndTime
            // 
            this.ExamEndTime.CustomFormat = "\"HH:mm\"";
            this.ExamEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExamEndTime.Location = new System.Drawing.Point(108, 109);
            this.ExamEndTime.Name = "ExamEndTime";
            this.ExamEndTime.ShowUpDown = true;
            this.ExamEndTime.Size = new System.Drawing.Size(218, 20);
            this.ExamEndTime.TabIndex = 17;
            this.ExamEndTime.Value = new System.DateTime(2025, 6, 20, 6, 0, 0, 0);
            // 
            // Admin_Exam_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.AdminExamDelete);
            this.Controls.Add(this.AdminExamUpdate);
            this.Controls.Add(this.AdminExamSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AdminExamView);
            this.Name = "Admin_Exam_Management";
            this.Size = new System.Drawing.Size(958, 626);
            this.Load += new System.EventHandler(this.Admin_Exam_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminExamView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminExamView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminExamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminExamSave;
        private System.Windows.Forms.ComboBox AdminSubjectName;
        private System.Windows.Forms.Button AdminExamUpdate;
        private System.Windows.Forms.Button AdminExamDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ExamDate;
        private System.Windows.Forms.DateTimePicker ExamStartTime;
        private System.Windows.Forms.DateTimePicker ExamEndTime;
    }
}
