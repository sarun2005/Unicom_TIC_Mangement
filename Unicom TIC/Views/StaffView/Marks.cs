using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Controller;
using Unicom_TIC.Model;

namespace Unicom_TIC.Views.StaffView
{
    public partial class Staff_Marks : UserControl
    {
        private readonly MarksController _controller = new MarksController();

        public Staff_Marks()
        {
            InitializeComponent();
        }

        private void Staff_Marks_Load(object sender, EventArgs e)
        {
            LoadMarks();
        }

        public void LoadMarks()
        {
            var data = _controller.ViewMarks(Role.Staff);
            MarksView.AutoGenerateColumns = true;
            MarksView.DataSource = data;


            MarksView.Columns["StudentID"].Visible = false;
            MarksView.Columns["SubjectID"].Visible = false;
            MarksView.Columns["ExamID"].Visible = false;


        }

        private void TimetabeDelete_Click(object sender, EventArgs e)
        {
            if (MarksView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = MarksView.SelectedRows[0].Index;
                int markID = Convert.ToInt32(MarksView.Rows[selectedRowIndex].Cells["MarkID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this marks?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MarksController controller = new MarksController();
                    controller.DeleteMarks(markID);

                    MessageBox.Show("Marks deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMarks();  // Refresh the marks list after Delete
                }
            }
            else
            {
                MessageBox.Show("Please select an marks to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TimetableSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(MarksStudentID.Text) ||
                MarksSubject.SelectedValue == null ||
                MarksExam.SelectedValue == null)
            {
                MessageBox.Show("Student ID, course, and exam must all be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =============================== Is score a valid number? ===============================
            if (!int.TryParse(MarksScore.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out int score))
            {
                MessageBox.Show("Score must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = Convert.ToInt32(MarksStudentID.Text);

            // =============================== Does the student exist? ===============================
            if (!_controller.StudentExists(studentId))
            {
                MessageBox.Show($"Student ID {studentId} does not exist in the database.", "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var mark = new Mark
            {
                Score = score,
                StudentID = studentId,
                ExamID = Convert.ToInt32(MarksExam.SelectedValue),
                SubjectID = Convert.ToInt32(MarksSubject.SelectedValue)
            };

            try
            {
                _controller.AddMarks(mark);
                MessageBox.Show("Marks added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding marks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarksView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
