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
            this.button1 = new System.Windows.Forms.Button();
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
            this.MainAdminLeftPanel.Controls.Add(this.button1);
            this.MainAdminLeftPanel.Controls.Add(this.TreeMainAdmin);
            this.MainAdminLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainAdminLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.MainAdminLeftPanel.Name = "MainAdminLeftPanel";
            this.MainAdminLeftPanel.Size = new System.Drawing.Size(230, 720);
            this.MainAdminLeftPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TreeMainAdmin
            // 
            this.TreeMainAdmin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TreeMainAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMainAdmin.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMainAdmin.Indent = 20;
            this.TreeMainAdmin.ItemHeight = 22;
            this.TreeMainAdmin.Location = new System.Drawing.Point(0, 0);
            this.TreeMainAdmin.Name = "TreeMainAdmin";
            this.TreeMainAdmin.Size = new System.Drawing.Size(230, 720);
            this.TreeMainAdmin.TabIndex = 0;
            this.TreeMainAdmin.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMainAdmin_AfterSelect);
            // 
            // MainAdminMainPanel
            // 
            this.MainAdminMainPanel.BackColor = System.Drawing.Color.White;
            this.MainAdminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainAdminMainPanel.Location = new System.Drawing.Point(230, 94);
            this.MainAdminMainPanel.Name = "MainAdminMainPanel";
            this.MainAdminMainPanel.Size = new System.Drawing.Size(958, 626);
            this.MainAdminMainPanel.TabIndex = 3;
            this.MainAdminMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 94);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 720);
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
        private System.Windows.Forms.Button button1;
    }
}