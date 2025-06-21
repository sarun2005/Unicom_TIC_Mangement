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

namespace Unicom_TIC.Views.StudentView
{
    public partial class Student_Timetable : UserControl
    {
        public Student_Timetable()
        {
            InitializeComponent();
        }

        private void TimetableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_Timetable_Load(object sender, EventArgs e)
        {
            LoadTimetableView();
        }

        private void LoadTimetableView()
        {
            TimetableController controller = new TimetableController();
            List<Timetable> timetables = controller.ViewAllTimetables();
            TimetableView.DataSource = null;
            TimetableView.DataSource = timetables;
        }
    }
}
