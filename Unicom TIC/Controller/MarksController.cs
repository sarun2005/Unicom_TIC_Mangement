using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class MarksController
    {
        // ============================ ADD ============================
        public void AddMarks(Mark mark)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addMarksQuery = @"INSERT INTO Marks (Score, SubjectID, ExamID, StudentID)
                                        VALUES (@Score, @SubjectID, @ExamID, @StudentID);";

                using (SQLiteCommand insertMarksCommand = new SQLiteCommand(addMarksQuery, connection))
                {
                    insertMarksCommand.Parameters.AddWithValue("@Score", mark.Score);
                    insertMarksCommand.Parameters.AddWithValue("@SubjectID", mark.SubjectID);
                    insertMarksCommand.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    insertMarksCommand.Parameters.AddWithValue("@StudentID", mark.StudentID);
                    insertMarksCommand.ExecuteNonQuery();
                }
            }
        }

        // ============================ VIEW ============================
        public List<Mark> ViewAllMarks()
        {
            List<Mark> marks = new List<Mark>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                string viewMarksQuery = @"SELECT m.MarkID , m.Score , st.StudentID , (st.FirstName || ' ' || st.LastName) AS StudentName , sb.SubjectID , sb.SubjectName , ex.ExamID , ex.ExamName
                                          FROM Marks m
                                          LEFT JOIN Students st ON m.StudentID = st.StudentID
                                          LEFT JOIN Subjects sb ON m.SubjectID = sb.SubjectID
                                          LEFT JOIN Exams ex ON m.ExamID = ex.ExamID;";

                using (SQLiteCommand cmd = new SQLiteCommand(viewMarksQuery, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marks.Add(new Mark
                            {
                                MarkID = reader.GetInt32(0),
                                Score = reader["Score"] != DBNull.Value ? Convert.ToDecimal(reader["Score"]) : 0, // Use a default value if NULL
                                StudentID = reader["StudentID"] != DBNull.Value ? Convert.ToInt32(reader["StudentID"]) : 0, // Use a default value if NULL
                                StudentName = reader["StudentName"].ToString(),
                                SubjectID = reader["SubjectID"] != DBNull.Value ? Convert.ToInt32(reader["SubjectID"]) : 0, // Use a default value if NULL
                                SubjectName = reader["SubjectName"] != DBNull.Value ? reader["SubjectName"].ToString() : string.Empty, // Use an empty string if NULL
                                ExamID = reader["ExamID"] != DBNull.Value ? Convert.ToInt32(reader["ExamID"]) : 0, // Use a default value if NULL
                                ExamName = reader["ExamName"].ToString()
                            });
                        }
                    }
                }
            }
            return marks;
        }
    }
}
