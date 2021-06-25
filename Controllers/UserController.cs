using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutionManagementSystem.Models;

namespace TutionManagementSystem.Controllers
{
    class UserController
    {
        static Database db = new Database();
        public static ArrayList GetAllUsers()
        {
            return db.Users.GetAllUsers();
        }
        public static ArrayList GetAllUsersPending()
        {
            return db.Users.GetAllUsersPending();
        }
        public static ArrayList GetAllStudents()
        {
            return db.Students.GetAllStudents();
        }
        public static ArrayList GetAStudent(string username)
        {
            return db.Students.GetAStudent(username);
        }
        public static ArrayList GetATeacher(string username)
        {
            return db.Teachers.GetATeacher(username);
        }
        public static ArrayList GetAEmployee(string username)
        {
            return db.Employees.GetAEmployee(username);
        }
        public static ArrayList GetAllTeachers()
        {
            return db.Teachers.GetAllTeachers();
        }
        public static ArrayList GetAllEmployees()
        {
            return db.Employees.GetAllEmployees();
        }
        public static ArrayList GetAllCourses()
        {
            return db.Courses.GetAllCourses();
        }
        public static void DeleteUser(string username,string type)
        {
            User u = new User()
            {


                Username = username,
                UserType=type


            };
            db.Users.DeleteUser(u.Username,u.UserType);
        }
    }
}
