using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutionManagementSystem.Controllers;

namespace TutionManagementSystem.Views
{
    public partial class StudentUpdate : Form
    {
        string f1;
        public StudentUpdate(string s)
        {
            InitializeComponent();
            this.f1 = s;
        }

        private void StudentUpdate_Load(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = UserController.GetAStudent(f1);
        }
    }
}
