﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Model
{
    internal class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public string SubjectName { get; set; }

        [Browsable(false)] public int SubjectID { get; set; }
        
    }
}
