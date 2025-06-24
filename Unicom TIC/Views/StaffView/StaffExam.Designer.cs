namespace Unicom_TIC.Views.StaffView
{
    partial class StaffExam
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
            this.StaffExamView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StaffExamView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Exam Management";
            // 
            // StaffExamView
            // 
            this.StaffExamView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffExamView.Location = new System.Drawing.Point(389, 392);
            this.StaffExamView.Name = "StaffExamView";
            this.StaffExamView.Size = new System.Drawing.Size(548, 216);
            this.StaffExamView.TabIndex = 19;
            this.StaffExamView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffExamView_CellContentClick);
            // 
            // StaffExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffExamView);
            this.Name = "StaffExam";
            this.Size = new System.Drawing.Size(1267, 811);
            this.Load += new System.EventHandler(this.StaffExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffExamView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StaffExamView;
    }
}
