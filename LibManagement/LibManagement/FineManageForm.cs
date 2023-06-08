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
        string connectionString = "Data Source=VU-NGUYEN;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MUONSACH.MaMuonSach, MUONSACH.MaDocGia, MUONSACH.HanTra, TRASACH.NgayTra, TRASACH.TienPhat " +
                                "FROM MUONSACH INNER JOIN TRASACH ON MUONSACH.MaMuonSach = TRASACH.MaMuonSach";
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
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

            dgvFineTicket.Columns[0].HeaderText = "Mã mượn sách";
            dgvFineTicket.Columns[1].HeaderText = "Mã độc giả";
            dgvFineTicket.Columns[2].HeaderText = "Ngày trả đăng kí";
            dgvFineTicket.Columns[3].HeaderText = "Ngày trả thực tế";
            dgvFineTicket.Columns[4].HeaderText = "Tiền phạt";

            txtFine.Enabled = false;
            txtMaMuonSach.Enabled = false;

            //set column width to 130px and the make the header text bold using loop
            for (int i = 0; i < dgvFineTicket.Columns.Count; i++)
            {
                dgvFineTicket.Columns[i].Width = 130;
                dgvFineTicket.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvFineTicket.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Find the fine ticket by MaDocGia
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MUONSACH.MaMuonSach, MUONSACH.MaDocGia, MUONSACH.HanTra, TRASACH.NgayTra, TRASACH.TienPhat " +
                                "FROM MUONSACH INNER JOIN TRASACH ON MUONSACH.MaMuonSach = TRASACH.MaMuonSach " +
                                "WHERE MUONSACH.MaDocGia = @MaDocGia";
            cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);
            adapter = new SqlDataAdapter(cmd);
            loadData();
        }
    }
}
