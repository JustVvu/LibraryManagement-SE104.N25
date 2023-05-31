using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibManagement
{
    public partial class ReaderManageForm : Form
    {
        public ReaderManageForm()
        {
            InitializeComponent();
        }

        private void ReaderManageForm_Load(object sender, EventArgs e)
        {
            NgayLapThe.Value = DateTime.Today;
            NgayHetHan.Value = NgayLapThe.Value.AddMonths(6);
            DeActivate();
        }

        private void ReaderManageForm_Closed(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            //
            Clear();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            //
            Clear();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            //
            Clear();
        }

        private void GiaHan_Click(object sender, EventArgs e)
        {
            NgayHetHan.Value.AddMonths(6);
            //save
            Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeActivate()
        {
            Them.Enabled = false;
            Xoa.Enabled = false;
            Sua.Enabled = false;
            GiaHan.Enabled = false;
        }

        private void ThemCheck()
        {
            if (!string.IsNullOrWhiteSpace(HoTen.Text) &&
                GioiTinh.SelectedIndex != -1 &&
                !string.IsNullOrWhiteSpace(CMND.Text) &&
                !string.IsNullOrWhiteSpace(SDT.Text))
            {
                Them.Enabled = true;
            }
            else
            {
                Them.Enabled = false;
            }
        }

        private void Clear()
        {
            MaDocGia.Text = string.Empty;
            HoTen.Text = string.Empty;
            GioiTinh.SelectedIndex = -1;
            CMND.Text = string.Empty;
            SDT.Text = string.Empty;
            Email.Text = string.Empty;
            NgayLapThe.Value = DateTime.Today;
            NgayHetHan.Value = NgayLapThe.Value.AddMonths(6);
            DeActivate();
        }

        private void MaDocGia_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
            //If MaDocGia in database,
            //  lock all other fields and auto fill, 
            //  unlock Sua, Xoa, GiaHan, 
            //  else reset other fields and lock Sua Xoa GiaHan.
        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void CMND_TextChanged(object sender, EventArgs e)
        {
            if (CMND.Text.Length != 12 || CMND.Text.Length != 9 || !string.IsNullOrWhiteSpace(CMND.Text))
            {
                MessageBox.Show("CMND không hợp lệ.", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMND.BackColor = Color.LightPink;
            }
            else
            {
                CMND.BackColor = SystemColors.Window;
                ThemCheck();
            }
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            ThemCheck();
        }

        private void NgayLapThe_ValueChanged(object sender, EventArgs e)
        {
            NgayHetHan.Value = NgayLapThe.Value.AddMonths(6);
        }

    }
}
