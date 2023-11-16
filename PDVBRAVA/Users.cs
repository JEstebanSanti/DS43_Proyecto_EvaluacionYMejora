using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVBRAVA
{
    public partial class Users : Form
    {
        private UserRead userRead;
        private List<User> users;
        private User nUser;

        public Users()
        {
            InitializeComponent();
            userRead = new UserRead();
            users = new List<User>();
            nUser = new User();
            loadUsers();
            txtSearchUser.Text = "";
        }

        public void loadUsers(string filter = "")
        {
            userDGV.Rows.Clear();
            userDGV.Refresh();
            users.Clear();

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
        private bool validationUser()
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Missing User");
                return false;

            }
            if (string.IsNullOrEmpty(txtPasswordUser.Text.Trim()))
            {
                MessageBox.Show("Missing Password");
                return false;

            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            loadUsers(txtSearchUser.Text.Trim());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!validationUser()) { return; }

            loadUserData();

            if (userRead.addUser(nUser))
            {
                MessageBox.Show("User added Successfully");
                loadUsers();
                cleanFieldData();
            }
        }

        private void cleanFieldData()
        {
            txtSearchUser.Text = string.Empty;
            txtPasswordUser.Text = string.Empty;
            txtPasswordUser.Text = "";
            txtUser.Text = "";
        }

        private void loadUserData()
        {
            nUser.Name = txtUser.Text.Trim();
            nUser.Password = txtPasswordUser.Text.Trim();
        }



        private void userDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = userDGV.Rows[e.RowIndex];
            if (row != null)
            {
                string idUser = Convert.ToString(row.Cells["userID"].Value);
                nUser = userRead.getUserByID(idUser);
                if (nUser != null)
                {
                    txtUser.Text = nUser.Name;
                    txtPasswordUser.Text = nUser.Password;
                }

            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (!validationUser()) { return; }

            loadUserData();

            if (userRead.updateUser(nUser))
            {
                MessageBox.Show("User UPDATED Successfully");
                loadUsers();
                cleanFieldData();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!validationUser()) { return; }

            loadUserData();


            if (userRead.deleteUser(nUser))
            {
                MessageBox.Show("User DELETED Successfully");
                loadUsers();
                cleanFieldData();
            }
        }
    }
}
