using System;
using System.Windows.Forms;
using Unicom_TIC.Controller;
using Unicom_TIC.Model;

namespace Unicom_TIC.Views.AdminView
{
    public partial class Admin_Staff_Add : UserControl
    {
        public Admin_Staff_Add()
        {
            InitializeComponent();
        }

        // SAVE button click
        private void AdminStaffAddSave_Click(object sender, EventArgs e)
        {
            // ============================ Gender Check ============================
            string gender = "";
            if (AdminStaffAddMale.Checked)
                gender = "Male";
            else if (AdminStaffAddFemale.Checked)
                gender = "Female";

            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminStaffAddFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffAddLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffAddAddress.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffAddDOB.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffAddRole.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffAddPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffAddEmail.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter all required details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Email Format Validation ============================
            if (!AdminStaffAddEmail.Text.Contains("@") || !AdminStaffAddEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Staff Object Creation ============================
            Staff staff = new Staff
            {
                FirstName = AdminStaffAddFirstName.Text,
                LastName = AdminStaffAddLastName.Text,
                Address = AdminStaffAddAddress.Text,
                DOB = AdminStaffAddDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender,
                Role = AdminStaffAddRole.Text,
                PhoneNumber = AdminStaffAddPhoneNumber.Text,
                Email = AdminStaffAddEmail.Text
            };

            // ============================ Save using Controller ============================
            try
            {
                StaffController staffController = new StaffController();
                staffController.AddStaff(staff);

                MessageBox.Show("New Staff Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ============================ Clear and Reload ============================
            ClearFields();
            LoadStaffs();
        }

        
        private void LoadStaffs()
        {
           
        }

        
        private void ClearFields()
        {
            AdminStaffAddFirstName.Text = "";
            AdminStaffAddLastName.Text = "";
            AdminStaffAddAddress.Text = "";
            AdminStaffAddDOB.Value = DateTime.Now;
            AdminStaffAddRole.SelectedIndex = -1;
            AdminStaffAddPhoneNumber.Text = "";
            AdminStaffAddEmail.Text = "";
            AdminStaffAddMale.Checked = false;
            AdminStaffAddFemale.Checked = false;
        }

        private void Admin_Staff_Add_Load(object sender, EventArgs e)
        {
            AdminStaffAddRole.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminStaffAddRole.Items.Add("Manager");
            AdminStaffAddRole.Items.Add("Supervisor");

        }

        private void AdminStaffAddPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
