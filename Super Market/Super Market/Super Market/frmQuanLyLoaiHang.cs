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
    public partial class frmQuanLyLoaiHang : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        private int ID;
        public frmQuanLyLoaiHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }

        private void CbChungLoaiHangBinding()
        {
            
        }
        private void LstLoaiHangBinding()
        {
            

        }

        private void BtnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCapNhatLoaiHang_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
          
            
        }

        private void BtnThemLoaiHang_Click(object sender, EventArgs e)
        {
            
        }

        private void CbChungLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCategories_Load_1(object sender, EventArgs e)
        {
            
        }

        private void BtnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            
        }

    }
}