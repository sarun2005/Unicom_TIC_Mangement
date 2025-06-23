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
    public partial class Admin_Student_View_and_Delete : UserControl
    {
        public Admin_Student_View_and_Delete()
        {
            InitializeComponent();
            LoadStudents();



        }

        public void LoadStudents()
        {
            StudentController studentController = new StudentController();
            List<Student> students = studentController.ViewAllStudentWithCourse();
            AdminStudentDetails.DataSource = null;
            AdminStudentDetails.DataSource = students;
        }




        private void AdminStudentDelete_Click(object sender, EventArgs e)
        {
            if (AdminStudentDetails.SelectedRows.Count > 0)
            {

                int selectedRowIndex = AdminStudentDetails.SelectedRows[0].Index;
                int studentID = Convert.ToInt32(AdminStudentDetails.Rows[selectedRowIndex].Cells["StudentID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    StudentController controller = new StudentController();
                    controller.DeleteStudent(studentID);

                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select an student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


       
        private void AdminAdminSearchText_TextChanged(object sender, EventArgs e)
        {
            string keyword = AdminStudentSearchText.Text.Trim();

            StudentController controller = new StudentController();
            List<Student> result;

            if (string.IsNullOrEmpty(keyword))
            {
                result = controller.ViewAllStudentWithCourse(); // empty search → show all
            }
            else
            {
                result = controller.SearchStudents(keyword);
            }

            AdminStudentDetails.DataSource = null;
            AdminStudentDetails.DataSource = result;
        }

        private void Admin_Student_View_and_Delete_Load(object sender, EventArgs e)
        {

        }

        private void AdminStudentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
