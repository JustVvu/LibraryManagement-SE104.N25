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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form and open the login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the FindReaderForm
            FindReaderForm timDocGiaForm = new FindReaderForm();
            timDocGiaForm.Show();
            this.Hide();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the FindBookForm
            FindBookForm timSachForm = new FindBookForm();
            timSachForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Exit the Application
            Application.Exit();
        }

        private void quảnLíKhoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the BookMangeForm
            BookManageForm BookManageForm = new BookManageForm();
            BookManageForm.Show();
            this.Hide();
        }
    }
}
