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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
            Databind();
           dataGridView1.DataSource = AdminDL.returnlist();
        }

        private void update_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public  void Databind( )
       {
           dataGridView1.DataSource = null;
           dataGridView1.DataSource = AdminDL.students;
            sizeset();
           dataGridView1.Refresh();



       }
        int indexrow;
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow NewRow=dataGridView1.Rows[indexrow] ;
            NewRow.Cells[0].Value = textBox1.Text;
            NewRow.Cells[1].Value = textBox4.Text;
            NewRow.Cells[2].Value = textBox3.Text;
            NewRow.Cells[3].Value = textBox2.Text;
            AdminDL.Writedataforadnmin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          


        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
