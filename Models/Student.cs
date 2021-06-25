using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TutionManagementSystem.Models
{
    public class Student : User
    {
        public string Class { get; set; }
        public string Group { get; set; }
        public string Medium { get; set; }
    }
}
