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
using ApplicationInGUI.BL;

namespace ApplicationInGUI
{
    public partial class scholarship : Form
    {
        public scholarship()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) ||
             !int.TryParse(registration.Text, out int rollno))
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name1 = name.Text;
            int rollnumber = int.Parse(registration.Text);
            bool foundStudent = false;
            foreach (AdminBL s in AdminDL.students)
            {
                if (name1 == s.getnamesforadmin() && rollnumber==s.getrollno())
                {

                    foundStudent = true;
                    if (s.getpercentage() >= 80 && s.getpercentage() < 100)
                    {
                        
                       MessageBox.Show("you are eligible for ehsas scholarship");
                    }
                    else if (s.getpercentage() < 80 && s.getpercentage() >= 70)
                    {
                       
                        MessageBox.Show("you are eligible for PEEF scholarship");
                    }
                    else if (s.getpercentage() < 70 && s.getpercentage() >= 60)
                    {
                       
                        MessageBox.Show("you are eligible for FES scholarship");
                    }
                    else
                    {
                        
                        MessageBox.Show("there is no scholarship");
                    }
                    break;
                }
            }
            if (!foundStudent)
            {
                MessageBox.Show("student not found");
            }
        }

        private void scholarship_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
