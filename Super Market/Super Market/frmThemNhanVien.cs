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
    public partial class frmThemNhanVien : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        public frmThemNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }

        private void BtnThemNHanVien_Click(object sender, EventArgs e)
        {
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}