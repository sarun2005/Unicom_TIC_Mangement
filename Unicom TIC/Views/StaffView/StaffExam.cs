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

namespace Unicom_TIC.Views.StaffView
{
    public partial class StaffExam : UserControl
    {
        public StaffExam()
        {
            InitializeComponent();
        }

        private void StaffExam_Load(object sender, EventArgs e)
        {
            LoadExams();
        }

        public void LoadExams()
        {
            ExamController examController = new ExamController();
            List<Exam> exams = examController.ViewAllExams();

            StaffExamView.DataSource = null;
            StaffExamView.DataSource = exams;
            StaffExamView.ClearSelection();
        }

        private void StaffExamView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
