namespace Unicom_TIC.Views.AdminView
{
    partial class Marks_Add_and_Delete_and_Update
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
            this.components = new System.ComponentModel.Container();
            this.TimetabeDelete = new System.Windows.Forms.Button();
            this.TimetableSave = new System.Windows.Forms.Button();
            this.TimetableUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminMarksStudentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminMarksScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminMarksView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminMarksExam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmdminMarksCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMarksView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimetabeDelete
            // 
            this.TimetabeDelete.Location = new System.Drawing.Point(56, 582);
            this.TimetabeDelete.Name = "TimetabeDelete";
            this.TimetabeDelete.Size = new System.Drawing.Size(75, 23);
            this.TimetabeDelete.TabIndex = 24;
            this.TimetabeDelete.Text = "Delete";
            this.TimetabeDelete.UseVisualStyleBackColor = true;
            // 
            // TimetableSave
            // 
            this.TimetableSave.Location = new System.Drawing.Point(770, 566);
            this.TimetableSave.Name = "TimetableSave";
            this.TimetableSave.Size = new System.Drawing.Size(75, 23);
            this.TimetableSave.TabIndex = 23;
            this.TimetableSave.Text = "Save";
            this.TimetableSave.UseVisualStyleBackColor = true;
            this.TimetableSave.Click += new System.EventHandler(this.TimetableSave_Click);
            // 
            // TimetableUpdate
            // 
            this.TimetableUpdate.Location = new System.Drawing.Point(443, 582);
            this.TimetableUpdate.Name = "TimetableUpdate";
            this.TimetableUpdate.Size = new System.Drawing.Size(75, 23);
            this.TimetableUpdate.TabIndex = 22;
            this.TimetableUpdate.Text = "Update";
            this.TimetableUpdate.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.30769F));
            this.tableLayoutPanel2.Controls.Add(this.AdminMarksStudentID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AdminMarksScore, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 134);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // AdminMarksStudentID
            // 
            this.AdminMarksStudentID.Location = new System.Drawing.Point(108, 70);
            this.AdminMarksStudentID.Name = "AdminMarksStudentID";
            this.AdminMarksStudentID.Size = new System.Drawing.Size(202, 20);
            this.AdminMarksStudentID.TabIndex = 18;
            this.AdminMarksStudentID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Score";
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
            // AdminMarksScore
            // 
            this.AdminMarksScore.Location = new System.Drawing.Point(108, 3);
            this.AdminMarksScore.Name = "AdminMarksScore";
            this.AdminMarksScore.Size = new System.Drawing.Size(202, 20);
            this.AdminMarksScore.TabIndex = 17;
            this.AdminMarksScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Marks Management";
            // 
            // AdminMarksView
            // 
            this.AdminMarksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMarksView.Location = new System.Drawing.Point(208, 315);
            this.AdminMarksView.Name = "AdminMarksView";
            this.AdminMarksView.Size = new System.Drawing.Size(541, 210);
            this.AdminMarksView.TabIndex = 19;
            this.AdminMarksView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38639F));
            this.tableLayoutPanel1.Controls.Add(this.AdminMarksExam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AmdminMarksCourse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 134);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // AdminMarksExam
            // 
            this.AdminMarksExam.FormattingEnabled = true;
            this.AdminMarksExam.Location = new System.Drawing.Point(114, 70);
            this.AdminMarksExam.Name = "AdminMarksExam";
            this.AdminMarksExam.Size = new System.Drawing.Size(218, 21);
            this.AdminMarksExam.TabIndex = 1;
            this.AdminMarksExam.SelectedIndexChanged += new System.EventHandler(this.TimetableCourse_SelectedIndexChanged);
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
            // AmdminMarksCourse
            // 
            this.AmdminMarksCourse.FormattingEnabled = true;
            this.AmdminMarksCourse.Location = new System.Drawing.Point(114, 3);
            this.AmdminMarksCourse.Name = "AmdminMarksCourse";
            this.AmdminMarksCourse.Size = new System.Drawing.Size(218, 21);
            this.AmdminMarksCourse.TabIndex = 9;
            this.AmdminMarksCourse.SelectedIndexChanged += new System.EventHandler(this.TimetableGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Marks_Add_and_Delete_and_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimetabeDelete);
            this.Controls.Add(this.TimetableSave);
            this.Controls.Add(this.TimetableUpdate);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminMarksView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Marks_Add_and_Delete_and_Update";
            this.Size = new System.Drawing.Size(958, 626);
            this.Load += new System.EventHandler(this.Marks_Add_and_Delete_and_Update_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMarksView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimetabeDelete;
        private System.Windows.Forms.Button TimetableSave;
        private System.Windows.Forms.Button TimetableUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AdminMarksView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox AdminMarksExam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AmdminMarksCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminMarksStudentID;
        private System.Windows.Forms.TextBox AdminMarksScore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
