using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Model
{
    internal class Timetable
    {
        public int TimetableID { get; set; }
         public string GroupName { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string CourseName { get; set; }
        public string SubjectName { get; set; }
        public string RoomName { get; set; }
        public string LecturerName { get; set; }
        public int CourseID { get; set; }
        public int SubjectID { get; set; }
        public int RoomID { get; set; }
        public int LecturerID { get; set; }
        
    }
}
