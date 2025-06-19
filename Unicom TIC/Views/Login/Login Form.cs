using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Controller;
using Unicom_TIC.Views.AdminView;
using Unicom_TIC.Views.LecturerView;
using Unicom_TIC.Views.Login;
using Unicom_TIC.Views.StaffView;
using Unicom_TIC.Views.StudentView;


namespace Unicom_TIC.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        // ============================ Go to Register Form ============================
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
            // --------------- 1. Input Validation ---------------
            string username = Loginusername.Text.Trim();
            string password = Loginpassword.Text;   // Trim not required ‑‑ PasswordChar hides input
            string role = LoginRole.Text;
            string idText = LoginID.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Please fill in all details.","Login Failed", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idText, out int enteredId))
            {
                MessageBox.Show("ID must be a numeric value.", "Invalid ID",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            // --------------- 2. AuthenticateUser call ---------------
            bool isValid = UserController.AuthenticateUser(username,password,role,enteredId);



            // Login_Click() method-ல்
            if (isValid)
            {
                Form nextForm = null;

                switch (role)
                {
                    case "Admin":
                        nextForm = new Main_Admin(enteredId);
                        break;
                    case "Lecturer":
                        nextForm = new Main_Lecturer_Form(enteredId);
                        break;
                    case "Staff":
                        nextForm = new Main_Staff_Form(enteredId);
                        break;
                    case "Student":
                        nextForm = new Main_Student_Form(enteredId);
                        break;
                }

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                nextForm.ShowDialog();
                this.Show();
                ClearFields();
            }

            else
            {
                MessageBox.Show("Incorrect credentials. Please try again.","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

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
