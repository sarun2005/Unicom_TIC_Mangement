using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Views.Login;

namespace Unicom_TIC.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Form register_Form = new Register_Form();
            register_Form.ShowDialog();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginRole.DropDownStyle = ComboBoxStyle.DropDownList;

           
            LoginRole.Items.Add("Admin");
            LoginRole.Items.Add("Lecturer");
            LoginRole.Items.Add("Staff");
            LoginRole.Items.Add("Student");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            Loginusername.Text = "";
            LoginID.Text = "";
            Loginpassword.Text = "";
            LoginRole.SelectedIndex = -1;
            
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Loginpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Loginusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
