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
    public partial class FineManageForm : Form
    {
        //connect to database
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM THUTIEN";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dgvFineTicket.DataSource = dt;
        }
        public FineManageForm()
        {
            InitializeComponent();
        }

        private void FineManageForm_Load(object sender, EventArgs e)
        {
            //connect to database
            conn = new SqlConnection(connString.connectionString);
            conn.Open();
            loadData();

            dgvFineTicket.Columns[0].HeaderText = "Mã thu tiền";
            dgvFineTicket.Columns[1].HeaderText = "Mã độc giả";
            dgvFineTicket.Columns[2].HeaderText = "Ngày thu tiền";
            dgvFineTicket.Columns[3].HeaderText = "Số tiền thu";

            //txtTienThu.Enabled = false;
            txtMaThu.Enabled = false;

            //set column width to 130px and the make the header text bold using loop
            for (int i = 0; i < dgvFineTicket.Columns.Count; i++)
            {
                dgvFineTicket.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvFineTicket.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Using options in combobox to find
            using (SqlConnection conn = new SqlConnection(connString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string selectedCriteria = cbxOption.SelectedItem.ToString();
                    string query = "SELECT * FROM THUTIEN WHERE ";
                    string parameterName = "@SearchTerm";

                    switch (selectedCriteria)
                    {
                        case "Mã thu tiền":
                            query += "MaThuTien LIKE " + parameterName;
                            cmd.Parameters.AddWithValue(parameterName, "%" + txtMaThu.Text + "%");
                            break;
                        case "Mã độc giả":
                            query += "MaDocGia LIKE " + parameterName;
                            cmd.Parameters.AddWithValue(parameterName, "%" + txtMaDocGia.Text + "%");
                            break;
                        case "Ngày thu tiền":
                            query += "NgayThu = @NgayThu";
                            cmd.Parameters.AddWithValue("@NgayThu", dtpNgayThu.Value.Date);
                            break;
                    }
                    cmd.CommandText = query;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFineTicket.DataSource = dt;
                    }
                }
            }
        }
        private void FineManageForm_SizeChanged(object sender, EventArgs e)
        {
            dgvFineTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FineManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Go back to main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Add the data to database, use try catch to catch exception
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO THUTIEN VALUES(@MaThuTien, @MaDocGia, @NgayThu, @SoTienThu)";
                cmd.Parameters.AddWithValue("@MaThuTien", txtMaThu.Text);
                cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);
                cmd.Parameters.AddWithValue("@NgayThu", dtpNgayThu.Value.Date);
                cmd.Parameters.AddWithValue("@SoTienThu", txtTienThu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //delete the selected MaThuTine
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM THUTIEN WHERE MaThuTien = @MaThuTien";
                cmd.Parameters.AddWithValue("@MaThuTien", txtMaThu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công");
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFineTicket_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the data from the selected row to the textboxes
            int i;
            i = dgvFineTicket.CurrentRow.Index;
            txtMaThu.Text = dgvFineTicket.Rows[i].Cells[0].Value.ToString();
            txtMaDocGia.Text = dgvFineTicket.Rows[i].Cells[1].Value.ToString();
            dtpNgayThu.Text = dgvFineTicket.Rows[i].Cells[2].Value.ToString();
            txtTienThu.Text = dgvFineTicket.Rows[i].Cells[3].Value.ToString();
        }
    }
}
