using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class ExamController
    {
        // ============================ ADD ============================
        public void AddExam(Exam exam)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string addExamQuery = @"INSERT INTO Exams (ExamName, SubjectID, Date, StartTime, EndTime)
                                        VALUES (@ExamName, @SubjectID, @Date, @StartTime, @EndTime);";

                using (SQLiteCommand insertExamCommand = new SQLiteCommand(addExamQuery, connection))
                {
                    insertExamCommand.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    insertExamCommand.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    insertExamCommand.Parameters.AddWithValue("@Date", exam.Date.ToString("yyyy-MM-dd")); // Format date
                    insertExamCommand.Parameters.AddWithValue("@StartTime", exam.StartTime); // TimeSpan is fine
                    insertExamCommand.Parameters.AddWithValue("@EndTime", exam.EndTime); // TimeSpan is fine
                    insertExamCommand.ExecuteNonQuery();
                }
            }
        }

        // ============================ VIEW ============================
        public List<Exam> ViewAllExams()
        {
            List<Exam> exams = new List<Exam>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"SELECT e.ExamID, e.ExamName, e.SubjectID, s.SubjectName, 
                                            e.Date, e.StartTime, e.EndTime
                                     FROM Exams e
                                     LEFT JOIN Subjects s ON e.SubjectID = s.SubjectID;";
                using (var cmd = new SQLiteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamID = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            SubjectName = reader["SubjectName"] != DBNull.Value ? reader["SubjectName"].ToString() : null,
                            Date = DateTime.Parse(reader["Date"].ToString()), // Ensure correct parsing
                            StartTime = TimeSpan.Parse(reader["StartTime"].ToString()), // Ensure correct parsing
                            EndTime = TimeSpan.Parse(reader["EndTime"].ToString()) // Ensure correct parsing
                        });
                    }
                }
            }
            return exams; // Ensure the list is returned after reading
        }

        // ============================ UPDATE ============================
        public void UpdateExam(Exam exam)
        {
            using (var conn = DataBaseConnection.GetConnection())
            {
                const string sql = @"UPDATE Exams
                                     SET ExamName = @ExamName,
                                         SubjectID = @SubjectID,
                                         Date = @Date,
                                         StartTime = @StartTime,
                                         EndTime = @EndTime
                                     WHERE ExamID = @ExamID;";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName?.Trim());
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@Date", exam.Date.ToString("yyyy-MM-dd")); // Format date
                    cmd.Parameters.AddWithValue("@StartTime", exam.StartTime); // TimeSpan is fine
                    cmd.Parameters.AddWithValue("@EndTime", exam.EndTime); // TimeSpan is fine
                    cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ===================================== DELETE =====================================
        public void DeleteExam(int examID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteExamQuery = "DELETE FROM Exams WHERE ExamID = @ExamID";
                using (SQLiteCommand deleteExamCommand = new SQLiteCommand(deleteExamQuery, connection))
                {
                    deleteExamCommand.Parameters.AddWithValue("@ExamID", examID);
                    deleteExamCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
