using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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





        // ===================================== View Students (+ Course Name) =====================================
        public List<Student> ViewAllStudentWithCourse()
        {
            var list = new List<Student>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"
                    SELECT s.StudentID, s.FirstName, s.LastName, s.Address,s.DOB, s.Gender, s.Email, s.PhoneNumber,s.CourseID, c.CourseName
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


        // ===================================== VIEW (ONE) =====================================
        public Student GetStudentById(int id)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                const string sql = @"SELECT  s.StudentID, s.FirstName, s.LastName, s.Address,s.DOB, s.Gender, s.Email, s.PhoneNumber,s.CourseID, c.CourseName
                                     FROM  Students s
                                     LEFT JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE   s.StudentID = @id    LIMIT 1;";
                

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
    }
}
