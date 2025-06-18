namespace Unicom_TIC.Views.Login
{
    partial class Register_Form
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
            this.Register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.RegisterID = new System.Windows.Forms.TableLayoutPanel();
            this.Registerconformpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Registerpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterRole = new System.Windows.Forms.ComboBox();
            this.userid = new System.Windows.Forms.TextBox();
            this.Registerusername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RegisterID.SuspendLayout();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.FlatAppearance.BorderSize = 0;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(77, 398);
            this.Register.Margin = new System.Windows.Forms.Padding(4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(256, 35);
            this.Register.TabIndex = 6;
            this.Register.Text = "REGISTER";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 513);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Already Have An Account";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(307, 349);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(99, 17);
            this.checkBoxShowPassword.TabIndex = 8;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // RegisterID
            // 
            this.RegisterID.ColumnCount = 2;
            this.RegisterID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.46154F));
            this.RegisterID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.53846F));
            this.RegisterID.Controls.Add(this.Registerconformpassword, 1, 4);
            this.RegisterID.Controls.Add(this.label1, 0, 4);
            this.RegisterID.Controls.Add(this.Registerpassword, 1, 3);
            this.RegisterID.Controls.Add(this.label5, 0, 3);
            this.RegisterID.Controls.Add(this.ID, 0, 1);
            this.RegisterID.Controls.Add(this.label2, 0, 0);
            this.RegisterID.Controls.Add(this.label4, 0, 2);
            this.RegisterID.Controls.Add(this.RegisterRole, 1, 0);
            this.RegisterID.Controls.Add(this.userid, 1, 1);
            this.RegisterID.Controls.Add(this.Registerusername, 1, 2);
            this.RegisterID.Location = new System.Drawing.Point(23, 79);
            this.RegisterID.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterID.Name = "RegisterID";
            this.RegisterID.RowCount = 5;
            this.RegisterID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RegisterID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RegisterID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RegisterID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RegisterID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RegisterID.Size = new System.Drawing.Size(383, 263);
            this.RegisterID.TabIndex = 9;
            // 
            // Registerconformpassword
            // 
            this.Registerconformpassword.Location = new System.Drawing.Point(113, 212);
            this.Registerconformpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Registerconformpassword.Name = "Registerconformpassword";
            this.Registerconformpassword.Size = new System.Drawing.Size(266, 20);
            this.Registerconformpassword.TabIndex = 11;
            this.Registerconformpassword.UseSystemPasswordChar = true;
            this.Registerconformpassword.TextChanged += new System.EventHandler(this.Registerconformpassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Conform Password";
            // 
            // Registerpassword
            // 
            this.Registerpassword.Location = new System.Drawing.Point(113, 160);
            this.Registerpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Registerpassword.Name = "Registerpassword";
            this.Registerpassword.Size = new System.Drawing.Size(266, 20);
            this.Registerpassword.TabIndex = 9;
            this.Registerpassword.UseSystemPasswordChar = true;
            this.Registerpassword.TextChanged += new System.EventHandler(this.Registerpassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(4, 52);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // RegisterRole
            // 
            this.RegisterRole.FormattingEnabled = true;
            this.RegisterRole.Location = new System.Drawing.Point(113, 4);
            this.RegisterRole.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterRole.Name = "RegisterRole";
            this.RegisterRole.Size = new System.Drawing.Size(266, 21);
            this.RegisterRole.TabIndex = 6;
            this.RegisterRole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(113, 56);
            this.userid.Margin = new System.Windows.Forms.Padding(4);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(266, 20);
            this.userid.TabIndex = 7;
            this.userid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Registerusername
            // 
            this.Registerusername.Location = new System.Drawing.Point(113, 108);
            this.Registerusername.Margin = new System.Windows.Forms.Padding(4);
            this.Registerusername.Name = "Registerusername";
            this.Registerusername.Size = new System.Drawing.Size(266, 20);
            this.Registerusername.TabIndex = 8;
            this.Registerusername.TextChanged += new System.EventHandler(this.Registerusername_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(77, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(77, 530);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back to LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegisterID);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Register);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.RegisterID.ResumeLayout(false);
            this.RegisterID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TableLayoutPanel RegisterID;
        private System.Windows.Forms.TextBox Registerconformpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Registerpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RegisterRole;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox Registerusername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}