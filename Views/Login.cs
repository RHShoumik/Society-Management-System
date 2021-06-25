using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutionManagementSystem.Views;
using TutionManagementSystem.Models;
using TutionManagementSystem.Controllers;

namespace TutionManagementSystem.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin(object sender, EventArgs e)
        {
            
                    var result = LoginController.AuthenticateUser(textBoxUsername.Text, textBoxPassword.Text);
                    var userResultAdmin = LoginController.UserTypeAdmin(textBoxUsername.Text);
                    var userResultStudent = LoginController.UserTypeStudent(textBoxUsername.Text);
                    var userResultTeacher = LoginController.UserTypeTeacher(textBoxUsername.Text);
                    var userResultEmployee = LoginController.UserTypeEmployee(textBoxUsername.Text);

                    if (result != null)
                    {
                        if (userResultAdmin != null)
                        {
                            this.Hide();
                            new AdminView().Show();
                        }
                        else if (userResultStudent != null)
                        {
                            this.Hide();
                            new StudentView(textBoxUsername.Text).Show();
                        }
                        else if (userResultTeacher != null)
                        {
                            this.Hide();
                            new TeacherView(textBoxUsername.Text).Show();
                        }
                        else if (userResultEmployee != null)
                        {
                            this.Hide();
                            new EmployeeView(textBoxUsername.Text).Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failure", "Alert");
                    }
               
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        
        }
    }
}
