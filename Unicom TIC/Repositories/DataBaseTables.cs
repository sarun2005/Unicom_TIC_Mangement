using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Repositories
{
    internal class DataBaseTables
    {
        public static void CreateTable()
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                var cmd = connection.CreateCommand();

                // 01. User Table ===================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users 
                      ( 
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        AdminID INTEGER,
                        StaffID INTEGER,
                        LecturerID INTEGER,
                        StudentID INTEGER,
                        FOREIGN KEY (AdminID) REFERENCES Admins(AdminID),
                        FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID),
                        FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID)

                      );
                ";
                cmd.ExecuteNonQuery();


                // 02. Admin Table ===================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Admins
                       (
                         AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                         FirstName TEXT NOT NULL,
                         LastName TEXT NOT NULL,
                         Role TEXT NOT NULL,
                         Email TEXT NOT NULL,
                         PhoneNumber TEXT NOT NULL
                       );
                ";
                cmd.ExecuteNonQuery();


                // 03. Staff Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Staffs
                       (
                         StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                         FirstName TEXT NOT NULL,
                         LastName TEXT NOT NULL,
                         Address TEXT NOT NULL,
                         DOB TEXT,
                         Gender TEXT,
                         Role TEXT NOT NULL,
                         Email TEXT NOT NULL,
                         PhoneNumber TEXT NOT NULL
                       );
                ";
                cmd.ExecuteNonQuery();


                // 04. Lecturer Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Lecturers
                       (
                         LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                         FirstName TEXT NOT NULL,
                         LastName TEXT NOT NULL,
                         Address TEXT NOT NULL,
                         DOB TEXT,
                         Gender TEXT,
                         Subject TEXT NOT NULL,
                         Email TEXT NOT NULL,
                         PhoneNumber TEXT NOT NULL
                       );
                ";
                cmd.ExecuteNonQuery();


                // 05. Course Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Courses
                       (
                         CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                         CourseName TEXT NOT NULL
                       );
                ";
                cmd.ExecuteNonQuery();


                // 06. Subject Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Subjects
                       (
                         SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                         SubjectName TEXT NOT NULL,
                         CourseID INTEGER,
                         FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                       );
                ";
                cmd.ExecuteNonQuery();


                // 07. Student Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Students
                       (
                         StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                         FirstName TEXT NOT NULL,
                         LastName TEXT NOT NULL,
                         Address TEXT NOT NULL,
                         DOB TEXT,
                         Gender TEXT,
                         Email TEXT NOT NULL,
                         PhoneNumber TEXT NOT NULL,
                         CourseID INTEGER,
                         FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                       );
                ";
                cmd.ExecuteNonQuery();


                // 08. Exam Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Exams 
                       (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        SubjectID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                      );
                ";
                cmd.ExecuteNonQuery();


                // 09. Mark Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Marks
                       (
                        MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Score INTEGER,
                        StudentID INTEGER,
                        ExamID INTEGER,
                        SubjectID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                       );
                ";
                cmd.ExecuteNonQuery();


                // 10. Room Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Rooms
                       (
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                       );
                ";
                cmd.ExecuteNonQuery();


                // 11. Timetable Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Timetables 
                       (
                         TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                         SubjectID INTEGER,
                         LecturerID INTEGER,
                         TimeSlot TEXT NOT NULL,
                         RoomID INTEGER,
                         FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                         FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID),  
                         FOREIGN KEY(LecturerID) REFERENCES Lecturers(LecturerID)  
                       );
                ";
                cmd.ExecuteNonQuery();


                // 12. LecturerSubject Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS LecturerSubjects
                       (
                         LecturerID INTEGER,
                         SubjectID INTEGER,
                         PRIMARY KEY ( LecturerID , SubjectID ),
                         FOREIGN KEY(LecturerID) REFERENCES Lecturers(LecturerID),
                         FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                       );
                ";
                cmd.ExecuteNonQuery();


                // 13. StudentCourse Table ==================================================
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS StudentCourses 
                       (
                          StudentID INTEGER,
                          SubjectID INTEGER,
                          PRIMARY KEY (StudentID , SubjectID ),
                          FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                          FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                       );
                ";
                cmd.ExecuteNonQuery();


            }
        }
    }
}
