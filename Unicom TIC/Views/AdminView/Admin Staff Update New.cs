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
    public partial class Admin_Staff_Update_New : UserControl
    {
        public Admin_Staff_Update_New()
        {
            InitializeComponent();
        }

        private void AdminStaffUpdateSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AdminStaffSearchText.Text.Trim(), out int staffID))
            {
                MessageBox.Show("Please enter valid StaffID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            StaffController controller = new StaffController();
            Staff staff = controller.SearchStaffs(staffID.ToString()).FirstOrDefault();


            if (staff == null)
            {
                MessageBox.Show("There is nothing with this StaffID..", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearUpdateFields();
                return;
            }


            AdminStaffUpdateStaffID.Text = staff.StaffID.ToString();
            AdminStaffUpdateFirstName.Text = staff.FirstName;
            AdminStaffUpdateLastName.Text = staff.LastName;
            AdminStaffUpdateRole.Text = staff.Role;
            AdminStaffUpdateEmail.Text = staff.Email;
            AdminSatffUpdatePhoneNumber.Text = staff.PhoneNumber;
        }

        // ============================ CLEAR ============================
        private void ClearUpdateFields()
        {
            AdminStaffUpdateStaffID.Clear();
            AdminStaffUpdateFirstName.Clear();
            AdminStaffUpdateLastName.Clear();
            AdminStaffUpdateRole.SelectedIndex = -1;
            AdminStaffUpdateEmail.Clear();
            AdminSatffUpdatePhoneNumber.Clear();
          
        }

        private void AdminStaffUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();

        }

        private void AdminStaffUpdateSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AdminStaffUpdateStaffID.Text, out int id))
            {
                MessageBox.Show("First, search and load the StaffID.", "No Staff Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Staff staff = new Staff
            {
                StaffID = id,
                FirstName = AdminStaffUpdateFirstName.Text.Trim(),
                LastName = AdminStaffUpdateLastName.Text.Trim(),
                Role = AdminStaffUpdateRole.Text.Trim(),
                Email = AdminStaffUpdateEmail.Text.Trim(),
                PhoneNumber = AdminSatffUpdatePhoneNumber.Text.Trim()
            };

            // Input Validation
            if (string.IsNullOrWhiteSpace(staff.FirstName) ||
                string.IsNullOrWhiteSpace(staff.Email) ||
                string.IsNullOrWhiteSpace(staff.LastName) ||
                string.IsNullOrWhiteSpace(staff.Role) ||
                string.IsNullOrWhiteSpace(staff.PhoneNumber))
            {
                MessageBox.Show("Please enter your details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phone Number validation
            if (staff.PhoneNumber.Length != 10 || !staff.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!staff.Email.Contains("@") || !staff.Email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this staff?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                StaffController controller = new StaffController();
                controller.UpdateStaff(staff); // Call the UpdateLecturer method

                MessageBox.Show("Staff details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffs(); // Refresh the lecturer list after update
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStaffs()
        {
           
        }
    }
    
}
