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
    public partial class Admin_Lecturer_View_and_Delete_Update : UserControl
    {
        private int selectedLecturerID = -1;

        public Admin_Lecturer_View_and_Delete_Update()
        {
            InitializeComponent();
            AdminLecturerDetails.RowHeaderMouseClick += AdminLecturerDetails_RowHeaderMouseClick;
            AdminLecturerDetails.CellClick += AdminLecturerDetails_CellClick;

            
            LoadLecturers();

        }

        public void LoadLecturers()
        {
            LecturerController lecturerController = new LecturerController();
            List<Lecturer> lecturers = lecturerController.ViewAllLecturers();
            AdminLecturerDetails.DataSource = null;
            AdminLecturerDetails.DataSource = lecturers;
        }

        




        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Delete an lecturer +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminLecturerDelete_Click(object sender, EventArgs e)
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
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





       

        private void AdminAdminSearchText_TextChanged(object sender, EventArgs e)
        {
            string keyword = AdminLecturerSearchText.Text.Trim();

            LecturerController controller = new LecturerController();
            List<Lecturer> result;

            if (string.IsNullOrEmpty(keyword))
            {
                result = controller.ViewAllLecturers(); 
            }
            else
            {
                result = controller.SearchLecturers(keyword);
            }

            AdminLecturerDetails.DataSource = null;
            AdminLecturerDetails.DataSource = result;
        }




        private void Admin_Lecturer_View_and_Delete_Load(object sender, EventArgs e)
        {
            // ============================ Add items to the role dropdown ============================
            AdminLecturerUpdateSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            AdminLecturerUpdateSubject.Items.Add("Python");
            AdminLecturerUpdateSubject.Items.Add("C#");
            AdminLecturerUpdateSubject.Items.Add("Java");
            AdminLecturerUpdateSubject.Items.Add("HTML");
            AdminLecturerUpdateSubject.Items.Add("PHP");
        }

        


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ CLEAR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminLecturerUpdateClear_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();
        }

        private void ClearUpdateFields()
        {
            AdminLecturerSearchText.Clear();
            AdminLecturerUpdateLecturerID.Clear();
            AdminLecturerUpdateFirstName.Clear();
            AdminLecturerUpdateLastName.Clear();
            AdminLecturerUpdateSubject.SelectedIndex = -1;
            AdminLecturerUpdateEmail.Clear();
            AdminLecturerUpdatePhoneNumber.Clear();
            AdminLecturerUpdateAddress.Clear();
            AdminLecturerUpdateMale.Checked = false;
            AdminLecturerUpdateFemale.Checked = false;
            AdminLecturerUpdateDOB.Value = DateTime.Now;
        }
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++





        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ UPDATE ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AdminLecturerUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLecturerID == -1)
            {
                MessageBox.Show("Please select a lecturer row first.",
                                "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // gender
            string gender = AdminLecturerUpdateMale.Checked ? "Male" :
                            AdminLecturerUpdateFemale.Checked ? "Female" : "";

            // basic validation
            if (string.IsNullOrWhiteSpace(AdminLecturerUpdateFirstName.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateAddress.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateSubject.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdateEmail.Text) ||
                string.IsNullOrWhiteSpace(AdminLecturerUpdatePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill-in all required details.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // phone
            string phone = AdminLecturerUpdatePhoneNumber.Text.Trim();
            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Enter a 10-digit phone number.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // email
            string email = AdminLecturerUpdateEmail.Text.Trim();
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter a valid email address.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this lecturer?",
                                "Confirm Update", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes) return;

            // build object
            var lec = new Lecturer
            {
                LecturerID = selectedLecturerID,
                FirstName = AdminLecturerUpdateFirstName.Text.Trim(),
                LastName = AdminLecturerUpdateLastName.Text.Trim(),
                Subject = AdminLecturerUpdateSubject.Text.Trim(),
                Address = AdminLecturerUpdateAddress.Text.Trim(),
                DOB = AdminLecturerUpdateDOB.Value.ToString("yyyy-MM-dd"),
                gender = gender,
                Email = email,
                PhoneNumber = phone
            };

            try
            {
                new LecturerController().UpdateLecturer(lec);
                MessageBox.Show("Lecturer details updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLecturers();     // grid refresh
                ClearUpdateFields(); // reset form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void AdminLecturerDetails_RowHeaderMouseClick(object sender,
                                      DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var lec = AdminLecturerDetails.Rows[e.RowIndex].DataBoundItem as Lecturer;
            if (lec == null) return;

            selectedLecturerID = lec.LecturerID;

            AdminLecturerUpdateLecturerID.Text = lec.LecturerID.ToString();
            AdminLecturerUpdateFirstName.Text = lec.FirstName;
            AdminLecturerUpdateLastName.Text = lec.LastName;
            AdminLecturerUpdateSubject.Text = lec.Subject;
            AdminLecturerUpdateEmail.Text = lec.Email;
            AdminLecturerUpdatePhoneNumber.Text = lec.PhoneNumber;
            AdminLecturerUpdateAddress.Text = lec.Address;

            // gender
            AdminLecturerUpdateMale.Checked = lec.gender == "Male";
            AdminLecturerUpdateFemale.Checked = lec.gender == "Female";

            // DOB
            if (DateTime.TryParse(lec.DOB, out DateTime dob))
                AdminLecturerUpdateDOB.Value = dob;
        }

        private void AdminLecturerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AdminLecturerDetails_RowHeaderMouseClick(
                    sender,
                    new DataGridViewCellMouseEventArgs(e.ColumnIndex, e.RowIndex, 0, 0,
                        new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)));
            }
        }


        private void label1_Click(object sender, EventArgs e){}
        private void AdminLecturerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void s_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
