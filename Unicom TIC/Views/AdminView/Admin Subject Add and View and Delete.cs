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
    public partial class Admin_Subject_Add_and_View_and_Delete : UserControl
    {
        public Admin_Subject_Add_and_View_and_Delete()
        {
            InitializeComponent();
            this.Load += Admin_Subject_Add_and_View_and_Delete_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Subject_Add_and_View_and_Delete_Load(object sender, EventArgs e)
        {
            LoadCoursesIntoComboBox();

        }

        private void LoadCoursesIntoComboBox()
        {
            AdminSubjectCourseName.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController courseController = new CourseController();
            List<Course> courses = courseController.ViewAllCourses();
            AdminSubjectCourseName.DisplayMember = "CourseName"; 
            AdminSubjectCourseName.ValueMember = "CourseID";     
            AdminSubjectCourseName.DataSource = courses;
            AdminSubjectCourseName.SelectedIndex = -1;
        }


        private void AdminSubjectSave_Click(object sender, EventArgs e)
        {

            // Create subject object with selected CourseID ==============================================================
            Subject newSubject = new Subject
            {
                SubjectName = AdminSubjectSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(AdminSubjectCourseName.SelectedValue)
            };



            // Validate subject name input ==============================================================
            if (string.IsNullOrWhiteSpace(AdminSubjectSubjectName.Text))
            {
                MessageBox.Show("Please enter a subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate course selection ==============================================================
            if (AdminSubjectCourseName.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SubjectController subjectController = new SubjectController();
                subjectController.AddSubject(newSubject); 

                MessageBox.Show("Subject added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add subject. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ClearForm()
        {
            AdminSubjectSubjectName.Text = string.Empty;
            AdminSubjectCourseName.SelectedIndex = -1;
        }

        private void AdminSubjectCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
