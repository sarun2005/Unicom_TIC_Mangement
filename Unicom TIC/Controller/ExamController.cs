using System;
using System.Collections.Generic;
using System.Data;
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
                string addExamQuery = @"INSERT INTO Exams (ExamName, SubjectID)
                                        VALUES (@ExamName, @SubjectID);";

                SQLiteCommand inserExamCommand = new SQLiteCommand(addExamQuery, connection);
                inserExamCommand.Parameters.AddWithValue("@ExamName", exam.ExamName);
                inserExamCommand.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                inserExamCommand.ExecuteNonQuery();
            }
        }

        // ============================ VIEW ============================
        public List<Exam> ViewAllExams()
        {
            List<Exam> exams = new List<Exam>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                string viewExamQuery = @"SELECT e.ExamID, e.ExamName, s.SubjectID, s.SubjectName
                                 FROM Exams e
                                 LEFT JOIN Subjects s ON e.SubjectID = s.SubjectID;";

                SQLiteCommand cmd = new SQLiteCommand(viewExamQuery, connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    exams.Add(new Exam
                    {
                        ExamID = Convert.ToInt32(reader["ExamID"]),
                        ExamName = reader["ExamName"].ToString(),
                        SubjectID = reader["SubjectID"] != DBNull.Value ? Convert.ToInt32(reader["SubjectID"]) : 0, // Use a default value if NULL
                        SubjectName = reader["SubjectName"] != DBNull.Value ? reader["SubjectName"].ToString() : string.Empty // Use an empty string if NULL
                    });
                }
            }
            return exams;
        }

        /*
        // ============================ UPDATE ============================
        public void UpdateExam(Exam exam)
        {
            using var conn = DataBaseConnection.GetConnection();
            const string sql = @"UPDATE Exams
                                 SET    ExamName  = @ExamName,
                                        SubjectID = @SubjectID
                                 WHERE  ExamID    = @ExamID;";

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ExamName", exam.ExamName?.Trim());
            cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
            cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
            cmd.ExecuteNonQuery();
        }*/

        // ===================================== DELETE =====================================
        public void DeleteExam(int examID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteExamQuery = "DELETE FROM Exams WHERE ExamID = @ExamID";
                SQLiteCommand deleteExamCommand = new SQLiteCommand(deleteExamQuery, connection);
                deleteExamCommand.Parameters.AddWithValue("@ExamID", examID);
                deleteExamCommand.ExecuteNonQuery();
            }
        }


    }
}
