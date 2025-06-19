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

namespace Unicom_TIC.Views.StudentView
{
    public partial class Student_Details : UserControl
    {
        private int studentId;

        public Student_Details(int id)
        {
            InitializeComponent();
            studentId = id;
        }



        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ View Student Details ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void Student_Details_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            var controller = new StudentController();
            var student = controller.GetStudentById(studentId);

            // ======================= only view not change =======================
            StudentMale.Enabled = false;
            StudentFemale.Enabled = false;
            StudentStudentID.Enabled = false;
            StudentFirstName.Enabled = false;
            StudentLastName.Enabled = false;
            StudentAddress.Enabled = false;
            StudentDOB.Enabled = false;
            StudentCourse.Enabled = false;
            StudentEmail.Enabled = false;
            StudentPhoneNumber.Enabled = false;


            // ================= Gender Check =======================
            if (student.Gender == "Male")
            {
                StudentMale.Checked = true;
            }
            else if (student.Gender == "Female")
            {
                StudentFemale.Checked = true;
            }

            if (student != null)
            {

                StudentStudentID.Text = student.StudentID.ToString();
                StudentFirstName.Text = student.FirstName;
                StudentLastName.Text = student.LastName;
                StudentAddress.Text = student.Address;
                StudentDOB.Text = student.DOB;
                StudentCourse.Text = student.CourseName;
                StudentEmail.Text = student.Email;
                StudentPhoneNumber.Text = student.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Student details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }
}
