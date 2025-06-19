using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unicom_TIC.Controller;
using Unicom_TIC.Model;

namespace Unicom_TIC.Views.AdminView
{
    public partial class Admin_Lecturer_Add : UserControl
    {
        public Admin_Lecturer_Add()
        {
            InitializeComponent();
            
        }

       

        private void AdminLecturerAddSave_Click(object sender, EventArgs e)
        {
            // ============================ Gender Check ============================
            string gender = "";
            if (AdminLecturerAddMale.Checked)
                gender = "Male";
            else if (AdminLecturerAddFemale.Checked)
                gender = "Female";


            // ============================ Lecturer Object Creation ============================
            Lecturer lecturer = new Lecturer
            {
                FirstName = AdminLecturerAddFirstName.Text,
                LastName = AdminLecturerAddLastName.Text,
                Address = AdminLecturerAddAddress.Text,
                DOB = AdminLecturerAddDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender,
                Subject = AdminLecturerAddSubject.Text,
                PhoneNumber = AdminLecturerAddPhoneNumber.Text,
                Email = AdminLecturerAddEmail.Text
            };

            // ============================ Save using Controller ONLY ============================
            LecturerController lecturerController = new LecturerController();




            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminLecturerAddFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerAddLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerAddAddress.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerAddDOB.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerAddSubject.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerAddPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerAddEmail.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter all required details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Email Format Validation ============================
            if (!AdminLecturerAddEmail.Text.Contains("@") || !AdminLecturerAddEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Phone Number validation ============================

            if (lecturer.PhoneNumber.Length != 10 || !lecturer.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                lecturerController.AddLecturer(lecturer);
                MessageBox.Show("New Lecturer Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            ClearFields();
            LoadLecturers();
        }

        private void LoadLecturers()
        {
            
        }




        // ============================ CLEAR ============================
        private void ClearFields()
        {
            AdminLecturerAddFirstName.Text = "";
            AdminLecturerAddLastName.Text = "";
            AdminLecturerAddAddress.Text = "";
            AdminLecturerAddDOB.Value = DateTime.Now;
            AdminLecturerAddSubject.SelectedIndex = -1;
            AdminLecturerAddPhoneNumber.Text = "";
            AdminLecturerAddEmail.Text = "";
            AdminLecturerAddMale.Checked = false;
            AdminLecturerAddFemale.Checked = false;
        }

        // Load subjects to ComboBox
        private void Admin_Lecturer_Add_Load(object sender, EventArgs e)
        {
            LoadSubjectsIntoComboBox();
        }

        private void LoadSubjectsIntoComboBox()
        {
            AdminLecturerAddSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            SubjectController subjectController = new SubjectController();
            List<Subject> subjects = subjectController.ViewAllSubjectsWithCourse();
            AdminLecturerAddSubject.DisplayMember = "SubjectName";
            AdminLecturerAddSubject.ValueMember = "SubjectId";
            AdminLecturerAddSubject.DataSource = subjects;
            AdminLecturerAddSubject.SelectedIndex = -1;
        }


        private void AdminLecturerAddClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void AdminLecturerAddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminLecturerAddEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
