using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TutionManagementSystem.Models
{
    public class User
    {
        SqlConnection conn;
        public User()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string DateOfBirth { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Approval { get; set; }
        public string Gender { get; set; }
    }
}
 