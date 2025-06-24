namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Admin_View_and_Delete_and_Update
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
            this.AdminAdminDelete = new System.Windows.Forms.Button();
            this.AdminAdminSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminAdminDetails = new System.Windows.Forms.DataGridView();
            this.AdminAdminUpdateBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.AdminAdminUpdateFirstName = new System.Windows.Forms.TextBox();
            this.AdminAdminUpdateAdminID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AdminAdminUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.AdminAdminUpdateEmail = new System.Windows.Forms.TextBox();
            this.AdminAdminUpdateRole = new System.Windows.Forms.ComboBox();
            this.AdminAdminUpdateLastName = new System.Windows.Forms.TextBox();
            this.AdminAdminUpdateUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminAdminDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminAdminDelete
            // 
            this.AdminAdminDelete.Location = new System.Drawing.Point(587, 674);
            this.AdminAdminDelete.Name = "AdminAdminDelete";
            this.AdminAdminDelete.Size = new System.Drawing.Size(96, 31);
            this.AdminAdminDelete.TabIndex = 1;
            this.AdminAdminDelete.Text = "Delete";
            this.AdminAdminDelete.UseVisualStyleBackColor = true;
            this.AdminAdminDelete.Click += new System.EventHandler(this.AdminAdminDelete_Click);
            // 
            // AdminAdminSearchText
            // 
            this.AdminAdminSearchText.Location = new System.Drawing.Point(620, 112);
            this.AdminAdminSearchText.Name = "AdminAdminSearchText";
            this.AdminAdminSearchText.Size = new System.Drawing.Size(196, 20);
            this.AdminAdminSearchText.TabIndex = 3;
            this.AdminAdminSearchText.TextChanged += new System.EventHandler(this.AdminAdminSearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admin Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // AdminAdminDetails
            // 
            this.AdminAdminDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminAdminDetails.Location = new System.Drawing.Point(346, 445);
            this.AdminAdminDetails.Name = "AdminAdminDetails";
            this.AdminAdminDetails.Size = new System.Drawing.Size(631, 191);
            this.AdminAdminDetails.TabIndex = 0;
            this.AdminAdminDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminAdminUpdateBack
            // 
            this.AdminAdminUpdateBack.Location = new System.Drawing.Point(73, 665);
            this.AdminAdminUpdateBack.Name = "AdminAdminUpdateBack";
            this.AdminAdminUpdateBack.Size = new System.Drawing.Size(107, 29);
            this.AdminAdminUpdateBack.TabIndex = 21;
            this.AdminAdminUpdateBack.Text = "Clear";
            this.AdminAdminUpdateBack.UseVisualStyleBackColor = true;
            this.AdminAdminUpdateBack.Click += new System.EventHandler(this.AdminAdminUpdateBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminAdminUpdateFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminAdminUpdateAdminID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminAdminUpdatePhoneNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.AdminAdminUpdateEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.AdminAdminUpdateRole, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminAdminUpdateLastName, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(452, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 252);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "AdminID";
            // 
            // AdminAdminUpdateFirstName
            // 
            this.AdminAdminUpdateFirstName.Location = new System.Drawing.Point(178, 47);
            this.AdminAdminUpdateFirstName.Name = "AdminAdminUpdateFirstName";
            this.AdminAdminUpdateFirstName.Size = new System.Drawing.Size(224, 20);
            this.AdminAdminUpdateFirstName.TabIndex = 9;
            // 
            // AdminAdminUpdateAdminID
            // 
            this.AdminAdminUpdateAdminID.Location = new System.Drawing.Point(178, 3);
            this.AdminAdminUpdateAdminID.Name = "AdminAdminUpdateAdminID";
            this.AdminAdminUpdateAdminID.Size = new System.Drawing.Size(224, 20);
            this.AdminAdminUpdateAdminID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "First Name";
            // 
            // AdminAdminUpdatePhoneNumber
            // 
            this.AdminAdminUpdatePhoneNumber.Location = new System.Drawing.Point(178, 179);
            this.AdminAdminUpdatePhoneNumber.Name = "AdminAdminUpdatePhoneNumber";
            this.AdminAdminUpdatePhoneNumber.Size = new System.Drawing.Size(224, 20);
            this.AdminAdminUpdatePhoneNumber.TabIndex = 10;
            // 
            // AdminAdminUpdateEmail
            // 
            this.AdminAdminUpdateEmail.Location = new System.Drawing.Point(178, 223);
            this.AdminAdminUpdateEmail.Name = "AdminAdminUpdateEmail";
            this.AdminAdminUpdateEmail.Size = new System.Drawing.Size(224, 20);
            this.AdminAdminUpdateEmail.TabIndex = 11;
            // 
            // AdminAdminUpdateRole
            // 
            this.AdminAdminUpdateRole.FormattingEnabled = true;
            this.AdminAdminUpdateRole.Location = new System.Drawing.Point(178, 135);
            this.AdminAdminUpdateRole.Name = "AdminAdminUpdateRole";
            this.AdminAdminUpdateRole.Size = new System.Drawing.Size(224, 21);
            this.AdminAdminUpdateRole.TabIndex = 2;
            // 
            // AdminAdminUpdateLastName
            // 
            this.AdminAdminUpdateLastName.Location = new System.Drawing.Point(178, 91);
            this.AdminAdminUpdateLastName.Name = "AdminAdminUpdateLastName";
            this.AdminAdminUpdateLastName.Size = new System.Drawing.Size(224, 20);
            this.AdminAdminUpdateLastName.TabIndex = 17;
            // 
            // AdminAdminUpdateUpdate
            // 
            this.AdminAdminUpdateUpdate.Location = new System.Drawing.Point(1084, 676);
            this.AdminAdminUpdateUpdate.Name = "AdminAdminUpdateUpdate";
            this.AdminAdminUpdateUpdate.Size = new System.Drawing.Size(107, 29);
            this.AdminAdminUpdateUpdate.TabIndex = 19;
            this.AdminAdminUpdateUpdate.Text = "Update";
            this.AdminAdminUpdateUpdate.UseVisualStyleBackColor = true;
            this.AdminAdminUpdateUpdate.Click += new System.EventHandler(this.AdminAdminUpdateUpdate_Click);
            // 
            // Admin_Admin_View_and_Delete_and_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminAdminUpdateBack);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AdminAdminUpdateUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminAdminSearchText);
            this.Controls.Add(this.AdminAdminDelete);
            this.Controls.Add(this.AdminAdminDetails);
            this.Name = "Admin_Admin_View_and_Delete_and_Update";
            this.Size = new System.Drawing.Size(1237, 717);
            this.Load += new System.EventHandler(this.Admin_Admin_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminAdminDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AdminAdminDelete;
        private System.Windows.Forms.TextBox AdminAdminSearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AdminAdminDetails;
        private System.Windows.Forms.Button AdminAdminUpdateBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdminAdminUpdateFirstName;
        private System.Windows.Forms.TextBox AdminAdminUpdateAdminID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AdminAdminUpdatePhoneNumber;
        private System.Windows.Forms.TextBox AdminAdminUpdateEmail;
        private System.Windows.Forms.ComboBox AdminAdminUpdateRole;
        private System.Windows.Forms.TextBox AdminAdminUpdateLastName;
        private System.Windows.Forms.Button AdminAdminUpdateUpdate;
    }
}
