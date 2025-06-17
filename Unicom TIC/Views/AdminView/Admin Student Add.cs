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
    public partial class Admin_Student_Add : UserControl
    {
        public Admin_Student_Add()
        {
            InitializeComponent();
        }

        private void AdminStudentAddSave_Click(object sender, EventArgs e)
        {
            // ============================ Gender Check ============================
            string gender = "";
            if (AdminStudentAddMale.Checked)
            {
                gender = "Male";
            }
            else if (AdminStudentAddFemale.Checked)
            {
                gender = "Female";
            }


            // ============================ Student Object Creation ============================
            Student student = new Student
            {
                FirstName = AdminStudentAddFirstName.Text,
                LastName = AdminStudentAddLastName.Text,
                Address = AdminStudentAddAddress.Text,
                PhoneNumber = AdminStudentAddPhoneNumber.Text,
                Email = AdminStudentAddEmail.Text,
                DOB = AdminStudentAddDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender,
                CourseID = Convert.ToInt32(AdminStudentAddCourse.SelectedValue)
            };

            // ============================ Save using Controller ONLY ============================
            StudentController studentController = new StudentController();

            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminStudentAddFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentAddLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentAddAddress.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentAddDOB.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentAddCourse.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentAddPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentAddEmail.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter all required details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Email Format Validation ============================
            if (!AdminStudentAddEmail.Text.Contains("@") || !AdminStudentAddEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Phone Number validation ============================

            if (student.PhoneNumber.Length != 10 || !student.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                studentController.AddStudent(student);
                MessageBox.Show("New Student Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ClearFields();
            LoadStudents();
        }

        private void LoadStudents()
        {
            
        }





        // ============================ CLEAR ============================
        private void ClearFields()
        {
            AdminStudentAddFirstName.Text = "";
            AdminStudentAddLastName.Text = "";
            AdminStudentAddAddress.Text = "";
            AdminStudentAddDOB.Value = DateTime.Now;
            AdminStudentAddCourse.SelectedIndex = -1;
            AdminStudentAddPhoneNumber.Text = "";
            AdminStudentAddEmail.Text = "";
            AdminStudentAddMale.Checked = false;
            AdminStudentAddFemale.Checked = false;
        }


        private void Admin_Student_Add_Load(object sender, EventArgs e)
        {
            LoadCoursesIntoComboBox();
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Course Add by Student Combobox +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void LoadCoursesIntoComboBox()
        {
            AdminStudentAddCourse.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController courseController = new CourseController();
            List<Course> courses = courseController.ViewAllCourses();
            AdminStudentAddCourse.DisplayMember = "CourseName";
            AdminStudentAddCourse.ValueMember = "CourseID";
            AdminStudentAddCourse.DataSource = courses;
            AdminStudentAddCourse.SelectedIndex = -1;
        }

        private void AdminStudentAddClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
