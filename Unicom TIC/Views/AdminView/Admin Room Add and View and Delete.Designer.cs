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
            this.AminRoomView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminRoomRoomName = new System.Windows.Forms.TextBox();
            this.AdminRoomDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminRoomUpdate = new System.Windows.Forms.Button();
            this.AdminRoomSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminRoomRoomType = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AminRoomView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AminRoomView
            // 
            this.AminRoomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AminRoomView.Location = new System.Drawing.Point(230, 315);
            this.AminRoomView.Name = "AminRoomView";
            this.AminRoomView.Size = new System.Drawing.Size(312, 150);
            this.AminRoomView.TabIndex = 0;
            this.AminRoomView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AminRoomView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Name";
            // 
            // AdminRoomRoomName
            // 
            this.AdminRoomRoomName.Location = new System.Drawing.Point(127, 3);
            this.AdminRoomRoomName.Name = "AdminRoomRoomName";
            this.AdminRoomRoomName.Size = new System.Drawing.Size(189, 20);
            this.AdminRoomRoomName.TabIndex = 2;
            this.AdminRoomRoomName.TextChanged += new System.EventHandler(this.AdminRoomRoomName_TextChanged);
            // 
            // AdminRoomDelete
            // 
            this.AdminRoomDelete.Location = new System.Drawing.Point(471, 249);
            this.AdminRoomDelete.Name = "AdminRoomDelete";
            this.AdminRoomDelete.Size = new System.Drawing.Size(75, 23);
            this.AdminRoomDelete.TabIndex = 3;
            this.AdminRoomDelete.Text = "Delete";
            this.AdminRoomDelete.UseVisualStyleBackColor = true;
            this.AdminRoomDelete.Click += new System.EventHandler(this.AdminRoomDelete_Click);
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
            this.AdminRoomUpdate.Location = new System.Drawing.Point(323, 249);
            this.AdminRoomUpdate.Name = "AdminRoomUpdate";
            this.AdminRoomUpdate.Size = new System.Drawing.Size(75, 23);
            this.AdminRoomUpdate.TabIndex = 5;
            this.AdminRoomUpdate.Text = "Update";
            this.AdminRoomUpdate.UseVisualStyleBackColor = true;
            this.AdminRoomUpdate.Click += new System.EventHandler(this.AdminRoomUpdate_Click);
            // 
            // AdminRoomSave
            // 
            this.AdminRoomSave.Location = new System.Drawing.Point(198, 249);
            this.AdminRoomSave.Name = "AdminRoomSave";
            this.AdminRoomSave.Size = new System.Drawing.Size(75, 23);
            this.AdminRoomSave.TabIndex = 6;
            this.AdminRoomSave.Text = "Save";
            this.AdminRoomSave.UseVisualStyleBackColor = true;
            this.AdminRoomSave.Click += new System.EventHandler(this.AdminRoomSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.74911F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.25089F));
            this.tableLayoutPanel1.Controls.Add(this.AdminRoomRoomName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminRoomRoomType, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(230, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 113);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // AdminRoomRoomType
            // 
            this.AdminRoomRoomType.FormattingEnabled = true;
            this.AdminRoomRoomType.Location = new System.Drawing.Point(127, 59);
            this.AdminRoomRoomType.Name = "AdminRoomRoomType";
            this.AdminRoomRoomType.Size = new System.Drawing.Size(189, 21);
            this.AdminRoomRoomType.TabIndex = 8;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(601, 249);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Room_Add_and_View_and_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AdminRoomSave);
            this.Controls.Add(this.AdminRoomUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminRoomDelete);
            this.Controls.Add(this.AminRoomView);
            this.Name = "Admin_Room_Add_and_View_and_Delete";
            this.Size = new System.Drawing.Size(796, 489);
            this.Load += new System.EventHandler(this.Admin_Room_Add_and_View_and_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AminRoomView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AminRoomView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminRoomRoomName;
        private System.Windows.Forms.Button AdminRoomDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminRoomUpdate;
        private System.Windows.Forms.Button AdminRoomSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox AdminRoomRoomType;
        private System.Windows.Forms.Button clear;
    }
}
