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
    public partial class Admin_Student_Update : UserControl
    {
        public Admin_Student_Update()
        {
            InitializeComponent();
        }

        private void AdminStudentUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        private void ClearUpdateFields()
        {
            AdminUpdateStudentSearchText.Clear();
            AdminStudentUpdateStudentID.Clear();
            AdminStudentUpdateFirstName.Clear();
            AdminStudentUpdateLastName.Clear();
            AdminStudentUpdateEmail.Clear();
            AdminStudentUpdatePhoneNumber.Clear();
            AdminStudentUpdateAddress.Clear();
            AdminStudentUpdateMale.Checked = false;
            AdminStudentUpdateFemale.Checked = false;
            AdminStudentUpdateDOB.Value = DateTime.Now;
        }

        private void AdminStudentUpdateSave_Click(object sender, EventArgs e)
        {
            // ============================ Gender Check ============================
            string gender = "";
            if (AdminStudentUpdateMale.Checked)
            {
                gender = "Male";
            }
            else if (AdminStudentUpdateFemale.Checked)
            {
                gender = "Female";
            }



            // ============================ Student Object Creation ============================
            Student student = new Student
            {
                FirstName = AdminStudentUpdateFirstName.Text,
                LastName = AdminStudentUpdateLastName.Text,
                Address = AdminStudentUpdateAddress.Text,
                PhoneNumber = AdminStudentUpdatePhoneNumber.Text,
                Email = AdminStudentUpdateEmail.Text,
                DOB = AdminStudentUpdateDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender,
                CourseID = Convert.ToInt32(AdminStudentUpdateCourse.SelectedValue)
            };

            // ============================ Save using Controller ONLY ============================
            StudentController studentController = new StudentController();

            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminStudentUpdateFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentUpdateAddress.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentUpdateDOB.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentUpdateCourse.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentUpdatePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminStudentUpdateEmail.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter all required details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Email Format Validation ============================
            if (!AdminStudentUpdateEmail.Text.Contains("@") || !AdminStudentUpdateEmail.Text.Contains("."))
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

        }

        private void Admin_Student_Update_Load(object sender, EventArgs e)
        {
            LoadCoursesIntoComboBox();
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Course Add by Student Combobox +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void LoadCoursesIntoComboBox()
        {
            AdminStudentUpdateCourse.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController courseController = new CourseController();
            List<Course> courses = courseController.ViewAllCourses();
            AdminStudentUpdateCourse.DisplayMember = "CourseName";
            AdminStudentUpdateCourse.ValueMember = "CourseID";
            AdminStudentUpdateCourse.DataSource = courses;
            AdminStudentUpdateCourse.SelectedIndex = -1;
        }

        private void AdminStudentUpdateCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminStudentSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AdminUpdateStudentSearchText.Text.Trim(), out int studentID))
            {
                MessageBox.Show("Please enter valid StudentID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            StudentController controller = new StudentController();
            Student student = controller.SearchStudents(studentID.ToString()).FirstOrDefault();


            if (student == null)
            {
                MessageBox.Show("There is nothing with this StudentID..", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearUpdateFields();
                return;
            }


            // ============================ Add by Textbox in update ============================
            AdminStudentUpdateStudentID.Text = student.StudentID.ToString();
            AdminStudentUpdateFirstName.Text = student.FirstName;
            AdminStudentUpdateLastName.Text = student.LastName;
            AdminStudentUpdateAddress.Text = student.Address;
            AdminStudentUpdateEmail.Text = student.Email;
            AdminStudentUpdatePhoneNumber.Text = student.PhoneNumber;
            AdminStudentUpdateDOB.Value = DateTime.Parse(student.DOB);


          


            AdminStudentUpdateMale.Checked = student.gender == "Male";
            AdminStudentUpdateFemale.Checked = student.gender == "Female";
        }
    }
}
