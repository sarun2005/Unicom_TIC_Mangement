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
                                          "VALUES ( @AdminStaffAddFirstName , @AdminStaffAddLastName , @AdminStaffAddAddress ,@AdminStaffAddDOB ," +
                                          "@gender ,  @AdminStaffAddRole , @AdminStaffAddEmail , @AdminStaffAddPhoneNumber )";


                SQLiteCommand insertStaffCommand = new SQLiteCommand(addStaffQuery, connection);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddFirstName", staff.FirstName);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddLastName", staff.LastName);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddAddress", staff.Address);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddDOB", staff.DOB);
                insertStaffCommand.Parameters.AddWithValue("@gender", staff.Gender);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddRole", staff.Role);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddEmail", staff.Email);
                insertStaffCommand.Parameters.AddWithValue("@AdminStaffAddPhoneNumber", staff.PhoneNumber);
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
                        PhoneNumber = reader.GetString(7),
                        Email = reader.GetString(8)
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



        // ===================================== UPDATE AND VIEW SEARCH =====================================
        public List<Staff> SearchStaffs(string keyword)
        {
            List<Staff> staffs = new List<Staff>();
            bool isNumeric = int.TryParse(keyword, out int idVal);

            string sql = @"
                SELECT * FROM Staffs
                WHERE FirstName LIKE @AdminStaffSearchText COLLATE NOCASE
                   OR LastName LIKE @AdminStaffSearchText COLLATE NOCASE
                   OR Email LIKE @AdminStaffSearchText COLLATE NOCASE";


            if (isNumeric)
            {
                sql += " OR StaffID = @AdminStaffSearchID";
            }

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@AdminStaffSearchText", $"%{keyword}%");

                if (isNumeric)
                {
                    cmd.Parameters.AddWithValue("@AdminStaffSearchID", idVal);
                }

                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        staffs.Add(new Staff
                        {
                            StaffID = Convert.ToInt32(read["StaffID"]),
                            FirstName = read["FirstName"].ToString(),
                            LastName = read["LastName"].ToString(),
                            Address = read["Address"].ToString(),
                            DOB = read["DOB"].ToString(),
                            Gender = read["gender"].ToString(),
                            Role = read["Role"].ToString(),
                            Email = read["Email"].ToString(),
                            PhoneNumber = read["PhoneNumber"].ToString()
                        });
                    }
                }
            }

            return staffs;
        }

        
    }
}
