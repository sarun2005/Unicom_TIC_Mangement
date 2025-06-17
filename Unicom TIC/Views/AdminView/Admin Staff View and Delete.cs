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
    public partial class Admin_Staff_View_and_Delete : UserControl
    {
        public Admin_Staff_View_and_Delete()
        {
           InitializeComponent();
            LoadStaffs();

        }

        public void LoadStaffs()
        {
            StaffController staffController = new StaffController();
            List<Staff> staffs = staffController.ViewAllStaffs();
            AdminStaffDetails.DataSource = null;
            AdminStaffDetails.DataSource = staffs;
        }

        private void AdminStaffDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        // Delete an lecturer +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminStaffDelete_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }


        // Method to delete an lecturer based on selected row in DataGridView =========================
        private void DeleteStaff()
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



        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



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

        }
    }
}
