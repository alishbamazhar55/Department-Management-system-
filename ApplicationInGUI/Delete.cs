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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            Databind();
            dataGridView1.DataSource = AdminDL.returnlist();

        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        public void Databind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AdminDL.students;
            sizeset();
            dataGridView1.Refresh();



        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AdminDL.currentindex(dataGridView1.CurrentRow.Index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AdminDL.returnlist();
            sizeset();
            AdminDL.Writedataforadnmin();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
             
            }

        private void Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }
    
    

