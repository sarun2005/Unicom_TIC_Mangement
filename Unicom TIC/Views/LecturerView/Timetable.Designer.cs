﻿namespace Unicom_TIC.Views.LecturerView
{
    partial class Lecturer_Timetable
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
            this.TimetableView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Timetable Management";
            // 
            // TimetableView
            // 
            this.TimetableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimetableView.Location = new System.Drawing.Point(178, 384);
            this.TimetableView.Name = "TimetableView";
            this.TimetableView.Size = new System.Drawing.Size(637, 210);
            this.TimetableView.TabIndex = 19;
            this.TimetableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimetableView_CellContentClick);
            // 
            // Lecturer_Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimetableView);
            this.Name = "Lecturer_Timetable";
            this.Size = new System.Drawing.Size(988, 720);
            this.Load += new System.EventHandler(this.Lecturer_Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimetableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TimetableView;
    }
}
