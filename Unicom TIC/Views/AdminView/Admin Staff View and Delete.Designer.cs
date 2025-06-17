namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Staff_View_and_Delete
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
            this.AdminStaffSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminStaffDetails = new System.Windows.Forms.DataGridView();
            this.AdminStaffDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStaffDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminStaffSearchText
            // 
            this.AdminStaffSearchText.Location = new System.Drawing.Point(402, 76);
            this.AdminStaffSearchText.Name = "AdminStaffSearchText";
            this.AdminStaffSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminStaffSearchText.TabIndex = 17;
            this.AdminStaffSearchText.TextChanged += new System.EventHandler(this.AdminStaffSearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Staff Details";
            // 
            // AdminStaffDetails
            // 
            this.AdminStaffDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStaffDetails.Location = new System.Drawing.Point(23, 127);
            this.AdminStaffDetails.Name = "AdminStaffDetails";
            this.AdminStaffDetails.Size = new System.Drawing.Size(702, 218);
            this.AdminStaffDetails.TabIndex = 15;
            this.AdminStaffDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminStaffDetails_CellContentClick);
            // 
            // AdminStaffDelete
            // 
            this.AdminStaffDelete.Location = new System.Drawing.Point(293, 396);
            this.AdminStaffDelete.Name = "AdminStaffDelete";
            this.AdminStaffDelete.Size = new System.Drawing.Size(107, 29);
            this.AdminStaffDelete.TabIndex = 5;
            this.AdminStaffDelete.Text = "Delete";
            this.AdminStaffDelete.UseVisualStyleBackColor = true;
            this.AdminStaffDelete.Click += new System.EventHandler(this.AdminStaffDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search";
            // 
            // Admin_Staff_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminStaffSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminStaffDetails);
            this.Controls.Add(this.AdminStaffDelete);
            this.Name = "Admin_Staff_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            this.Load += new System.EventHandler(this.Admin_Staff_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminStaffDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AdminStaffDetails;
        private System.Windows.Forms.Button AdminStaffDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminStaffSearchText;
    }
}
