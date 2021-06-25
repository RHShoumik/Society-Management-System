using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutionManagementSystem.Models;
using System.Data.SqlClient;
using System.Collections;


namespace TutionManagementSystem.Controllers
{
    class EmployeeViewController
    {
        
            
        static Database db = new Database();
        public static Employee GetEmployeeInfo(string username)
        {
            Employee u = new Employee()
            {


                Username = username
               


            };
           return db.Employees.GetEmployeeInfo(u.Username);
        }

    }
}
