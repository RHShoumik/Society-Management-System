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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void SignUpFprmStudent_Load(object sender, EventArgs e)
        {
            radioButtonMale.Checked = true;
           
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignUpNext_Click(object sender, EventArgs e)
        {

            
            dynamic item = (string)comboBoxUserType.SelectedItem;
            string errors = "";
 
                dynamic gender;
                if (radioButtonMale.Checked == true)
                {
                    gender = radioButtonMale.Text;
                }
                else if (radioButtonFemale.Checked == true)
                {
                    gender = radioButtonMale.Text;
                }
                if (errors.Length != 0)
                {
                    MessageBox.Show(errors, "Error");
                    return;
                }
            if (textBoxName.Text.Length != 0)
            {
                if(textBoxEmail.Text.Length != 0)
                {
                    if(textBoxPassword.Text.Length != 0)
                    {
                        if(textBoxAddress.Text.Length != 0)
                        {
                            if(textBoxPhone.Text.Length != 0)
                            {
                                if (textBoxDateOfBirth.Text.Length != 0)
                                {
                                   // try
                                   // {
                                        if (item.Length != 0)
                                        {

                                            int a = SignUpController.GetLastId();
                                            a = a + 1;
                                            if (item == "Students")
                                            {
                                                this.Hide();
                                                new SignUpFormStudent(this, a).Show();
                                            }
                                            else if (item == "Teachers")
                                            {
                                                this.Hide();
                                                new SignUpFormTeacher(this, a).Show();
                                            }
                                            else if (item == "Employees")
                                            {
                                                this.Hide();
                                                new SignUpFormEmployee(this, a).Show();
                                            }
                                        }
                                        else
                                        {
                                            errors += "Please Provide User Type";
                                        }
                                   // }
                                    //catch(Exception)
                                   // {
                                   //     errors += "Please Provide User Type";
                                        
                                   // }
                                }
                                else
                                {
                                    errors += "Please Provide Date Of Birth";
                                }
                            }
                            else
                            {
                                errors += "Please Provide Contact Number";
                            }
                        }
                        else
                        {
                            errors += "Please Provide Address";
                        }
                    }
                    else
                    {
                        errors += "Please Provide Password";
                    }
                }
                else
                {
                    errors += "Please Provide Email";
                }
            }
            else
            {
                errors +=  "Please Provide Name";
            }

            if (errors.Length != 0)
            {
                MessageBox.Show(errors, "Error");
                return;
            }



        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
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

