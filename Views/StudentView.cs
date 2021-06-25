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
using TutionManagementSystem.Models;

namespace TutionManagementSystem.Views
{
    public partial class StudentView : Form
    {
        string studentName;
        string teacherName;
        string courseId;
        string courseName;
        string courseFee;
        Course c = new Course();

        public StudentView(string s)
        {
            InitializeComponent();
            studentName = s;
        }

        private void viewInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            
            dataGridViewAllCourses.DataSource = UserController.GetAllCourses();
            dataGridViewTaken.DataSource = CourseViewController.StudentAllCourses(studentName);

        }

        private void SelectRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rw = dataGridViewAllCourses.CurrentRow;
            // MessageBox.Show(rw.Cells["Username"].Value.ToString());
            textBoxCourseName.Text = rw.Cells["CourseId"].Value.ToString();
            teacherName= rw.Cells["TeacherName"].Value.ToString();
            courseName= rw.Cells["CourseName"].Value.ToString();
            courseFee= rw.Cells["CourseFee"].Value.ToString();
            courseId = textBoxCourseName.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CourseViewController.StudentCourse(studentName,teacherName,courseId,courseName,courseFee);
            dataGridViewTaken.DataSource = CourseViewController.StudentAllCourses(studentName);
            dataGridViewAllCourses.DataSource = UserController.GetAllCourses();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentView(studentName).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SelectTakenClassRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow rw = dataGridViewTaken.CurrentRow;
                textBoxCourseName.Text = rw.Cells["CourseId"].Value.ToString();
                
            }
            catch(Exception)
            {

            }
            
        }

        private void buttonStartClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PlayVideo(textBoxCourseName.Text).Show();
        }
    }
}
