using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class AdminController 
    {
        // ========================================================= Add new Admin Method =========================================================
        public void AddAdmin(Admin admin)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addadminQuery = "INSERT INTO Admins ( FirstName , LastName , Role , Email , PhoneNumber ) " +
                                       "VALUES ( @AdminAdminAddFirstName , @AdminAdminAddLastName , @AdminAdminAddRole , @AdminAdminAddEmail , @AdminAdminAddPhoneNumber )";


                SQLiteCommand insertAdminCommand = new SQLiteCommand(addadminQuery, connection);
                insertAdminCommand.Parameters.AddWithValue("@AdminAdminAddFirstName", admin.FirstName);
                insertAdminCommand.Parameters.AddWithValue("@AdminAdminAddLastName", admin.LastName);
                insertAdminCommand.Parameters.AddWithValue("@AdminAdminAddRole", admin.Role);
                insertAdminCommand.Parameters.AddWithValue("@AdminAdminAddEmail", admin.Email);
                insertAdminCommand.Parameters.AddWithValue("@AdminAdminAddPhoneNumber", admin.PhoneNumber);
                insertAdminCommand.ExecuteNonQuery();
            }
        }





        // ========================================================= View All Admins Method =========================================================
        public List<Admin> ViewAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                string viewAllAdminsQuery = "SELECT * FROM Admins";
                SQLiteCommand viewAllAdmins = new SQLiteCommand(viewAllAdminsQuery, connection);
                var reader = viewAllAdmins.ExecuteReader();
                while (reader.Read())
                {
                    Admin admin = new Admin
                    {
                        AdminID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Role = reader.GetString(3),
                        Email = reader.GetString(4),
                        PhoneNumber = reader.GetString(5)
                    };
                    admins.Add(admin);
                }
            }
            return admins;
        }




        // ========================================================= Delete Admin Method =========================================================
        public void DeleteAdmin(int adminID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteAdminQuery = "DELETE FROM Admins WHERE AdminID = @AdminID";
                SQLiteCommand deleteAdminCommand = new SQLiteCommand(deleteAdminQuery, connection);
                deleteAdminCommand.Parameters.AddWithValue("@AdminID", adminID);
                deleteAdminCommand.ExecuteNonQuery();
            }
        }
    }
}
