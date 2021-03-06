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
    public partial class frmQuanLyLoaiHang : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        private int ID;
        public frmQuanLyLoaiHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
        }

        private void CbChungLoaiHangBinding()
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
        private void LstLoaiHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                this.ID = Convert.ToInt32(CbChungLoaiHang.SelectedValue);
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
                // MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void BtnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.ID = Int32.Parse(CbChungLoaiHang.SelectedValue.ToString());
            int CateID = Int32.Parse(LstLoaiHang.SelectedValue.ToString());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select Name from Categories Where CategoryID = @CateID AND TypeID = @TypeID";
                command.Parameters.Add("@CateID", SqlDbType.Int).Value = CateID;
                command.Parameters.Add("@TypeID", SqlDbType.Int).Value = ID;
                TxtLoaiHang.Text = (string)command.ExecuteScalar();
                TxtLoaiHang.Select();
                conn.Close();
                this.BtnSuaLoaiHang.Hide();
                this.BtnThemLoaiHang.Enabled = false;
                this.BtnXoaLoaiHang.Enabled = false;
                this.BtnCapNhatLoaiHang.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnCapNhatLoaiHang_Click(object sender, EventArgs e)
        {
            if (TxtLoaiHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên chủng loại hàng", "Norther says", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                this.ID = Int32.Parse(CbChungLoaiHang.SelectedValue.ToString());
                int CateID = Int32.Parse(LstLoaiHang.SelectedValue.ToString());

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Update Categories set Name = @Name where CategoryID = @CateID AND TypeID = @ID";
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = TxtLoaiHang.Text.ToString();
                    command.Parameters.Add("@CateID", SqlDbType.Int).Value = CateID;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                TxtLoaiHang.Text = "";
                this.BtnThemLoaiHang.Enabled = true;
                this.BtnXoaLoaiHang.Enabled = true;
                this.BtnSuaLoaiHang.Show();
                LstLoaiHangBinding();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to quit", "Norther says", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void BtnThemLoaiHang_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (TxtLoaiHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại hàng", "Norther says", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            else
            {
                this.ID = Convert.ToInt32(CbChungLoaiHang.SelectedValue);
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Insert into Categories(Name,TypeID) values(@Name,@TypeID)";
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = TxtLoaiHang.Text.ToString();
                    command.Parameters.Add("@TypeID", SqlDbType.Int).Value = ID;
                    command.ExecuteNonQuery();
                    conn.Close();
                    TxtLoaiHang.Text = "";
                    LstLoaiHangBinding();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
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
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frmCategories_Load_1(object sender, EventArgs e)
        {
            this.BtnCapNhatLoaiHang.Hide();
            CbChungLoaiHangBinding();
            LstLoaiHangBinding();
        }

        private void BtnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            int cateid = int.Parse(LstLoaiHang.SelectedValue.ToString());
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From Categories where CategoryID = " + cateid + "", conn);
                command.ExecuteNonQuery();
                conn.Close();
                LstLoaiHangBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa Loại hàng khi còn sản phẩm", "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

    }
}