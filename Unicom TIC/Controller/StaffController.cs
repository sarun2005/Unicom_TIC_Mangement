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


        // View All Staff Method =========================================================
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



        // Delete Staff Method =========================================================
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
    }
}
