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
    public partial class ViewFees : Form
    {

        public ViewFees()
        {
          
            InitializeComponent();
            dataGridView1.Refresh();
            Databind();
        }
        public void Databind()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = coursesDL.courses;
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
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == dataGridView1.Columns["Register"].Index)
                {
              
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

           
                    string courseName = selectedRow.Cells[2].Value.ToString();
                    int dur = int.Parse(selectedRow.Cells[3].Value.ToString());
                    string coursecode = selectedRow.Cells[4].Value.ToString();
                    int fees = int.Parse(selectedRow.Cells[5].Value.ToString());
                    courseBL b = new courseBL(courseName, dur, coursecode, fees);

                    if (coursesDL.registeredCourses.Any(c => c.getcoursename() == b.getcoursename()))
                    {
                        MessageBox.Show("You have already registered for this course.");
                    }
                    else
                    {
                        coursesDL.registeredCourses.Add(b);
                        coursesDL.Writedataforregisteredcourses();
                        MessageBox.Show("You have successfully registered for this course.");
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Unregister"].Index)
                {
           
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    string courseName = selectedRow.Cells[2].Value.ToString();
                    courseBL b = coursesDL.registeredCourses.FirstOrDefault(c => c.getcoursename() == courseName);

                    if (b != null)
                    {
                        coursesDL.registeredCourses.Remove(b);
                        coursesDL.Writedataforregisteredcourses();
                        MessageBox.Show("You have successfully unregistered from this course.");
                    }
                    else
                    {
                        MessageBox.Show("You have not registered for this course.");
                    }
                }
            }
        }

        private void ViewFees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewFees_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

        }
    }



    
    } 

