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
        private int selectedSubjectId = -1;

        public Admin_Subject_Add_and_View_and_Delete()
        {
            InitializeComponent();
            AdminSubjectDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AdminSubjectDetails.MultiSelect = false;
            AdminSubjectDetails.CellContentClick += AdminSubjectDetails_CellClick;
            AdminSubjectDetails.CellClick += AdminSubjectDetails_CellClick;
            LoadSubjects();
        }


        public void LoadSubjects()
        {
            SubjectController subjectController = new SubjectController();
            List<Subject> subjects = subjectController.ViewAllSubjectsWithCourse();

            AdminSubjectDetails.DataSource = null;
            AdminSubjectDetails.DataSource = subjects;

            
            if (AdminSubjectDetails.Columns["CourseID"] != null)
                AdminSubjectDetails.Columns["CourseID"].Visible = false;

          
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Course Add by Subject Combobox +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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

            LoadSubjects();
        }

        

        private void AdminSubjectCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AdminSubjectDelete_Click(object sender, EventArgs e)
        {
            if (AdminSubjectDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = AdminSubjectDetails.SelectedRows[0].Index;
                int subjectID = Convert.ToInt32(AdminSubjectDetails.Rows[selectedRowIndex].Cells["SubjectID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SubjectController controller = new SubjectController();
                    controller.DeleteSubject(subjectID);

                    MessageBox.Show("Subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjects();
                }
            }
            else
            {
                MessageBox.Show("Please select an subject to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            AdminSubjectSubjectName.Text = string.Empty;
            AdminSubjectCourseName.SelectedIndex = -1;
            selectedSubjectId = -1;
            AdminSubjectDetails.ClearSelection();
        }


        private void AdminSubjectDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

           
            var subject = (Subject)AdminSubjectDetails.Rows[e.RowIndex].DataBoundItem;
            selectedSubjectId = subject.SubjectID;
            AdminSubjectSubjectName.Text = subject.SubjectName;
            //AdminSubjectCourseName.SelectedValue = subject.CourseID;
        }


        private void AdminSubjectUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject from the list to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(AdminSubjectSubjectName.Text) || AdminSubjectCourseName.SelectedValue == null)
            {
                MessageBox.Show("Subject Name and Course are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var subject = new Subject
            {
                SubjectID = selectedSubjectId,
                SubjectName = AdminSubjectSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(AdminSubjectCourseName.SelectedValue)
            };
            try
            {
                new SubjectController().UpdateSubject(subject);
                MessageBox.Show("Subject updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedSubjectId = -1;
                ClearForm();
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
