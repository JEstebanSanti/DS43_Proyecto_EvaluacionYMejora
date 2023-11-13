using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVBRAVA
{
    internal class UserLogin
    {
        private DataConnection connection;
        public UserLogin() 
        {
            connection = new DataConnection();
            
        }
        public bool login(string username, string password) 
        {
            bool result = false;
            try 
            {
                string query = "SELECT * FROM users WHERE user="+ "'" + username+"'"  +" AND password="+ "'"+password +"';";
                MySqlDataReader reader;
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection.getConnection());
                reader = mySqlCommand.ExecuteReader();
                result = reader.Read();
                reader.Close();
                connection.getConnection().Close();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
