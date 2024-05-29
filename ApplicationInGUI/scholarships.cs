using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationInGUI
{
    public partial class scholarships : Form
    {
        public scholarships()
        {
            InitializeComponent();
        }

        private void scholarships_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
