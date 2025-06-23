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
        public int Score { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        
        public string SubjectName { get; set; }
       

        public int ExamID { get; set; }
        public string ExamName { get; set; }
       
        public int SubjectID { get; set; }

    }
}
