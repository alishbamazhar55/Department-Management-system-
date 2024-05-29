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
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameText.Text) || !decimal.TryParse(ecatText.Text, out decimal ecatmarks) ||
                !int.TryParse(rollnoText.Text, out int rollno) || !decimal.TryParse(fscText.Text, out decimal fscmarks))
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = nameText.Text;
           int rollnumber =int.Parse( rollnoText.Text);
          
            float fsc =float.Parse( fscText.Text);
            float ecat = float.Parse(ecatText.Text);
            float percentage = ((fsc* 70f) / 1100f + (ecat * 30f) / 400f);
            percentText.Text = percentage.ToString() + "%";
            AdminBL stu = new AdminBL(name, ecat, fsc, rollnumber,percentage);

            AdminDL.storeDataInListforadmin(stu);

            AdminDL.Writedataforadnmin();
            MessageBox.Show("Student added successfully");
            cleardatafromform();


        }
        private void cleardatafromform()
        {
            nameText.Text = "";
           rollnoText.Text= "";
           fscText.Text="";
         ecatText.Text="";
            percentText.Text = "";


        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addStudent_Load(object sender, EventArgs e)
        {

        }

        private void addStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        
           
        }
    }
    }

