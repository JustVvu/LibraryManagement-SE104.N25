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
    public partial class ReturnBookForm : Form
    {
        //Connect to database
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        void loadData()
        {
            //Load data in the database
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MUONSACH.MaMuonSach, MUONSACH.MaDocGia, MUONSACH.HanTra, TRASACH.NgayTra, TRASACH.TienPhat " +
                                "FROM MUONSACH " +
                                "INNER JOIN TRASACH ON MUONSACH.MaMuonSach = TRASACH.MaMuonSach";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dgvTraSach.DataSource = dt;
        }
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            //Connect to database and load data to dgvTraSach
            conn = new SqlConnection(connString.connectionString);
            conn.Open();
            loadData();

            txtTienPhat.Enabled = false;
            txtMaDocGia.Enabled = false;
            dtpHanTra.Enabled = false;

            dgvTraSach.Columns[0].HeaderText = "Mã mượn sách";
            dgvTraSach.Columns[1].HeaderText = "Mã độc giả";
            dgvTraSach.Columns[2].HeaderText = "Ngày trả sách đăng kí";
            dgvTraSach.Columns[3].HeaderText = "Ngày trả sách thực tế";
            dgvTraSach.Columns[4].HeaderText = "Tiền phạt";

            //Set the width of each column to 150px, using loop
            for (int i = 0; i < dgvTraSach.Columns.Count; i++)
            {
                dgvTraSach.Columns[i].Width = 150;
                dgvTraSach.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTraSach.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvTraSach.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            }
        }
        void Clear()
        {
            txtMaMuonSach.Clear();
            txtMaDocGia.Clear();
            txtTienPhat.Clear();
            dtpNgayTra.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now;

            txtMaMuonSach.Enabled = true;
        }
        private void dgvTraSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the data from dgvTraSach to the textboxes
            int i;
            i = dgvTraSach.CurrentRow.Index;
            txtMaMuonSach.Text = dgvTraSach.Rows[i].Cells[0].Value.ToString();
            txtMaDocGia.Text = dgvTraSach.Rows[i].Cells[1].Value.ToString();
            dtpHanTra.Value = Convert.ToDateTime(dgvTraSach.Rows[i].Cells[2].Value.ToString());
            dtpNgayTra.Value = Convert.ToDateTime(dgvTraSach.Rows[i].Cells[3].Value.ToString());
            txtTienPhat.Text = dgvTraSach.Rows[i].Cells[4].Value.ToString();

            txtMaMuonSach.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //add all the data to TRASACH table using try catch
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO TRASACH VALUES(@MaMuonSach, @NgayTra, @TienPhat)";
                cmd.Parameters.AddWithValue("@MaMuonSach", txtMaMuonSach.Text);
                cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                cmd.Parameters.AddWithValue("@TienPhat", txtTienPhat.Text);
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Thêm thành công!");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //edit the NgayTra of TRASACH table
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE TRASACH SET NgayTra = @NgayTra WHERE MaMuonSach = @MaMuonSach";
            cmd.Parameters.AddWithValue("@MaMuonSach", txtMaMuonSach.Text);
            cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //confirm the delete action
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //delete the data from TRASACH table and show message if succeed or not
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM TRASACH WHERE MaMuonSach = @MaMuonSach";
                cmd.Parameters.AddWithValue("@MaMuonSach", txtMaMuonSach.Text);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Go back to the main form
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //Use MaDocGia to get the data from DOCGIA table
            ReaderManageForm readerManageForm = new ReaderManageForm(txtMaDocGia.Text);
            readerManageForm.Show();
            this.Hide();
        }
    }
}
