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