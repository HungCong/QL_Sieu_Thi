namespace Super_Market
{
    partial class frmDangNhap
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
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.CBChucvu = new System.Windows.Forms.ComboBox();
            this.LabelChucVu = new System.Windows.Forms.Label();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.Window;
            this.PanelLogin.Controls.Add(this.btnThoat);
            this.PanelLogin.Controls.Add(this.btnDangNhap);
            this.PanelLogin.Controls.Add(this.txtPassword);
            this.PanelLogin.Controls.Add(this.LabelPassword);
            this.PanelLogin.Controls.Add(this.txtUsername);
            this.PanelLogin.Controls.Add(this.labelUser);
            this.PanelLogin.Controls.Add(this.CBChucvu);
            this.PanelLogin.Controls.Add(this.LabelChucVu);
            this.PanelLogin.Location = new System.Drawing.Point(12, 55);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(268, 161);
            this.PanelLogin.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(175, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(71, 122);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "&Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(33, 88);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(52, 13);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(111, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(30, 56);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Tài khoản";
            // 
            // CBChucvu
            // 
            this.CBChucvu.DisplayMember = "Title";
            this.CBChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBChucvu.Location = new System.Drawing.Point(111, 14);
            this.CBChucvu.Name = "CBChucvu";
            this.CBChucvu.Size = new System.Drawing.Size(121, 21);
            this.CBChucvu.TabIndex = 1;
            this.CBChucvu.ValueMember = "Title";
            // 
            // LabelChucVu
            // 
            this.LabelChucVu.AutoSize = true;
            this.LabelChucVu.Location = new System.Drawing.Point(33, 17);
            this.LabelChucVu.Name = "LabelChucVu";
            this.LabelChucVu.Size = new System.Drawing.Size(48, 13);
            this.LabelChucVu.TabIndex = 0;
            this.LabelChucVu.Text = "Chức Vụ";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 271);
            this.Controls.Add(this.PanelLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management [Login]";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox CBChucvu;
        private System.Windows.Forms.Label LabelChucVu;
    }
}