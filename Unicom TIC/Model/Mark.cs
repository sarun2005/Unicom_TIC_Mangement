using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Model
{
    internal class Mark
    {
        public int MarkID { get; set; }
        public decimal Score { get; set; }
        [Browsable(false)] public int StudentID { get; set; }
        public string StudentName { get; set; }
        
        public string SubjectName { get; set; }
        [Browsable(false)]  public int ExamID { get; set; }
        public string ExamName { get; set; }
        [Browsable(false)]  public int CourseID { get; internal set; }
        [Browsable(false)] public int SubjectID { get; set; }

    }
}
