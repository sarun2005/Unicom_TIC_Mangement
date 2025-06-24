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
                string addlecturerQuery = @"INSERT INTO Lecturers ( FirstName , LastName , Address , DOB , Gender , SubjectID , Email , PhoneNumber )
                                            VALUES ( @FirstName , @LastName , @Address , @DOB , @Gender ,  @SubjectID , @Email , @PhoneNumber )";

                SQLiteCommand insertLecturerCommand = new SQLiteCommand(addlecturerQuery, connection);
                insertLecturerCommand.Parameters.AddWithValue("@FirstName", lecturer.FirstName);
                insertLecturerCommand.Parameters.AddWithValue("@LastName", lecturer.LastName);
                insertLecturerCommand.Parameters.AddWithValue("@Address", lecturer.Address);
                insertLecturerCommand.Parameters.AddWithValue("@DOB", lecturer.DOB);
                insertLecturerCommand.Parameters.AddWithValue("@Gender", lecturer.Gender);
                insertLecturerCommand.Parameters.AddWithValue("@SubjectID", lecturer.SubjectID);
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
                string viewAllLecturersQuery = @"SELECT l.LecturerID, l.FirstName, l.LastName, l.Address, l.DOB, l.Gender, l.SubjectID, s.SubjectName, l.Email, l.PhoneNumber
                                         FROM Lecturers l
                                         LEFT JOIN Subjects s ON l.SubjectID = s.SubjectID";

                SQLiteCommand viewAllLecturers = new SQLiteCommand(viewAllLecturersQuery, connection);
                var reader = viewAllLecturers.ExecuteReader();
                while (reader.Read())
                {
                    Lecturer lecturer = new Lecturer
                    {
                        LecturerID = Convert.ToInt32(reader["LecturerID"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Address = reader["Address"].ToString(),
                        DOB = reader["DOB"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        SubjectID = Convert.ToInt32(reader["SubjectID"]),
                        SubjectName = reader["SubjectName"] == DBNull.Value ? null : reader["SubjectName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString()
                    };
                    lecturers.Add(lecturer);
                }
            }
            return lecturers;
        }





        public List<Lecturer> SearchLecturers(string keyword)
        {
            var lecturers = new List<Lecturer>();

            const string searchlecturerQuery = @"
        SELECT l.*, s.SubjectName 
        FROM Lecturers l
        LEFT JOIN Subjects s ON l.SubjectID = s.SubjectID
        WHERE l.LecturerID = @Id
           OR l.FirstName   LIKE @AdminLecturerSearchText COLLATE NOCASE
           OR l.LastName    LIKE @AdminLecturerSearchText COLLATE NOCASE
           OR l.Address     LIKE @AdminLecturerSearchText COLLATE NOCASE
           OR l.DOB         LIKE @AdminLecturerSearchText COLLATE NOCASE
           OR l.Gender      LIKE @AdminLecturerSearchText COLLATE NOCASE
           OR s.SubjectName LIKE @AdminLecturerSearchText COLLATE NOCASE;";

            using (var connection = DataBaseConnection.GetConnection())
            using (var SearchLecturerCommand = new SQLiteCommand(searchlecturerQuery, connection))
            {
                SearchLecturerCommand.Parameters.AddWithValue("AdminLecturerSearchText", $"%{keyword}%");

                
                if (int.TryParse(keyword, out int id))
                    SearchLecturerCommand.Parameters.AddWithValue("@Id", id);
                else
                    SearchLecturerCommand.Parameters.AddWithValue("@Id", -1);

                using (var reader = SearchLecturerCommand.ExecuteReader())
                    while (reader.Read())
                    {
                        lecturers.Add(new Lecturer
                        {
                            LecturerID = Convert.ToInt32(reader["LecturerID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            DOB = reader["DOB"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            SubjectName = reader["SubjectName"] == DBNull.Value ? null : reader["SubjectName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString()
                        });
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
                string updateQuery = @"UPDATE Lecturers 
                               SET FirstName = @FirstName, 
                                   LastName = @LastName, 
                                   Address = @Address, 
                                   DOB = @DOB, 
                                   Gender = @Gender, 
                                   SubjectID = @SubjectID, 
                                   Email = @Email, 
                                   PhoneNumber = @PhoneNumber 
                               WHERE LecturerID = @LecturerID";

                using (var updateLecturerCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateLecturerCommand.Parameters.AddWithValue("@FirstName", lecturer.FirstName);
                    updateLecturerCommand.Parameters.AddWithValue("@LastName", lecturer.LastName);
                    updateLecturerCommand.Parameters.AddWithValue("@Address", lecturer.Address);
                    updateLecturerCommand.Parameters.AddWithValue("@DOB", lecturer.DOB);
                    updateLecturerCommand.Parameters.AddWithValue("@Gender", lecturer.Gender);
                    updateLecturerCommand.Parameters.AddWithValue("@SubjectID", lecturer.SubjectID);
                    updateLecturerCommand.Parameters.AddWithValue("@Email", lecturer.Email);
                    updateLecturerCommand.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);
                    updateLecturerCommand.Parameters.AddWithValue("@LecturerID", lecturer.LecturerID); 

                    updateLecturerCommand.ExecuteNonQuery();
                }
            }
        }











        // ===================================== VIEW (ONE) IN MAIN LECTURER FORM =====================================
        public Lecturer GetLecturerById(int id)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = "SELECT * FROM Lecturers WHERE LecturerID = @id LIMIT 1;";   
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
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                SubjectName = reader["SubjectName"] == DBNull.Value ? null : reader["SubjectName"].ToString(),
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
