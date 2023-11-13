namespace PDVBRAVA
{
    partial class Login
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lb_TitleLogib = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_TitleLogib);
            panel1.Location = new Point(143, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 585);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(393, 393);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(199, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Confirm";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(372, 313);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(239, 29);
            txtPassword.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(372, 209);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(239, 29);
            txtUser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(372, 277);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 175);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // lb_TitleLogib
            // 
            lb_TitleLogib.AutoSize = true;
            lb_TitleLogib.Dock = DockStyle.Top;
            lb_TitleLogib.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TitleLogib.Location = new Point(0, 0);
            lb_TitleLogib.Name = "lb_TitleLogib";
            lb_TitleLogib.Size = new Size(115, 45);
            lb_TitleLogib.TabIndex = 0;
            lb_TitleLogib.Text = "Login";
            lb_TitleLogib.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private Label lb_TitleLogib;
    }
}