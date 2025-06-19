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
                const string sql = @"INSERT INTO Timetables (SubjectID, LecturerID, TimeSlot, RoomID, GroupName)
                                    VALUES (@SubjectID, @LecturerID, @TimeSlot, @RoomID, @GroupName);";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@LecturerID", timetable.LecturerID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@Group", timetable.GroupName);

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
                const string sql = @"SELECT  t.TimetableID , t.SubjectID , s.SubjectName , t.LecturerID , (l.FirstName || ' ' || l.LastName) AS LecturerName,
                t.TimeSlot , t.RoomID , r.RoomName , t.GroupName FROM Timetables t JOIN    Subjects   s ON t.SubjectID  = s.SubjectID
                JOIN    Lecturers  l ON t.LecturerID = l.LecturerID
                JOIN    Rooms      r ON t.RoomID     = r.RoomID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Timetable
                        {
                            TimetableID = rdr.GetInt32(0),
                            SubjectID = rdr.GetInt32(1),
                            SubjectName = rdr["SubjectName"].ToString(),
                            LecturerID = rdr.GetInt32(3),
                            LecturerName = rdr["LecturerName"].ToString(),
                            TimeSlot = rdr["TimeSlot"].ToString(),
                            RoomID = rdr.GetInt32(6),
                            RoomName = rdr["RoomName"].ToString(),
                            GroupName = rdr["GroupName"].ToString()
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
                const string sql = @"UPDATE Timetables SET SubjectID = @SubjectID, LecturerID = @LecturerID, TimeSlot = @TimeSlot, RoomID = @RoomID, Group = @Group
                                    WHERE TimetableID = @TimetableID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@LecturerID", timetable.LecturerID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
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
