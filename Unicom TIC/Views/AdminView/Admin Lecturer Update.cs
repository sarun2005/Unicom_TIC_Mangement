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
    public partial class Admin_Lecturer_Update : UserControl
    {
        public Admin_Lecturer_Update()
        {
            InitializeComponent();
        }

        private void Admin_Lecturer_Update_Load(object sender, EventArgs e)
        {
            // ============================ Add items to the role dropdown ============================
            AdminLecturerUpdateSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminLecturerUpdateSubject.Items.Add("Python");
            AdminLecturerUpdateSubject.Items.Add("C#");
            AdminLecturerUpdateSubject.Items.Add("Java");
            AdminLecturerUpdateSubject.Items.Add("HTML");
            AdminLecturerUpdateSubject.Items.Add("PHP");
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ UPDATE SAVE ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminLecturerUpdateSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AdminLecturerUpdateLecturerID.Text, out int id))
            {
                MessageBox.Show("First, search and load the LecturerID.", "No Lecturer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Gender Check ============================
            string gender = "";
            if (AdminLecturerUpdateMale.Checked)
                gender = "Male";
            else if (AdminLecturerUpdateFemale.Checked)
                gender = "Female";

            // ============================ Lecturer Object Creation ============================
            Lecturer lecturer = new Lecturer
            {
                LecturerID = id,
                FirstName = AdminLecturerUpdateFirstName.Text.Trim(),
                LastName = AdminLecturerUpdateLastName.Text.Trim(),
                Subject = AdminLecturerUpdateSubject.Text.Trim(),
                DOB = AdminLecturerUpdateDOB.Value.ToString("yyyy-MM-dd"),
                gender = gender,
                Email = AdminLecturerUpdateEmail.Text.Trim(),
                PhoneNumber = AdminLecturerUpdatePhoneNumber.Text.Trim(),
                Address = AdminLecturerUpdateAddress.Text.Trim()   
            };


            // Input Validation
            if (string.IsNullOrWhiteSpace(AdminLecturerUpdateFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateAddress.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateDOB.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateSubject.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdatePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateEmail.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter your details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phone Number validation
            if (lecturer.PhoneNumber.Length != 10 || !lecturer.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!lecturer.Email.Contains("@") || !lecturer.Email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this lecturer?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                LecturerController controller = new LecturerController();
                controller.UpdateLecturer(lecturer); 

                MessageBox.Show("Lecturer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ============================ After View Update ============================
                LoadLecturers(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++












        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ UPDATE SEARCH LECTURER ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminLecturerSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AdminUpdateLecturerSearchText.Text.Trim(), out int lecturerID))
            {
                MessageBox.Show("Please enter valid LecturerID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            LecturerController controller = new LecturerController();
            Lecturer lecturer = controller.SearchLecturers(lecturerID.ToString()).FirstOrDefault();


            if (lecturer == null)
            {
                MessageBox.Show("There is nothing with this LecturerID..", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearUpdateFields();
                return;
            }


            // ============================ Add by Textbox in update ============================
            AdminLecturerUpdateLecturerID.Text = lecturer.LecturerID.ToString();
            AdminLecturerUpdateFirstName.Text = lecturer.FirstName;
            AdminLecturerUpdateLastName.Text = lecturer.LastName;
            AdminLecturerUpdateAddress.Text = lecturer.Address;
            AdminLecturerUpdateEmail.Text = lecturer.Email;
            AdminLecturerUpdatePhoneNumber.Text = lecturer.PhoneNumber;
            AdminLecturerUpdateDOB.Value = DateTime.Parse(lecturer.DOB);


            if (!AdminLecturerUpdateSubject.Items.Contains(lecturer.Subject))
                AdminLecturerUpdateSubject.Items.Add(lecturer.Subject);
            AdminLecturerUpdateSubject.SelectedItem = lecturer.Subject;

            
            AdminLecturerUpdateMale.Checked = lecturer.gender == "Male";
            AdminLecturerUpdateFemale.Checked = lecturer.gender == "Female";

        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ CLEAR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void AdminLecturerUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        private void ClearUpdateFields()
        {
            AdminUpdateLecturerSearchText.Clear();
            AdminLecturerUpdateLecturerID.Clear();
            AdminLecturerUpdateFirstName.Clear();
            AdminLecturerUpdateLastName.Clear();
            AdminLecturerUpdateSubject.SelectedIndex = -1;
            AdminLecturerUpdateEmail.Clear();
            AdminLecturerUpdatePhoneNumber.Clear();
            AdminLecturerUpdateAddress.Clear();
            AdminLecturerUpdateMale.Checked = false;
            AdminLecturerUpdateFemale.Checked = false;
            AdminLecturerUpdateDOB.Value = DateTime.Now;
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        private void LoadLecturers() { } // View
        private void AdminLecturerUpdateRole_SelectedIndexChanged(object sender, EventArgs e){}
        private void AdminLecturerSearchText_TextChanged(object sender, EventArgs e){}
    }
    
}
