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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        { 
            dataGridViewUsers.DataSource = UserController.GetAllUsers();
        }

        private void mouse_click(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SelectRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rw = dataGridViewUsers.CurrentRow;
            // MessageBox.Show(rw.Cells["Username"].Value.ToString());
            textBoxUsername.Text = rw.Cells["Username"].Value.ToString();
            textBoxType.Text= rw.Cells["UserType"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            UserController.DeleteUser(textBoxUsername.Text,textBoxType.Text);
            dataGridViewUsers.DataSource = UserController.GetAllUsers();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminView().Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
