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
using Newtonsoft.Json;
namespace ApplicationInGUI
{
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
            Databind();
          
        }
        private void sizeset()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        public  void Databind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AdminDL.students;
            sizeset();
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void customDataBind()
        {

            dataGridView1.DataSource = AdminDL.students.Select(c => new { c.Namesforadmin, c.Percentageforadmin }).ToList();
            
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {

        
     }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
