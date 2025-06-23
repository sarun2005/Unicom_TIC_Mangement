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
    internal class StaffController
    {
        // ===================================== ADD =====================================
        public void AddStaff(Staff staff)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addStaffQuery = "INSERT INTO Staffs ( FirstName , LastName , Address , DOB , Gender , Role , Email , PhoneNumber ) " +
                                          "VALUES ( @FirstName , @LastName , @Address ,@DOB ," +
                                          "@gender ,  @Role , @Email , @PhoneNumber )";


                SQLiteCommand insertStaffCommand = new SQLiteCommand(addStaffQuery, connection);
                insertStaffCommand.Parameters.AddWithValue("@FirstName", staff.FirstName);
                insertStaffCommand.Parameters.AddWithValue("@LastName", staff.LastName);
                insertStaffCommand.Parameters.AddWithValue("@Address", staff.Address);
                insertStaffCommand.Parameters.AddWithValue("@DOB", staff.DOB);
                insertStaffCommand.Parameters.AddWithValue("@gender", staff.Gender);
                insertStaffCommand.Parameters.AddWithValue("@Role", staff.Role);
                insertStaffCommand.Parameters.AddWithValue("@Email", staff.Email);
                insertStaffCommand.Parameters.AddWithValue("@PhoneNumber", staff.PhoneNumber);
                insertStaffCommand.ExecuteNonQuery();
            }
        }


        // ===================================== VIEW =====================================
        public List<Staff> ViewAllStaffs()
        {
            List<Staff> staffs = new List<Staff>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                string viewAllStaffsQuery = "SELECT * FROM Staffs";
                SQLiteCommand viewAllStaffs = new SQLiteCommand(viewAllStaffsQuery, connection);
                var reader = viewAllStaffs.ExecuteReader();
                while (reader.Read())
                {
                    Staff staff = new Staff
                    {
                        StaffID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Address = reader.GetString(3),
                        DOB = reader.GetString(4),
                        Gender = reader.GetString(5),
                        Role = reader.GetString(6),
                        PhoneNumber = reader.GetString(8),
                        Email = reader.GetString(7)
                    };
                    staffs.Add(staff);
                }
            }
            return staffs;
        }



        // ===================================== DELETE =====================================
        public void DeleteStaff(int staffID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteStaffQuery = "DELETE FROM Staffs WHERE StaffID = @StaffID";
                SQLiteCommand deleteStaffCommand = new SQLiteCommand(deleteStaffQuery, connection);
                deleteStaffCommand.Parameters.AddWithValue("@StaffID", staffID);
                deleteStaffCommand.ExecuteNonQuery();
            }
        }

        



        // ===================================== UPDATE =====================================
        internal void UpdateStaff(Staff staff)
        {
            if (staff is null)
            {
                throw new ArgumentNullException(nameof(staff));
            }

            using (var connection = DataBaseConnection.GetConnection())
            {
                string updateQuery = "UPDATE Staffs SET FirstName = @FirstName , LastName = @LastName , Address = @Address , DOB = @DOB ," +
                                     "Role = @Role , Gender = @gender , Email = @Email , PhoneNumber = @PhoneNumber WHERE StaffID = @StaffID ";

                using (var updateStaffCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateStaffCommand.Parameters.AddWithValue("@FirstName", staff.FirstName);
                    updateStaffCommand.Parameters.AddWithValue("@LastName", staff.LastName);
                    updateStaffCommand.Parameters.AddWithValue("@Address", staff.Address);
                    updateStaffCommand.Parameters.AddWithValue("@DOB", staff.DOB);
                    updateStaffCommand.Parameters.AddWithValue("@Role", staff.Role);
                    updateStaffCommand.Parameters.AddWithValue("@gender", staff.Gender);
                    updateStaffCommand.Parameters.AddWithValue("@Email", staff.Email);
                    updateStaffCommand.Parameters.AddWithValue("@PhoneNumber", staff.PhoneNumber);
                    updateStaffCommand.Parameters.AddWithValue("@StaffID", staff.StaffID);

                    updateStaffCommand.ExecuteNonQuery(); 
                }
            }
        }




        // ============================ SEARCH ============================
        public List<Staff> SearchStaffs(string keyword)
        {
            var staffs = new List<Staff>();
            bool isNumeric = int.TryParse(keyword, out int idVal);

            string sql = @"
                SELECT * FROM Staffs
                WHERE FirstName   LIKE @Txt COLLATE NOCASE
                   OR LastName    LIKE @Txt COLLATE NOCASE
                   OR Address     LIKE @Txt COLLATE NOCASE
                   OR DOB         LIKE @Txt COLLATE NOCASE
                   OR Gender      LIKE @Txt COLLATE NOCASE
                   OR Role        LIKE @Txt COLLATE NOCASE
                   OR Email       LIKE @Txt COLLATE NOCASE
                   OR PhoneNumber LIKE @Txt COLLATE NOCASE";

            if (isNumeric)
                sql += " OR StaffID = @Id";

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Txt", $"%{keyword}%");
                cmd.Parameters.AddWithValue("@Id", isNumeric ? idVal : -1);

                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                    {
                        staffs.Add(new Staff
                        {
                            StaffID = Convert.ToInt32(r["StaffID"]),
                            FirstName = r["FirstName"].ToString(),
                            LastName = r["LastName"].ToString(),
                            Address = r["Address"].ToString(),
                            DOB = r["DOB"].ToString(),
                            Gender = r["Gender"].ToString(),
                            Role = r["Role"].ToString(),
                            Email = r["Email"].ToString(),
                            PhoneNumber = r["PhoneNumber"].ToString()
                        });
                    }
            }
            return staffs;
        }

       


        // ===================================== VIEW (ONE) IN MAIN STAFF FORM =====================================
        public Staff GetStaffById(int id)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = "SELECT * FROM Staffs WHERE StaffID = @id LIMIT 1;";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Staff
                            {
                                StaffID = Convert.ToInt32(reader["StaffID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                DOB = reader["DOB"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Role = reader["Role"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }


    }
}
