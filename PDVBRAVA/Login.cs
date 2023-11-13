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
            bool res = userLogin.login(user, pass);
            if (res)
            {
                MessageBox.Show("GOOD Credentials");
            }
            else
            {
                MessageBox.Show("Bad credentials");
            }
        }
    }
}
