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

namespace Unicom_TIC.Views.LecturerView
{
    public partial class Lecturer_Timetable : UserControl
    {
       

        public Lecturer_Timetable(int lecturerId)
        {
            InitializeComponent();
            LoadLecturerTimetable();
        }

        private void TimetableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadLecturerTimetable()
        {
            TimetableController controller = new TimetableController();
            List<Timetable> timetables = controller.ViewAllTimetables();
            TimetableView.DataSource = null;
            TimetableView.DataSource = timetables;
                        
        }

        private void Lecturer_Timetable_Load(object sender, EventArgs e)
        {

        }
    }
}
