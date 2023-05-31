using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagement
{
    public partial class BookManageForm : Form
    {
        public BookManageForm()
        {
            InitializeComponent();
        }

        private void BookManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to Mainform
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        void DeActivate()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
        void Activate()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }
        bool CheckEmpty()
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Mã sách trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
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
                MessageBox.Show("Ngôn ngũ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtYear.Text == "")
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
        private void BookManageForm_Load(object sender, EventArgs e)
        {
            //When the form is loaded, the btnAdd, btnEdit, btnDelete buttons are deactivated
            DeActivate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //When click Save button, check if the textboxes are empty and show the message "<label> trống"
            CheckEmpty();
        }
    }
}
