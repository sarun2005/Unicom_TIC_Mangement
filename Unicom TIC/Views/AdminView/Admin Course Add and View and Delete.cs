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
    public partial class Admin_Course_Add_and_View_and_Delete : UserControl
    {
        public int CourseID { get; private set; } = -1;
        
        public Admin_Course_Add_and_View_and_Delete()
        {
            InitializeComponent();
            AdminCourseDetails.MultiSelect = false;
            AdminCourseDetails.CellContentClick += AdminCourseDetails_CellContentClick;
            AdminCourseDetails.CellClick += AdminCourseDetails_CellClick;
            LoadCourses();
        }

        public void LoadCourses()
        {
            var controller = new CourseController();
            List<Course> courses = controller.ViewAllCourses();

            AdminCourseDetails.DataSource = null;
            AdminCourseDetails.DataSource = courses;
        }



        private void AdminCourseSave_Click(object sender, EventArgs e)
        {
            // Course Object Creation ================================================================
            Course course = new Course
            {
                CourseName = AdminCourseName.Text,
               
            };



            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminCourseName.Text))

            {
                MessageBox.Show("Please enter Course details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            // ============================ Save using Controller ONLY ============================
            CourseController courseController = new CourseController();


            try
            {
                courseController.AddCourse(course);
                MessageBox.Show("New Course Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
            LoadCourses();
        }

        private void ClearFields()
        {
            AdminCourseName.Text = "";
        }


        // Delete an Course ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCourse();
        }

        // Method to delete a course based on selected row in DataGridView =========================
        private void DeleteCourse()
        {
            if (AdminCourseDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = AdminCourseDetails.SelectedRows[0].Index;
                int courseID = Convert.ToInt32(AdminCourseDetails.Rows[selectedRowIndex].Cells["CourseID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CourseController controller = new CourseController();
                    controller.DeleteCourse(courseID);
                    MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCourses();
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminCourseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Course_Add_and_View_and_Delete_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CourseID == -1)
            {
                MessageBox.Show("Please select a Course from the list to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(AdminCourseName.Text))
            {
                MessageBox.Show("Course Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var course = new Course
            {
                CourseID = CourseID,
                CourseName = AdminCourseName.Text.Trim()
            };
            try
            {
                new CourseController().UpdateCourse(course);
                MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ============================ DATAGRIDVIEW EVENTS ============================
        private void AdminCourseDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AdminCourseDetails.Rows[e.RowIndex];
                CourseID = Convert.ToInt32(row.Cells["CourseID"].Value);
                AdminCourseName.Text = row.Cells["CourseName"].Value?.ToString() ?? "";
            }
        }
    }

}
