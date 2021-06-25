using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace TutionManagementSystem.Models
{
    public class Students : User
    {
        SqlConnection conn;
        public Students()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public void AddUserStudent(Student s)
        {
            conn.Open();

            
                string query = "INSERT INTO Students(Id,Class,[Group],Medium,Username) Values ('" + s.Id + "','" + s.Class + "','" + s.Group + "','" + s.Medium + "','" + s.Username + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
            
            
            conn.Close();
        }
        public ArrayList GetAllStudents()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where UserType='Students'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
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
        public Student GetStudent(string username)
        {
            Student users = new Student();
            conn.Open();
            string query = "SELECT * FROM Users where Username='" + username +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student u = new Student()
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
                users = u;
            }
            conn.Close();
            return users;
        }

        public ArrayList GetAStudent(string username)
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where Username='"+username+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {

                    Name = reader.GetString(reader.GetOrdinal("Name")),
                   // Id = reader.GetString(reader.GetOrdinal("Id")),
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

    }
}
