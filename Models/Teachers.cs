using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutionManagementSystem.Models;
using System.Data.SqlClient;
using System.Collections;


namespace TutionManagementSystem.Models
{
    public class Teachers
    {
        SqlConnection conn;
        public Teachers()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public void AddUserTeacher(Teacher s)
        {
            conn.Open();

            string query = "INSERT INTO Teachers(Id,Medium,Subject,Qualification,Username) Values ('" + s.Id + "','" + s.Medium + "','" + s.Subject + "','" + s.Qualification + "','" + s.Username + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public ArrayList GetAllTeachers()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where UserType='Teachers'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher u = new Teacher()
                {

                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),
                    UserType = reader.GetString(reader.GetOrdinal("UserType")),
                    DateOfBirth = reader.GetString(reader.GetOrdinal("DateOfBirth")),
                    Address = reader.GetString(reader.GetOrdinal("Address")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Approval = reader.GetString(reader.GetOrdinal("Approval"))

                };
                users.Add(u);
            }
            conn.Close();
            return users;
        }
        public ArrayList GetATeacher(string username)
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where Username='" + username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {

                    Name = reader.GetString(reader.GetOrdinal("Name")),
                   // Id = reader.Int32.Parse(reader.GetOrdinal("Id")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),
                    UserType = reader.GetString(reader.GetOrdinal("UserType")),
                    DateOfBirth = reader.GetString(reader.GetOrdinal("DateOfBirth")),
                    Address = reader.GetString(reader.GetOrdinal("Address")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Approval = reader.GetString(reader.GetOrdinal("Approval"))

                };
                users.Add(u);
            }
            conn.Close();
            return users;
        }

        public ArrayList GetAllCourses(string username)
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Courses where TeacherUsername='"+username+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course u = new Course()
                {

                    CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                    CourseId = reader.GetString(reader.GetOrdinal("CourseId")),
                    CourseFee = reader.GetString(reader.GetOrdinal("CourseFee")),
                    TeacherName = reader.GetString(reader.GetOrdinal("TeacherUsername")),
                    Class1 = reader.GetString(reader.GetOrdinal("Class1")),
                    Class2 = reader.GetString(reader.GetOrdinal("Class2")),
                    Class3 = reader.GetString(reader.GetOrdinal("Class3")),
                    Class4 = reader.GetString(reader.GetOrdinal("Class4")),
                    Class5 = reader.GetString(reader.GetOrdinal("Class5"))


                };
                courses.Add(u);
            }

            conn.Close();
            return courses;
        }

    }
}
