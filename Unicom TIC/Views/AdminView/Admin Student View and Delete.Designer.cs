﻿namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Student_View_and_Delete
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
            this.AdminStudentDelete = new System.Windows.Forms.Button();
            this.AdminStudentDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminStudentSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminStudentDelete
            // 
            this.AdminStudentDelete.Location = new System.Drawing.Point(425, 566);
            this.AdminStudentDelete.Name = "AdminStudentDelete";
            this.AdminStudentDelete.Size = new System.Drawing.Size(107, 29);
            this.AdminStudentDelete.TabIndex = 5;
            this.AdminStudentDelete.Text = "Delete";
            this.AdminStudentDelete.UseVisualStyleBackColor = true;
            this.AdminStudentDelete.Click += new System.EventHandler(this.AdminStudentDelete_Click);
            // 
            // AdminStudentDetails
            // 
            this.AdminStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStudentDetails.Location = new System.Drawing.Point(106, 282);
            this.AdminStudentDetails.Name = "AdminStudentDetails";
            this.AdminStudentDetails.Size = new System.Drawing.Size(742, 257);
            this.AdminStudentDetails.TabIndex = 12;
            this.AdminStudentDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminStudentDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Details";
            // 
            // AdminStudentSearchText
            // 
            this.AdminStudentSearchText.Location = new System.Drawing.Point(476, 219);
            this.AdminStudentSearchText.Name = "AdminStudentSearchText";
            this.AdminStudentSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminStudentSearchText.TabIndex = 13;
            this.AdminStudentSearchText.TextChanged += new System.EventHandler(this.AdminAdminSearchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search";
            // 
            // Admin_Student_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminStudentSearchText);
            this.Controls.Add(this.AdminStudentDetails);
            this.Controls.Add(this.AdminStudentDelete);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Student_View_and_Delete";
            this.Size = new System.Drawing.Size(958, 626);
            this.Load += new System.EventHandler(this.Admin_Student_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminStudentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminStudentDelete;
        private System.Windows.Forms.DataGridView AdminStudentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminStudentSearchText;
        private System.Windows.Forms.Label label2;
    }
}
