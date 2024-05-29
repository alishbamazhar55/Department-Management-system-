using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationInGUI.DL;

namespace ApplicationInGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            string path = "C:\\OPP\\GUI\\ApplicationInGUI\\users.txt";
            MuserDL.readData(path);
          AdminDL. readDataforadmin();
            coursesDL.readDataforcourse();
            coursesDL.readDataforregisteredcourses();


            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreform = new SignUP();
            moreform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form moreform = new SignIn();
            moreform.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
