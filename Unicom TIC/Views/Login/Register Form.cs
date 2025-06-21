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
using Unicom_TIC.Model;   


namespace Unicom_TIC.Views.Login
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }




        // ============================ Go to Login Form ============================
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(); 
            loginForm.ShowDialog(); 
        }




        // ============================ Role Combobox Show ============================
        private void Register_Form_Load(object sender, EventArgs e)
        {           
            RegisterRole.DropDownStyle = ComboBoxStyle.DropDownList;
                        
            RegisterRole.Items.Add("Admin");
            RegisterRole.Items.Add("Lecturer");
            RegisterRole.Items.Add("Staff");
            RegisterRole.Items.Add("Student");

            Registerpassword.UseSystemPasswordChar = true;
            Registerconformpassword.UseSystemPasswordChar = true;

        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ CLEAR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++






        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ REGISTER ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void Register_Click(object sender, EventArgs e)
        {
            
            // ============================ Input Validation - Empty Check ============================
            string username = Registerusername.Text.Trim();
            string password = Registerpassword.Text.Trim();
            string conformPassword = Registerconformpassword.Text.Trim();
            string role = RegisterRole.Text;
            string registerIdText = userid.Text.Trim(); 


           if (string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(registerIdText) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(conformPassword))
            {
                
                MessageBox.Show("Please enter all details.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            };

            // ============================ Password Conformation ============================
            if (password != conformPassword)
            {
                MessageBox.Show("Passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Password Strength ============================
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Duplicate Username Check ============================
            if (UserController.UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // ============================ Numeric ID Validation ============================
            int enteredId;
            if (!int.TryParse(registerIdText, out enteredId))
            {
                MessageBox.Show("ID must be a numeric value.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // ============================ Role ID Existence Check ============================
            UserController userController = new UserController(); 

            try
            {
                bool idExists = false;

                // ============================ Use the UserController's methods to check ID existence based on the selected role ============================
                switch (role)
                {
                    case "Admin":
                        idExists = userController.CheckAdminIDExists(enteredId);
                        break;
                    case "Lecturer":
                        idExists = userController.CheckLecturerIDExists(enteredId);
                        break;
                    case "Staff":
                        idExists = userController.CheckStaffIDExists(enteredId);
                        break;
                    case "Student":
                        idExists = userController.CheckStudentIDExists(enteredId);
                        break;
                    default:
                        
                        MessageBox.Show("Please select a valid role.", "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

               
                if (!idExists)
                {
                    MessageBox.Show($"{role} ID {enteredId} was not found in the database. Please enter a valid ID.", "Invalid Role ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // ============================ Role ID already used check ============================
                if (userController.IsRoleIdAlreadyUsed(role, enteredId))
                {
                    MessageBox.Show($"This {role} ID is already associated with an existing account.", "Duplicate Role ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"An error occurred while verifying the ID: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // ============================ Create User Object ============================
            User user = new User
            {
                Username = Registerusername.Text,
                Password = Registerpassword.Text, 
                Role = RegisterRole.Text
            };

            // Assign the entered ID to the correct role-specific property in the User object
            // and set others to null.
            switch (role)
            {
                case "Admin":
                    user.AdminID = enteredId;
                    user.LecturerID = null;
                    user.StaffID = null;
                    user.StudentID = null;
                    break;
                case "Lecturer":
                    user.LecturerID = enteredId;
                    user.AdminID = null;
                    user.StaffID = null;
                    user.StudentID = null;
                    break;
                case "Staff":
                    user.StaffID = enteredId;
                    user.AdminID = null;
                    user.LecturerID = null;
                    user.StudentID = null;
                    break;
                case "Student":
                    user.StudentID = enteredId;
                    user.AdminID = null;
                    user.StaffID = null;
                    user.LecturerID = null;
                    break;
            }

            // ============================ Insert into the Database ============================
            try
            {
                
                userController.AddUser(user);
                MessageBox.Show("New user registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

                // ============================ Go to login form ============================
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Failed to register user. Error: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

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
            Registerpassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            Registerconformpassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}