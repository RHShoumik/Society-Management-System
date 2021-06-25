using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TutionManagementSystem.Models;
using TutionManagementSystem.Controllers;
using TutionManagementSystem.Views;

namespace TutionManagementSystem.Views
{
    public partial class PlayVideo : Form
    {
        string _yUrl;
        Course c = new Course();
        public PlayVideo(string CourseId)
        {
            InitializeComponent();
            c.CourseId = CourseId;


        }

        
        public string VideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_yUrl);
                return yMatch.Success ? yMatch.Groups[1].Value : string.Empty;
            }
        }

        private void PlayVideo_Load(object sender, EventArgs e)
        {
           c=CourseViewController.GetSelectedCourse(c.CourseId);

        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            string Class = (string)comboBoxUrl.SelectedItem;
            try
            {
                if (Class == "Class1")
                {
                    _yUrl = c.Class1;
                }
                else if (Class == "Class2")
                {
                    _yUrl = c.Class2;
                }
                else if (Class == "Class3")
                {
                    _yUrl = c.Class3;
                }
                else if (Class == "Class4")
                {
                    _yUrl = c.Class4;
                }
                else if (Class == "Class5")
                {
                    _yUrl = c.Class5;
                }

                webBrowser1.DocumentText = String.Format("<meta http-equiv='X-UA-Compatible' content='IE=Edge'/><iframe width='100%' height='315'" +
                    " src='https://www.youtube.com/embed/{0}?autoplay=1' frameborder='0' allow='accelerometer; autoplay;" +
                    " encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>", VideoID);
            }
            catch(Exception)
            {

            }
            
        
    }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentView(c.CourseId).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
