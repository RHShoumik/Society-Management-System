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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
  

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = UserController.GetAllCourses();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = UserController.GetAllTeachers();
        }

        private void MenuItemPendingRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PendingRequest().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCourse().Show();
        }

        private void toolStripMenuItemHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminView().Show();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = UserController.GetAllUsers();
        }

        private void MenuItemStudent_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = UserController.GetAllStudents();
        }

        private void MenuItemEmployees_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = UserController.GetAllTeachers();
        }

        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteUser().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
