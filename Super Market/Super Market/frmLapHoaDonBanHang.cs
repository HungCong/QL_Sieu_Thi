using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace Super_Market
{
    public partial class frmLapHoaDonBanHang : Form
    {
        private static SqlConnection conn;
        private bool controlKey=false;
      
        public frmLapHoaDonBanHang()
        {
            InitializeComponent();
            
        }
        public ArrayList load_ProductsID()
        {
           
        }

        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            
            
            

        }
        public void createHoadon()
        {
            
        }
        public void insert_Hoadon(int employeeId, decimal total)
        {
            
        }
        public void insert_HoadonChitiet(int sellOrderId, String ProductId, int quantity)
        {
           
        }

        private void BtnXoaMH_Click(object sender, EventArgs e)
        {
           
          
        }

        private void BtnHoaDonMoi_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BtnInHoaDon_Click(object sender, EventArgs e)
        {
           
            
            
        }
        public int select_orderid()
        {
            
        }

        private void cBMaMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cBMaMatHang_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgChiTietMH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
        private void ctMenuXoa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void frmLapHoaDonBanHang_Load(object sender, EventArgs e)
        {

        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
           
        }
        private void writeToFile()
        {
        }
        private void inHoaDon()
        {
            


        }
        private void doc_Printpage(object sender, PrintPageEventArgs e)
        {
           
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}