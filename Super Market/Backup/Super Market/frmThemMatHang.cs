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
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                this.TypeID = Int32.Parse(this.CbChungLoaiHang.SelectedValue.ToString());
                conn.Open();
                DataSet ds = new DataSet("Categories");
                SqlDataAdapter adapter = new SqlDataAdapter("Select *from Categories where TypeID = " + (int)TypeID + " ", conn);
                adapter.Fill(ds);
                cBLoaiHang.DataSource = ds.Tables[0];
                cBLoaiHang.DisplayMember = "Name";
                cBLoaiHang.ValueMember = "CategoryID";
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message,"Norther says",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void cBChungLoaiHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                DataSet ds = new DataSet("Types");
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Types", conn);
                adapter.Fill(ds);
                CbChungLoaiHang.DataSource = ds.Tables[0];
                CbChungLoaiHang.DisplayMember = "Name";
                CbChungLoaiHang.ValueMember = "TypeID";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Products(ProductID,Name,PurchasePrice,SellingPrice,ProduceDate,ExpiryDate,Vat,CategoryID,UnitCalc) VALUES(@ProductID,@Name,@PurchasePrice,@SellingPrice,@ProduceDate,@ExpiryDate,@VAT,@CategoryID,@UnitCalc)",conn);
                command.Parameters.Add("@ProductID",SqlDbType.Char,13).Value = txtMaSanPham.Text;
                command.Parameters.Add("@Name",SqlDbType.NVarChar,50).Value = txtTenSanPham.Text;
                command.Parameters.Add("@PurchasePrice",SqlDbType.Float).Value = txtGiaMua.Text;
                command.Parameters.Add("@SellingPrice",SqlDbType.Float).Value = txtGiaBan.Text;
                command.Parameters.Add("@ProduceDate",SqlDbType.DateTime).Value = dtPcikerNgaySanXuat.Text;
                command.Parameters.Add("@ExpiryDate",SqlDbType.DateTime).Value = dtNgayHetHan.Text;
                command.Parameters.Add("@Vat",SqlDbType.NChar,10).Value = txtVAT.Text;
                command.Parameters.Add("@CategoryID",SqlDbType.Int).Value = cBLoaiHang.SelectedValue;
                command.Parameters.Add("@UnitCalc",SqlDbType.NChar,10).Value = txtDonViTinh.Text;
                int i = command.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thành công","Norther says",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                txtDonViTinh.Text = "";
                txtGiaBan.Text = "";
                txtMaSanPham.Text = "";
                txtVAT.Text = "";
                txtGiaMua.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
           
        }

        private void frmThemMatHang_Load(object sender, EventArgs e)
        {
            cBChungLoaiHangBinding();
            cBLoaiHangBinding();
        }

        private void CbChungLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            cBLoaiHangBinding();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}