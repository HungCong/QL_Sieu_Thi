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
    public partial class frmQuanLyHangHoa : Form
    {
        private static SqlConnection conn; //= new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        private int ID;
        private int cateID;
        public frmQuanLyHangHoa()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }
        private void CbLoaiiHangBinding()
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
                // MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void LstLoaiHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                this.ID = Int32.Parse(this.CbChungLoaiHang.SelectedValue.ToString());
                conn.Open();
                DataSet ds = new DataSet("Categories");
                SqlDataAdapter adapter = new SqlDataAdapter("Select *from Categories where TypeID = " + (int)ID + " ", conn);
                adapter.Fill(ds);
                LstLoaiHang.DataSource = ds.Tables[0];
                LstLoaiHang.DisplayMember = "Name";
                LstLoaiHang.ValueMember = "CategoryID";
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message,"Norther says",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        private void dgChiTietMatHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                this.ID = Int32.Parse(CbChungLoaiHang.SelectedValue.ToString());
                this.cateID = Int32.Parse(LstLoaiHang.SelectedValue.ToString());
                string selectCommand = "Select * from Products where CategoryID = " + cateID + "";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                table.Columns["ProductID"].ColumnName = "Mã Sản Phẩm";
                table.Columns["Name"].ColumnName = "Tên sản phẩm";
                table.Columns["PurchasePrice"].ColumnName = "Giá mua(VND)";
                table.Columns["SellingPrice"].ColumnName = "Giá bán(VND)";
                table.Columns["ProduceDate"].ColumnName = "Ngày sản xuất";
                table.Columns["ExpiryDate"].ColumnName = "Ngày hết hạn";
                table.Columns["Vat"].ColumnName = "VAT(%)";
                table.Columns["CategoryID"].ColumnName = "Mã chủng loại";
                table.Columns["UnitCalc"].ColumnName = "Đơn vị tính";
                dgChiTietMH.DataSource = table;
                int i = dgChiTietMH.RowCount - 1;
                LblSoMatHang.Text = i.ToString();
                conn.Close();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void frmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            CbLoaiiHangBinding();
            LstLoaiHangBinding();

        }

        private void CbChungLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                }
                LstLoaiHangBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            frmThemMatHang frmThemMH = new frmThemMatHang();
            frmThemMH.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to quit", "errors", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LstLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            dgChiTietMatHangBinding();
        }

        private void ctMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("ctMenuDelete"))
            {
                string productid = dgChiTietMH.CurrentCell.Value.ToString();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Products where ProductID =@ProductID", conn);
                    command.Parameters.Add("ProductID", SqlDbType.NChar, 13).Value = productid.ToString();
                    command.ExecuteNonQuery();
                    conn.Close();
                    dgChiTietMH.Refresh();
                    dgChiTietMatHangBinding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa vì còn hóa đơn bán hàng", "errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.ClickedItem.Name.Equals("ctMenuEdit"))
            {

            }
            else if (e.ClickedItem.Name.Equals("ctMenuNew"))
            {
                frmThemMatHang frmSP = new frmThemMatHang();
                frmSP.Show();
            }
        }

        private void frmQuanLyHangHoa_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgChiTietMH_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void ctMenuDelete_Click(object sender, EventArgs e)
        {

        }


        private void ctMenuEdit_Click_1(object sender, EventArgs e)
        {
           
        }

    }
}