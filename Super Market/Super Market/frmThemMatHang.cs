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