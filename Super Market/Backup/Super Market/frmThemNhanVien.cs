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
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Insert into Employees(EmployeeName,Title,DateOfBirth,Sex,IDCard,Address,Tel,Username,Password,Picture) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",conn);
                command.Parameters.Add("@p1",SqlDbType.NVarChar, 50).Value = TxtFullName.Text;
                command.Parameters.Add("@p2",SqlDbType.NVarChar,50).Value = CbChucVu.Text;
                command.Parameters.Add("@p3",SqlDbType.DateTime).Value = dtPickerNS.Text;
                command.Parameters.Add("@p4",SqlDbType.NChar,10).Value = CbGioiTinh.Text;
                command.Parameters.Add("@p5",SqlDbType.Int).Value = int.Parse(TxtCMND.Text.ToString());
                command.Parameters.Add("@p6",SqlDbType.NVarChar,100).Value = TxtDiaChi.Text;
                command.Parameters.Add("@p7",SqlDbType.NChar,10).Value = TxtDienThoai.Text;
                command.Parameters.Add("@p8",SqlDbType.NChar,10).Value = TxtUsername.Text;
                command.Parameters.Add("@p9",SqlDbType.NChar,10).Value = TxtPassword.Text;
                //create image from path
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] imageData = ms.GetBuffer();
                ms.Close();
                command.Parameters.Add("@p10",SqlDbType.Image).Value = imageData;
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thành công","Norther says",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Norther says",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/";
            openFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        
    }
}