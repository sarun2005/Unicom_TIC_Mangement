namespace Unicom_TIC.Views.AdminView
{
    partial class Main_Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Admin));
            this.MainAdminLeftPanel = new System.Windows.Forms.Panel();
            this.TreeMainAdmin = new System.Windows.Forms.TreeView();
            this.MainAdminMainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainAdminLeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainAdminLeftPanel
            // 
            this.MainAdminLeftPanel.Controls.Add(this.TreeMainAdmin);
            this.MainAdminLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainAdminLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.MainAdminLeftPanel.Name = "MainAdminLeftPanel";
            this.MainAdminLeftPanel.Size = new System.Drawing.Size(214, 566);
            this.MainAdminLeftPanel.TabIndex = 2;
            // 
            // TreeMainAdmin
            // 
            this.TreeMainAdmin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TreeMainAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMainAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMainAdmin.ItemHeight = 20;
            this.TreeMainAdmin.Location = new System.Drawing.Point(3, 12);
            this.TreeMainAdmin.Name = "TreeMainAdmin";
            this.TreeMainAdmin.Size = new System.Drawing.Size(208, 551);
            this.TreeMainAdmin.TabIndex = 0;
            this.TreeMainAdmin.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMainAdmin_AfterSelect);
            // 
            // MainAdminMainPanel
            // 
            this.MainAdminMainPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainAdminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainAdminMainPanel.Location = new System.Drawing.Point(214, 77);
            this.MainAdminMainPanel.Name = "MainAdminMainPanel";
            this.MainAdminMainPanel.Size = new System.Drawing.Size(796, 489);
            this.MainAdminMainPanel.TabIndex = 3;
            this.MainAdminMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(214, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 566);
            this.Controls.Add(this.MainAdminMainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainAdminLeftPanel);
            this.Name = "Main_Admin";
            this.Text = "Main Admin";
            this.Load += new System.EventHandler(this.Main_Admin_Load);
            this.MainAdminLeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainAdminLeftPanel;
        private System.Windows.Forms.TreeView TreeMainAdmin;
        private System.Windows.Forms.Panel MainAdminMainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}