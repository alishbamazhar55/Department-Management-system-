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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
            Databind(AdminDL.students);
        }
        public void Databind(List<AdminBL> searching)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =searching;
            sizeset();
            dataGridView1.Refresh();



        }
        private void sizeset()
        {
            for (int i=0;i<dataGridView1.Columns.Count;i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = searchtext.Text;
            List<AdminBL> s = AdminBL.searchstudent(name);
            Databind(s);

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Databind(AdminDL.students);
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
           
                }

        private void search_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

        }

    
    
    



