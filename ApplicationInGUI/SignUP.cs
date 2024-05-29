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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameText.Text) || string.IsNullOrEmpty(PasswordText.Text) || string.IsNullOrEmpty(RoleText.Text))
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = UsernameText.Text;
            string password = PasswordText.Text;
            string role = RoleText.Text;
            string path = "C:\\OPP\\GUI\\ApplicationInGUI\\users.txt";
            Muser user = new Muser(username, password, role);

            MuserDL.adduserintolist(user);
            MuserDL.storeDataInFile(path, user);
            MessageBox.Show("user added successfully");
            cleardatafromform();


        }
        private void cleardatafromform()
        {
            UsernameText.Text = "";
            PasswordText.Text = "";
            RoleText.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void SignUP_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }
    }
    }

