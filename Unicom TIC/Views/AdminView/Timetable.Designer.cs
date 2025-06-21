namespace Unicom_TIC.Views.AdminView
{
    partial class Timetable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimetableSubject = new System.Windows.Forms.ComboBox();
            this.TimetableCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimetableGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimetableLecturer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimetableView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimetableRoom = new System.Windows.Forms.ComboBox();
            this.TimetableEndTime = new System.Windows.Forms.DateTimePicker();
            this.TimetableDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimetableStartTime = new System.Windows.Forms.DateTimePicker();
            this.TimetableUpdate = new System.Windows.Forms.Button();
            this.TimetableSave = new System.Windows.Forms.Button();
            this.TimetabeDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38639F));
            this.tableLayoutPanel1.Controls.Add(this.TimetableSubject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TimetableCourse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TimetableGroup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TimetableLecturer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TimetableSubject
            // 
            this.TimetableSubject.FormattingEnabled = true;
            this.TimetableSubject.Location = new System.Drawing.Point(113, 83);
            this.TimetableSubject.Name = "TimetableSubject";
            this.TimetableSubject.Size = new System.Drawing.Size(218, 21);
            this.TimetableSubject.TabIndex = 12;
            this.TimetableSubject.SelectedIndexChanged += new System.EventHandler(this.TimetableSubject_SelectedIndexChanged);
            // 
            // TimetableCourse
            // 
            this.TimetableCourse.FormattingEnabled = true;
            this.TimetableCourse.Location = new System.Drawing.Point(113, 43);
            this.TimetableCourse.Name = "TimetableCourse";
            this.TimetableCourse.Size = new System.Drawing.Size(218, 21);
            this.TimetableCourse.TabIndex = 1;
            this.TimetableCourse.SelectedIndexChanged += new System.EventHandler(this.TimetableCourse_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subject";
            // 
            // TimetableGroup
            // 
            this.TimetableGroup.FormattingEnabled = true;
            this.TimetableGroup.Location = new System.Drawing.Point(113, 3);
            this.TimetableGroup.Name = "TimetableGroup";
            this.TimetableGroup.Size = new System.Drawing.Size(218, 21);
            this.TimetableGroup.TabIndex = 9;
            this.TimetableGroup.SelectedIndexChanged += new System.EventHandler(this.TimetableGroup_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lecturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course";
            // 
            // TimetableLecturer
            // 
            this.TimetableLecturer.FormattingEnabled = true;
            this.TimetableLecturer.Location = new System.Drawing.Point(113, 123);
            this.TimetableLecturer.Name = "TimetableLecturer";
            this.TimetableLecturer.Size = new System.Drawing.Size(218, 21);
            this.TimetableLecturer.TabIndex = 10;
            this.TimetableLecturer.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Group";
            // 
            // TimetableView
            // 
            this.TimetableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimetableView.Location = new System.Drawing.Point(143, 361);
            this.TimetableView.Name = "TimetableView";
            this.TimetableView.Size = new System.Drawing.Size(637, 210);
            this.TimetableView.TabIndex = 3;
            this.TimetableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timetable Management";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.30769F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimetableRoom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimetableEndTime, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TimetableDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TimetableStartTime, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(520, 120);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 161);
            this.tableLayoutPanel2.TabIndex = 14;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Room";
            // 
            // TimetableRoom
            // 
            this.TimetableRoom.FormattingEnabled = true;
            this.TimetableRoom.Location = new System.Drawing.Point(108, 3);
            this.TimetableRoom.Name = "TimetableRoom";
            this.TimetableRoom.Size = new System.Drawing.Size(218, 21);
            this.TimetableRoom.TabIndex = 15;
            this.TimetableRoom.SelectedIndexChanged += new System.EventHandler(this.TimetableRoom_SelectedIndexChanged);
            // 
            // TimetableEndTime
            // 
            this.TimetableEndTime.CustomFormat = "\"HH:mm\"";
            this.TimetableEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimetableEndTime.Location = new System.Drawing.Point(108, 123);
            this.TimetableEndTime.Name = "TimetableEndTime";
            this.TimetableEndTime.ShowUpDown = true;
            this.TimetableEndTime.Size = new System.Drawing.Size(218, 20);
            this.TimetableEndTime.TabIndex = 17;
            this.TimetableEndTime.Value = new System.DateTime(2025, 6, 20, 6, 0, 0, 0);
            // 
            // TimetableDate
            // 
            this.TimetableDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimetableDate.Location = new System.Drawing.Point(108, 43);
            this.TimetableDate.Name = "TimetableDate";
            this.TimetableDate.Size = new System.Drawing.Size(218, 20);
            this.TimetableDate.TabIndex = 13;
            this.TimetableDate.Value = new System.DateTime(2025, 6, 20, 6, 58, 0, 0);
            this.TimetableDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start Time";
            // 
            // TimetableStartTime
            // 
            this.TimetableStartTime.CustomFormat = "\"HH:mm\"";
            this.TimetableStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimetableStartTime.Location = new System.Drawing.Point(108, 83);
            this.TimetableStartTime.Name = "TimetableStartTime";
            this.TimetableStartTime.ShowUpDown = true;
            this.TimetableStartTime.Size = new System.Drawing.Size(218, 20);
            this.TimetableStartTime.TabIndex = 14;
            this.TimetableStartTime.Value = new System.DateTime(2025, 6, 20, 6, 0, 0, 0);
            // 
            // TimetableUpdate
            // 
            this.TimetableUpdate.Location = new System.Drawing.Point(426, 577);
            this.TimetableUpdate.Name = "TimetableUpdate";
            this.TimetableUpdate.Size = new System.Drawing.Size(75, 23);
            this.TimetableUpdate.TabIndex = 15;
            this.TimetableUpdate.Text = "Update";
            this.TimetableUpdate.UseVisualStyleBackColor = true;
            this.TimetableUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimetableSave
            // 
            this.TimetableSave.Location = new System.Drawing.Point(826, 577);
            this.TimetableSave.Name = "TimetableSave";
            this.TimetableSave.Size = new System.Drawing.Size(75, 23);
            this.TimetableSave.TabIndex = 16;
            this.TimetableSave.Text = "Save";
            this.TimetableSave.UseVisualStyleBackColor = true;
            this.TimetableSave.Click += new System.EventHandler(this.TimetableSave_Click);
            // 
            // TimetabeDelete
            // 
            this.TimetabeDelete.Location = new System.Drawing.Point(41, 577);
            this.TimetabeDelete.Name = "TimetabeDelete";
            this.TimetabeDelete.Size = new System.Drawing.Size(75, 23);
            this.TimetabeDelete.TabIndex = 17;
            this.TimetabeDelete.Text = "Delete";
            this.TimetabeDelete.UseVisualStyleBackColor = true;
            this.TimetabeDelete.Click += new System.EventHandler(this.TimetabeDelete_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimetabeDelete);
            this.Controls.Add(this.TimetableSave);
            this.Controls.Add(this.TimetableUpdate);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimetableView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(958, 626);
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox TimetableCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TimetableView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TimetableGroup;
        private System.Windows.Forms.ComboBox TimetableSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker TimetableDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TimetableLecturer;
        private System.Windows.Forms.ComboBox TimetableRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TimetableUpdate;
        private System.Windows.Forms.Button TimetableSave;
        private System.Windows.Forms.Button TimetabeDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TimetableStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker TimetableEndTime;
    }
}
