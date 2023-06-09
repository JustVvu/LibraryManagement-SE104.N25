using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibManagement
{
    //connect to the database
    

    public partial class LoginForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Close this form and open the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString.connectionString);
            conn.Open();
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //Close this form and exit the application
            this.Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            //Close this form and exit the application
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Check if the username and password are empty
            if (txtUName2.Text == "" || txtPass2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPass2.Text != txtRePass2.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Check if the username is already exist
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM LOGIN WHERE USERNAME = @UserName";
                cmd.Parameters.AddWithValue("@UserName", txtUName2.Text);
                adapter = new SqlDataAdapter(cmd);
                dt.Clear();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Insert the new account to the database
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO LOGIN (Username, Password) VALUES (@UserName, @Pass)";
                    cmd.Parameters.AddWithValue("@UserName", txtUName2.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtPass2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }

        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //Check if the username and password are empty
            if (txtUName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Check if the username and password are correct
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM LOGIN WHERE USERNAME = @UserName AND PASSWORD = @Pass";
                cmd.Parameters.AddWithValue("@UserName", txtUName.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPass.Text);
                adapter = new SqlDataAdapter(cmd);
                dt.Clear();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Close this form and open the main form
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtRePass2_TextChanged(object sender, EventArgs e)
        {
            //IF the password and re-password are not the same, change the color of the label and the textbox border color to red
            if (txtPass2.Text != txtRePass2.Text)
            {
                lblRePass.ForeColor = Color.Red;
                txtRePass2.BackColor = Color.LightPink;
            }
            else
            {
                lblRePass.ForeColor = Color.Black;
                txtRePass2.BackColor = Color.White;
            }
        }
    }
}
