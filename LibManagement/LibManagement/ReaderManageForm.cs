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
        string connectionString = "Data Source=VU-NGUYEN;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
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
        private void ReaderManageForm_Closed(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void ReaderManageForm_Load(object sender, EventArgs e)
        {
            //Load database
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

            txtDebt.Text = "0";
            dtNgayLapThe.Value = DateTime.Today;
            dtNgayHetHan.Value = dtNgayLapThe.Value.AddMonths(6);
        }

        //Check if the reader is in the database
        private bool CheckReader()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM DOCGIA WHERE MaDocGia = '" + txtMaDocGia.Text + "'";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO DOCGIA (MaDocGia, HoTen, GioiTinh, NgaySinh, CMND, SDT, Email, NgayLapThe, NgayHetHan, TienNo, TongPhat) " +
                                          "VALUES (@MaDocGia, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @Email, @NgayLapThe, @NgayHetHan, @TienNo, @TongPhat)";

                        cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NgayLapThe", dtNgayLapThe.Value.Date);
                        cmd.Parameters.AddWithValue("@NgayHetHan", dtNgayHetHan.Value.Date);
                        cmd.Parameters.AddWithValue("@TienNo", Convert.ToInt32(txtDebt.Text));
                        cmd.Parameters.AddWithValue("@TongPhat", Convert.ToInt32(txtDebt.Text));

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
                                  "TienNo = @TienNo, WHERE MaDocGia = @MaDocGia";

                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NgayLapThe", dtNgayLapThe.Value.Date);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtNgayHetHan.Value.Date);
                cmd.Parameters.AddWithValue("@TienNo", Convert.ToInt32(txtDebt.Text));
                cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa độc giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Show error
                MessageBox.Show(ex.Message);
                loadData();
            }

            Clear();

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
    }
}
