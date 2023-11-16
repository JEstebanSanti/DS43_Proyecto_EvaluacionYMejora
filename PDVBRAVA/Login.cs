using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVBRAVA
{
    public partial class Login : Form
    {
        private UserLogin userLogin;
        public Login()
        {
            InitializeComponent();
            userLogin = new UserLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string pass = txtPassword.Text.ToString();
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                bool res = userLogin.login(user, pass);
                if (res)
                {
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bad credentials");
                }
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
