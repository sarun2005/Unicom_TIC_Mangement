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
    public partial class LecturerExam : UserControl
    {
        public LecturerExam()
        {
            InitializeComponent();
        }

        private void LecturerExam_Load(object sender, EventArgs e)
        {
            LoadExams();
        }

        public void LoadExams()
        {
            ExamController examController = new ExamController();
            List<Exam> exams = examController.ViewAllExams();

            LecturerExamView.DataSource = null;
            LecturerExamView.DataSource = exams;
            LecturerExamView.ClearSelection();
        }

        private void LecturerExamView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
