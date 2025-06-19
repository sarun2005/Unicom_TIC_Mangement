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
        // ===================================== ADD =====================================
        public void AddAdmin(Admin admin)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addadminQuery = "INSERT INTO Admins ( FirstName , LastName , Role , Email , PhoneNumber ) " +
                                       "VALUES ( @FirstName , @LastName , @Role , @Email , @PhoneNumber )";


                SQLiteCommand insertAdminCommand = new SQLiteCommand(addadminQuery, connection);
                insertAdminCommand.Parameters.AddWithValue("@FirstName", admin.FirstName);
                insertAdminCommand.Parameters.AddWithValue("@LastName", admin.LastName);
                insertAdminCommand.Parameters.AddWithValue("@Role", admin.Role);
                insertAdminCommand.Parameters.AddWithValue("@Email", admin.Email);
                insertAdminCommand.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                insertAdminCommand.ExecuteNonQuery();
            }
        }





        // ===================================== VIEW =====================================
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




        // ===================================== DELETE =====================================
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



       

        // ===================================== UPDATE =====================================
        internal void UpdateAdmin(Admin admin)
        {
            if (admin is null)
            {
                throw new ArgumentNullException(nameof(admin));
            }

            using (var connection = DataBaseConnection.GetConnection())
            {
                string updateQuery = "UPDATE Admins SET FirstName = @FirstName, LastName = @LastName, Role = @Role, Email = @Email," +
                                     " PhoneNumber = @PhoneNumber WHERE AdminID = @AdminID";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", admin.FirstName);
                    command.Parameters.AddWithValue("@LastName", admin.LastName);
                    command.Parameters.AddWithValue("@Role", admin.Role);
                    command.Parameters.AddWithValue("@Email", admin.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                    command.Parameters.AddWithValue("@AdminID", admin.AdminID);
                    command.ExecuteNonQuery(); 
                }
            }
        }




        // ===================================== UPDATE AND VIEW SEARCH =====================================
        public List<Admin> SearchAdmins(string keyword)
        {
            List<Admin> admins = new List<Admin>();
            bool isNumeric = int.TryParse(keyword, out int idVal);

            string sql = @"
                SELECT * FROM Admins
                WHERE FirstName LIKE @AdminAdminSearchText COLLATE NOCASE
                   OR LastName LIKE @AdminAdminSearchText COLLATE NOCASE
                   OR Email LIKE @AdminAdminSearchText COLLATE NOCASE";


            if (isNumeric)
            {
                sql += " OR AdminID = @AdminAdminSearchID";
            }

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@AdminAdminSearchText", $"%{keyword}%");

                if (isNumeric)
                {
                    cmd.Parameters.AddWithValue("@AdminAdminSearchID", idVal);
                }

                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        admins.Add(new Admin
                        {
                            AdminID = Convert.ToInt32(read["AdminID"]),
                            FirstName = read["FirstName"].ToString(),
                            LastName = read["LastName"].ToString(),
                            Role = read["Role"].ToString(),
                            Email = read["Email"].ToString(),
                            PhoneNumber = read["PhoneNumber"].ToString()
                        });
                    }
                }
            }

            return admins;
        }


        


        /*
       // ===================================== UPDATE SEARCH =====================================
       public Admin ViewAdminByID(int adminID)
       {
           Admin admin = null;

           string searchQuery = "SELECT * FROM Admins WHERE AdminID = @AdminAdminSearchID";

           using (var connection = DataBaseConnection.GetConnection())
           using (var cmd = new SQLiteCommand(searchQuery, connection))
           {
               cmd.Parameters.AddWithValue("@AdminAdminSearchID", adminID);

               using (var read = cmd.ExecuteReader())
               {
                   if (read.Read())
                   {
                       admin = new Admin
                       {
                           AdminID = Convert.ToInt32(read["AdminID"]),
                           FirstName = read["FirstName"].ToString(),
                           LastName = read["LastName"].ToString(),
                           Role = read["Role"].ToString(),
                           Email = read["Email"].ToString(),
                           PhoneNumber = read["PhoneNumber"].ToString()
                       };
                   }
               }
           }
           return admin;
       }
       */



        /*

        // =====================================  VIEW AND DELETE SEARCH =====================================
        public List<Admin> SearchAdmins(string keyword)
        {
            List<Admin> admins = new List<Admin>();

            string sql =
                @"SELECT * FROM Admins
                    WHERE AdminID   = @AdminAdminSearchID
                          OR FirstName LIKE @AdminAdminSearchText
                          OR LastName  LIKE @AdminAdminSearchText
                          OR Email     LIKE @AdminAdminSearchText"
                ;

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                // ---- AdminID parameter ----
                if (int.TryParse(keyword, out int idVal))
                    cmd.Parameters.AddWithValue("@AdminAdminSearchID", idVal);   
                else
                    cmd.Parameters.AddWithValue("@AdminAdminSearchID", DBNull.Value); // no match



                // ---- Text wildcard parameter ----
                cmd.Parameters.AddWithValue("@AdminAdminSearchText", $"%{keyword}%");

                using (var read = cmd.ExecuteReader())
                    while (read.Read())
                        admins.Add(new Admin
                        {
                            AdminID = Convert.ToInt32(read["AdminID"]),
                            FirstName = read["FirstName"].ToString(),
                            LastName = read["LastName"].ToString(),
                            Role = read["Role"].ToString(),
                            Email = read["Email"].ToString(),
                            PhoneNumber = read["PhoneNumber"].ToString()
                        });
            }

            return admins;
        }

        */


    }
}
