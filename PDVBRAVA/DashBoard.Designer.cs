namespace PDVBRAVA
{
    partial class DashBoard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnExit = new Button();
            button4 = new Button();
            button3 = new Button();
            btnUsers = new Button();
            button2 = new Button();
            button5 = new Button();
            DVGProducts = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            txtSearchProduct = new TextBox();
            btnConfirm = new Button();
            lbTotal = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVGProducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Controls.Add(btnExit, 5, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(btnUsers, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(964, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(878, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(53, 38);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button4
            // 
            button4.Location = new Point(528, 3);
            button4.Name = "button4";
            button4.Size = new Size(130, 38);
            button4.TabIndex = 3;
            button4.Text = "Suppliers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(353, 3);
            button3.Name = "button3";
            button3.Size = new Size(130, 38);
            button3.TabIndex = 2;
            button3.Text = "Sales";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(3, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(130, 38);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // button2
            // 
            button2.Location = new Point(178, 3);
            button2.Name = "button2";
            button2.Size = new Size(130, 38);
            button2.TabIndex = 1;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(703, 3);
            button5.Name = "button5";
            button5.Size = new Size(127, 38);
            button5.TabIndex = 4;
            button5.Text = "Customers";
            button5.UseVisualStyleBackColor = true;
            // 
            // DVGProducts
            // 
            DVGProducts.AllowUserToDeleteRows = false;
            DVGProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGProducts.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, PRICE, QUANTITY });
            DVGProducts.Location = new Point(33, 178);
            DVGProducts.Name = "DVGProducts";
            DVGProducts.ReadOnly = true;
            DVGProducts.RowTemplate.Height = 25;
            DVGProducts.Size = new Size(592, 331);
            DVGProducts.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 200;
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.Name = "PRICE";
            PRICE.ReadOnly = true;
            PRICE.Width = 150;
            // 
            // QUANTITY
            // 
            QUANTITY.HeaderText = "QUANTITY";
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(33, 129);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(550, 23);
            txtSearchProduct.TabIndex = 2;
            txtSearchProduct.PreviewKeyDown += textBox1_PreviewKeyDown;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(692, 455);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(116, 54);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(651, 197);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(167, 34);
            lbTotal.TabIndex = 4;
            lbTotal.Text = "SUBTOTAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(651, 255);
            label1.Name = "label1";
            label1.Size = new Size(107, 34);
            label1.TabIndex = 5;
            label1.Text = "TOTAL";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(964, 601);
            Controls.Add(label1);
            Controls.Add(lbTotal);
            Controls.Add(btnConfirm);
            Controls.Add(txtSearchProduct);
            Controls.Add(DVGProducts);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashBoard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DVGProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnUsers;
        private Button button5;
        private Button btnExit;
        private DataGridView DVGProducts;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn QUANTITY;
        private TextBox txtSearchProduct;
        private Button btnConfirm;
        private Label lbTotal;
        private Label label1;
    }
}