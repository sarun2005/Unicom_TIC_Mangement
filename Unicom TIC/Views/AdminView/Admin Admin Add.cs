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
    public partial class Admin_Admin_Add : UserControl
    {
        public Admin_Admin_Add()
        {
            InitializeComponent();
        }


        private void Admin_Admin_Add_Load(object sender, EventArgs e)
        {
            // ============================ Add items to the role dropdown ============================
            AdminAdminAddRole.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminAdminAddRole.Items.Add("Owner");
            AdminAdminAddRole.Items.Add("Manager");
            AdminAdminAddRole.Items.Add("Staff");
            AdminAdminAddRole.Items.Add("Lecturer");
        }


        //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Admin Add +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminAddSave_Click(object sender, EventArgs e)
        {
            // ============================ Admin Object Creation ============================
            Admin admin = new Admin
            {
                FirstName = AdminAdminAddFirstName.Text,
                LastName = AdminAdminAddLastName.Text,
                Role = AdminAdminAddRole.Text,
                PhoneNumber = AdminAdminAddPhoneNumber.Text,
                Email = AdminAdminAddEmail.Text
            };


            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminAdminAddFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminAdminAddLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminAdminAddRole.Text) ||
                string.IsNullOrWhiteSpace(AdminAdminAddPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminAdminAddEmail.Text)
               )

            {
                MessageBox.Show("Please enter your details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };



            // ============================ Phone Number validation ============================
            if (admin.PhoneNumber.Length != 10 || !admin.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ============================  Email validation ============================
            if (!AdminAdminAddEmail.Text.Contains("@") || !AdminAdminAddEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ============================ Save using Controller ONLY ============================
            AdminController adminController = new AdminController();


            try
            {
                adminController.AddAdmin(admin);
                MessageBox.Show("New Admin Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // ------------- CLEAR -------------
            ClearFields();

            // ------------- VIEW -------------
            LoadAdmins();
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++






        // ------------- VIEW -------------
        private void LoadAdmins()
        {

        }






        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ CLEAR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminAdminAddBack_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ------------- Clear fields Method -------------
        private void ClearFields()
        {
            AdminAdminAddFirstName.Text = "";
            AdminAdminAddLastName.Text = "";
            AdminAdminAddRole.SelectedIndex = -1;
            AdminAdminAddPhoneNumber.Text = "";
            AdminAdminAddEmail.Text = "";
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++









        private void label1_Click(object sender, EventArgs e){}
        private void AdminAdminAddRole_SelectedIndexChanged(object sender, EventArgs e){}
        private void AdminAdminAddFirstName_TextChanged(object sender, EventArgs e){}
        private void AdminAdminAddLastName_TextChanged(object sender, EventArgs e){}
        private void AdminAdminAddPhoneNumber_TextChanged(object sender, EventArgs e){}
        private void AdminAdminAddEmail_TextChanged(object sender, EventArgs e){}
    }    
    
}
