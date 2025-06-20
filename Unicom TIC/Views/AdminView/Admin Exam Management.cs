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
    public partial class Admin_Exam_Management : UserControl
    {
        public Admin_Exam_Management()
        {
            InitializeComponent();
            LoadExams();
        }

        public void LoadExams()
        {
            ExamController examController = new ExamController();
            List<Exam> exams = examController.ViewAllExams();

            AdminExamView.DataSource = null;
            AdminExamView.DataSource = exams;

                    }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminExamSave_Click(object sender, EventArgs e)
        {
            // ============================================ Exam Object Create =====================================================
            Exam exam = new Exam
            {
                ExamName = AdminExamName.Text,
                SubjectID = Convert.ToInt32(AdminSubjectName.SelectedValue)
            };


            try
            {
                ExamController examController = new ExamController();
                examController.AddExam(exam);

                MessageBox.Show("Exam added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadExams();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add exam. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            AdminExamName.Text = string.Empty;
            AdminSubjectName.SelectedIndex = -1;
            //selectedSubjectID = -1;
            AdminExamView.ClearSelection();
        }

        private void Admin_Exam_Management_Load(object sender, EventArgs e)
        {
            LoadSubjectIntoComboBox();
        }
        private void LoadSubjectIntoComboBox()
        {
            AdminSubjectName.DropDownStyle = ComboBoxStyle.DropDownList;

            SubjectController subjectController = new SubjectController();
            List<Subject> courses = subjectController.ViewAllSubjectsWithCourse();
            AdminSubjectName.DisplayMember = "SubjectName";
            AdminSubjectName.ValueMember = "SubjectID";
            AdminSubjectName.DataSource = courses;
            AdminSubjectName.SelectedIndex = -1;
        }

        private void AdminExamDelete_Click(object sender, EventArgs e)
        {
            if (AdminExamView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = AdminExamView.SelectedRows[0].Index;
                int examID = Convert.ToInt32(AdminExamView.Rows[selectedRowIndex].Cells["ExamID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ExamController controller = new ExamController();
                    controller.DeleteExam(examID);

                    MessageBox.Show("Exam deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExams();
                }
            }
            else
            {
                MessageBox.Show("Please select an exam to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminExamUpdate_Click(object sender, EventArgs e)
        {

        }

        private void AdminExamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminExamView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
