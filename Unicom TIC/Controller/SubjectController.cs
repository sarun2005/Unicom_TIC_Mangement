using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class SubjectController
    {
        // ===================================== Add Subject =====================================
        public void AddSubject(Subject subject)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addSubjectQuery = "INSERT INTO Subjects (SubjectName, CourseID) " +
                                          "VALUES (@SubjectName, @CourseID)";

                SQLiteCommand insertSubjectCommand = new SQLiteCommand(addSubjectQuery, connection);
                insertSubjectCommand.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                insertSubjectCommand.Parameters.AddWithValue("@CourseID", subject.CourseID);
                insertSubjectCommand.ExecuteNonQuery();

            }
        }




        // ===================================== View Subjects (+ Course Name) =====================================
        public List<Subject> ViewAllSubjectsWithCourse()
        {
            var list = new List<Subject>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"
            SELECT s.SubjectID, s.SubjectName, s.CourseID, c.CourseName
            FROM Subjects s
            LEFT JOIN Courses c ON s.CourseID = c.CourseID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        try
                        {
                            Subject subject = new Subject
                            {
                                SubjectID = Convert.ToInt32(rdr["SubjectID"]),
                                SubjectName = rdr["SubjectName"].ToString(),
                                CourseID = Convert.ToInt32(rdr["CourseID"]),
                                CourseName = rdr["CourseName"] == DBNull.Value ? null : rdr["CourseName"].ToString()
                            };
                            list.Add(subject);
                        }
                        catch (InvalidCastException ex)
                        {
                            // Log the error with column values for debugging
                            Console.WriteLine($"Error casting values: {ex.Message}");
                            Console.WriteLine($"Row values: {string.Join(", ", Enumerable.Range(0, rdr.FieldCount).Select(i => rdr[i].ToString()))}");
                             // Re-throw if you want to propagate the error
                        }
                    }
                }
            }
            return list;
        }





        // ===================================== Delete Subject =====================================
        public void DeleteSubject(int subjectID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = "DELETE FROM Subjects WHERE SubjectID = @SubjectID;";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // ===================================== Update  =====================================
        public bool UpdateSubject(Subject subject)
        {
            if (subject == null || string.IsNullOrWhiteSpace(subject.SubjectName) || subject.CourseID <= 0)
            {
                throw new ArgumentException("Subject details cannot be null or empty.");
            }

            try
            {
                using (var connection = DataBaseConnection.GetConnection())
                {
                    string UpdateSubjectQuery = "UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID";
                    using (SQLiteCommand cmd = new SQLiteCommand(UpdateSubjectQuery, connection))
                    {
                        cmd.Parameters.Add("@SubjectName", System.Data.DbType.String).Value = subject.SubjectName.Trim();
                        cmd.Parameters.Add("@CourseID", System.Data.DbType.Int32).Value = subject.CourseID;
                        cmd.Parameters.Add("@SubjectID", System.Data.DbType.Int32).Value = subject.SubjectID;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating subject: " + ex.Message);
            }
        }


    }
}
