using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC.Views.StudentView
{
    public partial class Main_Student_Form : Form
    {
        public Main_Student_Form()
        {
            InitializeComponent();
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

        private void StudentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
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

        private void StudentMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
