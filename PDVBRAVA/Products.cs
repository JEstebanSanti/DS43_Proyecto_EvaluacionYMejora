using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Products : Form
    {
        private ProductReader productRead;
        private List<Product> listProducts;
        private Product nProduct;
        public Products()
        {
            InitializeComponent();
            productRead = new ProductReader();
            listProducts = new List<Product>();
            nProduct = new Product();
            loadProducts();
            txtSearchProduct.Text = "";
        }

        public void loadProducts(string filter = "")
        {
            productDGV.Rows.Clear();
            productDGV.Refresh();
            listProducts.Clear();

            listProducts = productRead.getProducts(filter);
            for (int i = 0; i < listProducts.Count; i++)
            {
                productDGV.RowTemplate.Height = 60;
                productDGV.Rows.Add(
                    listProducts[i].Id,
                    listProducts[i].Name,
                    listProducts[i].Description,
                    listProducts[i].Price,
                    listProducts[i].Stock
                    );

            }
        }
        private bool validationProduct()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Missing User");
                return false;

            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Missing Password");
                return false;

            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Missing Password");
                return false;

            }
            if (string.IsNullOrEmpty(txtQuantityStock.Text.Trim()))
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
        private void cleanFieldData()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantityStock.Text = string.Empty;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            loadProducts(txtSearchProduct.Text.Trim());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!validationProduct()) { return; }

            loadProductData();

            if (productRead.addProduct(nProduct))
            {
                MessageBox.Show("Product added Successfully");
                loadProducts();
                cleanFieldData();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (!validationProduct()) { return; }

            loadProductData();

            if (productRead.updateProduct(nProduct))
            {
                MessageBox.Show("Product UPDATED Successfully");
                loadProducts();
                cleanFieldData();
            }
        }

        private void loadProductData()
        {
            nProduct.Name = txtName.Text.Trim();
            nProduct.Description = txtDescription.Text.Trim();
            nProduct.Price = Convert.ToDecimal(txtPrice.Text);
            nProduct.Stock = Convert.ToInt32(txtQuantityStock.Text);
        }

        private void productDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = productDGV.Rows[e.RowIndex];
            if (row != null)
            {
                string idProduct = Convert.ToString(row.Cells["ID"].Value);
                nProduct = productRead.getProductByID(idProduct);
                if (nProduct != null)
                {
                    txtName.Text = nProduct.Name;
                    txtDescription.Text = nProduct.Description;
                    txtPrice.Text = Convert.ToString(nProduct.Price);
                    txtQuantityStock.Text = Convert.ToString(nProduct.Stock);
                }

            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

            loadProductData();

            if (productRead.deleteProduct(nProduct))
            {
                MessageBox.Show("Product DELETED Successfully");
                loadProducts();
                cleanFieldData();
            }
        }
    }
}
