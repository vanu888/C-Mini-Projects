using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Login_Window
{
    public partial class FrmLogin : Form
    {
        String uname = "admin";
        String pw = "password";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            txtPassword.PasswordChar = '*';
            String password = txtPassword.Text;
            if ((username == uname) && (password == pw))
            {
                MessageBox.Show("Login Succussful!");
                txtUserName.Clear();
                txtPassword.Clear();
            }
            else {
                MessageBox.Show("Login Failed!");
            }


        }
    }
}
