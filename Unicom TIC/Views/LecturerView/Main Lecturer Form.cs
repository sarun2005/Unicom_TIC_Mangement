using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Views.AdminView;

namespace Unicom_TIC.Views.LecturerView
{
    public partial class Main_Lecturer_Form : Form
    {

        public Main_Lecturer_Form()
        {
            InitializeComponent();
        }

       

        private void MainLecturerMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Main_Lecturer_Form_Load(object sender, EventArgs e)
        {
            // Details Management
            TreeNode DetailsNode = LecturerTreeView.Nodes.Add("Your Details");
            DetailsNode.Nodes.Add("View Details");


            // Marks Management
            TreeNode MarksNode = LecturerTreeView.Nodes.Add("Marks Management");
            MarksNode.Nodes.Add("Add Marks");
            MarksNode.Nodes.Add("View/Delete Marks");
            MarksNode.Nodes.Add("Update Marks");


            // Timetable Management
            TreeNode TimetableNode = LecturerTreeView.Nodes.Add("Timetable Management");
            TimetableNode.Nodes.Add("View Timetable");


        }


        private void LecturerTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selected = e.Node.Text;
            MainLecturerMainPanel.Controls.Clear(); // Only once is enough


            
            // View Details
            if (selected == "View Details")
            {
                Lecturer_Details viewLecturerAction = new Lecturer_Details();
                viewLecturerAction.Dock = DockStyle.Fill;
                MainLecturerMainPanel.Controls.Add(viewLecturerAction);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();  
            loginForm.ShowDialog();
        }

        private void MainLecturerMainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
