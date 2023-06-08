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

namespace LibManagement
{
    public partial class TicketManageForm : Form
    {
        //Connect to database
        SqlConnection conn;
        SqlCommand cmd;
        string connectionString = "Data Source=VU-NGUYEN;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            //Load data in the database
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM MUONSACH";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dgvMuonSach.DataSource = dt;
        }

        public TicketManageForm()
        {
            InitializeComponent();
        }

        //Create a constructor to pass the value from the FindTicketForm to this form
        public TicketManageForm(string MaPhieu, string MaDocGia, string MaSach, string NgayMuon, string NgayTra)
        {
            InitializeComponent();
            txtMaMuonSach.Text = MaPhieu;
            txtMaDocGia.Text = MaDocGia;
            txtMaSach.Text = MaSach;
            dtpNgayMuon.Value = Convert.ToDateTime(NgayMuon);
            dtpNgayTra.Value = Convert.ToDateTime(NgayTra);
        }
        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            //Connect to database and load data to datagridview
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

            txtMaMuonSach.Enabled = false;
            btnThoat.Enabled = false;

            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = dtpNgayMuon.Value.AddDays(7);

            dgvMuonSach.Columns[0].HeaderText = "Mã mượn sách";
            dgvMuonSach.Columns[1].HeaderText = "Mã độc giả";
            dgvMuonSach.Columns[2].HeaderText = "Mã sách";
            dgvMuonSach.Columns[3].HeaderText = "Ngày mượn";
            dgvMuonSach.Columns[4].HeaderText = "Ngày trả";

            //set column width to 130px and the make the header text bold using loop
            for (int i = 0; i < dgvMuonSach.Columns.Count; i++)
            {
                dgvMuonSach.Columns[i].Width = 150;
                dgvMuonSach.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvMuonSach.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }
        }
        private void BorrowBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        void Clear()
        {
            txtMaSach.Enabled = true;
            txtMaDocGia.Enabled = true;

            txtMaMuonSach.Text = "";
            txtMaSach.Text = "";
            txtMaDocGia.Text = "";
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = dtpNgayMuon.Value.AddDays(7);
        }
        private void dgvPhieuMuon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get data from datagridview to textbox
            txtMaMuonSach.Text = dgvMuonSach.CurrentRow.Cells[0].Value.ToString();
            txtMaDocGia.Text = dgvMuonSach.CurrentRow.Cells[1].Value.ToString();
            txtMaSach.Text = dgvMuonSach.CurrentRow.Cells[2].Value.ToString();
            dtpNgayMuon.Value = Convert.ToDateTime(dgvMuonSach.CurrentRow.Cells[3].Value.ToString());
            dtpNgayTra.Value = Convert.ToDateTime(dgvMuonSach.CurrentRow.Cells[4].Value.ToString());
            
            txtMaSach.Enabled = false;
            txtMaDocGia.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Add new borrow books
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO MUONSACH VALUES(@MaDocGia, @MaSach, @NgayMuon, @NgayTra)";
                cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);
                cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                cmd.ExecuteNonQuery();

                loadData();
                MessageBox.Show("Thêm phiếu mượn thành công");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm phiếu mượn không thành công");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Delete borrow books
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM MUONSACH WHERE MaMuonSach = @MaPhieu";
                cmd.Parameters.AddWithValue("@MaPhieu", txtMaMuonSach.Text);
                cmd.ExecuteNonQuery();

                loadData();
                MessageBox.Show("Xóa phiếu mượn thành công");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa phiếu mượn không thành công");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Open FindTicketForm
            FindTicketForm findTicketForm = new FindTicketForm();
            findTicketForm.Show();
            this.Hide();
        }
    }
}
