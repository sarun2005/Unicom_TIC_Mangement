using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC.Views.Login
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

            RegisterRole.DropDownStyle = ComboBoxStyle.DropDownList;

            RegisterRole.Items.Add("Admin");
            RegisterRole.Items.Add("Lecturer");
            RegisterRole.Items.Add("Staff");
            RegisterRole.Items.Add("Student");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            Registerusername.Text = "";
            RegisterID.Text = "";
            Registerpassword.Text = "";
            Registerconformpassword.Text = "";
            RegisterRole.SelectedIndex = -1;

        }

        private void Register_Click(object sender, EventArgs e)
        {
            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(RegisterRole.Text) ||
                string.IsNullOrWhiteSpace(RegisterID.Text) ||
                string.IsNullOrWhiteSpace(Registerusername.Text) ||
                string.IsNullOrWhiteSpace(Registerpassword.Text) ||
                string.IsNullOrWhiteSpace(Registerconformpassword.Text)
               )

            {
                MessageBox.Show("Please enter details", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else if (Registerpassword.Text == Registerconformpassword.Text)
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerconformpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
