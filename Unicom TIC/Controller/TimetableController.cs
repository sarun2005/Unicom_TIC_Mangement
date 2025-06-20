using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class TimetableController
    {
        // ============================ ADD ============================ 
        public void AddTimetable(Timetable timetable)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"INSERT INTO Timetables ( SubjectID , CourseID , LecturerID , Date , StartTime , EndTime , RoomID , GroupName)
                                    VALUES ( @SubjectID , @CourseID , @LecturerID , @Date , @StartTime , @EndTime , @RoomID , @GroupName );";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@GroupName", timetable.GroupName);
                    cmd.Parameters.AddWithValue("@Date", timetable.Date);
                    cmd.Parameters.AddWithValue("@StartTime", timetable.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", timetable.EndTime);
                    cmd.Parameters.AddWithValue("@CourseID", timetable.CourseID);
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@LecturerID", timetable.LecturerID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ============================ VIEW ALL ============================ 
        public List<Timetable> ViewAllTimetables()
        {
            var list = new List<Timetable>();

            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"SELECT t.TimetableID , t.GroupName , t.Date , t.StartTime , t.EndTime , s.CourseID,c.CourseName , t.SubjectID,s.SubjectName , t.RoomID,r.RoomName, 
                                    t.LecturerID, (l.FirstName || ' ' || l.LastName) AS LecturerName
                                    FROM Timetables t JOIN Subjects   s ON t.SubjectID  = s.SubjectID
                                    JOIN Courses    c ON s.CourseID   = c.CourseID        
                                    JOIN Lecturers  l ON t.LecturerID = l.LecturerID
                                    JOIN Rooms      r ON t.RoomID     = r.RoomID;
;";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())

                    {
                        list.Add(new Timetable
                        {
                            TimetableID = Convert.ToInt32(rdr["TimetableID"]),
                            GroupName = rdr["GroupName"].ToString(),
                            Date = DateTime.Parse(rdr["Date"].ToString()),
                            StartTime = rdr["StartTime"].ToString(),
                            EndTime = rdr["EndTime"].ToString(),

                            CourseID = Convert.ToInt32(rdr["CourseID"]),
                            CourseName = rdr["CourseName"].ToString(),

                            SubjectID = Convert.ToInt32(rdr["SubjectID"]),
                            SubjectName = rdr["SubjectName"].ToString(),

                            RoomID = Convert.ToInt32(rdr["RoomID"]),
                            RoomName = rdr["RoomName"].ToString(),

                            LecturerID = Convert.ToInt32(rdr["LecturerID"]),
                            LecturerName = rdr["LecturerName"].ToString()
                        });

                    }
                }
            }
            return list;
        }

        // ============================ UPDATE ============================ 
        public void UpdateTimetable(Timetable timetable)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"UPDATE Timetables SET SubjectID = @SubjectID,CourseID = @CourseID, LecturerID = @LecturerID, Date = @Date,StartTime = @StartTime,EndTime = @EndTime, RoomID = @RoomID, Group = @Group
                                    WHERE TimetableID = @TimetableID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@CourseID", timetable.CourseID);
                    cmd.Parameters.AddWithValue("@LecturerID", timetable.LecturerID);
                    cmd.Parameters.AddWithValue("@Date", timetable.Date);
                    cmd.Parameters.AddWithValue("@StartTime", timetable.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", timetable.EndTime);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@Group", timetable.GroupName);
                    cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ============================ DELETE ============================ 
        public void DeleteTimetable(int timetableId)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = "DELETE FROM Timetables WHERE TimetableID = @TimetableID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
