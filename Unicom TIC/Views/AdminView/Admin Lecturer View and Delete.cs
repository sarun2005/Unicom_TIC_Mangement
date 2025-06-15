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
    public partial class Admin_Lecturer_View_and_Delete : UserControl
    {
        public Admin_Lecturer_View_and_Delete()
        {
            InitializeComponent();
            LoadLecturers();

        }

        public void LoadLecturers()
        {
            LecturerController lecturerController = new LecturerController();
            List<Lecturer> lecturers = lecturerController.ViewAllLecturers();
            AdminLecturerDetails.DataSource = null;
            AdminLecturerDetails.DataSource = lecturers;
        }


        private void AdminLecturerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Delete an lecturer +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminLecturerDelete_Click(object sender, EventArgs e)
        {
            DeleteLecturer();
        }

        // Method to delete an lecturer based on selected row in DataGridView =========================
        private void DeleteLecturer()
        {
            if (AdminLecturerDetails.SelectedRows.Count > 0)
            {

                int selectedRowIndex = AdminLecturerDetails.SelectedRows[0].Index;
                int lecturerID = Convert.ToInt32(AdminLecturerDetails.Rows[selectedRowIndex].Cells["LecturerID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    LecturerController controller = new LecturerController();
                    controller.DeleteLecturer(lecturerID);

                    MessageBox.Show("Lecturer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLecturers();
                }
            }
            else
            {
                MessageBox.Show("Please select an lecturer to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Admin_Lecturer_View_and_Delete_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }
}
