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

    }
}
