using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace TutionManagementSystem.Models
{
    public class Employees
    {
        SqlConnection conn;
        public Employees()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public void AddUserEmployee(Employee s)
        {
            conn.Open();

            string query = "INSERT INTO Employees(Id,Position,Qualification,Experiecne,Username) Values ('" + s.Id + "','" + s.Position + "','" + s.Qualification + "','" + s.Experience + "','" + s.Username + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public ArrayList GetAllEmployees()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users where UserType='Employees'";
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
        public Employee GetEmployeeInfo(string username)
        {
            Employee user = new Employee();
            conn.Open();
            string query = "select * from Users where Username ='" + username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            

            while (reader.Read())
            {
                Employee u1 = new Employee()
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
                    Approval = reader.GetString(reader.GetOrdinal("Approval")),
                    
                };
                user = u1;
            }
            conn.Close();
            conn.Open();
            string query1 = "select * from Employees where Username ='" + username + "'";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                Employee u2 = new Employee();

                u2.Position = reader1.GetString(3);
                u2.Qualification = reader1.GetString(reader1.GetOrdinal("Qualification"));
                u2.Experience = reader1.GetString(reader1.GetOrdinal("Experience"));
                

                user.Position = u2.Position;
                user.Qualification = u2.Qualification;
                user.Experience = u2.Experience;
            }
            conn.Close();
            return user;
        }

        public ArrayList GetAEmployee(string username)
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
