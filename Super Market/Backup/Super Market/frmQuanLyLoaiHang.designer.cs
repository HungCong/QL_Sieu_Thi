namespace Super_Market
{
    partial class frmQuanLyLoaiHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnThemLoaiHang = new System.Windows.Forms.Button();
            this.TxtLoaiHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbChungLoaiHang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSuaLoaiHang = new System.Windows.Forms.Button();
            this.BtnCapNhatLoaiHang = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnXoaLoaiHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LstLoaiHang = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chủng &loại";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnThemLoaiHang);
            this.groupBox1.Controls.Add(this.TxtLoaiHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbChungLoaiHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // BtnThemLoaiHang
            // 
            this.BtnThemLoaiHang.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThemLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThemLoaiHang.Location = new System.Drawing.Point(303, 47);
            this.BtnThemLoaiHang.Name = "BtnThemLoaiHang";
            this.BtnThemLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.BtnThemLoaiHang.TabIndex = 4;
            this.BtnThemLoaiHang.Text = "&Thêm";
            this.BtnThemLoaiHang.UseVisualStyleBackColor = false;
            this.BtnThemLoaiHang.Click += new System.EventHandler(this.BtnThemLoaiHang_Click);
            // 
            // TxtLoaiHang
            // 
            this.TxtLoaiHang.Location = new System.Drawing.Point(101, 49);
            this.TxtLoaiHang.Name = "TxtLoaiHang";
            this.TxtLoaiHang.Size = new System.Drawing.Size(190, 20);
            this.TxtLoaiHang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại &hàng";
            // 
            // CbChungLoaiHang
            // 
            this.CbChungLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbChungLoaiHang.FormattingEnabled = true;
            this.CbChungLoaiHang.Location = new System.Drawing.Point(101, 16);
            this.CbChungLoaiHang.Name = "CbChungLoaiHang";
            this.CbChungLoaiHang.Size = new System.Drawing.Size(190, 21);
            this.CbChungLoaiHang.TabIndex = 4;
            this.CbChungLoaiHang.SelectedValueChanged += new System.EventHandler(this.CbChungLoaiHang_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnSuaLoaiHang);
            this.groupBox2.Controls.Add(this.BtnCapNhatLoaiHang);
            this.groupBox2.Controls.Add(this.BtnThoat);
            this.groupBox2.Controls.Add(this.BtnXoaLoaiHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LstLoaiHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 207);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // BtnSuaLoaiHang
            // 
            this.BtnSuaLoaiHang.BackColor = System.Drawing.SystemColors.Info;
            this.BtnSuaLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSuaLoaiHang.Location = new System.Drawing.Point(323, 28);
            this.BtnSuaLoaiHang.Name = "BtnSuaLoaiHang";
            this.BtnSuaLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.BtnSuaLoaiHang.TabIndex = 14;
            this.BtnSuaLoaiHang.Text = "&Sửa";
            this.BtnSuaLoaiHang.UseVisualStyleBackColor = false;
            this.BtnSuaLoaiHang.Click += new System.EventHandler(this.BtnSuaLoaiHang_Click);
            // 
            // BtnCapNhatLoaiHang
            // 
            this.BtnCapNhatLoaiHang.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCapNhatLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCapNhatLoaiHang.ForeColor = System.Drawing.Color.Black;
            this.BtnCapNhatLoaiHang.Location = new System.Drawing.Point(323, 28);
            this.BtnCapNhatLoaiHang.Name = "BtnCapNhatLoaiHang";
            this.BtnCapNhatLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.BtnCapNhatLoaiHang.TabIndex = 13;
            this.BtnCapNhatLoaiHang.Text = "&Cập nhật";
            this.BtnCapNhatLoaiHang.UseVisualStyleBackColor = false;
            this.BtnCapNhatLoaiHang.Click += new System.EventHandler(this.BtnCapNhatLoaiHang_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThoat.Location = new System.Drawing.Point(323, 162);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 12;
            this.BtnThoat.Text = "&Thoát";
            this.BtnThoat.UseVisualStyleBackColor = false;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnXoaLoaiHang
            // 
            this.BtnXoaLoaiHang.BackColor = System.Drawing.SystemColors.Info;
            this.BtnXoaLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnXoaLoaiHang.Location = new System.Drawing.Point(323, 93);
            this.BtnXoaLoaiHang.Name = "BtnXoaLoaiHang";
            this.BtnXoaLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.BtnXoaLoaiHang.TabIndex = 11;
            this.BtnXoaLoaiHang.Text = "&Xóa";
            this.BtnXoaLoaiHang.UseVisualStyleBackColor = false;
            this.BtnXoaLoaiHang.Click += new System.EventHandler(this.BtnXoaLoaiHang_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LstLoaiHang
            // 
            this.LstLoaiHang.BackColor = System.Drawing.Color.Cornsilk;
            this.LstLoaiHang.FormattingEnabled = true;
            this.LstLoaiHang.Location = new System.Drawing.Point(29, 28);
            this.LstLoaiHang.Name = "LstLoaiHang";
            this.LstLoaiHang.Size = new System.Drawing.Size(288, 173);
            this.LstLoaiHang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý Loại hàng";
            // 
            // frmQuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::Super_Market.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyLoaiHang";
            this.Text = "Quản lý Loại hàng";
            this.Load += new System.EventHandler(this.frmCategories_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbChungLoaiHang;
        private System.Windows.Forms.Button BtnThemLoaiHang;
        private System.Windows.Forms.TextBox TxtLoaiHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LstLoaiHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCapNhatLoaiHang;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnXoaLoaiHang;
        private System.Windows.Forms.Button BtnSuaLoaiHang;
        private System.Windows.Forms.Label label1;
    }
}