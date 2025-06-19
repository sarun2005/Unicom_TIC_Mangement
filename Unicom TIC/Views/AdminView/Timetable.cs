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
            var controller = new TimetableController();
            TimetableView.DataSource = null;
            List<TimetableModel> timetables = controller.ViewAllTimetables(); 
            TimetableView.DataSource = timetables;
        }



        private void TimetableSave_Click(object sender, EventArgs e)
        {

            var tt = new TimetableModel
            {
                SubjectID = Convert.ToInt32(TimetableSubject.SelectedValue),
                LecturerID = Convert.ToInt32(TimetableLecturer.SelectedValue),
                RoomID = Convert.ToInt32(TimetableRoom.SelectedValue),
                TimeSlot = TimetableSlotCombo.Value.ToString("yyyy-MM-dd"),
                GroupName = TimetableGroup.Text
            };


            try
            {
                new TimetableController().AddTimetable(tt);
                MessageBox.Show("Timetable entry saved!");
                LoadTimetableView();                     
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB Error: {ex.Message}");
            }
        }


        private void TimetableCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TimetableGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimetableSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimetableRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimetabeDelete_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
