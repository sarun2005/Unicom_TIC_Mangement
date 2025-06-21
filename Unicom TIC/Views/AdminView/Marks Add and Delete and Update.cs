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
    public partial class Marks_Add_and_Delete_and_Update : UserControl
    {
        private readonly MarksController _controller = new MarksController();
        public Marks_Add_and_Delete_and_Update()
        {
            InitializeComponent();
        }

        private void Marks_Add_and_Delete_and_Update_Load(object sender, EventArgs e)
        {
            LoadMarks();
            LoadCourses();
            LoadExams();
            
        }

        public void LoadMarks()
        {
            var data = _controller.ViewMarks(Role.Admin);             
            AdminMarksView.AutoGenerateColumns = true;
            AdminMarksView.DataSource = data;
                     
        }

        private void LoadCourses()
        {
            AmdminMarksCourse.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController controller = new CourseController();
            List<Course> courses = controller.ViewAllCourses();
            AmdminMarksCourse.DisplayMember = "CourseName";
            AmdminMarksCourse.ValueMember = "CourseID";
            AmdminMarksCourse.DataSource = courses;
            AmdminMarksCourse.SelectedIndex = -1;
        }
        

        private void LoadExams()
        {
            AdminMarksExam.DropDownStyle = ComboBoxStyle.DropDownList;

            ExamController controller = new ExamController();
            List<Exam> exams = controller.ViewAllExams();
            AdminMarksExam.DisplayMember = "ExamName";
            AdminMarksExam.ValueMember = "ExamID";
            AdminMarksExam.DataSource = exams;
            AdminMarksExam.SelectedIndex = -1;
        } 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimetableSave_Click(object sender, EventArgs e)
        {

            // Validation check
            if (!decimal.TryParse(AdminMarksScore.Text, out decimal score))
            {
                MessageBox.Show("Score must be a valid number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mark marks = new Mark
            {
                Score = score,
                StudentID = Convert.ToInt32(AdminMarksStudentID.Text),
                ExamID = Convert.ToInt32(AdminMarksExam.SelectedValue),
                SubjectID = Convert.ToInt32(AmdminMarksCourse.SelectedValue)  
            };

            try
            {
                MarksController controller = new MarksController();
                controller.AddMarks(marks);

                MessageBox.Show("Marks added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding marks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimetableGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimetableCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
