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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            dataGridView1.Refresh();
            Databind();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Databind()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = coursesDL.registeredCourses;
            sizeset();
            dataGridView1.Refresh();
        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float totalfees = 0F;

            foreach (courseBL registeredCourse in coursesDL.registeredCourses)
            {
                totalfees += registeredCourse.getfees();
            }
           totalFees.Text = "Rs. "+ totalfees.ToString() ;

            MessageBox.Show("Total fees for all registered courses: RS. " + totalfees);
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}

