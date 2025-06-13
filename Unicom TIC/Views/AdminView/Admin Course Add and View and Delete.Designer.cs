namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Course_Add_and_View_and_Delete
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
            this.AdminCourseSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AdminCourseDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminCourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCourseDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminCourseSave
            // 
            this.AdminCourseSave.Location = new System.Drawing.Point(140, 168);
            this.AdminCourseSave.Name = "AdminCourseSave";
            this.AdminCourseSave.Size = new System.Drawing.Size(107, 29);
            this.AdminCourseSave.TabIndex = 4;
            this.AdminCourseSave.Text = "Save";
            this.AdminCourseSave.UseVisualStyleBackColor = true;
            this.AdminCourseSave.Click += new System.EventHandler(this.AdminCourseSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(301, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminCourseDetails
            // 
            this.AdminCourseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminCourseDetails.Location = new System.Drawing.Point(323, 260);
            this.AdminCourseDetails.Name = "AdminCourseDetails";
            this.AdminCourseDetails.Size = new System.Drawing.Size(276, 180);
            this.AdminCourseDetails.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Course :";
            // 
            // AdminCourseName
            // 
            this.AdminCourseName.Location = new System.Drawing.Point(391, 83);
            this.AdminCourseName.Name = "AdminCourseName";
            this.AdminCourseName.Size = new System.Drawing.Size(194, 20);
            this.AdminCourseName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Admin_Course_Add_and_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminCourseSave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AdminCourseDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminCourseName);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Course_Add_and_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            ((System.ComponentModel.ISupportInitialize)(this.AdminCourseDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminCourseSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView AdminCourseDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
