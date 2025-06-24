namespace Unicom_TIC.Views.LecturerView
{
    partial class Lecturer_Marks
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MarksStudentID = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MarksScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MarksView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MarksExam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MarksSubject = new System.Windows.Forms.ComboBox();
            this.r = new System.Windows.Forms.Label();
            this.TimetabeDelete = new System.Windows.Forms.Button();
            this.TimetableSave = new System.Windows.Forms.Button();
            this.TimetableUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarksView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.30769F));
            this.tableLayoutPanel2.Controls.Add(this.MarksStudentID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Score, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MarksScore, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(677, 219);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 134);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // MarksStudentID
            // 
            this.MarksStudentID.Location = new System.Drawing.Point(108, 70);
            this.MarksStudentID.Name = "MarksStudentID";
            this.MarksStudentID.Size = new System.Drawing.Size(202, 20);
            this.MarksStudentID.TabIndex = 18;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(3, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(35, 13);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "StudentID";
            // 
            // MarksScore
            // 
            this.MarksScore.Location = new System.Drawing.Point(108, 3);
            this.MarksScore.Name = "MarksScore";
            this.MarksScore.Size = new System.Drawing.Size(202, 20);
            this.MarksScore.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marks Management";
            // 
            // MarksView
            // 
            this.MarksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksView.Location = new System.Drawing.Point(312, 394);
            this.MarksView.Name = "MarksView";
            this.MarksView.Size = new System.Drawing.Size(637, 210);
            this.MarksView.TabIndex = 23;
            this.MarksView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MarksView_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38639F));
            this.tableLayoutPanel1.Controls.Add(this.MarksExam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MarksSubject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.r, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 219);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 134);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // MarksExam
            // 
            this.MarksExam.FormattingEnabled = true;
            this.MarksExam.Location = new System.Drawing.Point(114, 70);
            this.MarksExam.Name = "MarksExam";
            this.MarksExam.Size = new System.Drawing.Size(218, 21);
            this.MarksExam.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exam";
            // 
            // MarksSubject
            // 
            this.MarksSubject.FormattingEnabled = true;
            this.MarksSubject.Location = new System.Drawing.Point(114, 3);
            this.MarksSubject.Name = "MarksSubject";
            this.MarksSubject.Size = new System.Drawing.Size(218, 21);
            this.MarksSubject.TabIndex = 9;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(3, 0);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(43, 13);
            this.r.TabIndex = 2;
            this.r.Text = "Subject";
            // 
            // TimetabeDelete
            // 
            this.TimetabeDelete.Location = new System.Drawing.Point(219, 699);
            this.TimetabeDelete.Name = "TimetabeDelete";
            this.TimetabeDelete.Size = new System.Drawing.Size(75, 23);
            this.TimetabeDelete.TabIndex = 28;
            this.TimetabeDelete.Text = "Delete";
            this.TimetabeDelete.UseVisualStyleBackColor = true;
            this.TimetabeDelete.Click += new System.EventHandler(this.TimetabeDelete_Click);
            // 
            // TimetableSave
            // 
            this.TimetableSave.Location = new System.Drawing.Point(933, 683);
            this.TimetableSave.Name = "TimetableSave";
            this.TimetableSave.Size = new System.Drawing.Size(75, 23);
            this.TimetableSave.TabIndex = 27;
            this.TimetableSave.Text = "Save";
            this.TimetableSave.UseVisualStyleBackColor = true;
            this.TimetableSave.Click += new System.EventHandler(this.TimetableSave_Click);
            // 
            // TimetableUpdate
            // 
            this.TimetableUpdate.Location = new System.Drawing.Point(606, 699);
            this.TimetableUpdate.Name = "TimetableUpdate";
            this.TimetableUpdate.Size = new System.Drawing.Size(75, 23);
            this.TimetableUpdate.TabIndex = 26;
            this.TimetableUpdate.Text = "Update";
            this.TimetableUpdate.UseVisualStyleBackColor = true;
            this.TimetableUpdate.Click += new System.EventHandler(this.TimetableUpdate_Click);
            // 
            // Lecturer_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimetabeDelete);
            this.Controls.Add(this.TimetableSave);
            this.Controls.Add(this.TimetableUpdate);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarksView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Lecturer_Marks";
            this.Size = new System.Drawing.Size(1267, 811);
            this.Load += new System.EventHandler(this.Lecturer_Marks_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarksView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox MarksStudentID;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MarksScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MarksView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox MarksExam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MarksSubject;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Button TimetabeDelete;
        private System.Windows.Forms.Button TimetableSave;
        private System.Windows.Forms.Button TimetableUpdate;
    }
}
