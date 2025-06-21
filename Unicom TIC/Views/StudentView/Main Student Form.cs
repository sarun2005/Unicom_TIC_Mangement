using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Views.LecturerView;
using Unicom_TIC.Views.StaffView;

namespace Unicom_TIC.Views.StudentView
{
    public partial class Main_Student_Form : Form
    {
        private int studentId;

        public Main_Student_Form(int id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void MainLecturerMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainLecturerLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainLecturerTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Main_Student_Form_Load(object sender, EventArgs e)
        {
            // Details Management
            TreeNode DetailsNode = StudentTreeView.Nodes.Add("Your Details");
            DetailsNode.Nodes.Add("View Details");


            // Marks Management
            TreeNode MarksNode = StudentTreeView.Nodes.Add("Marks Management");
            MarksNode.Nodes.Add("View Marks");


            // Timetable Management
            TreeNode TimetableNode = StudentTreeView.Nodes.Add("Timetable Management");
            TimetableNode.Nodes.Add("View Timetable");
        }



        private void StudentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selected = e.Node.Text;
            MainStudentMainPanel.Controls.Clear(); // Only once is enough



            // View Details
            if (selected == "View Details")
            {
                Student_Details viewStudentAction = new Student_Details(studentId);
                viewStudentAction.Dock = DockStyle.Fill;
                MainStudentMainPanel.Controls.Add(viewStudentAction);
            }

            // ============================ TIMETABLE ============================
            else if (selected == "View Timetable")
            {
                Student_Timetable TimetableAction = new Student_Timetable();
                TimetableAction.Dock = DockStyle.Fill;
                MainStudentMainPanel.Controls.Add(TimetableAction);
            }


            // ============================ Marks ============================
            else if (selected == "View Marks")
            {
                
                StudentMarks TimetableAction = new StudentMarks(studentId);
                TimetableAction.Dock = DockStyle.Fill;
                MainStudentMainPanel.Controls.Add(TimetableAction);
            }
        }

        private void StudentMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
