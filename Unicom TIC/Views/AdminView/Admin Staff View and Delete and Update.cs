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
    public partial class Admin_Staff_View_and_Delete_and_Update : UserControl
    {
        private int selectedStaffID = -1;

        public Admin_Staff_View_and_Delete_and_Update()
        {
           InitializeComponent();
            AdminStaffDetails.RowHeaderMouseClick += AdminStaffDetails_RowHeaderMouseClick;
            AdminStaffDetails.CellClick += AdminStaffDetails_CellClick;
            LoadStaffs();

        }

        public void LoadStaffs()
        {
            StaffController staffController = new StaffController();
            List<Staff> staffs = staffController.ViewAllStaffs();
            AdminStaffDetails.DataSource = null;
            AdminStaffDetails.DataSource = staffs;
        }

        



        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Delete an Staff ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminStaffDelete_Click(object sender, EventArgs e)
        {
            if (AdminStaffDetails.SelectedRows.Count > 0)
            {

                int selectedRowIndex = AdminStaffDetails.SelectedRows[0].Index;
                int staffID = Convert.ToInt32(AdminStaffDetails.Rows[selectedRowIndex].Cells["StaffID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    StaffController controller = new StaffController();
                    controller.DeleteStaff(staffID);

                    MessageBox.Show("Staff deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStaffs();
                }
            }
            else
            {
                MessageBox.Show("Please select an staff to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




  



        //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Staff Search in View and Delete ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminStaffSearchText_TextChanged(object sender, EventArgs e)
        {
            string keyword = AdminStaffSearchText.Text.Trim(); 

            StaffController staffController = new StaffController();
            List<Staff> result;

            if (string.IsNullOrEmpty(keyword))
            {
                result = staffController.ViewAllStaffs();
            }
            else
            {
                result = staffController.SearchStaffs(keyword);
            }

            AdminStaffDetails.DataSource = null;
            AdminStaffDetails.DataSource = result;
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void Admin_Staff_View_and_Delete_Load(object sender, EventArgs e)
        {
            AdminStaffUpdateRole.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminStaffUpdateRole.Items.Add("Manager");
            AdminStaffUpdateRole.Items.Add("Supervisor");
        }





        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ UPDATE ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminStaffUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaffID == -1)
            {
                MessageBox.Show("Please select a staff member in the grid first.","No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // radio → gender string
            string gender = AdminStaffUpdateMale.Checked ? "Male" :AdminStaffUpdateFemale.Checked ? "Female" : "";

            // validation
            if (string.IsNullOrWhiteSpace(AdminStaffUpdateFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffUpdateRole.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffUpdateEmail.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffUpdatePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminStaffUpdateAddress.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all required fields.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phone = AdminStaffUpdatePhoneNumber.Text.Trim();
            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = AdminStaffUpdateEmail.Text.Trim();

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this staff member?","Confirm Update", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes) return;

            // Build object
            var staff = new Staff
            {
                StaffID = selectedStaffID,
                FirstName = AdminStaffUpdateFirstName.Text.Trim(),
                LastName = AdminStaffUpdateLastName.Text.Trim(),
                Role = AdminStaffUpdateRole.Text.Trim(),
                Email = email,
                PhoneNumber = phone,
                Address = AdminStaffUpdateAddress.Text.Trim(),
                DOB = AdminStaffUpdateDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender
            };

            try
            {
                new StaffController().UpdateStaff(staff);
                MessageBox.Show("Staff details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffs();
                ClearUpdateFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ CLEAR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminStaffUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        private void ClearUpdateFields()
        {
            AdminStaffUpdateStaffID.Clear();
            AdminStaffUpdateFirstName.Clear();
            AdminStaffUpdateLastName.Clear();
            AdminStaffUpdateRole.SelectedIndex = -1; 
            AdminStaffUpdateDOB.Value = DateTime.Now;
            AdminStaffUpdateEmail.Clear();
            AdminStaffUpdatePhoneNumber.Clear(); 
            AdminStaffUpdateAddress.Clear();
            AdminStaffUpdateMale.Checked = false;
            AdminStaffUpdateFemale.Checked = false;
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // =========== GRID → FORM autofill ===========
        private void AdminStaffDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var staff = AdminStaffDetails.Rows[e.RowIndex].DataBoundItem as Staff;
            if (staff == null) return;

            selectedStaffID = staff.StaffID;
            AdminStaffUpdateStaffID.Text = staff.StaffID.ToString();
            AdminStaffUpdateFirstName.Text = staff.FirstName;
            AdminStaffUpdateLastName.Text = staff.LastName;
            AdminStaffUpdateRole.Text = staff.Role;
            AdminStaffUpdateEmail.Text = staff.Email;
            AdminStaffUpdatePhoneNumber.Text = staff.PhoneNumber; // Corrected variable name
            AdminStaffUpdateAddress.Text = staff.Address;

            // Set DOB
            if (DateTime.TryParse(staff.DOB, out DateTime dob))
                AdminStaffUpdateDOB.Value = dob;

            // Set Gender
            AdminStaffUpdateMale.Checked = staff.Gender == "Male";
            AdminStaffUpdateFemale.Checked = staff.Gender == "Female";
        }


        private void AdminStaffDetails_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AdminStaffDetails_RowHeaderMouseClick(s,new DataGridViewCellMouseEventArgs(e.ColumnIndex, e.RowIndex, 0, 0, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)));
        }


        private void AdminStaffDetails_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
