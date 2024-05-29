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
    public partial class personalInfo : Form
        
    {
        
        public personalInfo()
        {
            InitializeComponent();
            
        }
        private  void addinfo()
        {
           

        }

        private void personalInfo_Load(object sender, EventArgs e)
        {
           /* textBox1.Text = currentStudent.Namesforadmin;
            textBox2.Text = currentStudent.Rollnoforadmin.ToString();
            textBox3.Text = currentStudent.Ecatmarksforadmin.ToString();
            textBox4.Text = currentStudent.Marksforadmin.ToString();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || !decimal.TryParse(textBox3.Text, out decimal ecatmarks) ||
               !int.TryParse(textBox2.Text, out int rollno) || !decimal.TryParse(textBox4.Text, out decimal fscmarks))
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = textBox1.Text;
            int rollnumber = int.Parse(textBox2.Text);
            float fsc = float.Parse(textBox4.Text);
            float ecat = float.Parse(textBox3.Text);
            bool isAdmitted = false;

            foreach (AdminBL s in AdminDL.students)
            {
                if (name == s.getnamesforadmin()&& rollnumber==s.getrollno()&& fsc==s.getmarksforadmin()&& ecat==s.getecatmarks())
                {
                    isAdmitted = true;
                    break; 
                }
            }

            if (isAdmitted)
            {
                MessageBox.Show("You are admitted in the university.", "Admission Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are not admitted.", "Admission Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void personalInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
