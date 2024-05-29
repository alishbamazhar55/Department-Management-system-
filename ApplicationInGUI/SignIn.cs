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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameText.Text) || string.IsNullOrEmpty(PasswordText.Text))
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = UsernameText.Text;
            string password = PasswordText.Text;
            Muser user = new Muser(username, password);
            Muser validUser = MuserDL.signIn(user);
          
            Muser m = new Muser();
            if (validUser != null)
            {
              /*  MessageBox.Show("user is valid");*/
                if(validUser.isadmin())
                {
                    Form f = new Admin();
                    f.Show();
                    this.Close();
                }
             else   if(validUser.isadmin2())
                {
                    Form f = new UserMenu();
                    f.Show();
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("user is invalid");
            }
            cleardatafromform();
           

        }
        private void cleardatafromform()
        {
            UsernameText.Text = "";
            PasswordText.Text = "";


        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
