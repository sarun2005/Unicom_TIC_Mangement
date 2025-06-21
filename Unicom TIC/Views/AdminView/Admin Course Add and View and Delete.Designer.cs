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
            this.AminCourseDelete = new System.Windows.Forms.Button();
            this.AdminCourseUpdate = new System.Windows.Forms.Button();
            this.AdminCourseDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminCourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCourseDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminCourseSave
            // 
            this.AdminCourseSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCourseSave.Location = new System.Drawing.Point(264, 290);
            this.AdminCourseSave.Name = "AdminCourseSave";
            this.AdminCourseSave.Size = new System.Drawing.Size(107, 29);
            this.AdminCourseSave.TabIndex = 4;
            this.AdminCourseSave.Text = "Save";
            this.AdminCourseSave.UseVisualStyleBackColor = true;
            this.AdminCourseSave.Click += new System.EventHandler(this.AdminCourseSave_Click);
            // 
            // AminCourseDelete
            // 
            this.AminCourseDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AminCourseDelete.Location = new System.Drawing.Point(598, 290);
            this.AminCourseDelete.Name = "AminCourseDelete";
            this.AminCourseDelete.Size = new System.Drawing.Size(107, 29);
            this.AminCourseDelete.TabIndex = 5;
            this.AminCourseDelete.Text = "Delete";
            this.AminCourseDelete.UseVisualStyleBackColor = true;
            this.AminCourseDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminCourseUpdate
            // 
            this.AdminCourseUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCourseUpdate.Location = new System.Drawing.Point(409, 290);
            this.AdminCourseUpdate.Name = "AdminCourseUpdate";
            this.AdminCourseUpdate.Size = new System.Drawing.Size(107, 29);
            this.AdminCourseUpdate.TabIndex = 1;
            this.AdminCourseUpdate.Text = "Update";
            this.AdminCourseUpdate.UseVisualStyleBackColor = true;
            this.AdminCourseUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminCourseDetails
            // 
            this.AdminCourseDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCourseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminCourseDetails.Location = new System.Drawing.Point(370, 382);
            this.AdminCourseDetails.Name = "AdminCourseDetails";
            this.AdminCourseDetails.Size = new System.Drawing.Size(244, 166);
            this.AdminCourseDetails.TabIndex = 13;
            this.AdminCourseDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminCourseDetails_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Course :";
            // 
            // AdminCourseName
            // 
            this.AdminCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCourseName.Location = new System.Drawing.Point(438, 205);
            this.AdminCourseName.Name = "AdminCourseName";
            this.AdminCourseName.Size = new System.Drawing.Size(194, 20);
            this.AdminCourseName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Management";
            // 
            // Admin_Course_Add_and_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminCourseSave);
            this.Controls.Add(this.AminCourseDelete);
            this.Controls.Add(this.AdminCourseUpdate);
            this.Controls.Add(this.AdminCourseDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminCourseName);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Course_Add_and_View_and_Delete";
            this.Size = new System.Drawing.Size(958, 626);
            this.Load += new System.EventHandler(this.Admin_Course_Add_and_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminCourseDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminCourseSave;
        private System.Windows.Forms.Button AminCourseDelete;
        private System.Windows.Forms.Button AdminCourseUpdate;
        private System.Windows.Forms.DataGridView AdminCourseDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminCourseName;
        private System.Windows.Forms.Label label1;
    }
}
