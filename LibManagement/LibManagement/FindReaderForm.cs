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
    public partial class FindReaderForm : Form
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
            dgvFindReader.DataSource = dt;
        }

        public FindReaderForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit and go back to ReaderManageForm
            ReaderManageForm readerManageForm = new ReaderManageForm();
            readerManageForm.Show();
            this.Hide();
        }

        private void TimDocGiaForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

            dgvFindReader.Columns[0].HeaderText = "Mã sách";
            dgvFindReader.Columns[1].HeaderText = "Tên sách";
            dgvFindReader.Columns[2].HeaderText = "Tác giả";
            dgvFindReader.Columns[3].HeaderText = "Năm xuất bản";
            dgvFindReader.Columns[4].HeaderText = "Nhà xuất bản";
            dgvFindReader.Columns[5].HeaderText = "Ngôn ngữ";
            dgvFindReader.Columns[6].HeaderText = "Số lượng";
            dgvFindReader.Columns[7].HeaderText = "Giá tiền";
            dgvFindReader.Columns[8].HeaderText = "Thể loại";

            //set column width to 130px and the make the header text bold using loop
            for (int i = 0; i < dgvFindReader.Columns.Count; i++)
            {
                dgvFindReader.Columns[i].Width = 130;
                dgvFindReader.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvFindReader.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }
        }

        private void FindReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to ReaderManageForm
            ReaderManageForm readerManageForm = new ReaderManageForm();
            readerManageForm.Show();
            this.Close();
        }

        private void dgvFindReader_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the value from the selected row in the datagridview and pass it to the BookManageForm
            int i;
            i = dgvFindReader.CurrentRow.Index;
            DataGridViewRow row = dgvFindReader.Rows[i];
            //pass the value to the BookManageForm with the second constructor
            ReaderManageForm readerManageForm = new ReaderManageForm(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
                                                                    row.Cells[2].Value.ToString(), DateTime.Parse(row.Cells[3].Value.ToString()),
                                                                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(),
                                                                    DateTime.Parse(row.Cells[7].Value.ToString()), DateTime.Parse(row.Cells[8].Value.ToString()),
                                                                    Convert.ToInt32(row.Cells[9].Value.ToString()));
            readerManageForm.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Using the option selected in the combobox to find the reader
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string selectedCriteria = cbxOption.SelectedItem.ToString();
                    string query = "SELECT * FROM DOCGIA WHERE ";
                    string parameterName = "@SearchTerm";

                    switch (selectedCriteria)
                    {
                        case "Mã độc giả":
                            query += "MADOCGIA LIKE " + parameterName;
                            break;
                        case "Tên độc giả":
                            query += "TENDOCGIA LIKE " + parameterName;
                            break;
                        case "CMND/CCCD":
                            query += "CMND LIKE " + parameterName;
                            break;
                        case "Số điện thoại":
                            query += "SDT LIKE " + parameterName;
                            break;
                        default:
                            // Handle invalid selection
                            return;
                    }

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue(parameterName, "%" + txtFind.Text + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dt.Clear();
                        adapter.Fill(dt);
                        dgvFindReader.DataSource = dt;
                    }
                }
            }
        }
    }
}
