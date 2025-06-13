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
        public Admin_Course_Add_and_View_and_Delete()
        {
            InitializeComponent();
            LoadCourses();
        }

        public void LoadCourses()
        {
            CourseController courseController = new CourseController();
            var courses = courseController.ViewAllCourses();
            AdminCourseDetails.DataSource = null;
            AdminCourseDetails.DataSource = courses;
        }

        private void AdminCourseSave_Click(object sender, EventArgs e)
        {
            // Course Object Creation ================================================================
            Course course = new Course
            {
                CourseName = AdminCourseName.Text
            };


            CourseController courseController = new CourseController();
            CourseController.AddCourse(course);


            // Input checks =========================================================
            if (string.IsNullOrWhiteSpace(AdminCourseName.Text))


            {
                MessageBox.Show("Please Added New Course", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ;
            MessageBox.Show("New Course Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }

}
