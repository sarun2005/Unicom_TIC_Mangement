namespace Unicom_TIC.Views.StudentView
{
    partial class Main_Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Student_Form));
            this.StudentLeftPanel = new System.Windows.Forms.Panel();
            this.StudentTreeView = new System.Windows.Forms.TreeView();
            this.StudentMainPanel = new System.Windows.Forms.Panel();
            this.StudentTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentLeftPanel.SuspendLayout();
            this.StudentTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLeftPanel
            // 
            this.StudentLeftPanel.Controls.Add(this.button1);
            this.StudentLeftPanel.Controls.Add(this.StudentTreeView);
            this.StudentLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentLeftPanel.Name = "StudentLeftPanel";
            this.StudentLeftPanel.Size = new System.Drawing.Size(200, 607);
            this.StudentLeftPanel.TabIndex = 0;
            // 
            // StudentTreeView
            // 
            this.StudentTreeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StudentTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentTreeView.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentTreeView.Location = new System.Drawing.Point(0, 0);
            this.StudentTreeView.Name = "StudentTreeView";
            this.StudentTreeView.Size = new System.Drawing.Size(200, 607);
            this.StudentTreeView.TabIndex = 0;
            this.StudentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.StudentTreeView_AfterSelect);
            // 
            // StudentMainPanel
            // 
            this.StudentMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentMainPanel.Location = new System.Drawing.Point(200, 0);
            this.StudentMainPanel.Name = "StudentMainPanel";
            this.StudentMainPanel.Size = new System.Drawing.Size(815, 607);
            this.StudentMainPanel.TabIndex = 1;
            this.StudentMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentMainPanel_Paint);
            // 
            // StudentTopPanel
            // 
            this.StudentTopPanel.Controls.Add(this.pictureBox1);
            this.StudentTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentTopPanel.Location = new System.Drawing.Point(200, 0);
            this.StudentTopPanel.Name = "StudentTopPanel";
            this.StudentTopPanel.Size = new System.Drawing.Size(815, 100);
            this.StudentTopPanel.TabIndex = 2;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 607);
            this.Controls.Add(this.StudentTopPanel);
            this.Controls.Add(this.StudentMainPanel);
            this.Controls.Add(this.StudentLeftPanel);
            this.Name = "Main_Student_Form";
            this.Text = "Main_Student_Form";
            this.Load += new System.EventHandler(this.Main_Student_Form_Load);
            this.StudentLeftPanel.ResumeLayout(false);
            this.StudentTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StudentLeftPanel;
        private System.Windows.Forms.TreeView StudentTreeView;
        private System.Windows.Forms.Panel StudentMainPanel;
        private System.Windows.Forms.Panel StudentTopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}