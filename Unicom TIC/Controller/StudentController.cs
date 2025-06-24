using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.Model;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.Controller
{
    internal class StudentController
    {
        // ===================================== ADD =====================================
        public void AddStudent(Student student)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"
                    INSERT INTO Students (FirstName, LastName, Address, DOB, Gender, Email, PhoneNumber, CourseID)
                    VALUES (@FirstName, @LastName, @Address, @DOB, @Gender, @Email, @PhoneNumber, @CourseID)";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@DOB", student.DOB);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseID);

                    cmd.ExecuteNonQuery();
                }
            }
        }




        // ===================================== UPDATE =====================================
        internal void UpdateStudent(Student student)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"
            UPDATE Students
            SET FirstName = @FirstName,
                LastName = @LastName,
                Address = @Address,
                DOB = @DOB,
                Gender = @Gender,
                Email = @Email,
                PhoneNumber = @PhoneNumber,
                CourseID = @CourseID
            WHERE StudentID = @StudentID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@DOB", student.DOB);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID); 

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // ===================================== View Students (+ Course Name) =====================================
        public List<Student> ViewAllStudentWithCourse()
        {
            var list = new List<Student>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"
                    SELECT s.StudentID, s.FirstName, s.LastName, s.Address, s.DOB, s.Gender, s.Email, s.PhoneNumber, s.CourseID, c.CourseName
                    FROM Students s
                    LEFT JOIN Courses c ON s.CourseID = c.CourseID;";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Student student = new Student
                        {
                            StudentID = Convert.ToInt32(rdr["StudentID"]),
                            FirstName = rdr["FirstName"].ToString(),
                            LastName = rdr["LastName"].ToString(),
                            Address = rdr["Address"].ToString(),
                            DOB = rdr["DOB"].ToString(),
                            Gender = rdr["Gender"].ToString(),
                            Email = rdr["Email"].ToString(),
                            PhoneNumber = rdr["PhoneNumber"].ToString(),
                            CourseID = Convert.ToInt32(rdr["CourseID"]),
                            CourseName = rdr["CourseName"] == DBNull.Value ? null : rdr["CourseName"].ToString()
                        };
                        list.Add(student);
                    }
                }
            }
            return list;
        }

        // ===================================== SEARCH STUDENTS =====================================
        public List<Student> SearchStudents(string keyword)
        {
            var students = new List<Student>();

            const string sql = @"
        SELECT s.*, c.CourseName 
        FROM Students s
        LEFT JOIN Courses c ON s.CourseID = c.CourseID
        WHERE s.StudentID = @Id
           OR s.FirstName   LIKE @Txt COLLATE NOCASE
           OR s.LastName    LIKE @Txt COLLATE NOCASE
           OR s.Address     LIKE @Txt COLLATE NOCASE
           OR s.DOB         LIKE @Txt COLLATE NOCASE
           OR s.Gender      LIKE @Txt COLLATE NOCASE
           ;";

            using (var connection = DataBaseConnection.GetConnection())
            using (var cmd = new SQLiteCommand(sql, connection))
            {
               
                cmd.Parameters.AddWithValue("@Txt", $"%{keyword}%");

                
                if (int.TryParse(keyword, out int id))
                    cmd.Parameters.AddWithValue("@Id", id);
                else
                    cmd.Parameters.AddWithValue("@Id", -1);  

                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = Convert.ToInt32(r["StudentID"]),
                            FirstName = r["FirstName"].ToString(),
                            LastName = r["LastName"].ToString(),
                            Address = r["Address"].ToString(),
                            DOB = r["DOB"].ToString(),
                            Gender = r["Gender"].ToString(),
                            Email = r["Email"].ToString(),
                            PhoneNumber = r["PhoneNumber"].ToString(),
                            CourseID = Convert.ToInt32(r["CourseID"]),
                            CourseName = r["CourseName"] == DBNull.Value ? null : r["CourseName"].ToString() // Ensure CourseName is accessed correctly
                        });
                    }
                }
            }
            return students;
        }


        // ===================================== VIEW (ONE) IN MAIN STUDENT FORM =====================================
        public Student GetStudentById(int id)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"SELECT s.StudentID, s.FirstName, s.LastName, s.Address, s.DOB, s.Gender, s.Email, s.PhoneNumber, s.CourseID, c.CourseName
                                     FROM Students s
                                     LEFT JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.StudentID = @id LIMIT 1;";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                DOB = reader["DOB"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                CourseName = reader["CourseName"] == DBNull.Value ? null : reader["CourseName"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        // ===================================== DELETE =====================================
        public void DeleteStudent(int studentID)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteStudentQuery = "DELETE FROM Students WHERE StudentID = @StudentID";
                using (var deleteStudentCommand = new SQLiteCommand(deleteStudentQuery, connection))
                {
                    deleteStudentCommand.Parameters.AddWithValue("@StudentID", studentID);
                    deleteStudentCommand.ExecuteNonQuery();
                }
            }
        }

        
    }
}
