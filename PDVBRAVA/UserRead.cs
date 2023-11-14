using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVBRAVA
{
    internal class UserRead
    {

        private DataConnection connection;
        private List<User> users;
        public UserRead() 
        {
            connection = new DataConnection();
            users = new List<User>();  

        }

        public List<User> getUsers(string filter = "") 
        {
            string query = "SELECT * FROM users";
            MySqlDataReader reader = null;

            try
            {
                if (!string.IsNullOrEmpty(filter)) 
                {
                    query += "WHERE " +
                                "name LIKE '%" + filter + "%' OR " +
                                "userid LIKE '%" + filter + "%'";
                }
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection.getConnection();
                reader = command.ExecuteReader();
                User user = null;
                while (reader.Read()) 
                {
                    user = new User();
                    user.id = reader.GetInt32(0);
                    user.Name = reader.GetString(1);
                    user.Password  = reader.GetString(2);
                    users.Add(user);    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return users;
        }
    }
}
