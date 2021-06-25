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
    public partial class TeacherView : Form
    {
        string username;
        public TeacherView(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void TeacherView_Load(object sender, EventArgs e)
        {
            dataGridViewTeacherAllCourse.DataSource = CourseViewController.GetAllCourses(username);
        }

        private void SelectRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rw = dataGridViewTeacherAllCourse.CurrentRow;
            textBoxCourse.Text = rw.Cells["CourseId"].Value.ToString();
            dataGridViewStudentList.DataSource = CourseViewController.GetSelectedDetails(textBoxCourse.Text);
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            dynamic Class = (string)comboBox1.SelectedItem;
            CourseViewController.SetClass(textBoxCourse.Text,Class,textBoxUrl.Text);

            dataGridViewTeacherAllCourse.DataSource = CourseViewController.GetAllCourses(username);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherView(username).Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
