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

        }


       
        private void AdminAdminSearchText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Admin_Student_View_and_Delete_Load(object sender, EventArgs e)
        {

        }

        private void AdminStudentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
