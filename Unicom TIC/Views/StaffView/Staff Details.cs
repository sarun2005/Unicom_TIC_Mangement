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

namespace Unicom_TIC.Views.StaffView
{
    public partial class Staff_Details : UserControl
    {
        private int staffId;

        public Staff_Details(int id)
        {
            InitializeComponent();
            staffId = id;
        }


        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ View Lecturer Details ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void Staff_Details_Load(object sender, EventArgs e)
        {
            LoadStaffDetails();
        }

        private void LoadStaffDetails()
        {
            var controller = new StaffController();
            var staff = controller.GetStaffById(staffId);

            // ======================= only view not change =======================
            StaffMale.Enabled = false;
            StaffFemale.Enabled = false;
            StaffStaffID.Enabled = false;
            StaffFirstName.Enabled = false;
            StaffLastName.Enabled = false;
            StaffAddress.Enabled = false;
            StaffDOB.Enabled = false;
            StaffRole.Enabled = false;
            StaffEmail.Enabled = false;
            StaffPhoneNumber.Enabled = false;



            // ================= Gender Check =======================
            if (staff.Gender == "Male")
            {
                StaffMale.Checked = true;
            }
            else if (staff.Gender == "Female")
            {
                StaffFemale.Checked = true;
            }

            if (staff != null)
            {

                StaffStaffID.Text = staff.StaffID.ToString();
                StaffFirstName.Text = staff.FirstName;
                StaffLastName.Text = staff.LastName;
                StaffAddress.Text = staff.Address;
                StaffDOB.Text = staff.DOB;
                StaffRole.Text = staff.Role;
                StaffEmail.Text = staff.Email;
                StaffPhoneNumber.Text = staff.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Lecturer details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }
}
