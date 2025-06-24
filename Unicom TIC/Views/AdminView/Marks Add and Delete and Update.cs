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

namespace Unicom_TIC.Views.AdminView
{
    public partial class Marks_Add_and_Delete_and_Update : UserControl
    {
        private readonly MarksController controller = new MarksController();
       
        private int selectedMarkID = -1;
        private int score;
        private int studentId;

        public Marks_Add_and_Delete_and_Update()
        {
            InitializeComponent();
            MarksView.RowHeaderMouseClick += MarksView_RowHeaderMouseClick;
            MarksView.CellClick += MarksView_CellClick;
        }

        private void Marks_Add_and_Delete_and_Update_Load(object sender, EventArgs e)
        {
            LoadMarks();
            LoadSubjects();
            LoadExams();
            
        }



        public void LoadMarks()
        {
            var data = controller.ViewMarks(Role.Admin);             
            MarksView.AutoGenerateColumns = true;
            MarksView.DataSource = data;

            MarksView.Columns["StudentID"].Visible = false;
            MarksView.Columns["SubjectID"].Visible = false;
            MarksView.Columns["ExamID"].Visible = false;
           
        }

        private void LoadSubjects()
        {
            MarksSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            SubjectController controller = new SubjectController();
            List<Subject> subjects = controller.ViewAllSubjectsWithCourse();
            MarksSubject.DisplayMember = "SubjectName";
            MarksSubject.ValueMember = "SubjectID";
            MarksSubject.DataSource = subjects;
            MarksSubject.SelectedIndex = -1;
        }
        

        private void LoadExams()
        {
            MarksExam.DropDownStyle = ComboBoxStyle.DropDownList;

            ExamController controller = new ExamController();
            List<Exam> exams = controller.ViewAllExams();
            MarksExam.DisplayMember = "ExamName";
            MarksExam.ValueMember = "ExamID";
            MarksExam.DataSource = exams;
            MarksExam.SelectedIndex = -1;
        } 



       
       // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ADD MARKS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void TimetableSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(MarksStudentID.Text) ||
                MarksSubject.SelectedValue == null ||
                MarksExam.SelectedValue == null)
            {
                MessageBox.Show("Student ID, course, and exam must all be selected.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =============================== Is score a valid number? ===============================
            if (!int.TryParse(MarksScore.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out int score))
            {
                MessageBox.Show("Score must be a valid number.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =============================== Is score within 0-100? ===============================
            if (score < 0 || score > 100)
            {
                MessageBox.Show("Score must be between 0 and 100.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int studentId = Convert.ToInt32(MarksStudentID.Text);

            // =============================== Does the student exist? ===============================
            if (!controller.StudentExists(studentId))
            {
                MessageBox.Show($"Student ID {studentId} does not exist in the database.","Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                controller.AddMarks(mark);
                MessageBox.Show("Marks added successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding marks: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++








       
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ DELETE MARKS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
                    LoadMarks();  
                }
            }
            else
            {
                MessageBox.Show("Please select an marks to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ UPDATE MARKS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        private void TimetableUpdate_Click(object sender, EventArgs e)
        {
               
            if (selectedMarkID == -1)
            {
                MessageBox.Show("Please select a record to update.","No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            var mark = new Mark
            {
                MarkID = selectedMarkID,        
                Score = score,
                StudentID = studentId,
                SubjectID = Convert.ToInt32(MarksSubject.SelectedValue),
                ExamID = Convert.ToInt32(MarksExam.SelectedValue)
            };

            try
            {
                controller.UpdateMarks(mark);
                MessageBox.Show("Marks updated successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();
                ResetForm();                         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating marks: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void ResetForm()
        {
            MarksStudentID.Clear();
            MarksScore.Clear();
            MarksSubject.SelectedIndex = -1;
            MarksExam.SelectedIndex = -1;
            selectedMarkID = -1;
        }



        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ROW SELECT ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void MarksView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var mark = MarksView.Rows[e.RowIndex].DataBoundItem as Mark;
            if (mark == null) return;

           
            selectedMarkID = mark.MarkID;

          
            MarksStudentID.Text = mark.StudentID.ToString();
            MarksScore.Text = mark.Score.ToString();
            MarksSubject.SelectedValue = mark.SubjectID;
            MarksExam.SelectedValue = mark.ExamID;
        }

       
        private void MarksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MarksView_RowHeaderMouseClick(sender,
                    new DataGridViewCellMouseEventArgs(e.ColumnIndex, e.RowIndex, 0, 0,
                        new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)));
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void TimetableGroup_SelectedIndexChanged(object sender, EventArgs e){}
        private void TimetableCourse_SelectedIndexChanged(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}


    }
}
