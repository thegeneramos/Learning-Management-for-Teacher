using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Teacher" && txtPassword.Text == "1234")
            {
                MessageBox.Show("Login successful");
                StudentRecords objmain = new StudentRecords();
                objmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password \nPlease try again");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
