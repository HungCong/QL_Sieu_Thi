using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Super_Market
{
    public partial class frmQuanLyNhanVien : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
           
        }
        private void ListEmployeeInfo()
        {
            
        }
        private void GetEmployeeInfo()
        {
            
          
        }
        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
           
        }

        private void LstHoTen_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
        }

        private void LstHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}