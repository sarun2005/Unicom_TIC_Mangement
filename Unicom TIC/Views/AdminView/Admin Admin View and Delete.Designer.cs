namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Admin_View_and_Delete
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
            this.AdminAdminDetails = new System.Windows.Forms.DataGridView();
            this.AdminAdminDelete = new System.Windows.Forms.Button();
            this.AdminAdminSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminAdminDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminAdminDetails
            // 
            this.AdminAdminDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminAdminDetails.Location = new System.Drawing.Point(48, 114);
            this.AdminAdminDetails.Name = "AdminAdminDetails";
            this.AdminAdminDetails.Size = new System.Drawing.Size(641, 279);
            this.AdminAdminDetails.TabIndex = 0;
            this.AdminAdminDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminAdminDelete
            // 
            this.AdminAdminDelete.Location = new System.Drawing.Point(337, 440);
            this.AdminAdminDelete.Name = "AdminAdminDelete";
            this.AdminAdminDelete.Size = new System.Drawing.Size(96, 31);
            this.AdminAdminDelete.TabIndex = 1;
            this.AdminAdminDelete.Text = "Delete";
            this.AdminAdminDelete.UseVisualStyleBackColor = true;
            this.AdminAdminDelete.Click += new System.EventHandler(this.AdminAdminDelete_Click);
            // 
            // AdminAdminSearchText
            // 
            this.AdminAdminSearchText.Location = new System.Drawing.Point(337, 61);
            this.AdminAdminSearchText.Name = "AdminAdminSearchText";
            this.AdminAdminSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminAdminSearchText.TabIndex = 3;
            this.AdminAdminSearchText.TextChanged += new System.EventHandler(this.AdminAdminSearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admin Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // Admin_Admin_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminAdminSearchText);
            this.Controls.Add(this.AdminAdminDelete);
            this.Controls.Add(this.AdminAdminDetails);
            this.Name = "Admin_Admin_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            this.Load += new System.EventHandler(this.Admin_Admin_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminAdminDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminAdminDetails;
        private System.Windows.Forms.Button AdminAdminDelete;
        private System.Windows.Forms.TextBox AdminAdminSearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
