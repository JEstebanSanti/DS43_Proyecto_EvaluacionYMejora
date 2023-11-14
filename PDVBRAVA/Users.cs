using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVBRAVA
{
    public partial class Users : Form
    {
        private UserRead userRead;
        private List<User> users;

        public Users()
        {
            InitializeComponent();
            userRead = new UserRead();
            users = new List<User>();
            loadUsers();
        }

        public void loadUsers(string filter = "")
        {
            userDGV.Rows.Clear();
            userDGV.Refresh();
            userDGV.ClearSelection();
            users = userRead.getUsers(filter);
            for (int i = 0; i < users.Count; i++)
            {
                userDGV.RowTemplate.Height = 60;
                userDGV.Rows.Add(
                    users[i].id,
                    users[i].Name
                    );

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
