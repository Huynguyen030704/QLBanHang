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
using PhanMen_BanHang.Class;

namespace PhanMen_BanHang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CSDL_BanHangConnetionString;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@Username", txtUers.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Connection = con;

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);

                if(txtUers.Text == "admin" && txtPass.Text == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                    formMain.Text = "Quản Lý 👨‍⚖️👨‍⚖️👨‍⚖️";
                }    

                else if (code == 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                    formMain.Text = "Quản Lý 👨‍⚖️👨‍⚖️👨‍⚖️";
                    
                }
                else if (code == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                    formMain.Text = "Nhân Viên 🤵🤵🤵";
                    formMain.eccelenTaiKhoan.Visible = false;
                }
                else if (txtUers.Text == "")
                {
                    lbTB.Text = "Bạn chưa nhập tên tài khoản !";
                    txtUers.Focus();
                }
                else if (txtPass.Text == "")
                {
                    lbTB.Text = "Bạn chưa nhập mật khẩu !";
                    txtPass.Focus();
                }
                else if (code == 2)
                {
                    lbTB.Text = "Tài khoản hoặc mật khẩu không đúng !";
                    txtUers.SelectAll();
                    txtPass.SelectAll();
                    txtUers.Focus();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUers.Focus();
            
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy fDk = new FormDangKy();
            fDk.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
