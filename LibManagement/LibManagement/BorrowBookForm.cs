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
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void BorrowBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Go back to the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
