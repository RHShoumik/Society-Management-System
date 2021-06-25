using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TutionManagementSystem.Controllers;
using TutionManagementSystem.Models;


namespace TutionManagementSystem.Views
{
    public partial class PendingRequest : Form
    {
        public PendingRequest()
        {
            InitializeComponent();
            
        }

        private void PendingRequest_Load(object sender, EventArgs e)
        {
            radioButtonApproveYes.Checked = true;
            dataGridViewUsers.DataSource = UserController.GetAllUsersPending();
            
        }

        private void SelectRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rw = dataGridViewUsers.CurrentRow;
            // MessageBox.Show(rw.Cells["Username"].Value.ToString());
            textBoxUsername.Text = rw.Cells["Username"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpController.ApproveUser(textBoxUsername.Text);
           String massage= SignUpController.SendMail(textBoxUsername.Text);
            MessageBox.Show(massage);
            dataGridViewUsers.DataSource = UserController.GetAllUsersPending();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
