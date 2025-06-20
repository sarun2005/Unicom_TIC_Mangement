﻿namespace Unicom_TIC.Views.LecturerView
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
            this.MainLecturerMainPanel = new System.Windows.Forms.Panel();
            this.StudentLeftPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LecturerTreeView = new System.Windows.Forms.TreeView();
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
            this.StudentTopPanel.Size = new System.Drawing.Size(988, 100);
            this.StudentTopPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainLecturerMainPanel
            // 
            this.MainLecturerMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLecturerMainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainLecturerMainPanel.Name = "MainLecturerMainPanel";
            this.MainLecturerMainPanel.Size = new System.Drawing.Size(988, 720);
            this.MainLecturerMainPanel.TabIndex = 4;
            this.MainLecturerMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLecturerMainPanel_Paint_1);
            // 
            // StudentLeftPanel
            // 
            this.StudentLeftPanel.Controls.Add(this.button1);
            this.StudentLeftPanel.Controls.Add(this.LecturerTreeView);
            this.StudentLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentLeftPanel.Name = "StudentLeftPanel";
            this.StudentLeftPanel.Size = new System.Drawing.Size(200, 720);
            this.StudentLeftPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(47, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerTreeView
            // 
            this.LecturerTreeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LecturerTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LecturerTreeView.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerTreeView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LecturerTreeView.Location = new System.Drawing.Point(0, 0);
            this.LecturerTreeView.Name = "LecturerTreeView";
            this.LecturerTreeView.Size = new System.Drawing.Size(200, 720);
            this.LecturerTreeView.TabIndex = 0;
            this.LecturerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LecturerTreeView_AfterSelect);
            // 
            // Main_Lecturer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 720);
            this.Controls.Add(this.StudentTopPanel);
            this.Controls.Add(this.MainLecturerMainPanel);
            this.Controls.Add(this.StudentLeftPanel);
            this.Name = "Main_Lecturer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel MainLecturerMainPanel;
        private System.Windows.Forms.Panel StudentLeftPanel;
        private System.Windows.Forms.TreeView LecturerTreeView;
        private System.Windows.Forms.Button button1;
    }
}