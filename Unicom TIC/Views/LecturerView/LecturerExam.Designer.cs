namespace Unicom_TIC.Views.LecturerView
{
    partial class LecturerExam
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
            this.LecturerExamView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerExamView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Exam Management";
            // 
            // LecturerExamView
            // 
            this.LecturerExamView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerExamView.Location = new System.Drawing.Point(408, 411);
            this.LecturerExamView.Name = "LecturerExamView";
            this.LecturerExamView.Size = new System.Drawing.Size(520, 155);
            this.LecturerExamView.TabIndex = 16;
            this.LecturerExamView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LecturerExamView_CellContentClick);
            // 
            // LecturerExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LecturerExamView);
            this.Name = "LecturerExam";
            this.Size = new System.Drawing.Size(1267, 811);
            this.Load += new System.EventHandler(this.LecturerExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LecturerExamView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView LecturerExamView;
    }
}
