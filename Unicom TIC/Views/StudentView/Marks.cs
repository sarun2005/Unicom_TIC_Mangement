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
    public partial class StudentMarks : UserControl
    {
        private readonly int _studentId;
        private readonly MarksController _controller = new MarksController();

        public StudentMarks(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
        }

        private void StudentMarksView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Marks_Load(object sender, EventArgs e)
        {
            var data = _controller.ViewMarks(Role.Student, _studentId);   // ✅
            StudentMarksView.AutoGenerateColumns = true;
            StudentMarksView.DataSource = data;
        }
    }
}
