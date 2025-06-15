using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void LecturerTreeView_AfterSelect(object sender, TreeViewEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
