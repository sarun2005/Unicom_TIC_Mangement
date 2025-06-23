namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Staff_View_and_Delete_and_Update
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
            this.AdminStaffUpdateStaffID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TableLayoutPanel();
            this.AdminStaffUpdateFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminStaffUpdateMale = new System.Windows.Forms.RadioButton();
            this.AdminStaffUpdateClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminStaffUpdateAddress = new System.Windows.Forms.TextBox();
            this.AdminStaffUpdateLastName = new System.Windows.Forms.TextBox();
            this.AdminStaffUpdateFirstName = new System.Windows.Forms.TextBox();
            this.AdminStaffUpdateDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.AdminStaffUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AdminStaffUpdateRole = new System.Windows.Forms.ComboBox();
            this.AdminStaffUpdateEmail = new System.Windows.Forms.TextBox();
            this.AdminStaffUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStaffDetails)).BeginInit();
            this.s.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminStaffSearchText
            // 
            this.AdminStaffSearchText.Location = new System.Drawing.Point(570, 78);
            this.AdminStaffSearchText.Name = "AdminStaffSearchText";
            this.AdminStaffSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminStaffSearchText.TabIndex = 17;
            this.AdminStaffSearchText.TextChanged += new System.EventHandler(this.AdminStaffSearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Staff Details";
            // 
            // AdminStaffDetails
            // 
            this.AdminStaffDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStaffDetails.Location = new System.Drawing.Point(271, 461);
            this.AdminStaffDetails.Name = "AdminStaffDetails";
            this.AdminStaffDetails.Size = new System.Drawing.Size(702, 218);
            this.AdminStaffDetails.TabIndex = 15;
            this.AdminStaffDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminStaffDetails_CellContentClick);
            // 
            // AdminStaffDelete
            // 
            this.AdminStaffDelete.Location = new System.Drawing.Point(570, 742);
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
            this.label2.Location = new System.Drawing.Point(478, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search";
            // 
            // AdminStaffUpdateStaffID
            // 
            this.AdminStaffUpdateStaffID.Location = new System.Drawing.Point(188, 3);
            this.AdminStaffUpdateStaffID.Name = "AdminStaffUpdateStaffID";
            this.AdminStaffUpdateStaffID.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdateStaffID.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Staff ID";
            // 
            // s
            // 
            this.s.ColumnCount = 3;
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23214F));
            this.s.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.s.Controls.Add(this.AdminStaffUpdateFemale, 2, 0);
            this.s.Controls.Add(this.label4, 0, 0);
            this.s.Controls.Add(this.AdminStaffUpdateMale, 1, 0);
            this.s.Location = new System.Drawing.Point(388, 374);
            this.s.Name = "s";
            this.s.RowCount = 1;
            this.s.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.s.Size = new System.Drawing.Size(448, 41);
            this.s.TabIndex = 48;
            // 
            // AdminStaffUpdateFemale
            // 
            this.AdminStaffUpdateFemale.AutoSize = true;
            this.AdminStaffUpdateFemale.Location = new System.Drawing.Point(301, 3);
            this.AdminStaffUpdateFemale.Name = "AdminStaffUpdateFemale";
            this.AdminStaffUpdateFemale.Size = new System.Drawing.Size(59, 17);
            this.AdminStaffUpdateFemale.TabIndex = 16;
            this.AdminStaffUpdateFemale.TabStop = true;
            this.AdminStaffUpdateFemale.Text = "Female";
            this.AdminStaffUpdateFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // AdminStaffUpdateMale
            // 
            this.AdminStaffUpdateMale.AutoSize = true;
            this.AdminStaffUpdateMale.Location = new System.Drawing.Point(179, 3);
            this.AdminStaffUpdateMale.Name = "AdminStaffUpdateMale";
            this.AdminStaffUpdateMale.Size = new System.Drawing.Size(48, 17);
            this.AdminStaffUpdateMale.TabIndex = 15;
            this.AdminStaffUpdateMale.TabStop = true;
            this.AdminStaffUpdateMale.Text = "Male";
            this.AdminStaffUpdateMale.UseVisualStyleBackColor = true;
            // 
            // AdminStaffUpdateClear
            // 
            this.AdminStaffUpdateClear.Location = new System.Drawing.Point(35, 742);
            this.AdminStaffUpdateClear.Name = "AdminStaffUpdateClear";
            this.AdminStaffUpdateClear.Size = new System.Drawing.Size(107, 29);
            this.AdminStaffUpdateClear.TabIndex = 47;
            this.AdminStaffUpdateClear.Text = "Clear";
            this.AdminStaffUpdateClear.UseVisualStyleBackColor = true;
            this.AdminStaffUpdateClear.Click += new System.EventHandler(this.AdminStaffUpdateClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminStaffUpdateStaffID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminStaffUpdateAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminStaffUpdateLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminStaffUpdateFirstName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 136);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 207);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "First Name";
            // 
            // AdminStaffUpdateAddress
            // 
            this.AdminStaffUpdateAddress.Location = new System.Drawing.Point(188, 156);
            this.AdminStaffUpdateAddress.Name = "AdminStaffUpdateAddress";
            this.AdminStaffUpdateAddress.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdateAddress.TabIndex = 10;
            // 
            // AdminStaffUpdateLastName
            // 
            this.AdminStaffUpdateLastName.Location = new System.Drawing.Point(188, 105);
            this.AdminStaffUpdateLastName.Name = "AdminStaffUpdateLastName";
            this.AdminStaffUpdateLastName.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdateLastName.TabIndex = 9;
            // 
            // AdminStaffUpdateFirstName
            // 
            this.AdminStaffUpdateFirstName.Location = new System.Drawing.Point(188, 54);
            this.AdminStaffUpdateFirstName.Name = "AdminStaffUpdateFirstName";
            this.AdminStaffUpdateFirstName.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdateFirstName.TabIndex = 3;
            // 
            // AdminStaffUpdateDOB
            // 
            this.AdminStaffUpdateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AdminStaffUpdateDOB.Location = new System.Drawing.Point(187, 3);
            this.AdminStaffUpdateDOB.Name = "AdminStaffUpdateDOB";
            this.AdminStaffUpdateDOB.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdateDOB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date Of Birth";
            // 
            // AdminStaffUpdate
            // 
            this.AdminStaffUpdate.Location = new System.Drawing.Point(1080, 742);
            this.AdminStaffUpdate.Name = "AdminStaffUpdate";
            this.AdminStaffUpdate.Size = new System.Drawing.Size(107, 29);
            this.AdminStaffUpdate.TabIndex = 45;
            this.AdminStaffUpdate.Text = "Update";
            this.AdminStaffUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdminStaffUpdate.UseVisualStyleBackColor = true;
            this.AdminStaffUpdate.Click += new System.EventHandler(this.AdminStaffUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel2.Controls.Add(this.AdminStaffUpdateDOB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AdminStaffUpdateRole, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AdminStaffUpdateEmail, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.AdminStaffUpdatePhoneNumber, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(714, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 207);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Role";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Phone Number";
            // 
            // AdminStaffUpdateRole
            // 
            this.AdminStaffUpdateRole.FormattingEnabled = true;
            this.AdminStaffUpdateRole.Location = new System.Drawing.Point(187, 54);
            this.AdminStaffUpdateRole.Name = "AdminStaffUpdateRole";
            this.AdminStaffUpdateRole.Size = new System.Drawing.Size(224, 21);
            this.AdminStaffUpdateRole.TabIndex = 2;
            // 
            // AdminStaffUpdateEmail
            // 
            this.AdminStaffUpdateEmail.Location = new System.Drawing.Point(187, 105);
            this.AdminStaffUpdateEmail.Name = "AdminStaffUpdateEmail";
            this.AdminStaffUpdateEmail.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdateEmail.TabIndex = 18;
            // 
            // AdminStaffUpdatePhoneNumber
            // 
            this.AdminStaffUpdatePhoneNumber.Location = new System.Drawing.Point(187, 156);
            this.AdminStaffUpdatePhoneNumber.Name = "AdminStaffUpdatePhoneNumber";
            this.AdminStaffUpdatePhoneNumber.Size = new System.Drawing.Size(224, 20);
            this.AdminStaffUpdatePhoneNumber.TabIndex = 11;
            // 
            // Admin_Staff_View_and_Delete_and_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.AdminStaffUpdateClear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AdminStaffUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminStaffSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminStaffDetails);
            this.Controls.Add(this.AdminStaffDelete);
            this.Name = "Admin_Staff_View_and_Delete_and_Update";
            this.Size = new System.Drawing.Size(1236, 848);
            this.Load += new System.EventHandler(this.Admin_Staff_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminStaffDetails)).EndInit();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AdminStaffDetails;
        private System.Windows.Forms.Button AdminStaffDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminStaffSearchText;
        private System.Windows.Forms.TextBox AdminStaffUpdateStaffID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel s;
        private System.Windows.Forms.RadioButton AdminStaffUpdateFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton AdminStaffUpdateMale;
        private System.Windows.Forms.Button AdminStaffUpdateClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdminStaffUpdateAddress;
        private System.Windows.Forms.TextBox AdminStaffUpdateLastName;
        private System.Windows.Forms.TextBox AdminStaffUpdateFirstName;
        private System.Windows.Forms.DateTimePicker AdminStaffUpdateDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AdminStaffUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox AdminStaffUpdateRole;
        private System.Windows.Forms.TextBox AdminStaffUpdateEmail;
        private System.Windows.Forms.TextBox AdminStaffUpdatePhoneNumber;
    }
}
