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
    internal class UserController
    {


        // ===================================== USERNAME CHECK BY DATABASE =====================================
        public static bool UsernameExists(string username)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = "SELECT 1 FROM Users WHERE LOWER(Username) = LOWER(@u) LIMIT 1;";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@u", username.Trim());
                return cmd.ExecuteScalar() != null;
            }
        }




        // =====================================  Role‑specific ID existence checks =====================================
        public bool CheckAdminIDExists(int id)
        {
            return CheckIdExists("Admins", "AdminID", id);
        }

        public bool CheckStaffIDExists(int id)
        {
            return CheckIdExists("Staffs", "StaffID", id);
        }

        public bool CheckLecturerIDExists(int id)
        {
            return CheckIdExists("Lecturers", "LecturerID", id);
        }

        public bool CheckStudentIDExists(int id)
        {
            return CheckIdExists("Students", "StudentID", id);
        }

        // Generic checker
        private static bool CheckIdExists(string table, string column, int id)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string sql = $"SELECT 1 FROM {table} WHERE {column} = @id LIMIT 1;";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteScalar() != null;   // true ⇒ id exists
            }
        }


        // ===================================== ADD =====================================
        public void AddUser(User user)
        {
            if (UsernameExists(user.Username))
                throw new Exception("Username already exists.");


            using (var connection = DataBaseConnection.GetConnection())
            {
               string addUserQuery = "INSERT INTO Users ( Username , Password , Role , AdminID , StaffID , LecturerID , StudentID) " +
                                     "VALUES ( @Username , @Password , @Role , @AdminID , @StaffID , @LecturerID , @StudentID)";

                SQLiteCommand insertUserCommand = new SQLiteCommand(addUserQuery, connection);
                insertUserCommand.Parameters.AddWithValue("@Username", user.Username.Trim());
                insertUserCommand.Parameters.AddWithValue("@Password", user.Password); 
                insertUserCommand.Parameters.AddWithValue("@Role", user.Role);
                insertUserCommand.Parameters.AddWithValue("@AdminID", ToDb(user.AdminID));
                insertUserCommand.Parameters.AddWithValue("@StaffID", ToDb(user.StaffID));
                insertUserCommand.Parameters.AddWithValue("@LecturerID", ToDb(user.LecturerID));
                insertUserCommand.Parameters.AddWithValue("@StudentID", ToDb(user.StudentID));
                insertUserCommand.ExecuteNonQuery(); 
            }
        }



        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ LOGIN ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static bool AuthenticateUser(string username,string password,string role,int roleId)
        {
            
            string idColumn;
            switch (role)
            {
                case "Admin":
                    idColumn = "AdminID";
                    break;
                case "Lecturer":
                    idColumn = "LecturerID";
                    break;
                case "Staff":
                    idColumn = "StaffID";
                    break;
                case "Student":
                    idColumn = "StudentID";
                    break;
                default:
                    throw new ArgumentException("Invalid role", nameof(role));
            }

            using (var connection = DataBaseConnection.GetConnection())
            {
                string sql = $@"
                SELECT 1 FROM Users WHERE  LOWER(Username) = LOWER(@u) AND  Password = @p AND  Role = @r AND {idColumn}  = @id LIMIT 1;";

                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@u", username.Trim());
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.Parameters.AddWithValue("@id", roleId);

                return cmd.ExecuteScalar() != null;
            }
        }

        

        private object ToDb(int? value)
        {
            return value.HasValue ? (object)value.Value : DBNull.Value;
        }
    }
}


    
    

