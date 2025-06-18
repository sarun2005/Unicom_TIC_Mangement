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

namespace Unicom_TIC.Views.AdminView
{
    public partial class Admin_Admin_Update : UserControl
    {
        public Admin_Admin_Update()
        {
            InitializeComponent();
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Update Admin +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminUpdateSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AdminAdminUpdateAdminID.Text, out int id))
            {
                MessageBox.Show("First, search and load the AdminID.", "No Admin Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Admin admin = new Admin
            {
                AdminID = id,
                FirstName = AdminAdminUpdateFirstName.Text.Trim(),
                LastName = AdminAdminUpdateLastName.Text.Trim(),
                Role = AdminAdminUpdateRole.Text.Trim(),
                Email = AdminAdminUpdateEmail.Text.Trim(),
                PhoneNumber = AdminAdminUpdatePhoneNumber.Text.Trim()
            };

            // Input Validation
            if (string.IsNullOrWhiteSpace(admin.FirstName) ||
                string.IsNullOrWhiteSpace(admin.Email) ||
                string.IsNullOrWhiteSpace(admin.LastName) ||
                string.IsNullOrWhiteSpace(admin.Role) ||
                string.IsNullOrWhiteSpace(admin.PhoneNumber))
            {
                MessageBox.Show("Please enter your details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phone Number validation
            if (admin.PhoneNumber.Length != 10 || !admin.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!admin.Email.Contains("@") || !admin.Email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this admin?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                AdminController controller = new AdminController();
                controller.UpdateAdmin(admin); // Call the UpdateAdmin method

                MessageBox.Show("Admin details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins(); // Refresh the admin list after update
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadAdmins()
        {

        }


        // ============================ SEARCH ADMINID ============================
        private void AdminAdminSearch_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(AdminAdminSearchText.Text.Trim(), out int adminID))
            {
                MessageBox.Show("Please enter valid AdminID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            AdminController controller = new AdminController();
            Admin admin = controller.SearchAdmins(adminID.ToString()).FirstOrDefault();


            if (admin == null)
            {
                MessageBox.Show("There is nothing with this AdminID..", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearUpdateFields();        
                return;
            }

            
            AdminAdminUpdateAdminID.Text = admin.AdminID.ToString();
            AdminAdminUpdateFirstName.Text = admin.FirstName;
            AdminAdminUpdateLastName.Text = admin.LastName;
            AdminAdminUpdateRole.Text = admin.Role;          
            AdminAdminUpdateEmail.Text = admin.Email;
            AdminAdminUpdatePhoneNumber.Text = admin.PhoneNumber;
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        // ============================ CLEAR ============================
        private void ClearUpdateFields()
        {
            AdminAdminUpdateAdminID.Clear();
            AdminAdminUpdateFirstName.Clear();
            AdminAdminUpdateLastName.Clear();
            AdminAdminUpdateRole.SelectedIndex = -1;   
            AdminAdminUpdateEmail.Clear();
            AdminAdminUpdatePhoneNumber.Clear();
        }



        private void Admin_Admin_Update_Load(object sender, EventArgs e)
        {
                       
            // ============================ Add items to the role dropdown ============================
            AdminAdminUpdateRole.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminAdminUpdateRole.Items.Add("Owner");
            AdminAdminUpdateRole.Items.Add("Manager");
            AdminAdminUpdateRole.Items.Add("Staff");
            AdminAdminUpdateRole.Items.Add("Lecturer");
        }

       

        private void AdminAdminSearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAdminUpdatePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAdminUpdateEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAdminUpdateBack_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        private void AdminAdminUpdateRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void AdminAdminUpdateAdminID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAdminUpdateFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAdminUpdateLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
