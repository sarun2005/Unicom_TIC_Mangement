using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Model;

namespace Unicom_TIC.Views.AdminView
{
    public partial class Admin_Student_Add : UserControl
    {
        public Admin_Student_Add()
        {
            InitializeComponent();
        }

        private void AdminStudentAddSave_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (AdminStudentAddMale.Checked)
            {
                gender = "Male";
            }
            else if (AdminStudentAddFemale.Checked)
            {
                gender = "Female";
            }


            // Create Student object =======================================
            Student student = new Student
            {
                FirstName = AdminStudentAddFirstName.Text,
                LastName = AdminStudentAddLastName.Text,
                Address = AdminStudentAddAddress.Text,
                PhoneNumber = AdminStudentAddPhoneNumber.Text,
                Email = AdminStudentAddEmail.Text,
                DOB = AdminStudentAddDOB.Value.ToString("yyyy-MM-dd"),
                Gender = gender,
            };
        }

        private void Admin_Student_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
