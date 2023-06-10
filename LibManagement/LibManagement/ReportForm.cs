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

    public partial class ReportForm : Form
    {
        //connect to database
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public ReportForm()
        {
            InitializeComponent();
        }

        void LoadInfo(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connString.connectionString))
            {
                conn.Open();

                int month = date.Month;
                int year = date.Year;

                // Calculate the Total number of Readers
                string query = "SELECT COUNT(DISTINCT MADOCGIA) FROM DOCGIA WHERE MONTH(NgayLapThe) = @month AND YEAR(NgayLapThe) = @year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    int totalReader = (int)cmd.ExecuteScalar();
                    txtTotalReader.Text = totalReader.ToString();
                }

                // Calculate the number of New Readers
                query = "SELECT COUNT(DISTINCT MADOCGIA) FROM DOCGIA WHERE MONTH(NgayLapThe) = @month AND YEAR(NgayLapThe) = @year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    int newReader = (int)cmd.ExecuteScalar();
                    txtNewReader.Text = newReader.ToString();
                }

                // Calculate the number of Expired Readers
                query = "SELECT COUNT(DISTINCT MADOCGIA) FROM DOCGIA WHERE MONTH(NgayHetHan) = @month AND YEAR(NgayHetHan) = @year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    int expiredReader = (int)cmd.ExecuteScalar();
                    txtExpiredReader.Text = expiredReader.ToString();
                }

                // Calculate the number of Borrowed Books
                query = "SELECT COUNT(DISTINCT MASACH) FROM MUONSACH WHERE MONTH(NgayMuon) = @month AND YEAR(NgayMuon) = @year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    int lentBook = (int)cmd.ExecuteScalar();
                    txtLentBook.Text = lentBook.ToString();
                }

                // Calculate the number of Returned Books
                query = "SELECT COUNT(DISTINCT MAMUONSACH) FROM TRASACH WHERE MONTH(NgayTra) = @month AND YEAR(NgayTra) = @year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    int returnedBook = (int)cmd.ExecuteScalar();
                    txtReturnedBook.Text = returnedBook.ToString();
                }

                // Calculate the most borrowed book in the given month
                query = @"SELECT TOP 1 M.MaSach, S.TenSach
                FROM MUONSACH M
                INNER JOIN SACH S ON M.MaSach = S.MaSach
                WHERE MONTH(M.NgayMuon) = @month AND YEAR(M.NgayMuon) = @year
                GROUP BY M.MaSach, S.TenSach
                ORDER BY COUNT(*) DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string bookName = reader["TenSach"].ToString();
                        txtTopBook.Text = bookName;
                    }
                    else
                    {
                        txtTopBook.Text = "Không có dữ liệu";
                    }
                }
            }
        }


        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadInfo(dtpReport.Value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
