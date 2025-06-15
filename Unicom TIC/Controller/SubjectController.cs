using System.Collections.Generic;
using System.Data.SQLite;
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
        public List<dynamic> ViewAllSubjectsWithCourse()
        {
            var list = new List<dynamic>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"
                    SELECT s.SubjectID, s.SubjectName, c.CourseName
                    FROM Subjects s
                    LEFT JOIN Courses c ON s.CourseID = c.CourseID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new
                        {
                            SubjectID = rdr.GetInt32(0),
                            SubjectName = rdr.GetString(1),
                            CourseName = rdr.IsDBNull(2) ? "" : rdr.GetString(2)
                        });
                    }
                }
            }
            return list;
        }

        /*
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
        }*/
    }
}
