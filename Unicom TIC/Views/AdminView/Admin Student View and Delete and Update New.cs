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
    public partial class Admin_Student_View_and_Delete_and_Update_New : UserControl
    {
        private int selectedStudentID = -1;

        public Admin_Student_View_and_Delete_and_Update_New()
        {
            InitializeComponent();
            AdminStudentDetails.RowHeaderMouseClick += Grid_RowHeaderMouseClick;   // ➜ 2.
            AdminStudentDetails.CellClick += Grid_CellClick;
            LoadStudents();
        }

        private void Admin_Student_View_and_Delete_and_Update_New_Load(object sender, EventArgs e)
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

        public void LoadStudents()
        {
            StudentController studentController = new StudentController();
            List<Student> students = studentController.ViewAllStudentWithCourse();
            AdminStudentDetails.DataSource = null;
            AdminStudentDetails.DataSource = students;
        }

        private void AdminStudentDelete_Click(object sender, EventArgs e)
        {

            if (AdminStudentDetails.SelectedRows.Count > 0)
            {

                int selectedRowIndex = AdminStudentDetails.SelectedRows[0].Index;
                int studentID = Convert.ToInt32(AdminStudentDetails.Rows[selectedRowIndex].Cells["StudentID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    StudentController controller = new StudentController();
                    controller.DeleteStudent(studentID);

                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select an student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminStudentSearchText_TextChanged(object sender, EventArgs e)
        {
            string keyword = AdminUpdateStudentSearchText.Text.Trim();

            StudentController controller = new StudentController();
            List<Student> result;

            if (string.IsNullOrEmpty(keyword))
            {
                result = controller.ViewAllStudentWithCourse(); // empty search → show all
            }
            else
            {
                result = controller.SearchStudents(keyword);
            }

            AdminStudentDetails.DataSource = null;
            AdminStudentDetails.DataSource = result;
        }

        private void AdminStudentUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == -1)
            {
                MessageBox.Show("Please select a student row first.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gender
            string gender = AdminStudentUpdateMale.Checked ? "Male" : AdminStudentUpdateFemale.Checked ? "Female" : "";

            // Check if a course is selected
            if (AdminStudentUpdateCourse.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.", "No Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = new Student
            {
                StudentID = selectedStudentID,
                FirstName = AdminStudentUpdateFirstName.Text.Trim(),
                LastName = AdminStudentUpdateLastName.Text.Trim(),
                Address = AdminStudentUpdateAddress.Text.Trim(),
                DOB = AdminStudentUpdateDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender,
                Email = AdminStudentUpdateEmail.Text.Trim(),
                PhoneNumber = AdminStudentUpdatePhoneNumber.Text.Trim(),
                CourseID = (int)AdminStudentUpdateCourse.SelectedValue,
                CourseName = AdminStudentUpdateCourse.Text.Trim(),
            };

            // ============================ Check Validation ============================
            if (string.IsNullOrWhiteSpace(student.FirstName) ||
                string.IsNullOrWhiteSpace(student.LastName) ||
                string.IsNullOrWhiteSpace(student.Address) ||
                string.IsNullOrWhiteSpace(student.CourseName) ||
                string.IsNullOrWhiteSpace(student.Email) ||
                string.IsNullOrWhiteSpace(student.PhoneNumber) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all required details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Phone Number validation ============================
            if (student.PhoneNumber.Length != 10 || !student.PhoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Enter a 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================ Email validation ============================
            if (!student.Email.Contains("@") || !student.Email.Contains("."))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this student?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                new StudentController().UpdateStudent(student);
                MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadStudents(); // Refresh the student list
                ClearUpdateFields(); // Clear the input fields
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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



        // ---------- GRID → FORM autofill ----------
        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var student = AdminStudentDetails.Rows[e.RowIndex].DataBoundItem as Student;
            if (student == null) return;

            selectedStudentID = student.StudentID;
            AdminStudentUpdateStudentID.Text = student.StudentID.ToString();
            AdminStudentUpdateFirstName.Text = student.FirstName;
            AdminStudentUpdateLastName.Text = student.LastName;
            AdminStudentUpdateAddress.Text = student.Address;
            AdminStudentUpdatePhoneNumber.Text = student.PhoneNumber;
            AdminStudentUpdateEmail.Text = student.Email;

            if (DateTime.TryParse(student.DOB, out DateTime dob))
                AdminStudentUpdateDOB.Value = dob;

            AdminStudentUpdateMale.Checked = student.Gender == "Male";
            AdminStudentUpdateFemale.Checked = student.Gender == "Female";

            // Combo-box – Course
            AdminStudentUpdateCourse.SelectedValue = student.CourseID;
        }

        private void Grid_CellClick(object s, DataGridViewCellEventArgs e) =>
            Grid_RowHeaderMouseClick(s, new DataGridViewCellMouseEventArgs(
                e.ColumnIndex, e.RowIndex, 0, 0, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)));
    }
}
