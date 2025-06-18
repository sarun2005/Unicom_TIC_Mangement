using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public int? AdminID { get; set; }
        public int? StaffID { get; set; }
        public int? LecturerID { get; set; }
        public int? StudentID { get; set; }
    }
}
