using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Net;
using System.Net.Mail;

namespace TutionManagementSystem.Models
{
    public class Users
    {
        SqlConnection conn;
        public Users()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public void AddUser(User a)
        {
            conn.Open();
            
            string query = "INSERT INTO Users(Name,Username,Password,DateOfBirth,UserType,Email,Phone,Approval,Id,Address,Gender) Values ( '" + a.Name +"','"+ a.Username + "','" + a.Password +"','" + a.DateOfBirth + "','" + a.UserType + "','" + a.Email + "','" +a.Phone +"', 'No' ,'"+a.Id+"','"+a.Address+"','"+a.Gender+"')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public User AuthenticateUser(string username, string password)
        {
            User user = null;
            conn.Open();
           // string a = "Yes";
      
            string query = "SELECT * FROM Users WHERE Username='" + username + "' and Password='" + password + "' and Approval= 'Yes'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));

            }
            conn.Close();
            return user;
        }
        public User UserTypeAdmin(string username)
        {
            User user = null;
            conn.Open();
            string query = "Select * from Users where Username='" + username + "' and UserType= 'admin'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));

            }
            conn.Close();
            return user;
        }
        public User UserTypeStudent(string username)
        {
            User user = null;
            conn.Open();
            string query = "Select * from Users where Username='" + username + "' and UserType= 'Students'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));

            }
            conn.Close();
            return user;
        }
        public User UserTypeTeacher(string username)
        {
            User user = null;
            conn.Open();
            string query = "Select * from Users where Username='" + username + "' and UserType= 'Teachers'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));

            }
            conn.Close();
            return user;
        }
        public User UserTypeEmployee(string username)
        {
            User user = null;
            conn.Open();
            string query = "Select * from Users where Username='" + username + "' and UserType= 'Employees'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));

            }
            conn.Close();
            return user;
        }
        public ArrayList GetAllUsers()
        {
            ArrayList users = new ArrayList();
            try
            {
                
                conn.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User u = new User()
                    {

                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Username = reader.GetString(reader.GetOrdinal("Username")),
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
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

            }
            catch(Exception )
            {
                conn.Close();
            }
            return users;
        }

        public ArrayList GetAllUsersPending()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "select * from Users where Approval='No' ";
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
        public void ApproveUser(string Username)
        {
            User users = new User();
            conn.Open();
            string query = "UPDATE Users SET Approval = 'Yes' WHERE Username = '"+Username+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            
        }
        public string SendMail(string Username)
        {
            User users = new User();
            conn.Open();
            string query = "Select* from Users Where Username = '" + Username + "'";
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
                users = u;
            }
             string email = users.Email;
             string massage;
            
            string body = "Dear User,<br>Youe request have been approved.<br>Thank you./<br>-------------------------------- -" +
                "<br>DO NOT reply to this email.This email is system generated.<br> " +
                "Software Division automated email service." +
                "<br>This is an automatically generated email. " +
                "Please do not reply to this message. " +
                "Thanks From"+
                "Ragib & Shaila"
                ;
            try
            {
                MailMessage msg = new MailMessage(email, email, "Approval", body);
                msg.IsBodyHtml = true;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("rhshoumik12@gmail.com", "******");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
                conn.Close();
                massage = "Sent";
            }
            catch (Exception e)
            {
                conn.Close();
                massage = "Invalid mail Address";
                Console.WriteLine(e);
            }
            return massage;
        }
        public void DeleteUser(string Username,string userType)
        {
            try
            {
                conn.Open();
                string query1 = "Delete From " + userType + " WHERE Username = '" + Username + "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                conn.Close();
                conn.Open();
                string query = "Delete From Users WHERE Username = '" + Username + "'";
                // string query = "Delete From Students WHERE Id = '" + Username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch(Exception a)
            {
                conn.Close();
                Console.WriteLine(a);
            }
        }
        public  int GetLastId()
        {
            conn.Open();
            User users = new User();
            // string query= "SELECT TOP 1 Id FROM Users ORDER BY Id DESC";
            //string query= "SELECT MAX(Id) FROM Users";
            string query= "set rowcount 1 select * from Users order by Id desc";
            //string query= "SELECT MAX(Id) AS Id FROM Users";

            
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //string Id = reader.GetString(reader.GetOrdinal("Id"));
            //int id = Int32.Parse(Id);
            while (reader.Read())
            {
                User u = new User()
                {

                    
                    Id = reader.GetInt32(reader.GetOrdinal("Id"))
                   

                };
                users = u;
            }
            conn.Close();
            return users.Id;
        }
    }
}
