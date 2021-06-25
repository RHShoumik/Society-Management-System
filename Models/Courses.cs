using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace TutionManagementSystem.Models
{
    public class Courses
    {
        SqlConnection conn;
        public Courses()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public ArrayList GetAllCourses()
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course u = new Course()
                {

                    CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                    CourseId = reader.GetString(reader.GetOrdinal("CourseId")),
                    CourseFee = reader.GetString(reader.GetOrdinal("CourseFee")),
                    TeacherName= reader.GetString(reader.GetOrdinal("TeacherUsername")),
                    


                };
                courses.Add(u);
            }
            
            conn.Close();
            return  courses;
        } public ArrayList GetSelectedDetails(string courseId)
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM StudentCourse where CourseId='" + courseId +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course u = new Course()
                {

                    CourseName = reader.GetString(reader.GetOrdinal("UsernameSt")),
                    CourseId = reader.GetString(reader.GetOrdinal("UsernameT")),
                    CourseFee = reader.GetString(reader.GetOrdinal("CourseId")),
                    TeacherName= reader.GetString(reader.GetOrdinal("CourseName"))
                    


                };
                courses.Add(u);
            }
            
            conn.Close();
            return  courses;
        }
        public ArrayList StudentAllCourses(string student)
        {
            ArrayList courses = new ArrayList();
            
            conn.Open();
            string query = "SELECT * FROM StudentCourse where UsernameSt='"+student+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course u = new Course()
                {
                     CourseName= reader.GetString(reader.GetOrdinal("CourseName")),
                    CourseId = reader.GetString(reader.GetOrdinal("CourseId")),
                    CourseFee = reader.GetString(reader.GetOrdinal("CourseFee")),
                    TeacherName = reader.GetString(reader.GetOrdinal("UsernameT")),
                     Student= reader.GetString(reader.GetOrdinal("UsernameSt"))
            };  

                
                courses.Add(u);
            }
            
            conn.Close();
            return  courses;
        }

        public void AddCourse(Course a)
        {
            conn.Open();

            string query = "INSERT INTO Courses(CourseName,CourseId,CourseFee,TeacherUsername,Class1,Class2,Class3,Class4,Class5) Values ( '" + a.CourseName + "','" + a.CourseId + "','" + a.CourseFee +"','"+a.TeacherName+ "',"+ "'N/A','N/A','N/A','N/A','N/A')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateCourse(Course a)
        {
            conn.Open();

            string query = "Update Courses set CourseName='" + a.CourseName +"',CourseFee='"+ a.CourseFee + "' where CourseId='"+ a.CourseId +"'" ;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCourse(Course a)
        {
            conn.Open();

            string query = "DELETE FROM Courses WHERE CourseId='"+a.CourseId +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void StudentCourse(string studentName, string teacherName, string courseId, string courseName, string courseFee)

        {
            conn.Open();

            string query = "INSERT INTO StudentCourse(UsernameSt,UsernameT,CourseId,CourseName,CourseFee) Values ( '" +studentName+"','"+teacherName + "','" +courseId+ "','" +courseName+ "','" +courseFee + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }public void SetClass(string courseId,string Class,string link)

        {
            

            conn.Open();
            string query = "UPDATE Courses SET "+Class +"='"+link+"' where CourseId='"+courseId+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();


        }
        
        public Course GetSelectedCourse(string courseId)
        {
            //ArrayList courses = new ArrayList();
            Course U = new Course();
            conn.Open();
            string query = "SELECT * FROM Courses where CourseId='" + courseId + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course u = new Course()
                {

                    
                    Class1 = reader.GetString(reader.GetOrdinal("Class1")),
                    Class2 = reader.GetString(reader.GetOrdinal("Class2")),
                    Class3 = reader.GetString(reader.GetOrdinal("Class3")),
                    Class4 = reader.GetString(reader.GetOrdinal("Class4")),
                    Class5 = reader.GetString(reader.GetOrdinal("Class5"))


                };
                 //courses.Add(u);
               U = u;
            }

            conn.Close();
            return U;
        }
    }
}
