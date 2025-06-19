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
        private int staffId;

        public Main_Staff_Form(int id = 0)
        {
            InitializeComponent();
            staffId = id;
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
            MarksNode.Nodes.Add("Add/View/Delete Marks");
            


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
                Staff_Details viewStaffAction = new Staff_Details(staffId);
                viewStaffAction.Dock = DockStyle.Fill;
                MainStaffMainPanel.Controls.Add(viewStaffAction);
            }


            // ============================ TIMETABLE ============================
            else if (selected == "View Timetable")
            {
                Staff_Timetable TimetableAction = new Staff_Timetable();
                TimetableAction.Dock = DockStyle.Fill;
                MainStaffMainPanel.Controls.Add(TimetableAction);
            }


            // ============================ Marks ============================
            else if (selected == "Add/View/Delete Marks")
            {
                Staff_Marks TimetableAction = new Staff_Marks();
                TimetableAction.Dock = DockStyle.Fill;
                MainStaffMainPanel.Controls.Add(TimetableAction);
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
