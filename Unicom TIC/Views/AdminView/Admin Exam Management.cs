// =============================================================
//  Admin_Exam_Management.cs
// =============================================================
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
        private int selectedExamID = -1;

        public Admin_Exam_Management()
        {
            InitializeComponent();

            AdminExamView.RowHeaderMouseClick += AdminExamView_RowHeaderMouseClick;
            AdminExamView.CellClick += AdminExamView_CellClick;

            this.Load += Admin_Exam_Management_Load;    // Form Load attach

            LoadExams();
        }

        public void LoadExams()
        {
            ExamController examController = new ExamController();
            List<Exam> exams = examController.ViewAllExams();

            AdminExamView.DataSource = null;
            AdminExamView.DataSource = exams;
            AdminExamView.ClearSelection();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void AdminExamSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            Exam exam = new Exam
            {
                ExamName = AdminExamName.Text.Trim(),
                SubjectID = Convert.ToInt32(AdminSubjectName.SelectedValue),
                Date = ExamDate.Value,
                StartTime = ExamStartTime.Value.TimeOfDay,
                EndTime = ExamEndTime.Value.TimeOfDay
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
            AdminExamView.ClearSelection();
            ExamDate.Value = DateTime.Now;
            ExamStartTime.Value = DateTime.Now;
            ExamEndTime.Value = DateTime.Now;
            selectedExamID = -1;
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
                    try
                    {
                        ExamController controller = new ExamController();
                        controller.DeleteExam(examID);
                        MessageBox.Show("Exam deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadExams();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete exam. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an exam to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminExamUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamID == -1)
            {
                MessageBox.Show("Please select an exam in the grid first.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            var exam = new Exam
            {
                ExamID = selectedExamID,
                ExamName = AdminExamName.Text.Trim(),
                SubjectID = Convert.ToInt32(AdminSubjectName.SelectedValue),
                Date = ExamDate.Value.Date,
                StartTime = ExamStartTime.Value.TimeOfDay,
                EndTime = ExamEndTime.Value.TimeOfDay
            };

            if (MessageBox.Show("Are you sure you want to update this exam?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                new ExamController().UpdateExam(exam);
                MessageBox.Show("Exam details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadExams();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating exam:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(AdminExamName.Text))
            {
                MessageBox.Show("Please enter the exam name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminExamName.Focus();
                return false;
            }

            if (AdminSubjectName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminSubjectName.Focus();
                return false;
            }

            if (ExamDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("The exam date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ExamDate.Focus();
                return false;
            }

            if (ExamStartTime.Value.TimeOfDay >= ExamEndTime.Value.TimeOfDay)
            {
                MessageBox.Show("The start time must be before the end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ExamStartTime.Focus();
                return false;
            }

            return true;
        }

        private void AdminExamView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var exam = AdminExamView.Rows[e.RowIndex].DataBoundItem as Exam;
            if (exam == null) return;

            selectedExamID = exam.ExamID;
            AdminExamName.Text = exam.ExamName;
            AdminSubjectName.SelectedValue = exam.SubjectID;
            ExamDate.Value = exam.Date;
            ExamStartTime.Value = DateTime.Today + exam.StartTime;
            ExamEndTime.Value = DateTime.Today + exam.EndTime;
        }

        private void AdminExamView_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AdminExamView_RowHeaderMouseClick(s, new DataGridViewCellMouseEventArgs(e.ColumnIndex, e.RowIndex, 0, 0, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)));
        }

        private void AdminExamName_TextChanged(object sender, EventArgs e) { }
        private void AdminSubjectName_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AdminExamView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
