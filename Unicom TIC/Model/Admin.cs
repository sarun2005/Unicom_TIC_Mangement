using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Model
{
    internal class Admin
    {
        public int AdminID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        /*
        public static implicit operator Admin(Lecturer v)
        {
            throw new NotImplementedException();
        }*/
    }
}
