namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Lecturer_View_and_Delete
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
            this.AdminLecturerDetails = new System.Windows.Forms.DataGridView();
            this.AdminLecturerDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminAdminSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLecturerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminLecturerDetails
            // 
            this.AdminLecturerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminLecturerDetails.Location = new System.Drawing.Point(30, 112);
            this.AdminLecturerDetails.Name = "AdminLecturerDetails";
            this.AdminLecturerDetails.Size = new System.Drawing.Size(724, 227);
            this.AdminLecturerDetails.TabIndex = 10;
            this.AdminLecturerDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminLecturerDetails_CellContentClick);
            // 
            // AdminLecturerDelete
            // 
            this.AdminLecturerDelete.Location = new System.Drawing.Point(340, 411);
            this.AdminLecturerDelete.Name = "AdminLecturerDelete";
            this.AdminLecturerDelete.Size = new System.Drawing.Size(107, 29);
            this.AdminLecturerDelete.TabIndex = 11;
            this.AdminLecturerDelete.Text = "Delete";
            this.AdminLecturerDelete.UseVisualStyleBackColor = true;
            this.AdminLecturerDelete.Click += new System.EventHandler(this.AdminLecturerDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lecturer Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminAdminSearchText
            // 
            this.AdminAdminSearchText.Location = new System.Drawing.Point(399, 71);
            this.AdminAdminSearchText.Name = "AdminAdminSearchText";
            this.AdminAdminSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminAdminSearchText.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search";
            // 
            // Admin_Lecturer_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminAdminSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminLecturerDelete);
            this.Controls.Add(this.AdminLecturerDetails);
            this.Name = "Admin_Lecturer_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            this.Load += new System.EventHandler(this.Admin_Lecturer_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminLecturerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminLecturerDetails;
        private System.Windows.Forms.Button AdminLecturerDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminAdminSearchText;
        private System.Windows.Forms.Label label2;
    }
}
