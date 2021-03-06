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
            ListEmployeeInfo();
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListEmployeeInfo()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                DataSet ds = new DataSet("Employees");
                SqlDataAdapter da = new SqlDataAdapter("Select EmployeeID,EmployeeName from Employees", conn);
                da.Fill(ds);
                LstHoTen.DataSource = ds.Tables[0];
                LstHoTen.DisplayMember = "EmployeeName";
                LstHoTen.ValueMember = "EmployeeID";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GetEmployeeInfo()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                int EmployeeID = Convert.ToInt32(LstHoTen.SelectedValue.ToString());
                SqlCommand command = new SqlCommand("Select EmployeeName,Title,DateOfBirth,Sex,IDCard,Address,Tel,JoinDate,Username,Password,Picture from Employees where EmployeeID = " + EmployeeID + " ", conn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employees");
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    TxtName.Text = ds.Tables[0].Rows[i - 1]["EmployeeName"].ToString();
                    TxtUsername.Text = ds.Tables[0].Rows[i - 1]["Username"].ToString();
                    TxtPassword.Text = ds.Tables[0].Rows[i - 1]["Password"].ToString();
                    dtPickerNgaysinh.Text = ds.Tables[0].Rows[i - 1]["DateOfBirth"].ToString();
                    CbChucVu.Text = ds.Tables[0].Rows[i - 1]["Title"].ToString();
                    CbGioiTinh.Text = ds.Tables[0].Rows[i - 1]["Sex"].ToString();
                    TxtCMND.Text = ds.Tables[0].Rows[i - 1]["IDCard"].ToString();
                    TxtDiachi.Text = ds.Tables[0].Rows[i - 1]["Address"].ToString();
                    TxtDienThoai.Text = ds.Tables[0].Rows[i - 1]["Tel"].ToString();
                    dtPickerNgayVaoLam.Text = ds.Tables[0].Rows[i - 1]["JoinDate"].ToString();
                    byte[] imageData = new byte[0];
                    imageData = (byte[])(ds.Tables[0].Rows[i - 1]["Picture"]);
                    MemoryStream ms = new MemoryStream(imageData);
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = Image.FromStream(ms);
                    ms.Close();

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message,"Norther says",MessageBoxButtons.OK,MessageBoxIcon.Warning)
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\images\none.jpg");

            }
            finally
            {
                conn.Close();
            }
        }
        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmTNV = new frmThemNhanVien();
            frmTNV.Show();
        }

        private void LstHoTen_SelectedValueChanged(object sender, EventArgs e)
        {
            GetEmployeeInfo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All files|*.*|Bitmaps|*.bmpp|JPEG|*.jpg|Gifs|*.Gif";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            DialogResult = MessageBox.Show("Are you sure want to delete", "Norther says", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Delete from Employees where EmployeeID = @Em", conn);
                    command.Parameters.Add("@Em", SqlDbType.Int).Value = int.Parse(LstHoTen.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    conn.Close();
                    ListEmployeeInfo();
                    LstHoTen.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                int EmployeeID = int.Parse(LstHoTen.SelectedValue.ToString());
                conn.Open();
                SqlCommand command = new SqlCommand("Update Employees set EmployeeName = @p1,Title =@p2,DateOfBirth=@p3,Sex=@p4,IDCard=@p5,Address=@p6,Tel=@p7,JoinDate=@p8,Username=@p9,Password=@p10,Picture=@p11 where EmployeeID = @Em", conn);
                command.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = TxtName.Text.ToString();
                command.Parameters.Add("@p2", SqlDbType.NVarChar, 50).Value = CbChucVu.Text.ToString();
                command.Parameters.Add("@p3", SqlDbType.DateTime).Value = dtPickerNgaysinh.Text;
                command.Parameters.Add("@p4", SqlDbType.NVarChar, 10).Value = CbGioiTinh.Text.ToString();
                command.Parameters.Add("@p5", SqlDbType.Int).Value = int.Parse(TxtCMND.Text.ToString());
                command.Parameters.Add("@p6", SqlDbType.NVarChar, 50).Value = TxtDiachi.Text.ToString();
                command.Parameters.Add("@p7", SqlDbType.NChar, 10).Value = TxtDienThoai.Text.ToString();
                command.Parameters.Add("@p8", SqlDbType.DateTime).Value = dtPickerNgayVaoLam.Text;
                command.Parameters.Add("@p9", SqlDbType.NChar, 10).Value = TxtUsername.Text.ToString();
                command.Parameters.Add("@p10", SqlDbType.NChar, 10).Value = TxtPassword.Text.ToString();
                command.Parameters.Add("@Em", SqlDbType.Int).Value = EmployeeID;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] imageData = ms.GetBuffer();
                command.Parameters.Add("@p11", SqlDbType.Image).Value = imageData;
                ms.Close();
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thay đổi thành công", "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetEmployeeInfo();
                ListEmployeeInfo();
                conn.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void LstHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}