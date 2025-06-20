using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Unicom_TIC.Controller;
using Unicom_TIC.Model;
using TimetableModel = Unicom_TIC.Model.Timetable;



namespace Unicom_TIC.Views.AdminView
{
    public partial class Timetable : UserControl
    {
        public Timetable()
        {
            InitializeComponent();
        }

        

        private void Timetable_Load(object sender, EventArgs e)
        {
           
            LoadCourses();      
            LoadLecturers();    
            LoadRooms();
            LoadSubjects();
            LoadTimetableView();

            // ============================ Add items in Group Combobox ============================
            TimetableGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            TimetableGroup.Items.AddRange(new[] { "A", "B" });
                      

        }






        // ============================ Add items in Lecturer Combobox ============================
        private void LoadLecturers()
        {
            TimetableLecturer.DropDownStyle = ComboBoxStyle.DropDownList;

            LecturerController controller = new LecturerController();
            List<Lecturer> lecturers = controller.ViewAllLecturers();
            TimetableLecturer.DisplayMember = "LecturerName"; 
            TimetableLecturer.ValueMember = "LecturerID";
            TimetableLecturer.DataSource = lecturers;
            TimetableLecturer.SelectedIndex = -1;
        }


        // ============================ Add items in Room Combobox ============================
        private void LoadRooms()
        {
            TimetableRoom.DropDownStyle = ComboBoxStyle.DropDownList;

            RoomController controller = new RoomController();
            List<Room> rooms = controller.ViewAllRooms();
            TimetableRoom.DisplayMember = "RoomName";  
            TimetableRoom.ValueMember = "RoomID";
            TimetableRoom.DataSource = rooms;
            TimetableRoom.SelectedIndex = -1;
        }


        // ============================ Add items in Course Combobox ============================
        private void LoadCourses()
        {
            TimetableCourse.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController controller = new CourseController();
            List<Course> courses = controller.ViewAllCourses();
            TimetableCourse.DisplayMember = "CourseName";
            TimetableCourse.ValueMember = "CourseID";
            TimetableCourse.DataSource = courses;
            TimetableCourse.SelectedIndex = -1;
        }


        // ============================ Add items in Subject Combobox ============================
        private void LoadSubjects()
        {
            TimetableSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            SubjectController controller = new SubjectController();
            List<Subject> subjects = controller.ViewAllSubjectsWithCourse();
            TimetableSubject.DisplayMember = "SubjectName";
            TimetableSubject.ValueMember = "SubjectID";
            TimetableSubject.DataSource = subjects;
            TimetableSubject.SelectedIndex = -1;
        }

        private void LoadTimetableView()
        {
            TimetableController controller = new TimetableController();
            List<TimetableModel> timetables = controller.ViewAllTimetables();  
            TimetableView.DataSource = null;
            TimetableView.DataSource = timetables;
        }




        private void TimetableSave_Click(object sender, EventArgs e)
        {

            var timetable = new TimetableModel
            {
                GroupName = TimetableGroup.Text,
                Date = TimetableDate.Value.Date,
                StartTime = TimetableStartTime.Value.ToString("HH:mm"),
                EndTime = TimetableEndTime.Value.ToString("HH:mm"),
                CourseID = Convert.ToInt32(TimetableCourse.SelectedValue),
                SubjectID = Convert.ToInt32(TimetableSubject.SelectedValue),
                RoomID = Convert.ToInt32(TimetableRoom.SelectedValue),
                LecturerID = Convert.ToInt32(TimetableLecturer.SelectedValue)
                                              
            };


            

            try
            {
                TimetableController controller = new TimetableController();
                controller.AddTimetable(timetable);
                LoadTimetableView();
                MessageBox.Show("Timetable entry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB Error: {ex.Message}");
            }
            
           
        }


        private void ResetForm()
        {
            TimetableCourse.SelectedIndex = -1;
            TimetableSubject.SelectedIndex = -1;
            TimetableLecturer.SelectedIndex = -1;
            TimetableRoom.SelectedIndex = -1;
            TimetableGroup.SelectedIndex = -1;
            TimetableDate.Value = DateTime.Now;
        }

        

        private void TimetabeDelete_Click(object sender, EventArgs e)
        {
            if (TimetableView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = TimetableView.SelectedRows[0].Index;
                int timetableID = Convert.ToInt32(TimetableView.Rows[selectedRowIndex].Cells["TimetableID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this timelable row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    TimetableController controller = new TimetableController();
                    controller.DeleteTimetable(timetableID);

                    MessageBox.Show("Timelable row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTimetableView();
                }
            }
            else
            {
                MessageBox.Show("Please select an timelable row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }










        private void label4_Click(object sender, EventArgs e){}
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e){}
        private void button1_Click(object sender, EventArgs e){}
        private void timer1_Tick(object sender, EventArgs e){}
        private void TimetableCourse_SelectedIndexChanged(object sender, EventArgs e){}
        private void TimetableGroup_SelectedIndexChanged(object sender, EventArgs e){}
        private void TimetableSubject_SelectedIndexChanged(object sender, EventArgs e){}
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e){}
        private void TimetableRoom_SelectedIndexChanged(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
    }
}
