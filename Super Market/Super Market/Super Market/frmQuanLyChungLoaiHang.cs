using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Super_Market
{
    public partial class frmQuanLyChungLoaiHang : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        private int ID;
        public frmQuanLyChungLoaiHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }
        private void BtnThemChungLoai_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
           
        }
        private void TypeBinDing()
        {
            
        }
        
        private void BtnXoaChungLoai_Click(object sender, EventArgs e)
        {
           
        }
        private void frmTypes_Load(object sender, EventArgs e)
        {
            this.BtnCapNhatChungLoai.Hide();
            TypeBinDing();
            
            // 
        }

        private void BtnSuaChungLoai_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnCapNhatChungLoai_Click_1(object sender, EventArgs e)
        {
            
        }
        }
    }
