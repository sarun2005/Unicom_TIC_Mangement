using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Model
{
    internal class Timetable
    {
        public int TimetableID { get; set; }

        public int SubjectID { get; set; }

        public string TimeSlot { get; set; }

        public int RoomID { get; set; }

        public int LecturerID { get; set; }
        public string GroupName { get; internal set; }
        public string SubjectName { get; internal set; }
        public string LecturerName { get; internal set; }
        public string RoomName { get; internal set; }
    }
}
