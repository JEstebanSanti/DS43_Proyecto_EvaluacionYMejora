using Org.BouncyCastle.Tls;
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
    public partial class DashBoard : Form
    {
        private List<Product> listProducts;
        private Product nwProduct;
        private ProductReader productReader;
        private int rows;
        int quantity = 1;
        private double total= 0;
        public DashBoard()
        {

            InitializeComponent();
            listProducts = new List<Product>();
            productReader = new ProductReader();
            nwProduct = new Product();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users userForm = new Users();
            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products productForm = new Products();
            productForm.Show();
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearchProduct.Text.Trim()))
                {
                    MessageBox.Show("Introduce a the Product Code");
                    txtSearchProduct.Text = "";
                    return;
                }
                else 
                {
                    nwProduct = productReader.getProductByID(txtSearchProduct.Text.Trim().ToString());
                    if (nwProduct == null ) 
                    { 
                        MessageBox.Show("Product Not Find");
                        return;
                    }

                    rows = DVGProducts.Rows.Add(nwProduct.Id, nwProduct.Name.ToString(), Math.Round(nwProduct.Price, 2), quantity);
                    DVGProducts.ClearSelection();
                    DVGProducts.Rows[rows].Selected = true;
                    if (rows < DVGProducts.Rows.Count - 1)
                    {

                        DVGProducts.CurrentCell = DVGProducts.Rows[rows + 1].Cells[0];
                    }
                    updatePrice();
                }


            }
        }

        private void updatePrice()
        {

            total = 0;
            int i = 0;
            foreach (DataGridViewRow row in DVGProducts.Rows)
            {

                DataGridViewCell cell = row.Cells[2];
                if (cell.Value != null)
                {

                    double tempTotal = double.Parse(cell.Value.ToString());
                    total += tempTotal;
                    i++;

                }
                lbTotal.Text = "Total $ " + Math.Round(total, 2).ToString();
            }


        }
        /*private void loadList() 
        {
            DVGProducts.Rows.Clear();
            for (int i = 0; i < listProducts.Count; i++)
            {
                DVGProducts.RowTemplate.Height = 60;
                DVGProducts.Rows.Add(
                    listProducts[i].Id,
                    listProducts[i].Name,
                    listProducts[i].Price
                    );

            }

        }*/
    }
}
