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
    internal class CourseController
    {
        public static void AddCourse(Course course)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string adminCourseQuery = "INSERT INTO Courses (CourseName) VALUES (@AdminCourseName)";
                SQLiteCommand inserCourseCommand = new SQLiteCommand(adminCourseQuery, connection);

                inserCourseCommand.Parameters.AddWithValue("@AdminCourseName", course.CourseName);
                inserCourseCommand.ExecuteNonQuery();

            }
        }


        // View All Course Method =========================================================
        public List<Course> ViewAllCourses()
        {
            List<Course> courses = new List<Course>();
            using (var connection = DataBaseConnection.GetConnection())
            {
                string viewAllCoursesQuery = "SELECT * FROM Courses";
                SQLiteCommand viewAllCourses = new SQLiteCommand(viewAllCoursesQuery, connection);
                var reader = viewAllCourses.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1),

                    };
                    courses.Add(course);
                }
            }
            return courses;
        }

        // Delete Course Method =========================================================
        public void DeleteCourse(int courseId)
        {
            using (var connection = DataBaseConnection.GetConnection())
            {
                string deleteCourseQuery = "DELETE FROM Courses WHERE CourseID = @CourseID";
                SQLiteCommand deleteCourseCommand = new SQLiteCommand(deleteCourseQuery, connection);
                deleteCourseCommand.Parameters.AddWithValue("@CourseID", courseId);
                deleteCourseCommand.ExecuteNonQuery();
            }

        }

    }
}
