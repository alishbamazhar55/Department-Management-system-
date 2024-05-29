using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationInGUI.BL;
using ApplicationInGUI.DL;

namespace ApplicationInGUI
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form f = new personalInfo();
           setform(f);
        }
        private void setform(Form form)
        {
            mainpanel2.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            mainpanel2.Controls.Add(form);
            mainpanel2.Tag = form;

            form.BringToFront();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new ViewFees();
            setform(f);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new scholarship();
            setform(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new staff();
            setform(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Registration();
            setform(f);
        }

        private void UserMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
