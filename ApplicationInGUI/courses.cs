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
    public partial class courses : Form
    {
        public courses()
        {
            InitializeComponent();
            Databind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(coursenametext.Text) || string.IsNullOrEmpty(codetext.Text) ||
              !int.TryParse(durationtext.Text, out int dura))
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = coursenametext.Text;
            int duration = int.Parse(durationtext.Text);
            string code = codetext.Text;
            float fee = float.Parse(feetext.Text);
            courseBL course = new courseBL(name, duration, code,fee);

            coursesDL.Addcourseintolist(course);
            coursesDL.Writedataforcourses();
            MessageBox.Show("course added successfully");
            Databind();
            cleardatafromform();


        }
        private void cleardatafromform()
        {
            coursenametext.Text = "";
            durationtext.Text = "";
            codetext.Text = "";
            feetext.Text = "";


        }
        public void Databind()
        {
          
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = coursesDL.courses;
            sizeset();
            dataGridView1.Refresh();
        }
        int indexrow;
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

        private void button3_Click(object sender, EventArgs e)
        {
            coursesDL.currentindex(dataGridView1.CurrentRow.Index);
            dataGridView1.DataSource = null;
           
            dataGridView1.DataSource = coursesDL.returnlist2();
            sizeset();
            coursesDL.Writedataforcourses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewRow = dataGridView1.Rows[indexrow];
            NewRow.Cells[0].Value = coursenametext.Text;
            NewRow.Cells[1].Value = durationtext.Text;
            NewRow.Cells[2].Value =  codetext.Text;
            NewRow.Cells[3].Value = feetext.Text;

            coursesDL.Writedataforcourses();
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];

            coursenametext.Text = row.Cells[0].Value.ToString();
            durationtext.Text = row.Cells[1].Value.ToString();
            codetext.Text = row.Cells[2].Value.ToString();
            feetext.Text = row.Cells[3].Value.ToString();
        }

        private void courses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void courses_Load(object sender, EventArgs e)
        {

        }
    }
    }

