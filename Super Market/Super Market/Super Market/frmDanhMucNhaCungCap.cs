using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Super_Market
{
    public partial class frmDanhMucNhaCungCap : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        public frmDanhMucNhaCungCap()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
            GetListProvider();
            GetProviderInfo();
        }
        private void GetListProvider()
        {
            
        }
        private void GetProviderInfo()
        {
            
            
        }
        private void frmDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
           
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void LstTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}