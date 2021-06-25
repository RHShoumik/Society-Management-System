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
    public partial class EmployeeView : Form
    {
        Employee em = new Employee();
        public EmployeeView(String emp)
        {
            InitializeComponent();
            em.Username = emp;
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            em =EmployeeViewController.GetEmployeeInfo(em.Username);
            textBoxName.Text = em.Name;
            textBoxUsername.Text= em.Username;
            textBoxEmail.Text= em.Email;

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
