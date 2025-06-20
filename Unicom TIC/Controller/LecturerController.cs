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
        // ===================================== ADD =====================================
        public void AddLecturer(Lecturer lecturer)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addlecturerQuery = "INSERT INTO Lecturers ( FirstName , LastName , Address , DOB , Gender , Subject , Email , PhoneNumber ) " +
                                           "VALUES ( @FirstName , @LastName , @Address ,@DOB , @gender ,  @Subject , @Email , @PhoneNumber )";


                SQLiteCommand insertLecturerCommand = new SQLiteCommand(addlecturerQuery, connection);
                insertLecturerCommand.Parameters.AddWithValue("@FirstName", lecturer.FirstName);
                insertLecturerCommand.Parameters.AddWithValue("@LastName", lecturer.LastName);
                insertLecturerCommand.Parameters.AddWithValue("@Address", lecturer.Address);
                insertLecturerCommand.Parameters.AddWithValue("@DOB", lecturer.DOB);
                insertLecturerCommand.Parameters.AddWithValue("@gender", lecturer.Gender);
                insertLecturerCommand.Parameters.AddWithValue("@Subject", lecturer.Subject);
                insertLecturerCommand.Parameters.AddWithValue("@Email", lecturer.Email);
                insertLecturerCommand.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);
                insertLecturerCommand.ExecuteNonQuery();
            }
        }



        // ===================================== VIEW =====================================
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




        // ===================================== DELETE =====================================
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
                    updateLecturerCommand.Parameters.AddWithValue("@gender", lecturer.Gender);
                    updateLecturerCommand.Parameters.AddWithValue("@Subject", lecturer.Subject);
                    updateLecturerCommand.Parameters.AddWithValue("@Email", lecturer.Email);
                    updateLecturerCommand.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);

                    updateLecturerCommand.ExecuteNonQuery(); // This executes the update command
                }
            }
        }





        // ===================================== VIEW SEARCH =====================================
        public List<Lecturer> SearchLecturers(string keyword)
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            bool isNumeric = int.TryParse(keyword, out int idVal);

            string sql = @"
                SELECT * FROM Lecturers
                WHERE FirstName LIKE @AdminLecturerSearchText COLLATE NOCASE
                   OR LastName LIKE @AdminLecturerSearchText COLLATE NOCASE
                   OR Email LIKE @AdminLecturerSearchText COLLATE NOCASE";


            if (isNumeric)
            {
                sql += " OR LecturerID = @AdminLecturerSearchID";
            }

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@AdminLecturerSearchText", $"%{keyword}%");

                if (isNumeric)
                {
                    cmd.Parameters.AddWithValue("@AdminLecturerSearchID", idVal);
                }

                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lecturers.Add(new Lecturer
                        {
                            LecturerID = Convert.ToInt32(read["LecturerID"]),
                            FirstName = read["FirstName"].ToString(),
                            LastName = read["LastName"].ToString(),
                            Address = read["Address"].ToString(),
                            DOB = read["DOB"].ToString(),
                            Gender = read["gender"].ToString(),
                            Subject = read["Subject"].ToString(),
                            Email = read["Email"].ToString(),
                            PhoneNumber = read["PhoneNumber"].ToString()
                        });
                    }
                }
            }

            return lecturers;
        }




       
        // ===================================== VIEW (ONE) IN MAIN LECTURER FORM =====================================
        public Lecturer GetLecturerById(int id)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = "SELECT * FROM Lecturers WHERE LecturerID = @id LIMIT 1;";   // const = Mostly, value never changes during the program.
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Lecturer
                            {
                                LecturerID = Convert.ToInt32(reader["LecturerID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                DOB = reader["DOB"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Subject = reader["Subject"].ToString(),
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
