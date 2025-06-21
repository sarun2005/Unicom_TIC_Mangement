using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Repositories;
using Unicom_TIC.Views;
using Unicom_TIC.Views.AdminView;
using Unicom_TIC.Views.LecturerView;
using Unicom_TIC.Views.StaffView;
using Unicom_TIC.Views.StudentView;

namespace Unicom_TIC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseTables.CreateTable();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new Main_Admin());
            //Application.Run(new Main_Lecturer_Form());
            //Application.Run(new Main_Staff_Form());
            //Application.Run(new Main_Student_Form()); 
        }
    }
}
