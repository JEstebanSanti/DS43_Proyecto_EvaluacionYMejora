namespace PDVBRAVA
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            txtSearchProduct = new TextBox();
            productDGV = new DataGridView();
            LbTitleProducts = new Label();
            btnExit = new Button();
            label1 = new Label();
            lbProduct = new Label();
            lbPassoword = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            label3 = new Label();
            txtPrice = new TextBox();
            lbStock = new Label();
            txtQuantityStock = new TextBox();
            STOCK = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            DESCRIPTION = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearchProduct);
            panel1.Controls.Add(productDGV);
            panel1.Controls.Add(LbTitleProducts);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 601);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 175);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Search";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(102, 172);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(459, 23);
            txtSearchProduct.TabIndex = 2;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // productDGV
            // 
            productDGV.AllowUserToAddRows = false;
            productDGV.AllowUserToDeleteRows = false;
            productDGV.BorderStyle = BorderStyle.None;
            productDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            productDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDGV.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, DESCRIPTION, PRICE, STOCK });
            productDGV.GridColor = SystemColors.ButtonShadow;
            productDGV.Location = new Point(3, 217);
            productDGV.Name = "productDGV";
            productDGV.ReadOnly = true;
            productDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            productDGV.RowTemplate.Height = 25;
            productDGV.Size = new Size(631, 349);
            productDGV.StandardTab = true;
            productDGV.TabIndex = 1;
            productDGV.CellClick += productDGV_CellClick;
            // 
            // LbTitleProducts
            // 
            LbTitleProducts.AutoSize = true;
            LbTitleProducts.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LbTitleProducts.Location = new Point(259, 9);
            LbTitleProducts.Name = "LbTitleProducts";
            LbTitleProducts.Size = new Size(154, 37);
            LbTitleProducts.TabIndex = 0;
            LbTitleProducts.Text = "Products";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(873, 543);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(657, 68);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 17;
            label1.Text = "Add Or Edit";
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(657, 111);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(39, 15);
            lbProduct.TabIndex = 16;
            lbProduct.Text = "Name";
            // 
            // lbPassoword
            // 
            lbPassoword.AutoSize = true;
            lbPassoword.Location = new Point(657, 167);
            lbPassoword.Name = "lbPassoword";
            lbPassoword.Size = new Size(67, 15);
            lbPassoword.TabIndex = 15;
            lbPassoword.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(657, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 23);
            txtName.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(657, 185);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(273, 23);
            txtDescription.TabIndex = 13;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(855, 376);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 11;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(753, 376);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(75, 23);
            btnEditProduct.TabIndex = 12;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(657, 376);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 224);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 19;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(657, 242);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(273, 23);
            txtPrice.TabIndex = 18;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(657, 279);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(98, 15);
            lbStock.TabIndex = 21;
            lbStock.Text = "Quantity In Stock";
            // 
            // txtQuantityStock
            // 
            txtQuantityStock.Location = new Point(657, 309);
            txtQuantityStock.Name = "txtQuantityStock";
            txtQuantityStock.Size = new Size(273, 23);
            txtQuantityStock.TabIndex = 20;
            // 
            // STOCK
            // 
            STOCK.HeaderText = "STOCK";
            STOCK.Name = "STOCK";
            STOCK.ReadOnly = true;
            STOCK.Width = 90;
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.Name = "PRICE";
            PRICE.ReadOnly = true;
            PRICE.Width = 90;
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.HeaderText = "DESCRIPTION";
            DESCRIPTION.Name = "DESCRIPTION";
            DESCRIPTION.ReadOnly = true;
            DESCRIPTION.Width = 250;
            // 
            // NAME
            // 
            NAME.HeaderText = "Name";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 130;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 30;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 601);
            Controls.Add(lbStock);
            Controls.Add(txtQuantityStock);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(lbProduct);
            Controls.Add(lbPassoword);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtSearchProduct;
        private DataGridView productDGV;
        private Label LbTitleProducts;
        private Button btnExit;
        private Label label1;
        private Label lbProduct;
        private Label lbPassoword;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private Label label3;
        private TextBox txtPrice;
        private Label lbStock;
        private TextBox txtQuantityStock;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn STOCK;
    }
}