namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Subject_Add_and_View_and_Delete
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
            this.AdminSubjectDetails = new System.Windows.Forms.DataGridView();
            this.AdminSubjectSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminSubjectCourseName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminSubjectSubjectName = new System.Windows.Forms.TextBox();
            this.AdminSubjectUpdate = new System.Windows.Forms.Button();
            this.AdminSubjectDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminAdminSearchText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSubjectDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminSubjectDetails
            // 
            this.AdminSubjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminSubjectDetails.Location = new System.Drawing.Point(221, 302);
            this.AdminSubjectDetails.Name = "AdminSubjectDetails";
            this.AdminSubjectDetails.Size = new System.Drawing.Size(294, 151);
            this.AdminSubjectDetails.TabIndex = 0;
            this.AdminSubjectDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminSubjectSave
            // 
            this.AdminSubjectSave.Location = new System.Drawing.Point(98, 210);
            this.AdminSubjectSave.Name = "AdminSubjectSave";
            this.AdminSubjectSave.Size = new System.Drawing.Size(75, 23);
            this.AdminSubjectSave.TabIndex = 1;
            this.AdminSubjectSave.Text = "Save";
            this.AdminSubjectSave.UseVisualStyleBackColor = true;
            this.AdminSubjectSave.Click += new System.EventHandler(this.AdminSubjectSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminSubjectCourseName
            // 
            this.AdminSubjectCourseName.FormattingEnabled = true;
            this.AdminSubjectCourseName.Location = new System.Drawing.Point(152, 53);
            this.AdminSubjectCourseName.Name = "AdminSubjectCourseName";
            this.AdminSubjectCourseName.Size = new System.Drawing.Size(205, 21);
            this.AdminSubjectCourseName.TabIndex = 3;
            this.AdminSubjectCourseName.SelectedIndexChanged += new System.EventHandler(this.AdminSubjectCourseName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject Name";
            // 
            // AdminSubjectSubjectName
            // 
            this.AdminSubjectSubjectName.Location = new System.Drawing.Point(152, 3);
            this.AdminSubjectSubjectName.Name = "AdminSubjectSubjectName";
            this.AdminSubjectSubjectName.Size = new System.Drawing.Size(205, 20);
            this.AdminSubjectSubjectName.TabIndex = 6;
            // 
            // AdminSubjectUpdate
            // 
            this.AdminSubjectUpdate.Location = new System.Drawing.Point(251, 210);
            this.AdminSubjectUpdate.Name = "AdminSubjectUpdate";
            this.AdminSubjectUpdate.Size = new System.Drawing.Size(75, 23);
            this.AdminSubjectUpdate.TabIndex = 7;
            this.AdminSubjectUpdate.Text = "Update";
            this.AdminSubjectUpdate.UseVisualStyleBackColor = true;
            // 
            // AdminSubjectDelete
            // 
            this.AdminSubjectDelete.Location = new System.Drawing.Point(440, 210);
            this.AdminSubjectDelete.Name = "AdminSubjectDelete";
            this.AdminSubjectDelete.Size = new System.Drawing.Size(75, 23);
            this.AdminSubjectDelete.TabIndex = 8;
            this.AdminSubjectDelete.Text = "Delete";
            this.AdminSubjectDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.31961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.68039F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminSubjectSubjectName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminSubjectCourseName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(177, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 100);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminAdminSearchText
            // 
            this.AdminAdminSearchText.Location = new System.Drawing.Point(371, 258);
            this.AdminAdminSearchText.Name = "AdminAdminSearchText";
            this.AdminAdminSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminAdminSearchText.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search";
            // 
            // Admin_Subject_Add_and_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdminAdminSearchText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AdminSubjectDelete);
            this.Controls.Add(this.AdminSubjectUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminSubjectSave);
            this.Controls.Add(this.AdminSubjectDetails);
            this.Name = "Admin_Subject_Add_and_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            this.Load += new System.EventHandler(this.Admin_Subject_Add_and_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminSubjectDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminSubjectDetails;
        private System.Windows.Forms.Button AdminSubjectSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AdminSubjectCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminSubjectSubjectName;
        private System.Windows.Forms.Button AdminSubjectUpdate;
        private System.Windows.Forms.Button AdminSubjectDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AdminAdminSearchText;
        private System.Windows.Forms.Label label4;
    }
}
