using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagement
{
    public partial class FindTicketForm : Form
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
            dgvFindTicket.DataSource = dt;
        }

        public FindTicketForm()
        {
            InitializeComponent();
        }
        private void FindTicket_Load(object sender, EventArgs e)
        {
            //Connect to database and load data to datagridview
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

            dgvFindTicket.Columns[0].HeaderText = "Mã mượn sách";
            dgvFindTicket.Columns[1].HeaderText = "Mã độc giả";
            dgvFindTicket.Columns[2].HeaderText = "Mã sách";
            dgvFindTicket.Columns[3].HeaderText = "Ngày mượn";
            dgvFindTicket.Columns[4].HeaderText = "Ngày trả";

            for (int i = 0; i < dgvFindTicket.Columns.Count; i++)
            {
                dgvFindTicket.Columns[i].Width = 130;
                dgvFindTicket.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvFindTicket.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }

            //If the option in comboBox is option 4 or 5, dtpFind will be visible and txtFind will be invisible
            if (cbxOption.SelectedIndex == 3 || cbxOption.SelectedIndex == 4)
            {
                dtpFind.Visible = true;
                txtFind.Visible = false;
            }
            else
            {
                dtpFind.Visible = false;
                txtFind.Visible = true;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            // Using the option in the combobox to find the ticket
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string selectedCriteria = cbxOption.SelectedItem.ToString();
                    string query = "SELECT * FROM MUONSACH WHERE ";
                    string parameterName = "@SearchTerm";
                    switch (selectedCriteria)
                    {
                        case "Mã phiếu":
                            query += "MaMuonSach LIKE " + parameterName;
                            break;
                        case "Mã sách":
                            query += "MaSach LIKE " + parameterName;
                            break;
                        case "Mã độc giả":
                            query += "MaDocGia LIKE " + parameterName;
                            break;
                        case "Ngày mượn":
                            query += "CONVERT(date, NgayMuon) = CONVERT(date, " + parameterName + ")";
                            break;
                        case "Ngày trả":
                            query += "CONVERT(date, NgayTra) = CONVERT(date, " + parameterName + ")";
                            break;
                        default:
                            // Handle invalid selection
                            return;
                    }
                    cmd.CommandText = query;
                    if (selectedCriteria == "Ngày mượn" || selectedCriteria == "Ngày trả")
                    {
                        cmd.Parameters.AddWithValue(parameterName, dtpFind.Value.Date);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(parameterName, "%" + txtFind.Text + "%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dt.Clear();
                        adapter.Fill(dt);
                        dgvFindTicket.DataSource = dt;
                    }
                }
            }
        }

        private void dgvFindTicket_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //When double click on a row, the data will be loaded to TicketManageForm
            int i;
            i = dgvFindTicket.CurrentRow.Index;
            DataGridViewRow row = dgvFindTicket.Rows[i];
            TicketManageForm ticketManageForm = new TicketManageForm(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
            ticketManageForm.Show();
            this.Hide();
        }
    }
}
