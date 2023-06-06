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
    public partial class FindBookForm : Form
    {
        //connect to database
        SqlConnection conn;
        SqlCommand cmd;
        string connectionString = "Data Source=VU-NGUYEN;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM SACH";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dgvBookFind.DataSource = dt;
        }
        public FindBookForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit this form and open the BookManageForm
            BookManageForm bookManageForm = new BookManageForm();
            bookManageForm.Show();
            this.Hide();
        }

        private void FindBookForm_Load(object sender, EventArgs e)
        {
            //connect to database
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Using the option in combobox to find the book
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string selectedCriteria = cmbOption.SelectedItem.ToString();
                    string query = "SELECT * FROM SACH WHERE ";
                    string parameterName = "@SearchTerm";

                    switch (selectedCriteria)
                    {
                        case "Mã sách":
                            query += "MASACH LIKE " + parameterName;
                            break;
                        case "Tên sách":
                            query += "TENSACH LIKE " + parameterName;
                            break;
                        case "Tác giả":
                            query += "TACGIA LIKE " + parameterName;
                            break;
                        case "Nhà xuất bản":
                            query += "NHAXB LIKE " + parameterName;
                            break;
                        case "Năm xuất bản":
                            query += "NAMXB LIKE " + parameterName;
                            break;
                        case "Thể loại":
                            query += "THELOAI LIKE " + parameterName;
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
                        dgvBookFind.DataSource = dt;
                    }
                }
            }

        }

        private void FindBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to mainform
        }

        private void dgvBookFind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the value from the selected row in the datagridview and pass it to the BookManageForm
            int i;
            i = dgvBookFind.CurrentRow.Index;
            DataGridViewRow row = dgvBookFind.Rows[i];
            BookManageForm bookManageForm = new BookManageForm(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), Convert.ToInt32(row.Cells[6].Value.ToString()), Convert.ToInt32(row.Cells[7].Value.ToString()), row.Cells[8].Value.ToString());
            bookManageForm.Show();
            this.Hide();
        }
    }
}
