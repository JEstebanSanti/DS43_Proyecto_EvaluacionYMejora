namespace PDVBRAVA
{
    partial class Users
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
            txtSearchUser = new TextBox();
            userDGV = new DataGridView();
            userID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            LbTitleUsers = new Label();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            txtPasswordUser = new TextBox();
            txtUser = new TextBox();
            lbPassoword = new Label();
            lbUser = new Label();
            label1 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearchUser);
            panel1.Controls.Add(userDGV);
            panel1.Controls.Add(LbTitleUsers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 601);
            panel1.TabIndex = 0;
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
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(102, 172);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(459, 23);
            txtSearchUser.TabIndex = 2;
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
            // 
            // userDGV
            // 
            userDGV.AllowUserToAddRows = false;
            userDGV.AllowUserToDeleteRows = false;
            userDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDGV.Columns.AddRange(new DataGridViewColumn[] { userID, UserName });
            userDGV.Location = new Point(54, 214);
            userDGV.Name = "userDGV";
            userDGV.ReadOnly = true;
            userDGV.RowTemplate.Height = 25;
            userDGV.Size = new Size(543, 349);
            userDGV.TabIndex = 1;
            userDGV.CellClick += userDGV_CellClick;
            // 
            // userID
            // 
            userID.HeaderText = "ID";
            userID.Name = "userID";
            userID.ReadOnly = true;
            userID.Width = 200;
            // 
            // UserName
            // 
            UserName.HeaderText = "Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 300;
            // 
            // LbTitleUsers
            // 
            LbTitleUsers.AutoSize = true;
            LbTitleUsers.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LbTitleUsers.Location = new Point(259, 9);
            LbTitleUsers.Name = "LbTitleUsers";
            LbTitleUsers.Size = new Size(106, 37);
            LbTitleUsers.TabIndex = 0;
            LbTitleUsers.Text = "Users";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(859, 373);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(757, 373);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(75, 23);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(661, 373);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPasswordUser
            // 
            txtPasswordUser.Location = new Point(661, 290);
            txtPasswordUser.Name = "txtPasswordUser";
            txtPasswordUser.PasswordChar = '*';
            txtPasswordUser.Size = new Size(273, 23);
            txtPasswordUser.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(661, 214);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(273, 23);
            txtUser.TabIndex = 5;
            // 
            // lbPassoword
            // 
            lbPassoword.AutoSize = true;
            lbPassoword.Location = new Point(661, 261);
            lbPassoword.Name = "lbPassoword";
            lbPassoword.Size = new Size(57, 15);
            lbPassoword.TabIndex = 6;
            lbPassoword.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(661, 180);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(30, 15);
            lbUser.TabIndex = 7;
            lbUser.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(661, 65);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 8;
            label1.Text = "Add Or Edit";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(877, 540);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 601);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(lbUser);
            Controls.Add(lbPassoword);
            Controls.Add(txtUser);
            Controls.Add(txtPasswordUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LbTitleUsers;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private DataGridView userDGV;
        private Button btnAddUser;
        private TextBox txtPasswordUser;
        private TextBox txtUser;
        private Label lbPassoword;
        private Label lbUser;
        private Label label1;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn UserName;
        private Button btnExit;
        private Label label2;
        private TextBox txtSearchUser;
    }
}