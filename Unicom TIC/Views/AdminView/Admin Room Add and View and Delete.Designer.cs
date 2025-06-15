namespace Unicom_TIC.Views.AdminView
{
    partial class Admin_Room_Add_and_View_and_Delete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminRoomName = new System.Windows.Forms.TextBox();
            this.AdminRoomDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminRoomUpdate = new System.Windows.Forms.Button();
            this.AdminRoomSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminAdminSearchText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Name";
            // 
            // AdminRoomName
            // 
            this.AdminRoomName.Location = new System.Drawing.Point(333, 67);
            this.AdminRoomName.Name = "AdminRoomName";
            this.AdminRoomName.Size = new System.Drawing.Size(189, 20);
            this.AdminRoomName.TabIndex = 2;
            // 
            // AdminRoomDelete
            // 
            this.AdminRoomDelete.Location = new System.Drawing.Point(438, 136);
            this.AdminRoomDelete.Name = "AdminRoomDelete";
            this.AdminRoomDelete.Size = new System.Drawing.Size(75, 23);
            this.AdminRoomDelete.TabIndex = 3;
            this.AdminRoomDelete.Text = "Delete";
            this.AdminRoomDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room Management";
            // 
            // AdminRoomUpdate
            // 
            this.AdminRoomUpdate.Location = new System.Drawing.Point(277, 136);
            this.AdminRoomUpdate.Name = "AdminRoomUpdate";
            this.AdminRoomUpdate.Size = new System.Drawing.Size(75, 23);
            this.AdminRoomUpdate.TabIndex = 5;
            this.AdminRoomUpdate.Text = "Update";
            this.AdminRoomUpdate.UseVisualStyleBackColor = true;
            // 
            // AdminRoomSave
            // 
            this.AdminRoomSave.Location = new System.Drawing.Point(148, 136);
            this.AdminRoomSave.Name = "AdminRoomSave";
            this.AdminRoomSave.Size = new System.Drawing.Size(75, 23);
            this.AdminRoomSave.TabIndex = 6;
            this.AdminRoomSave.Text = "Save";
            this.AdminRoomSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminAdminSearchText
            // 
            this.AdminAdminSearchText.Location = new System.Drawing.Point(386, 202);
            this.AdminAdminSearchText.Name = "AdminAdminSearchText";
            this.AdminAdminSearchText.Size = new System.Drawing.Size(177, 20);
            this.AdminAdminSearchText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search";
            // 
            // Admin_Room_Add_and_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminAdminSearchText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminRoomSave);
            this.Controls.Add(this.AdminRoomUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminRoomDelete);
            this.Controls.Add(this.AdminRoomName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Room_Add_and_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            this.Load += new System.EventHandler(this.Admin_Room_Add_and_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminRoomName;
        private System.Windows.Forms.Button AdminRoomDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminRoomUpdate;
        private System.Windows.Forms.Button AdminRoomSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AdminAdminSearchText;
        private System.Windows.Forms.Label label3;
    }
}
