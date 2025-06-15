namespace Unicom_TIC.Views.LecturerView
{
    partial class Main_Lecturer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Lecturer_Form));
            this.StudentTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LecturerMainPanel = new System.Windows.Forms.Panel();
            this.StudentLeftPanel = new System.Windows.Forms.Panel();
            this.LecturerTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StudentLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentTopPanel
            // 
            this.StudentTopPanel.Controls.Add(this.pictureBox1);
            this.StudentTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentTopPanel.Location = new System.Drawing.Point(200, 0);
            this.StudentTopPanel.Name = "StudentTopPanel";
            this.StudentTopPanel.Size = new System.Drawing.Size(813, 100);
            this.StudentTopPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LecturerMainPanel
            // 
            this.LecturerMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturerMainPanel.Location = new System.Drawing.Point(200, 0);
            this.LecturerMainPanel.Name = "LecturerMainPanel";
            this.LecturerMainPanel.Size = new System.Drawing.Size(813, 602);
            this.LecturerMainPanel.TabIndex = 4;
            // 
            // StudentLeftPanel
            // 
            this.StudentLeftPanel.Controls.Add(this.button1);
            this.StudentLeftPanel.Controls.Add(this.LecturerTreeView);
            this.StudentLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentLeftPanel.Name = "StudentLeftPanel";
            this.StudentLeftPanel.Size = new System.Drawing.Size(200, 602);
            this.StudentLeftPanel.TabIndex = 3;
            // 
            // LecturerTreeView
            // 
            this.LecturerTreeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LecturerTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LecturerTreeView.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerTreeView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LecturerTreeView.Location = new System.Drawing.Point(0, 0);
            this.LecturerTreeView.Name = "LecturerTreeView";
            this.LecturerTreeView.Size = new System.Drawing.Size(200, 607);
            this.LecturerTreeView.TabIndex = 0;
            this.LecturerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LecturerTreeView_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(44, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Lecturer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 602);
            this.Controls.Add(this.StudentTopPanel);
            this.Controls.Add(this.LecturerMainPanel);
            this.Controls.Add(this.StudentLeftPanel);
            this.Name = "Main_Lecturer_Form";
            this.Text = "Main_Lecturer_Form";
            this.Load += new System.EventHandler(this.Main_Lecturer_Form_Load);
            this.StudentTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StudentLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StudentTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LecturerMainPanel;
        private System.Windows.Forms.Panel StudentLeftPanel;
        private System.Windows.Forms.TreeView LecturerTreeView;
        private System.Windows.Forms.Button button1;
    }
}