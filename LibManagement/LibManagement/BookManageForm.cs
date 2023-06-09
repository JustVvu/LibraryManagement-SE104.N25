﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibManagement
{
    public partial class BookManageForm : Form
    {
        //connect to database
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        void loadData()
        {
            //Load data in the database
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM SACH";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            dgvBookManage.DataSource = dt;
        }

        void ClearTextBox()
        {
            txtBookID.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            dtpYear.Value = DateTime.Now;
            txtPublisher.Clear();
            txtLanguage.Clear();
            txtQuantity.Clear();
            txtValue.Clear();
            txtGenre.Clear();
        }
        bool CheckEmpty()
        {
            if (txtBookName.Text == "")
            {
                MessageBox.Show("Tên sách trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtAuthor.Text == "")
            {
                MessageBox.Show("Tên tác giả trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtPublisher.Text == "")
            {
                MessageBox.Show("Nhà xuất bản trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtGenre.Text == "")
            {
                MessageBox.Show("Thể loại trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtLanguage.Text == "")
            {
                MessageBox.Show("Ngôn ngữ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (dtpYear.Text == "")
            {
                MessageBox.Show("Năm xuất bản trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Số lượng sách trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        bool CheckBookExist()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM SACH WHERE MaSach = '" + txtBookID.Text + "'";
            adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public BookManageForm()
        {
            InitializeComponent();
        }

        //Create the constructor to pass the value from the FindBook form to this form
        public BookManageForm(string bookID, string bookName, string author, string year, string publisher, string language, int quantity, int value, string genre)
        {
            InitializeComponent();

            txtBookID.Text = bookID;
            txtBookName.Text = bookName;
            txtAuthor.Text = author;
            txtPublisher.Text = publisher;

            string dateString = year;
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy", CultureInfo.InvariantCulture);
            dtpYear.Value = parsedDate;

            txtLanguage.Text = language;
            txtQuantity.Text = quantity.ToString();
            txtValue.Text = value.ToString();
            txtGenre.Text = genre;
        }

        private void BookManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to Mainform
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void BookManageForm_Load(object sender, EventArgs e)
        {
            //Connect to database and load data to datagridview
            conn = new SqlConnection(connString.connectionString);
            conn.Open();
            loadData();

            txtBookID.Enabled = false;

            dgvBookManage.Columns[0].HeaderText = "Mã sách";
            dgvBookManage.Columns[1].HeaderText = "Tên sách";
            dgvBookManage.Columns[2].HeaderText = "Tác giả";
            dgvBookManage.Columns[3].HeaderText = "Năm xuất bản";
            dgvBookManage.Columns[4].HeaderText = "Nhà xuất bản";
            dgvBookManage.Columns[5].HeaderText = "Ngôn ngữ";
            dgvBookManage.Columns[6].HeaderText = "Số lượng";
            dgvBookManage.Columns[7].HeaderText = "Giá tiền";
            dgvBookManage.Columns[8].HeaderText = "Thể loại";

            //Set the width of the columns to 130px and make the header text bold using loop
            for (int i = 0; i < dgvBookManage.Columns.Count; i++)
            {
                dgvBookManage.Columns[i].Width = 130;
                dgvBookManage.Columns[i].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
                dgvBookManage.Columns[i].DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            }
        }
        private void dgvBookManage_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //When double click on a row in datagridview, the data of that row will be loaded to the textboxes
            int i;
            i = dgvBookManage.CurrentRow.Index;
            txtBookID.Text = dgvBookManage.Rows[i].Cells[0].Value.ToString();
            txtBookName.Text = dgvBookManage.Rows[i].Cells[1].Value.ToString();
            txtAuthor.Text = dgvBookManage.Rows[i].Cells[2].Value.ToString();

            string dateString = dgvBookManage.Rows[i].Cells[3].Value?.ToString();
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy", CultureInfo.InvariantCulture);
            dtpYear.Value = parsedDate;

            txtPublisher.Text = dgvBookManage.Rows[i].Cells[4].Value.ToString();
            txtLanguage.Text = dgvBookManage.Rows[i].Cells[5].Value.ToString();
            txtQuantity.Text = dgvBookManage.Rows[i].Cells[6].Value.ToString();
            txtValue.Text = dgvBookManage.Rows[i].Cells[7].Value.ToString();
            txtGenre.Text = dgvBookManage.Rows[i].Cells[8].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Open FindBookForm
            FindBookForm findBookForm = new FindBookForm();
            findBookForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                return;
            }
            //Check if the book is in the database
            if (CheckBookExist()){
                MessageBox.Show("Sách đã có trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Add the book to the database and if succeed, show the message, if not show error and reload the datagridview
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO SACH ( TenSach, TacGia, NamXB, NhaXB, NgonNgu, SoLuong, TriGia, TheLoai)" +
                                    "VALUES (@BookName, @Author, @Year, @Publisher, @Language, @Quantity, @Value, @Genre)";

                // Set parameter values
                cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@Year", dtpYear.Text);
                cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@Language", txtLanguage.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@Value", txtValue.Text);
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //show error
                MessageBox.Show(ex.Message);
                loadData();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Confirm to delete the book first, if yes, delete the book in the database
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM SACH WHERE MaSach = '" + txtBookID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                loadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Edit the book in the database
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE SACH SET TenSach = @TenSach, TacGia = @TacGia, NamXB = @NamXuatBan, NhaXB = @NhaXuatBan, NgonNgu = @NgonNgu, SoLuong = @SoLuong, TriGia = @TriGia, TheLoai = @TheLoai WHERE MaSach = @MaSach";

                cmd.Parameters.AddWithValue("@TenSach", txtBookName.Text);
                cmd.Parameters.AddWithValue("@TacGia", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@NamXuatBan", dtpYear.Text);
                cmd.Parameters.AddWithValue("@NhaXuatBan", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@NgonNgu", txtLanguage.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@TriGia", txtValue.Text);
                cmd.Parameters.AddWithValue("@TheLoai", txtGenre.Text);
                cmd.Parameters.AddWithValue("@MaSach", txtBookID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Show error
                MessageBox.Show(ex.Message);
                loadData();
            }

        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
