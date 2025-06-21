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
        /*
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
        }*/


        // ============================ VIEW (ROLE‑BASED) ============================
        public List<Mark> ViewMarks(Role role, int actorId = 0)
            => GetMarks(role, actorId);

        // ---------------- PRIVATE COMMON QUERY ----------------
        private List<Mark> GetMarks(Role role, int actorId)
        {
            var list = new List<Mark>();

            using (var con = DataBaseConnection.GetConnection())
            {
                var sql = @"
                    SELECT  m.MarkID,
                            m.Score,
                            st.StudentID,
                            (st.FirstName || ' ' || st.LastName) AS StudentName,
                            sb.SubjectID,
                            sb.SubjectName,
                            ex.ExamID,
                            ex.ExamName
                    FROM        Marks    m
                    INNER JOIN  Students st ON m.StudentID = st.StudentID
                    INNER JOIN  Subjects sb ON m.SubjectID = sb.SubjectID
                    INNER JOIN  Exams    ex ON m.ExamID    = ex.ExamID
                ";

                switch (role)
                {
                    case Role.Student:
                        sql += " WHERE m.StudentID = @ActorID";
                        break;
                       /*
                    case Role.Lecturer:
                        // Subjects table‑ல் LecturerID column உள்ள பின்னர்:
                        sql += " WHERE sb.LecturerID = @ActorID";
                        // junction‑table variant comment செய்யப்பட்டுள்ளது.
                        break;

                        // Admin / Staff – filter வேண்டாம்*/
                }

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    if (role == Role.Student )
                        cmd.Parameters.AddWithValue("@ActorID", actorId);

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Mark
                            {
                                MarkID = r.GetInt32(0),
                                Score = r["Score"] != DBNull.Value ? Convert.ToDecimal(r["Score"]) : 0,
                                StudentID = r.GetInt32(2),
                                StudentName = r["StudentName"]?.ToString() ?? "",
                                SubjectID = r.GetInt32(4),
                                SubjectName = r["SubjectName"]?.ToString() ?? "",
                                ExamID = r.GetInt32(6),
                                ExamName = r["ExamName"]?.ToString() ?? ""
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}

