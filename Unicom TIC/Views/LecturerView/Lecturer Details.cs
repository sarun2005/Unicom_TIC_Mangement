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

namespace Unicom_TIC.Views.LecturerView
{
    public partial class Lecturer_Details : UserControl
    {
        private int lecturerId;

        public Lecturer_Details(int id)
        {
            InitializeComponent();
            lecturerId = id;
        }

        private void AdminLecturerAddLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lecturer_Details_Load(object sender, EventArgs e)
        {
            LoadLecturerDetails();
        }

        private void LoadLecturerDetails()
        {
            var controller = new LecturerController();
            var lec = controller.GetLecturerById(lecturerId);

            // ======================= only view not show =======================
            LecturerMale.Enabled = false;
            LecturerFemale.Enabled = false;
            LecturerLecturerID.Enabled = false;
            LecturerFirstName.Enabled = false;
            LecturerLastName.Enabled = false;
            LecturerAddress.Enabled = false;
            LecturerDOB.Enabled = false;
            LecturerSubject.Enabled = false;
            LecturerEmail.Enabled = false;
            LecturerPhoneNumber.Enabled = false;


            if (lec.Gender == "Male")
            {
                LecturerMale.Checked = true;
            }
            else if (lec.Gender == "Female")
            {
                LecturerFemale.Checked = true;
            }

            if (lec != null)
            {

                LecturerLecturerID.Text = lec.LecturerID.ToString();
                LecturerFirstName.Text = lec.FirstName;
                LecturerLastName.Text = lec.LastName;
                LecturerAddress.Text = lec.Address;
                LecturerDOB.Text = lec.DOB;
                LecturerSubject.Text = lec.Subject;
                LecturerEmail.Text = lec.Email;
                LecturerPhoneNumber.Text = lec.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Lecturer details not found.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LecturerLecturerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LecturerSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LecturerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LecturerFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
