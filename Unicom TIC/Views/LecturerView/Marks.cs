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
    public partial class Lecturer_Marks : UserControl
    {
        private readonly MarksController _controller = new MarksController();
        public Lecturer_Marks()
        {
            InitializeComponent();
        }

        private void Lecturer_Marks_Load(object sender, EventArgs e)
        {
            LoadMarks();
        }

        public void LoadMarks()
        {
            var data = _controller.ViewMarks(Role.Lecturer);            
            LecturerMarksView.AutoGenerateColumns = true;
            LecturerMarksView.DataSource = data;

        }
    }
}
