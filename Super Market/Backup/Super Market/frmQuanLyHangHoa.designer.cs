namespace Super_Market
{
    partial class frmQuanLyHangHoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHangHoa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbChungLoaiHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LstLoaiHang = new System.Windows.Forms.ListBox();
            this.dgChiTietMH = new System.Windows.Forms.DataGridView();
            this.ctMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ctMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSoMatHang = new System.Windows.Forms.Label();
            this.BtnThemMatHang = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietMH)).BeginInit();
            this.ctMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chủng &loại";
            // 
            // CbChungLoaiHang
            // 
            this.CbChungLoaiHang.FormattingEnabled = true;
            this.CbChungLoaiHang.Location = new System.Drawing.Point(96, 14);
            this.CbChungLoaiHang.Name = "CbChungLoaiHang";
            this.CbChungLoaiHang.Size = new System.Drawing.Size(184, 21);
            this.CbChungLoaiHang.TabIndex = 3;
            this.CbChungLoaiHang.SelectedValueChanged += new System.EventHandler(this.CbChungLoaiHang_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chủng &loại";
            // 
            // LstLoaiHang
            // 
            this.LstLoaiHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LstLoaiHang.FormattingEnabled = true;
            this.LstLoaiHang.Location = new System.Drawing.Point(16, 110);
            this.LstLoaiHang.Name = "LstLoaiHang";
            this.LstLoaiHang.Size = new System.Drawing.Size(155, 264);
            this.LstLoaiHang.TabIndex = 5;
            this.LstLoaiHang.SelectedValueChanged += new System.EventHandler(this.LstLoaiHang_SelectedValueChanged);
            // 
            // dgChiTietMH
            // 
            this.dgChiTietMH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgChiTietMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietMH.Location = new System.Drawing.Point(171, 92);
            this.dgChiTietMH.Name = "dgChiTietMH";
            this.dgChiTietMH.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgChiTietMH.Size = new System.Drawing.Size(539, 282);
            this.dgChiTietMH.TabIndex = 6;
            this.dgChiTietMH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgChiTietMH_CellMouseClick_1);
            // 
            // ctMenu
            // 
            this.ctMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctMenuNew,
            this.ctMenuEdit,
            this.ctMenuDelete});
            this.ctMenu.Name = "ctMenu";
            this.ctMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctMenu.ShowCheckMargin = true;
            this.ctMenu.ShowImageMargin = false;
            this.ctMenu.Size = new System.Drawing.Size(153, 92);
            this.ctMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctMenu_ItemClicked);
            // 
            // ctMenuNew
            // 
            this.ctMenuNew.Name = "ctMenuNew";
            this.ctMenuNew.Size = new System.Drawing.Size(152, 22);
            this.ctMenuNew.Text = "&New";
            // 
            // ctMenuEdit
            // 
            this.ctMenuEdit.Name = "ctMenuEdit";
            this.ctMenuEdit.Size = new System.Drawing.Size(152, 22);
            this.ctMenuEdit.Text = "&Edit";
            this.ctMenuEdit.Click += new System.EventHandler(this.ctMenuEdit_Click_1);
            // 
            // ctMenuDelete
            // 
            this.ctMenuDelete.Name = "ctMenuDelete";
            this.ctMenuDelete.Size = new System.Drawing.Size(152, 22);
            this.ctMenuDelete.Text = "&Delete";
            this.ctMenuDelete.Click += new System.EventHandler(this.ctMenuDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CbChungLoaiHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(241, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 43);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số mặt hàng:";
            // 
            // LblSoMatHang
            // 
            this.LblSoMatHang.AutoSize = true;
            this.LblSoMatHang.BackColor = System.Drawing.Color.Transparent;
            this.LblSoMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSoMatHang.Location = new System.Drawing.Point(112, 404);
            this.LblSoMatHang.Name = "LblSoMatHang";
            this.LblSoMatHang.Size = new System.Drawing.Size(0, 15);
            this.LblSoMatHang.TabIndex = 9;
            // 
            // BtnThemMatHang
            // 
            this.BtnThemMatHang.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThemMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThemMatHang.Location = new System.Drawing.Point(184, 395);
            this.BtnThemMatHang.Name = "BtnThemMatHang";
            this.BtnThemMatHang.Size = new System.Drawing.Size(87, 34);
            this.BtnThemMatHang.TabIndex = 13;
            this.BtnThemMatHang.Text = "Thêm &mới";
            this.BtnThemMatHang.UseVisualStyleBackColor = false;
            this.BtnThemMatHang.Click += new System.EventHandler(this.BtnThemMatHang_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThoat.Location = new System.Drawing.Point(310, 395);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(87, 34);
            this.BtnThoat.TabIndex = 16;
            this.BtnThoat.Text = "T&hoát";
            this.BtnThoat.UseVisualStyleBackColor = false;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // frmQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 472);
            this.Controls.Add(this.BtnThemMatHang);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.LblSoMatHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LstLoaiHang);
            this.Controls.Add(this.dgChiTietMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyHangHoa";
            this.Text = "Quan ly Hang hoa";
            this.Load += new System.EventHandler(this.frmQuanLyHangHoa_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyHangHoa_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietMH)).EndInit();
            this.ctMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbChungLoaiHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LstLoaiHang;
        private System.Windows.Forms.DataGridView dgChiTietMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSoMatHang;
        private System.Windows.Forms.Button BtnThemMatHang;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.ContextMenuStrip ctMenu;
        private System.Windows.Forms.ToolStripMenuItem ctMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem ctMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem ctMenuNew;
    }
}