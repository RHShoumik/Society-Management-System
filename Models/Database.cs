using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutionManagementSystem.Models
{
    public class Database
    {
        public Teachers Teachers { get; set; }
        public Students Students { get; set; }
        public Employees Employees { get; set; }
        public Courses Courses { get; set; }
        public Users Users { get; set; }
        
        public Database()
        {
            Teachers = new Teachers();
            Students = new Students();
            Employees = new Employees();
            Courses = new Courses();
            Users = new Users();
        }

    }
}
