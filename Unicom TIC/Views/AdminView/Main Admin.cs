using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC.Views.AdminView
{
    public partial class Main_Admin : Form
    {
        public Main_Admin()
        {
            InitializeComponent();
        }



        private void Main_Admin_Load(object sender, EventArgs e)
        {
            //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Left Panel Show Details ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Admin Management
            TreeNode AdminNode = TreeMainAdmin.Nodes.Add("Admin Management");
            AdminNode.Nodes.Add("Add New Admin");
            AdminNode.Nodes.Add("View/Delete Admins");
            AdminNode.Nodes.Add("Update Admins");


            // Lecturer Management
            TreeNode LecturerNode = TreeMainAdmin.Nodes.Add("Lecturer Management");
            LecturerNode.Nodes.Add("Add New Lecturer");
            LecturerNode.Nodes.Add("View/Delete Lecturers");
            LecturerNode.Nodes.Add("Update Lecturers");


            // Staff Management
            TreeNode StaffNode = TreeMainAdmin.Nodes.Add("Staff Management");
            StaffNode.Nodes.Add("Add New Staff");
            StaffNode.Nodes.Add("View/Delete Staffs");
            StaffNode.Nodes.Add("Update Staffs");


            // Student Management
            TreeNode StudentNode = TreeMainAdmin.Nodes.Add("Student Management");
            StudentNode.Nodes.Add("Add New Student");
            StudentNode.Nodes.Add("View/Delete Students");
            StudentNode.Nodes.Add("Update Students");


            // Course Management
            TreeNode CourseNode = TreeMainAdmin.Nodes.Add("Course Management");
            CourseNode.Nodes.Add("Add/View/Delete Course");
            


            // Subject Management
            TreeNode SubjectNode = TreeMainAdmin.Nodes.Add("Subject Management");
            SubjectNode.Nodes.Add("Add/View/Delete Subject");
            


            // Exam Management
            TreeNode ExamNode = TreeMainAdmin.Nodes.Add("Exam Management");
            ExamNode.Nodes.Add("Add Exam");
            ExamNode.Nodes.Add("View/Delete Exams");
            ExamNode.Nodes.Add("Update Exams");


            // Marks Management
            TreeNode MarksNode = TreeMainAdmin.Nodes.Add("Marks Management");
            MarksNode.Nodes.Add("Add Marks");
            MarksNode.Nodes.Add("View/Delete Marks");
            MarksNode.Nodes.Add("Update Marks");


            // Timetable Management
            TreeNode TimetableNode = TreeMainAdmin.Nodes.Add("Timetable Management");
            TimetableNode.Nodes.Add("Add/View/Delete Timetable");
            


            // Room Management
            TreeNode RoomNode = TreeMainAdmin.Nodes.Add("Room Management");
            RoomNode.Nodes.Add("Add/View/Delete Room");


            // Attendance Management
            TreeNode AttendanceNode = TreeMainAdmin.Nodes.Add("Attendance Management");
            AttendanceNode.Nodes.Add("Add/View/Delete Attendance");

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        }








        private void TreeMainAdmin_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Connect Forms ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            string selected = e.Node.Text;
            MainAdminMainPanel.Controls.Clear(); // Only once is enough


            // ============================ ADMIN ============================
            // Admin Add 
            if (selected == "Add New Admin")
            {
                Admin_Admin_Add addAdminAction = new Admin_Admin_Add();
                addAdminAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(addAdminAction);
            }


            // Admin View/Delete 
            else if (selected == "View/Delete Admins")
            {
                Admin_Admin_View_and_Delete ViewandDeleteAdminAction = new Admin_Admin_View_and_Delete();
                ViewandDeleteAdminAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(ViewandDeleteAdminAction);
            }


            // Admin Update 
            else if (selected == "Update Admins")
            {
                Admin_Admin_Update AdminUpdateAction = new Admin_Admin_Update();
                AdminUpdateAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(AdminUpdateAction);
            }








            // ============================ LECTURER ============================
            // Lecturer Add 
            else if (selected == "Add New Lecturer")
            {
                Admin_Lecturer_Add addLecturerAction = new Admin_Lecturer_Add();
                addLecturerAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(addLecturerAction);
            }

            // Lecturer View/Delete 
            else if (selected == "View/Delete Lecturers")
            {
                Admin_Lecturer_View_and_Delete ViewandDeleteLecturerAction = new Admin_Lecturer_View_and_Delete();
                ViewandDeleteLecturerAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(ViewandDeleteLecturerAction);
            }


            // Lecturer Update 
            else if (selected == "Update Lecturers")
            {
                Admin_Lecturer_Update LecturerUpdateAction = new Admin_Lecturer_Update();
                LecturerUpdateAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(LecturerUpdateAction);
            }








            // ============================ STAFF ============================
            // Staff Add 
            else if (selected == "Add New Staff")
            {
                Admin_Staff_Add addStaffAction = new Admin_Staff_Add();
                addStaffAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(addStaffAction);
            }

            // Staff View/Delete 
            else if (selected == "View/Delete Staffs")
            {
                Admin_Staff_View_and_Delete ViewandDeleteStaffAction = new Admin_Staff_View_and_Delete();
                ViewandDeleteStaffAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(ViewandDeleteStaffAction);
            }

            
            // Staff Update 
            else if (selected == "Update Staffs")
            {
                Admin_Staff_Update_New StaffUpdateAction = new Admin_Staff_Update_New();
                StaffUpdateAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(StaffUpdateAction);
            }







            // ============================ STUDENT ============================
            // Student Add 
            else if (selected == "Add New Student")
            {
                Admin_Student_Add addStudentAction = new Admin_Student_Add();
                addStudentAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(addStudentAction);
            }

            // Student View/Delete 
            else if (selected == "View/Delete Students")
            {
                Admin_Student_View_and_Delete ViewandDeleteStudentAction = new Admin_Student_View_and_Delete();
                ViewandDeleteStudentAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(ViewandDeleteStudentAction);
            }


            // Student Update 
            else if (selected == "Update Students")
            {
                Admin_Student_Update StudentUpdateAction = new Admin_Student_Update();
                StudentUpdateAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(StudentUpdateAction);
            }








            // ============================ COURSE ============================
            else if (selected == "Add/View/Delete Course")
            {
                Admin_Course_Add_and_View_and_Delete CourseAction = new Admin_Course_Add_and_View_and_Delete();
                CourseAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(CourseAction);
            }







            // ============================ SUBJECT ============================
            else if (selected == "Add/View/Delete Subject")
            {
                Admin_Subject_Add_and_View_and_Delete SubjectAction = new Admin_Subject_Add_and_View_and_Delete();
                SubjectAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(SubjectAction);
            }



            // ============================ TIMETABLE ============================
            else if (selected == "Add/View/Delete Timetable")
            {
                Timetable TimetableAction = new Timetable();
                TimetableAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(TimetableAction);
            }


            // ============================ ROOM ============================
            else if (selected == "Add/View/Delete Room")
            {
                Admin_Room_Add_and_View_and_Delete RoomAction = new Admin_Room_Add_and_View_and_Delete();
                RoomAction.Dock = DockStyle.Fill;
                MainAdminMainPanel.Controls.Add(RoomAction);
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
