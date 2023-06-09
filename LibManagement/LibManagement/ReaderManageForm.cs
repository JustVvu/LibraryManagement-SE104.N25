using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibManagement
{
    public partial class ReaderManageForm : Form
    {
        //connect to database
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            //Load data from database
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM DOCGIA";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dgvReaderManage.DataSource = dt;
        }
        public ReaderManageForm()
        {
            InitializeComponent();
        }

        //Create the constructor to pass the value from the FindReaderForm to ReaderManageForm
        public ReaderManageForm(string MaDocGia, string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string SDT, string Email, DateTime NgayLapThe, DateTime NgayHetHan, int No)
        {
            InitializeComponent();
            txtMaDocGia.Text = MaDocGia;
            txtHoTen.Text = HoTen;
            txtGioiTinh.Text = GioiTinh;
            dtNgaySinh.Value = NgaySinh;
            txtCMND.Text = CMND;
            txtSDT.Text = SDT;
            txtEmail.Text = Email;
            dtNgayLapThe.Value = NgayLapThe;
            dtNgayHetHan.Value = NgayHetHan;
            txtDebt.Text = No.ToString();
        }
        public ReaderManageForm(string MaDocGia)
        {
            this.InitializeComponent();
            //Use MaDocGia to find the reader in the database
            conn = new SqlConnection(connString.connectionString);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM DOCGIA WHERE MaDocGia = '" + MaDocGia + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtMaDocGia.Text = reader.GetInt32(0).ToString();
                txtHoTen.Text = reader.GetString(1);
                txtGioiTinh.Text = reader.GetString(2);
                dtNgaySinh.Value = reader.GetDateTime(3);
                txtCMND.Text = reader.GetString(4);
                txtSDT.Text = reader.GetString(5);
                txtEmail.Text = reader.GetString(6);
                dtNgayLapThe.Value = reader.GetDateTime(7);
                dtNgayHetHan.Value = reader.GetDateTime(8);
                txtDebt.Text = reader.GetInt32(9).ToString();
            }
            reader.Close();
            conn.Close();
        }
        private void ReaderManageForm_Closed(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void ReaderManageForm_Load(object sender, EventArgs e)
        {
            //Load database
            conn = new SqlConnection(connString.connectionString);
            conn.Open();
            loadData();

            txtMaDocGia.Enabled = false;

            txtDebt.Text = "0";
            dtNgayLapThe.Value = DateTime.Today;
            dtNgayHetHan.Value = dtNgayLapThe.Value.AddMonths(6);

            dgvReaderManage.Columns[0].HeaderText = "Mã độc giả";
            dgvReaderManage.Columns[1].HeaderText = "Họ tên";
            dgvReaderManage.Columns[2].HeaderText = "Giới tính";
            dgvReaderManage.Columns[3].HeaderText = "Ngày sinh";
            dgvReaderManage.Columns[4].HeaderText = "CMND/CCCD";
            dgvReaderManage.Columns[5].HeaderText = "Số điện thoại";
            dgvReaderManage.Columns[6].HeaderText = "Email";
            dgvReaderManage.Columns[7].HeaderText = "Ngày lập thẻ";
            dgvReaderManage.Columns[8].HeaderText = "Ngày hết hạn";
            dgvReaderManage.Columns[9].HeaderText = "Tiền nợ";
            dgvReaderManage.Columns[10].HeaderText = "Tổng phạt";

            //set width for each column to 130px and make the header text Bold using loop
            for (int i = 0; i < dgvReaderManage.Columns.Count; i++)
            {
                dgvReaderManage.Columns[i].Width = 130;
                dgvReaderManage.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvReaderManage.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }
        }

        //Check if the reader is in the database
        private bool CheckReader()
        {
            //check the reader CMND or SDT is in the database
            using (SqlConnection conn = new SqlConnection(connString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM DOCGIA WHERE CMND = @CMND OR SDT = @SDT";
                    cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            //Check if the reader is in the database, if not, add to database, show message, clear all fields, else show message
            //Check if the reader is in the database
            if (CheckReader())
            {
                MessageBox.Show("Độc giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Add reader to the database and if succeed, show the message, if not show error and reload the datagridview
            try
            {
                using (SqlConnection conn = new SqlConnection(connString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO DOCGIA (HoTen, GioiTinh, NgaySinh, CMND, SDT, Email, NgayLapThe, NgayHetHan) " +
                                          "VALUES (@HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @Email, @NgayLapThe, @NgayHetHan)";

                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NgayLapThe", dtNgayLapThe.Value.Date);
                        cmd.Parameters.AddWithValue("@NgayHetHan", dtNgayHetHan.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm độc giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //show error
                MessageBox.Show(ex.Message);
                loadData();
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE DOCGIA SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh," +
                                  "CMND = @CMND, SDT = @SDT, Email = @Email, NgayLapThe = @NgayLapThe, NgayHetHan = @NgayHetHan " +
                                  "WHERE MaDocGia = @MaDocGia";

                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NgayLapThe", dtNgayLapThe.Value.Date);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtNgayHetHan.Value.Date);
                cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa độc giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Show error
                MessageBox.Show(ex.Message);
                loadData();
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            //Confirm delete and delete reader in the database
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM DOCGIA WHERE MaDocGia = '" + txtMaDocGia.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa độc giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //show error
                    MessageBox.Show(ex.Message);
                    loadData();
                }
            }
            Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemCheck()
        {
            if (!string.IsNullOrWhiteSpace(txtHoTen.Text) &&
                txtGioiTinh.SelectedIndex != -1 &&
                !string.IsNullOrWhiteSpace(txtCMND.Text) &&
                !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void Clear()
        {
            txtMaDocGia.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtGioiTinh.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Today;
            txtCMND.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtNgayLapThe.Value = DateTime.Today;
            dtNgayHetHan.Value = dtNgayLapThe.Value.AddMonths(6);
        }
        private void dgvReaderManage_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load data from dgv to fields
            txtMaDocGia.Text = dgvReaderManage.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvReaderManage.CurrentRow.Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvReaderManage.CurrentRow.Cells[2].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dgvReaderManage.CurrentRow.Cells[3].Value.ToString());
            txtCMND.Text = dgvReaderManage.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dgvReaderManage.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvReaderManage.CurrentRow.Cells[6].Value.ToString();
            dtNgayLapThe.Value = Convert.ToDateTime(dgvReaderManage.CurrentRow.Cells[7].Value.ToString());
            dtNgayHetHan.Value = Convert.ToDateTime(dgvReaderManage.CurrentRow.Cells[8].Value.ToString());
            txtDebt.Text = dgvReaderManage.CurrentRow.Cells[9].Value.ToString();
        }
        private void MaDocGia_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }
        private void HoTen_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void CMND_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void NgayLapThe_ValueChanged(object sender, EventArgs e)
        {
            dtNgayHetHan.Value = dtNgayLapThe.Value.AddMonths(6);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //Open FindReaderForm
            FindReaderForm findReaderForm = new FindReaderForm();
            findReaderForm.Show();
            this.Hide();
        }
    }
}
