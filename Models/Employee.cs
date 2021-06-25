using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutionManagementSystem.Models
{
    public class Employee:User
    {
        public string Position { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }

    }
}
