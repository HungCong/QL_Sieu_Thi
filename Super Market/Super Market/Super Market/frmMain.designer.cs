namespace Super_Market
{
    partial class frmMain
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
            System.Windows.Forms.StatusStrip MainStatus;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quản lý Chủng loại hàng");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quản lý Loại hàng");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý hàng hóa");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Danh mục Hàng hóa", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh mục Nhà cung cấp");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý Danh mục", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Lập Hóa đơn Bán hàng");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hóa đơn Bán hàng");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Báo cáo Thống kê", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Quản lý Nghiệp vụ", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9});
            this.LblUer = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainTreeMenu = new System.Windows.Forms.TreeView();
            this.gbMain = new System.Windows.Forms.GroupBox();
            MainStatus = new System.Windows.Forms.StatusStrip();
            MainStatus.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatus
            // 
            MainStatus.AllowDrop = true;
            MainStatus.AutoSize = false;
            MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUer});
            MainStatus.Location = new System.Drawing.Point(0, 490);
            MainStatus.Name = "MainStatus";
            MainStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            MainStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MainStatus.Size = new System.Drawing.Size(764, 22);
            MainStatus.TabIndex = 2;
            MainStatus.Text = "MainStatus";
            // 
            // LblUer
            // 
            this.LblUer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblUer.Name = "LblUer";
            this.LblUer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUer.Size = new System.Drawing.Size(59, 17);
            this.LblUer.Text = "Welcome";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.TroGiupToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(764, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.thoatToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.HeThongToolStripMenuItem.Text = "&Hệ thống";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.thoatToolStripMenuItem.Text = "&Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // TroGiupToolStripMenuItem
            // 
            this.TroGiupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.TroGiupToolStripMenuItem.Name = "TroGiupToolStripMenuItem";
            this.TroGiupToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.TroGiupToolStripMenuItem.Text = "Trợ &giúp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(231, 17);
            this.toolStripStatusLabel1.Text = "Super Market Management Version 1.0";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Finder.ico");
            this.imageList1.Images.SetKeyName(1, "Apps.ico");
            this.imageList1.Images.SetKeyName(2, "Applications.ico");
            // 
            // MainTreeMenu
            // 
            this.MainTreeMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MainTreeMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainTreeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeMenu.FullRowSelect = true;
            this.MainTreeMenu.ImageKey = "Apps.ico";
            this.MainTreeMenu.ImageList = this.imageList1;
            this.MainTreeMenu.Location = new System.Drawing.Point(0, 24);
            this.MainTreeMenu.Name = "MainTreeMenu";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "DanhMucChungLoaiSP";
            treeNode1.Text = "Quản lý Chủng loại hàng";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "DanhMucLoaiSP";
            treeNode2.Text = "Quản lý Loại hàng";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "QLHangHoa";
            treeNode3.Text = "Quản lý hàng hóa";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "DanhMucSP";
            treeNode4.Text = "Danh mục Hàng hóa";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "DanhMucNhaCungCap";
            treeNode5.Text = "Danh mục Nhà cung cấp";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "QLDanhMuc";
            treeNode6.Text = "Quản lý Danh mục";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "LapHoaDonBH";
            treeNode7.Text = "Lập Hóa đơn Bán hàng";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "HoaDonBH";
            treeNode8.Text = "Hóa đơn Bán hàng";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "BaoCaoThongKe";
            treeNode9.Text = "Báo cáo Thống kê";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "quan_ly_nghiep_vu";
            treeNode10.Text = "Quản lý Nghiệp vụ";
            this.MainTreeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.MainTreeMenu.SelectedImageIndex = 1;
            this.MainTreeMenu.ShowNodeToolTips = true;
            this.MainTreeMenu.Size = new System.Drawing.Size(224, 466);
            this.MainTreeMenu.TabIndex = 10;
            this.MainTreeMenu.DoubleClick += new System.EventHandler(this.MainTreeMenu_DoubleClick);
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.Color.Transparent;
            this.gbMain.BackgroundImage = global::Super_Market.Properties.Resources.bg;
            this.gbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(224, 24);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(540, 466);
            this.gbMain.TabIndex = 11;
            this.gbMain.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 512);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.MainTreeMenu);
            this.Controls.Add(MainStatus);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "frmMain";
            this.Text = "Smart Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            MainStatus.ResumeLayout(false);
            MainStatus.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView MainTreeMenu;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TroGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel LblUer;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

