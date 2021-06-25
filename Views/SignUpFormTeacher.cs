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
    public partial class SignUpFormTeacher : Form
    {
         SignUpForm f1 = new SignUpForm();
        int id;
        public SignUpFormTeacher(SignUpForm rechiveForm,int a)
        {
            InitializeComponent();
            this.f1 = rechiveForm;
            this.id = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errors = "";
            dynamic type = (string)f1.comboBoxUserType.SelectedItem;
            string Text = "";
            string username = "T-" + id;
            for (int i = 0; i < checkedListBoxSubject.CheckedItems.Count; i++)
            {

                Text = Text + checkedListBoxSubject.CheckedItems[i] + ",";

            }
            dynamic gender = null;
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
                string medium = listBoxMedium.SelectedItem.ToString();
                if (medium.Length != 0)
                {
                    //try
                    //{
                        if (Text.Length != 0)
                        {
                            //try
                           // {
                                if (richTextBoxQualification.Text.Length != 0)
                                {
                                    SignUpController.AddUser(f1.textBoxName.Text, username, id, f1.textBoxPassword.Text, f1.textBoxEmail.Text, f1.textBoxAddress.Text, f1.textBoxPhone.Text, type, f1.textBoxDateOfBirth.Text, "No", gender);
                                    SignUpController.AddUserTeacher(id, medium, Text, richTextBoxQualification.Text, username);
                                    this.Hide();
                                    new Login().Show();
                                }
                            //}
                           // catch(Exception)
                           else
                            {
                                errors += "Please Provide Qualification";
                            }
                        }
                   // }
                    //catch(Exception)
                    else
                    {
                        errors += "Please Provide Subjects";
                    }
                }
            }
            catch(Exception)
            {
                errors += "Please Provide Medium";
            }
            if (errors.Length != 0)
            {
                MessageBox.Show(errors);
                return;
            }

        }

        private void SignUpFormTeacher_Load(object sender, EventArgs e)
        {
            string username = "T-" + id;
            textBoxUsername.ReadOnly = true;
           // textBoxId.ReadOnly = true;
           // textBoxId.Text = f1.textBoxId.Text;
            textBoxUsername.Text = username;
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
