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

        }

        private void AdminStudentUpdateSave_Click(object sender, EventArgs e)
        {

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
    }
}
