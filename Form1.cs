using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPR_QuizMester_lj3p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.SelectAll();
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
            {
                lblUsernameError.Text = "Wrong username, please try again";
            }
            else if (txbPassword.Text == "")
            {
                lblPasswordError.Text = "Wrong password, please try again";
            }
        }
    }
}
