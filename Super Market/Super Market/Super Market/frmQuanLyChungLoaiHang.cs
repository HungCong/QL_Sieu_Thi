private void BtnXoaChungLoai_Click(object sender, EventArgs e)
{
    if (conn.State == ConnectionState.Open)
    {
        conn.Close();
    }
    try
    {
        ID = Convert.ToInt32(LstProductTypes.SelectedValue);
        conn.Open();
        SqlCommand command = new SqlCommand();
        command.Connection = conn;
        command.CommandType = CommandType.Text;
        command.CommandText = "DELETE FROM Types where TypeID =" + ID + "";
        command.ExecuteNonQuery();
        conn.Close();
        TypeBinDing();

    }
    catch (Exception ex)
    {
        MessageBox.Show("Bạn không thể xóa khi còn chủng loại hàng", "Norther says", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
    }
}
private void frmTypes_Load(object sender, EventArgs e)
{
    this.BtnCapNhatChungLoai.Hide();
    TypeBinDing();

    // 
}

private void BtnSuaChungLoai_Click(object sender, EventArgs e)
{
    this.BtnThemChungLoai.Enabled = false;
    this.BtnXoaChungLoai.Enabled = false;
    if (conn.State == ConnectionState.Open)
    {
        conn.Close();
    }
    try
    {
        conn.Open();
        ID = Convert.ToInt32(LstProductTypes.SelectedValue);
        this.BtnSuaChungLoai.Hide();
        SqlCommand command = new SqlCommand("Select Name from Types where TypeID = @ID", conn);
        command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
        TxtChungLoai.Text = (string)command.ExecuteScalar();
        TxtChungLoai.SelectAll();
        conn.Close();
        this.BtnCapNhatChungLoai.Show();
    }
    catch (SqlException ex)
    {
        MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    }
}
private void BtnCapNhatChungLoai_Click_1(object sender, EventArgs e)
{
    if (conn.State == ConnectionState.Open)
    {
        conn.Close();
    }
    try
    {
        conn.Open();
        SqlCommand command = new SqlCommand("Update Types set Name = @Name where TypeID = @ID", conn);
        command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = TxtChungLoai.Text;
        command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
        command.ExecuteNonQuery();
        TxtChungLoai.Text = "";
        BtnSuaChungLoai.Show();
        this.BtnXoaChungLoai.Enabled = true;
        this.BtnThemChungLoai.Enabled = true;
        conn.Close();
        TypeBinDing();
        this.BtnCapNhatChungLoai.Hide();
    }
    catch (SqlException ex)
    {
        MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    }
}