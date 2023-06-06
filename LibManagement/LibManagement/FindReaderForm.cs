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

        }

        private void TimDocGiaForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            loadData();

        }

        private void FindReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //go back to mainform
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
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
    }
}
