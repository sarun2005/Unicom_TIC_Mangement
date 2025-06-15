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
    internal class LecturerController
    {
        // Add New Lecturer Method =========================================================
        public void AddLecturer(Lecturer lecturer)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addlecturerQuery = "INSERT INTO Lecturers ( FirstName , LastName , Address , DOB , Gender , Subject , Email , PhoneNumber ) " +
                                           "VALUES ( @AdminLecturerAddFirstName , @AdminLecturerAddLastName , @AdminLecturerAddAddress ,@AdminLecturerAddDOB ," +
                                          " @gender ,  @AdminLecturerAddSubject , @AdminLecturerAddEmail , @AdminLecturerAddPhoneNumber )";


                SQLiteCommand insertLecturerCommand = new SQLiteCommand(addlecturerQuery, connection);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddFirstName", lecturer.FirstName);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddLastName", lecturer.LastName);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddAddress", lecturer.Address);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddDOB", lecturer.DOB);
                insertLecturerCommand.Parameters.AddWithValue("@gender", lecturer.Gender);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddSubject", lecturer.Subject);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddEmail", lecturer.Email);
                insertLecturerCommand.Parameters.AddWithValue("@AdminLecturerAddPhoneNumber", lecturer.PhoneNumber);
                insertLecturerCommand.ExecuteNonQuery();
            }
        }



        // View All Lecturers Method =========================================================
        public List<Lecturer> ViewAllLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                string viewAllLecturersQuery = "SELECT * FROM Lecturers";
                SQLiteCommand viewAllLecturers = new SQLiteCommand(viewAllLecturersQuery, connection);
                var reader = viewAllLecturers.ExecuteReader();
                while (reader.Read())
                {
                    Lecturer lecturer = new Lecturer
                    {
                        LecturerID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Address = reader.GetString(3),
                        DOB = reader.GetString(4),
                        Gender = reader.GetString(5),
                        Subject = reader.GetString(6),
                        PhoneNumber = reader.GetString(7),
                        Email = reader.GetString(8),

                    };
                    lecturers.Add(lecturer);
                }
            }
            return lecturers;
        }


        // Delete Lecturer Method =========================================================
        public void DeleteLecturer(int lecturerID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteLecturerQuery = "DELETE FROM Lecturers WHERE LecturerID = @LecturerID";
                SQLiteCommand deleteLecturerCommand = new SQLiteCommand(deleteLecturerQuery, connection);
                deleteLecturerCommand.Parameters.AddWithValue("@LecturerID", lecturerID);
                deleteLecturerCommand.ExecuteNonQuery();
            }
        }




        // ===================================== VIEW AND DELETE SEARCH =====================================
        public Admin ViewAdminByID(int lecturerID)
        {
            Admin lecturer = null;

            string searchQuery = "SELECT * FROM Admins WHERE AdminID = @AdminAdminSearchID";

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(searchQuery, connection))
            {
                cmd.Parameters.AddWithValue("@AdminAdminSearchID", lecturerID);

                using (var read = cmd.ExecuteReader())
                {
                    if (read.Read())
                    {
                        lecturer = new Lecturer
                        {
                            LecturerID = Convert.ToInt32(read["LecturerID"]),
                            FirstName = read["FirstName"].ToString(),
                            LastName = read["LastName"].ToString(),
                            Role = read["Role"].ToString(),
                            Email = read["Email"].ToString(),
                            PhoneNumber = read["PhoneNumber"].ToString()
                        };
                    }
                }
            }
            return lecturer;
        }




        // ===================================== UPDATE =====================================
        internal void UpdateLecturer(Lecturer lecturer)
        {
            if (lecturer is null)
            {
                throw new ArgumentNullException(nameof(lecturer));
            }

            using (var connection = DataBaseConnection.GetConnection())
            {
                string updateQuery = "UPDATE Lecturers SET FirstName = @FirstName , LastName = @LastName , Address = @Address , DOB = @DOB ," +
                                     "Role = @Role , Gender = @gender , Subject = @Subject , Email = @Email , PhoneNumber = @PhoneNumber WHERE LecturerID = @LecturerID ";

                using (var updateLecturerCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateLecturerCommand.Parameters.AddWithValue("@FirstName", lecturer.FirstName);
                    updateLecturerCommand.Parameters.AddWithValue("@LastName", lecturer.LastName);
                    updateLecturerCommand.Parameters.AddWithValue("@Address", lecturer.Address);
                    updateLecturerCommand.Parameters.AddWithValue("@DOB", lecturer.DOB);
                    updateLecturerCommand.Parameters.AddWithValue("@Role", lecturer.Role);
                    updateLecturerCommand.Parameters.AddWithValue("@gender", lecturer.Gender);
                    updateLecturerCommand.Parameters.AddWithValue("@Subject", lecturer.Subject);
                    updateLecturerCommand.Parameters.AddWithValue("@Email", lecturer.Email);
                    updateLecturerCommand.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);

                    updateLecturerCommand.ExecuteNonQuery(); // This executes the update command
                }
            }
        }



        // ===================================== UPDATE SEARCH =====================================
        public List<Lecturer> SearchAdmins(string keyword)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

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
                    cmd.Parameters.AddWithValue("@AdminAdminSearchID", idVal);   // number typed
                else
                    cmd.Parameters.AddWithValue("@AdminAdminSearchID", DBNull.Value); // no match



                // ---- Text wildcard parameter ----
                cmd.Parameters.AddWithValue("@AdminAdminSearchText", $"%{keyword}%");

                using (var read = cmd.ExecuteReader())
                    while (read.Read())
                        lecturers.Add(new Lecturer
                        {
                            LecturerID = Convert.ToInt32(read["LecturerID"]),
                            FirstName = read["FirstName"].ToString(),
                            LastName = read["LastName"].ToString(),
                            Role = read["Role"].ToString(),
                            Email = read["Email"].ToString(),
                            PhoneNumber = read["PhoneNumber"].ToString()
                        });
            }

            return lecturers;
        }

    }
}
