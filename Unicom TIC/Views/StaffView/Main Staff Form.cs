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

namespace Unicom_TIC.Views.StaffView
{
    public partial class Main_Staff_Form : Form
    {
        public Main_Staff_Form()
        {
            InitializeComponent();
        }

        private void StaffMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Staff_Form_Load(object sender, EventArgs e)
        {
            // Details Management
            TreeNode DetailsNode = StaffTreeView.Nodes.Add("Your Details");
            DetailsNode.Nodes.Add("View Details");


            // Marks Management
            TreeNode MarksNode = StaffTreeView.Nodes.Add("Marks Management");
            MarksNode.Nodes.Add("Add Marks");
            MarksNode.Nodes.Add("View/Delete Marks");
            MarksNode.Nodes.Add("Update Marks");


            // Timetable Management
            TreeNode TimetableNode = StaffTreeView.Nodes.Add("Timetable Management");
            TimetableNode.Nodes.Add("View Timetable");
        }

        private void StaffTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selected = e.Node.Text;
            MainStaffMainPanel.Controls.Clear(); // Only once is enough



            // View Details
            if (selected == "View Details")
            {
                Staff_Details viewStaffAction = new Staff_Details();
                viewStaffAction.Dock = DockStyle.Fill;
                MainStaffMainPanel.Controls.Add(viewStaffAction);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();  
            loginForm.ShowDialog();
        }
    }
}
