using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutionManagementSystem.Models
{
    public class Teacher:User
    {

        public string Medium { get; set; }
        public string Subject { get; set; }
        public string Qualification { get; set; }


    }
}
