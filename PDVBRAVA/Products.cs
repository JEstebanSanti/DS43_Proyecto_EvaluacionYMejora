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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
