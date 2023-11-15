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

        /// <summary>
        /// SEARCH IN DATABASE, IF FIND DATA ill REUTURN IN FORM OF A LIST OF ALL
        /// IF FILTER HAVE SOMETHING WILL RETURN A SEARCH USING LIKE
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>LIST OF USERS</returns>
        public List<User> getUsers(string filter = "") 
        {
            string query = "SELECT * FROM users";
            MySqlDataReader reader = null;

            try
            {
                if (!string.IsNullOrEmpty(filter)) 
                {
                    query += $" WHERE usersid LIKE '%{filter}%' OR USER LIKE '%{filter}%';";
                }
                MySqlCommand command = new MySqlCommand(query);
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
                reader.Close();
                connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN USERS");
                MessageBox.Show(ex.Message);
            }
            return users;
        }
        /// <summary>
        /// INSERT A NEW USER
        /// </summary>
        /// <param name="user"></param>
        /// <returns>RETURN TRUE IF EXECUTE NON QUERY IS > 0 </returns>
        public bool addUser(User user) 
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO users(user, password) VALUES("+$"'{user.Name}'," + $"'{user.Password}')";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                result = command.ExecuteNonQuery() > 0;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return result;

        }
    }
}
