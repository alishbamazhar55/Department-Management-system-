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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new addStudent();
            setform(f);
        }
        private void setform (Form form)
        {
           mainpanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            mainpanel.Controls.Add(form);
            mainpanel.Tag = form;
          
           form.BringToFront();
          form.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new ViewStudents();
            setform(f);
          


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Delete();

            setform(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new update();
            setform(f);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new search();
            setform(f);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new scholarships();
            setform(f);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
           
            f.Show();
           
            this.Hide();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new courses();
         
            setform(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
