using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class RoomController
    {
        

        // ===================================== Add Room =====================================
        public bool AddRoom(Room room)
        {
            if (room == null || string.IsNullOrWhiteSpace(room.RoomName) || string.IsNullOrWhiteSpace(room.RoomType))
            {
                throw new ArgumentException("Room details cannot be null or empty.");
            }

            using (var connection = DataBaseConnection.GetConnection())
            {
                using (var insertRoomCommand = new SQLiteCommand(AddRoomQuery, connection))
                {
                    insertRoomCommand.Parameters.Add("@RoomName", System.Data.DbType.String).Value = room.RoomName.Trim();
                    insertRoomCommand.Parameters.Add("@RoomType", System.Data.DbType.String).Value = room.RoomType.Trim();
                    return insertRoomCommand.ExecuteNonQuery() > 0; // Returns true if a row was inserted
                }
            }
        }

        // ===================================== View =====================================
        public List<Room> ViewAllRooms()
        {
            List<Room> rooms = new List<Room>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                using (var viewAllRooms = new SQLiteCommand(ViewAllRoomsQuery, connection))
                {
                    using (var reader = viewAllRooms.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room
                            {
                                RoomID = reader.GetInt32(0),
                                RoomName = reader.GetString(1),
                                RoomType = reader.GetString(2),
                            };
                            rooms.Add(room);
                        }
                    }
                }
            }
            return rooms;
        }

        // ===================================== Delete  =====================================
        public bool DeleteRoom(int roomID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                using (var cmd = new SQLiteCommand(DeleteRoomQuery, connection))
                {
                    cmd.Parameters.Add("@RoomID", System.Data.DbType.Int32).Value = roomID;
                    return cmd.ExecuteNonQuery() > 0; // Returns true if a row was deleted
                }
            }
        }



        // SQL Queries as constants
        private const string AddRoomQuery = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@RoomName, @RoomType)";
        private const string ViewAllRoomsQuery = "SELECT * FROM Rooms";
        private const string DeleteRoomQuery = "DELETE FROM Rooms WHERE RoomID = @RoomID";
        private const string UpdateRoomQuery = @"
            UPDATE Rooms
            SET RoomName = @RoomName,
                RoomType = @RoomType
            WHERE RoomID = @RoomID";



        // ===================================== Update  =====================================
        public bool UpdateRoom(Room room)
        {
            if (room == null || string.IsNullOrWhiteSpace(room.RoomName) || string.IsNullOrWhiteSpace(room.RoomType))
            {
                throw new ArgumentException("Room details cannot be null or empty.");
            }

            using (var connection = DataBaseConnection.GetConnection())
            {
                using (var cmd = new SQLiteCommand(UpdateRoomQuery, connection))
                {
                    cmd.Parameters.Add("@RoomName", System.Data.DbType.String).Value = room.RoomName.Trim();
                    cmd.Parameters.Add("@RoomType", System.Data.DbType.String).Value = room.RoomType.Trim();
                    cmd.Parameters.Add("@RoomID", System.Data.DbType.Int32).Value = room.RoomID;

                    return cmd.ExecuteNonQuery() > 0; // Returns true if a row was updated
                }
            }
        }
    }
}
