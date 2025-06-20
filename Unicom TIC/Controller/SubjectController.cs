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
        // ===================================== ADD =====================================
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




        // ===================================== VIEW =====================================
        public List<Subject> ViewAllSubjectsWithCourse()
        {
            List<Subject> subjects = new List<Subject>();
            using (var connection = DataBaseConnection.GetConnection())
            {
               string viewSubjectQuery = @"SELECT s.SubjectID, s.SubjectName,c.CourseID,  c.CourseName
                                     FROM Subjects s
                                     LEFT JOIN Courses c ON s.CourseID = c.CourseID;";

                SQLiteCommand viewAllExams = new SQLiteCommand(viewSubjectQuery, connection);
                var reader = viewAllExams.ExecuteReader();
                while (reader.Read())
                {
                    Subject subject = new Subject
                    {
                        SubjectID = Convert.ToInt32(reader["SubjectID"]),
                        SubjectName = reader["SubjectName"].ToString(),
                        CourseID = Convert.ToInt32(reader["CourseID"]),
                        CourseName = reader["CourseName"] == DBNull.Value ? null : reader["CourseName"].ToString()
                    };
                    subjects.Add(subject);
                       
                }
                
            }
            return subjects;
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


    }
}
