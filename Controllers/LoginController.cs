using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutionManagementSystem.Models;

namespace TutionManagementSystem.Controllers
{
    class LoginController
    {
        static Database db = new Database();
        
        static public dynamic AuthenticateUser(string username, string password)
        {
            //bool result = false;
            var obj = db.Users.AuthenticateUser(username, password);
            //if (obj != null) result = true;
            return obj;
        }
        static public dynamic UserTypeAdmin(string username)
        {
            var obj = db.Users.UserTypeAdmin(username);
            return obj;
        }
        static public dynamic UserTypeStudent(string username)
        {
            var obj = db.Users.UserTypeStudent(username);
            return obj;
        }
        static public dynamic UserTypeTeacher(string username)
        {
            var obj = db.Users.UserTypeTeacher(username);
            return obj;
        }
        static public dynamic UserTypeEmployee(string username)
        {
            var obj = db.Users.UserTypeEmployee(username);
            return obj;
        }

    }
}
