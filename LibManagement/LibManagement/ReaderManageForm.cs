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
        SqlConnection conn;
        SqlCommand cmd;
        string connectionString = "Data Source=VU-NGUYEN;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM DOCGIA";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public ReaderManageForm()
        {
            InitializeComponent();
        }

        private void ReaderManageForm_Load(object sender, EventArgs e)
        {
            //Load database
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

            dtNgayLapThe.Value = DateTime.Today;
            dtNgayHetHan.Value = dtNgayLapThe.Value.AddMonths(6);
            DeActivate();
        }

        private void ReaderManageForm_Closed(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            //
            Clear();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            //
            Clear();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            //
            Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeActivate()
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
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
            txtCMND.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtNgayLapThe.Value = DateTime.Today;
            dtNgayHetHan.Value = dtNgayLapThe.Value.AddMonths(6);
            DeActivate();
        }

        private void MaDocGia_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
            //If MaDocGia in database,
            //  lock all other fields and auto fill, 
            //  unlock Sua, Xoa, GiaHan, 
            //  else reset other fields and lock Sua Xoa GiaHan.
        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void CMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.Text.Length != 12 || txtCMND.Text.Length != 9 || !string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("CMND không hợp lệ.", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.BackColor = Color.LightPink;
            }
            else
            {
                txtCMND.BackColor = SystemColors.Window;
                ThemCheck();
            }
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
