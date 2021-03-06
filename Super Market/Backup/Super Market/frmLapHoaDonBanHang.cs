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
        HoaDon hd = new HoaDon();
      
        public frmLapHoaDonBanHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
            cBMaMatHang.DataSource= load_ProductsID();
            
        }
        public ArrayList load_ProductsID()
        {
            ArrayList productsId = new ArrayList();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Select ProductID from Products";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productsId.Add(reader[0].ToString());

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                conn.Close();
            }
            return productsId;
        }

        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            createHoadon();
          
            foreach (Cart cart in hd._Cart)
            {
                    list.Add(cart);
            }
            dgChiTietMH.DataSource = list;
            
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            
            

        }
        public void createHoadon()
        {
            int employeeid = Session._EmployeeId;


            String productid = cBMaMatHang.Text;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "Select * From Products where ProductID=" + "'" + productid + "'";
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    if (int.Parse(txtSoluong.Text) > 0)
                        hd.insert_item_toCart(reader[0].ToString(), reader[1].ToString(), int.Parse(txtSoluong.Text), decimal.Parse(reader[3].ToString()));
                }


            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu"); }
            catch (Exception ex) { MessageBox.Show("Có lỗi sảy ra, bạn có chắc là đã thao tác đúng các bước không?", "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                conn.Close();
             
            }
        }
        public void insert_Hoadon(int employeeId, decimal total)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                String today = DateTime.Now.ToShortDateString();
                com.Connection = conn;
                com.CommandText = "insert into SellOrders(SellDate,Total,EmployeeID) values("+"'"+today+"'"+"," + "'" + total +"'"+ ","+"'" + employeeId + "')";
                com.ExecuteNonQuery();
            }

            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                writeToFile();
                conn.Close();
            }
        }
        public void insert_HoadonChitiet(int sellOrderId, String ProductId, int quantity)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "insert into SellOrderDetail(SellOrderID,ProductID,Quantity) values(" + "'" + sellOrderId + "'" + "," + "'" + ProductId + "'" + "," + "'" + quantity + "')";
                com.ExecuteNonQuery();
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { conn.Close(); }
        }

        private void BtnXoaMH_Click(object sender, EventArgs e)
        {
           
            try
            {
                hd.remove_item(dgChiTietMH.CurrentCell.FormattedValue.ToString());
                dgChiTietMH.DataSource = hd._Cart;
                txtTongTien.Text = hd.tong_HoaDon.ToString();
                dgChiTietMH.Refresh();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void BtnHoaDonMoi_Click(object sender, EventArgs e)
        {
            txtSoluong.Text = "";
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
            
        }

        private void BtnInHoaDon_Click(object sender, EventArgs e)
        {
            int employeeid = Session._EmployeeId;
            decimal total = hd.tong_HoaDon;
            insert_Hoadon(employeeid, total);
            foreach(Cart cart in hd._Cart)
            {
                insert_HoadonChitiet(select_orderid(), cart._ProductId, cart._Quantity);

            }

            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
            
            
        }
        public int select_orderid()
        {
            int result = 0;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "Select max(SellOrderID) id from SellOrders";
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    result = int.Parse(reader[0].ToString());
                }
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally {
                conn.Close();
            }
            return result;
        }

        private void cBMaMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (int)Keys.Escape)
            {
                cBMaMatHang.SelectedIndex = -1;
                cBMaMatHang.Text = "";
                controlKey = true;

            }
            else
            {
                if (char.IsControl(e.KeyChar))
                    controlKey = true;
                else
                    controlKey = false;
            }
        }

        private void cBMaMatHang_TextChanged(object sender, EventArgs e)
        {
            if (cBMaMatHang.Text != "" && !controlKey)
            {
                String matchText = cBMaMatHang.Text;
                int result = cBMaMatHang.FindString(matchText);
                if (result != -1)
                {
                    cBMaMatHang.SelectedIndex = result;
                    cBMaMatHang.SelectionStart = matchText.Length;
                    cBMaMatHang.SelectionLength = cBMaMatHang.Text.Length - cBMaMatHang.SelectionStart;
                }
            }
        }

        private void dgChiTietMH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
        private void ctMenuXoa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("ctMenudelete"))
            {
                try
                {
                    hd.remove_item(dgChiTietMH.CurrentCell.FormattedValue.ToString());
                    dgChiTietMH.DataSource = hd._Cart;
                    txtTongTien.Text = hd.tong_HoaDon.ToString();
                    dgChiTietMH.Refresh();

                }catch (Exception ex) { MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void frmLapHoaDonBanHang_Load(object sender, EventArgs e)
        {

        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void writeToFile()
        {
            String today = DateTime.Today.ToShortDateString();
            int rows = dgChiTietMH.Rows.Count;
            using (FileStream stream = new FileStream("donhang.txt", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("Siêu thị XYZ");
                    writer.WriteLine(today);
                    writer.WriteLine("Hóa đơn thanh toán");
                    writer.WriteLine("");
                    for (int i = 0; i < rows; i++)
                    {
                        String productname = dgChiTietMH.Rows[i].Cells[1].FormattedValue.ToString();
                        String soluong = dgChiTietMH.Rows[i].Cells[2].FormattedValue.ToString();
                        String gia = dgChiTietMH.Rows[i].Cells[3].FormattedValue.ToString();
                        String tong = dgChiTietMH.Rows[i].Cells[4].FormattedValue.ToString();
                        writer.WriteLine(productname + " " + soluong + " " + gia + " " + tong);
                    }
                    writer.WriteLine("Tổng tiền:"+hd.tong_HoaDon.ToString());
                    writer.WriteLine("Cảm ơn quý khách đã mua hàng tại siêu thị của chúng tôi");
                    writer.WriteLine("Nhân viên:"+ Session._EmployeeName);
                    writer.Close();
                }
                stream.Close();
            }
        }
        private void inHoaDon()
        {
            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += new PrintPageEventHandler(doc_Printpage);
                doc.Print();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
        private void doc_Printpage(object sender, PrintPageEventArgs e)
        {
            Font verdana10Font = new Font("Verdana", 10);
            StreamReader reader = new StreamReader("donhang.txt");
            Graphics g = e.Graphics;
            float linePerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            String line = null;
            linePerPage = e.MarginBounds.Height / verdana10Font.GetHeight(g);
            while (count < linePerPage && ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            int result;
            try
            {
                if (txtSoluong.Text != "")
                {
                    if (!(int.TryParse(txtSoluong.Text, out result)))
                        txtSoluong.BackColor = Color.Red;
                    else
                        txtSoluong.BackColor = Color.WhiteSmoke;
                }
            }
            catch (Exception ex) { }
        }
    }
}