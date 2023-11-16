using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVBRAVA
{
    internal class ProductReader
    {
        private DataConnection connection;
        private List<Product> listProducts;
        private Product nwProduct;
        public  ProductReader() 
        {
            connection = new DataConnection();
            listProducts = new List<Product>();
            nwProduct = new Product();
        }
        internal List<Product> getProducts(string filter)
        {
            string query = "SELECT * FROM products";
            MySqlDataReader reader = null;

            try
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    query += $" WHERE productid LIKE '%{filter}%' OR name LIKE '%{filter}%';";
                }
                MySqlCommand command = new MySqlCommand(query);
                command.Connection = connection.getConnection();
                reader = command.ExecuteReader();
                Product product = null;
                while (reader.Read())

                {
                    product = new Product();
                    product.Id = reader.GetInt32(0);
                    product.Name = reader.GetString(1);
                    product.Description = reader.GetString(2);
                    product.Price = reader.GetDecimal(3);
                    product.Stock = reader.GetInt32(4);
                    listProducts.Add(product);

                }
                reader.Close();
                connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN USERS");
                MessageBox.Show(ex.Message);
            }
            return listProducts;
        }
        public bool addProduct(Product product)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO products(name, description, price, quantityinstock) VALUES("
                    + $"'{product.Name}'," + 
                    $"'{product.Description}'"+
                    $"'{product.Price}'"+
                    $"'{product.Stock}'";
                MessageBox.Show(query);

                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                result = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return result;

        }
        public Product getProductByID(string id = "")
        {
            string query = $"SELECT * FROM products WHERE productID='{id}'";
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nwProduct.Id = reader.GetInt32(0);
                    nwProduct.Name = reader.GetString(1);
                    nwProduct.Description= reader.GetString(2);
                    nwProduct.Price = reader.GetDecimal(3);
                    nwProduct.Stock = reader.GetInt32(4);

                }
                reader.Close();
                connection.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return nwProduct;
        }
        public bool updateProduct(Product product)
        {
            bool result = false;
            try
            {
                string query = $"UPDATE products SET name='{product.Name}', description='{product.Description}', price='{product.Price}', quantityinstock='{product.Stock}'  WHERE productID='{product.Id}" +
                    $"'";
                MessageBox.Show(query);
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                result = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return result;

        }

        public bool deleteProduct(Product product) 
        {
            bool result = false;
            try
            {
                string query = $"DELETE FROM products WHERE productID='{product.Id}'";
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
