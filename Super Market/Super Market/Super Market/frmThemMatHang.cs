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
    public partial class frmThemMatHang : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        private int TypeID;
        public frmThemMatHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }
        private void cBLoaiHangBinding()
        {
            
        }
        private void cBChungLoaiHangBinding()
        {
            
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void frmThemMatHang_Load(object sender, EventArgs e)
        {
            
        }

        private void CbChungLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
           
        }
    }
}