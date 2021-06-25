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
    public partial class SignUpFormEmployee : Form
    {
        SignUpForm f1;
        int id;
        public SignUpFormEmployee(SignUpForm rechiveForm,int a)
        {
            InitializeComponent();
            this.f1 = rechiveForm;
            this.id = a;
            
        }

        private void SignUpFormEmployee_Load(object sender, EventArgs e)
        {
            string username = "E-" + id;
            textBoxUsername.ReadOnly = true;
            //textBoxId.ReadOnly = true;
            //textBoxId.Text = f1.textBoxId.Text;
            textBoxUsername.Text = username;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string errors ="";
            dynamic type = (string)f1.comboBoxUserType.SelectedItem;
            dynamic position = (string)comboBoxPosition.SelectedItem;
            dynamic gender = null;
            string username = "E-" + id;
            if (f1.radioButtonMale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            else if (f1.radioButtonFemale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            try
            {
                if (position.Length != 0)
                {
                    //try
                   // {
                        if (richTextBoxQualification.Text.Length != 0)
                        {
                            //try
                            //{
                                if (richTextBoxExperience.Text.Length != 0)
                                {
                                    // if (username.Length != 0)
                                    // {
                                    SignUpController.AddUser(f1.textBoxName.Text, username, id, f1.textBoxPassword.Text, f1.textBoxEmail.Text, f1.textBoxAddress.Text, f1.textBoxPhone.Text, type, f1.textBoxDateOfBirth.Text, "No", gender);
                                    SignUpController.AddUserEmployee(id, position, richTextBoxQualification.Text, richTextBoxExperience.Text, username);
                                    this.Hide();
                                    new Login().Show();
                                    // }

                                }
                            //}
                           // catch(Exception)
                           else
                            {
                                
                                    errors += "Please Provide Experience";
                                
                            }
                        }
                   // }

                   // catch (Exception)
                   else
                    {
                        errors += "Please Provide Qualification";
                    
                    }
                }
            }
            catch(Exception)
            {
                
                    errors += "Please Provide POsition";
                
            }
               
            
            if (errors.Length != 0)
            {
                MessageBox.Show(errors);
                return;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxQualification_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
