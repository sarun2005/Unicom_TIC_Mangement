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
    public partial class Admin_Admin_View_and_Delete_and_Update : UserControl
    {
        private int selectedAdminID = -1;
       

        public Admin_Admin_View_and_Delete_and_Update()
        {
            InitializeComponent();
            AdminAdminDetails.RowHeaderMouseClick += AdminAdminDetails_RowHeaderMouseClick;
            AdminAdminDetails.CellClick += AdminAdminDetails_CellClick;
            LoadAdmins(); // View

        }


        // ============================ VIEW METHOD ============================
        public void LoadAdmins()
        {
            AdminController adminController = new AdminController();
            List<Admin> admins = adminController.ViewAllAdmins();
            AdminAdminDetails.DataSource = null;
            AdminAdminDetails.DataSource = admins;
        }




        //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ADMIN DELETE +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
                    LoadAdmins();  // Refresh the admin list after Delete
                }
            }
            else
            {
                MessageBox.Show("Please select an admin to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





        //  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ADMIN SEARCH IN VIEW AND DELETE ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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





       
        private void Admin_Admin_View_and_Delete_Load(object sender, EventArgs e)
        {
            // ============================ Add items to the role dropdown ============================
            AdminAdminUpdateRole.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminAdminUpdateRole.Items.Add("Owner");
            AdminAdminUpdateRole.Items.Add("Manager");
            AdminAdminUpdateRole.Items.Add("Staff");
            AdminAdminUpdateRole.Items.Add("Lecturer");
        }
       



        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ UPDATE ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminUpdateUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAdminID == -1)
            {
                MessageBox.Show("Please select an admin row first.","No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var admin = new Admin
            {
                AdminID = selectedAdminID,                           
                FirstName = AdminAdminUpdateFirstName.Text.Trim(),
                LastName = AdminAdminUpdateLastName.Text.Trim(),
                Role = AdminAdminUpdateRole.Text.Trim(),          
                Email = AdminAdminUpdateEmail.Text.Trim(),
                PhoneNumber = AdminAdminUpdatePhoneNumber.Text.Trim()
            };


            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(admin.FirstName) ||
                string.IsNullOrWhiteSpace(admin.Email) ||
                string.IsNullOrWhiteSpace(admin.LastName) ||
                string.IsNullOrWhiteSpace(admin.Role) ||
                string.IsNullOrWhiteSpace(admin.PhoneNumber))
            {
                MessageBox.Show("Please enter your details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ============================ Phone Number validation ============================
            if (admin.PhoneNumber.Length != 10 || !admin.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ============================ Email validation ============================
            if (!admin.Email.Contains("@") || !admin.Email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (MessageBox.Show("Are you sure you want to update this admin?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;



            try
            {
                new AdminController().UpdateAdmin(admin);

                MessageBox.Show("Admin updated successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins();     
                ClearAdminForm(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating:\n{ex.Message}","Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ CLEAR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminUpdateBack_Click(object sender, EventArgs e)
        {
            ClearAdminForm();
        }

        private void ClearAdminForm()
        {
            AdminAdminSearchText.Clear();
            AdminAdminUpdateAdminID.Clear();
            AdminAdminUpdateFirstName.Clear();
            AdminAdminUpdateLastName.Clear();
            AdminAdminUpdateRole.SelectedIndex = -1;
            AdminAdminUpdateEmail.Clear();
            AdminAdminUpdatePhoneNumber.Clear();
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ LOAD DATA ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminDetails_RowHeaderMouseClick(object sender,
                DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;   
           
            var admin = AdminAdminDetails.Rows[e.RowIndex].DataBoundItem as Admin;
            if (admin == null) return;

            selectedAdminID = admin.AdminID;
           
            AdminAdminUpdateAdminID.Text = admin.AdminID.ToString();   
            AdminAdminUpdateFirstName.Text = admin.FirstName;
            AdminAdminUpdateLastName.Text = admin.LastName;
            AdminAdminUpdateRole.Text = admin.Role;
            AdminAdminUpdateEmail.Text = admin.Email;
            AdminAdminUpdatePhoneNumber.Text = admin.PhoneNumber;
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++






        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ROW SELECT (normal cell click) ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AdminAdminDetails_RowHeaderMouseClick(sender,
                    new DataGridViewCellMouseEventArgs(e.ColumnIndex, e.RowIndex, 0, 0,
                        new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)));
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++






        private void AdminAdminSearch_Click(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void label1_Click(object sender, EventArgs e){}

    }
}
