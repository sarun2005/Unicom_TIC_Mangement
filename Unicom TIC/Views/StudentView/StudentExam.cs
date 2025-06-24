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
    public partial class StudentExam : UserControl
    {
        public StudentExam()
        {
            InitializeComponent();
        }

        private void StudentExam_Load(object sender, EventArgs e)
        {
            LoadExams();
        }

        public void LoadExams()
        {
            ExamController examController = new ExamController();
            List<Exam> exams = examController.ViewAllExams();

            StudentExamView.DataSource = null;
            StudentExamView.DataSource = exams;
            StudentExamView.ClearSelection();
        }
    }
}
