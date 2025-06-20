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
    public partial class Admin_Admin_View_and_Delete : UserControl
    {
        public Admin_Admin_View_and_Delete()
        {
            InitializeComponent();


            // ------- VIEW -------
            LoadAdmins();

        }


        // ============================ VIEW METHOD ============================
        public void LoadAdmins()
        {
            AdminController adminController = new AdminController();
            List<Admin> admins = adminController.ViewAllAdmins();
            AdminAdminDetails.DataSource = null;
            AdminAdminDetails.DataSource = admins;
        }




        //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Admin Delete +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminDelete_Click(object sender, EventArgs e)
        {
            if (AdminAdminDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = AdminAdminDetails.SelectedRows[0].Index;
                int adminID = Convert.ToInt32(AdminAdminDetails.Rows[selectedRowIndex].Cells["AdminID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AdminController controller = new AdminController();
                    controller.DeleteAdmin(adminID);

                    MessageBox.Show("Admin deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmins();
                }
            }
            else
            {
                MessageBox.Show("Please select an admin to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





        //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Admin Search in View and Delete +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminSearchText_TextChanged(object sender, EventArgs e)
        {

            string keyword = AdminAdminSearchText.Text.Trim();

            AdminController controller = new AdminController();
            List<Admin> result;

            if (string.IsNullOrEmpty(keyword))
            {
                result = controller.ViewAllAdmins(); // empty search → show all
            }
            else
            {
                result = controller.SearchAdmins(keyword);
            }

            AdminAdminDetails.DataSource = null;
            AdminAdminDetails.DataSource = result;
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





        private void AdminAdminSearch_Click(object sender, EventArgs e){}
        private void Admin_Admin_View_and_Delete_Load(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
    }
}
