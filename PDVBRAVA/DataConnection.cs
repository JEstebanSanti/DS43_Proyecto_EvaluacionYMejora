using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVBRAVA
{
    internal class DataConnection : DataConfig
    {
        private MySqlConnection sqlConnection;
        public DataConnection()
        {
            string conString = "Database="+database+"; DataSource="+server+"; User Id="+user+"; Password="+password+";";
            sqlConnection = new MySqlConnection(conString);
        }

        public MySqlConnection getConnection() 
        {
            try 
            { 
                if(sqlConnection.State != System.Data.ConnectionState.Open) 
                {
                    sqlConnection.Open();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlConnection;
        }
    }
}
