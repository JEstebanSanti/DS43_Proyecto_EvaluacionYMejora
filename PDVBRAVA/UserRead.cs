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
        private User nwUser;
        public UserRead() 
        {
            connection = new DataConnection();
            users = new List<User>();  
            nwUser = new User();

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

        public User getUserByID(string id = "") 
        {
            string query = $"SELECT * FROM users WHERE usersid='{id}'";
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nwUser.id = reader.GetInt32(0);
                    nwUser.Name = reader.GetString(1);
                    nwUser.Password = reader.GetString(2);
                   
                }
                reader.Close ();
                connection.getConnection ().Close();   
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                
            }
            return nwUser;
        }

        public bool updateUser(User user) 
        {
            bool result = false;
            try
            {
                string query = $"UPDATE users SET user='{user.Name}', password='{user.Password}' WHERE usersID='{user.id}'"; 
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                result = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return result;

        }

        internal bool deleteUser(User nUser)
        {
            bool result = false;
            try
            {
                string query = $"DELETE FROM users WHERE usersID='{nUser.id}'";
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
