using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutionManagementSystem.Models;
using System.Collections;

namespace TutionManagementSystem.Controllers
{
    class SignUpController
    {
        static Database db = new Database();
        public static ArrayList GetAllUsers()
        {
            return db.Users.GetAllUsers();
        }
        public static void AddUser(string name, string username, int id, string password,string email,string address,string phone, string usertype, string dateOfBirth,string comment,dynamic gender)

        {
            User u = new User()
            {

                Name = name,
                Username = username,
                Id = id,
                Email=email,
                Address=address,
                Phone=phone,
                Password = password,
                UserType = usertype,
                DateOfBirth=dateOfBirth,
                Approval=comment,
                Gender=gender
                
            };
            db.Users.AddUser(u);

        }

        public static void AddUserStudent(int id,string Clas,string group,string medium,string username)
        {
            Student s = new Student()
            {
                Id = id,
                Class = Clas,
                Group = group,
                Medium = medium,
                Username = username

            };
            db.Students.AddUserStudent(s);
        }
        public static void AddUserTeacher(int id, string medium, string subject, string qualification,string username)
        {
            Teacher s = new Teacher()
            {
                Id = id,
                Medium = medium,
                Subject = subject,
                Qualification = qualification,
                Username = username

            };
            db.Teachers.AddUserTeacher(s);
        }
        public static void AddUserEmployee(int id, string position, string qualification, string exp,string username)
        {
            Employee s = new Employee()
            {
                Id = id,
                Position=position,
                Qualification=qualification,
                Experience=exp,
                Username = username

            };
            db.Employees.AddUserEmployee(s);
        }
        public static void ApproveUser(string username)
        {
            User u = new User()
            {
         
                Username = username,

            };
            db.Users.ApproveUser(u.Username);
        }
        public static string SendMail(string username)
        {
            User u = new User()
            {

                Username = username,

            };
          string massage=db.Users.SendMail(u.Username);
            return massage;
        }
        public static int GetLastId()
        {
           int id=db. Users.GetLastId();
            return id;
        }



    }
    }
