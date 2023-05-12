using PhanMen_BanHang.Class;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PhanMen_BanHang
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lbQuyen.Text = "0 => Quản Lý \n1 => Nhân Viên";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lbQuyen.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
                txtXNMK.UseSystemPasswordChar = false;
            }    
            else
            {
                txtXNMK.UseSystemPasswordChar = true;
                txtMK.UseSystemPasswordChar = true;
            }    
        }

        private void ResetValue()
        {
            txtHT.Text = "";
            txtEMail.Text = "";
            txtMK.Text = "";
            txtQuyen.Text = "";
            txtTK.Text = "";
            txtXNMK.Text = "";
            mtxtPhone.Text = "";
            cmbGioiTinh.ResetText();
            txtHT.Focus();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyNguoiDung();
        }

        private void DangKyNguoiDung()
        {
            //Điền đầy đủ thông tin 
            if (txtHT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Họ và Tên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHT.Focus();
            }
            else if (txtEMail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEMail.Focus();
            }
            else if (txtQuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa xác Nhận Quyền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuyen.Focus();
            }
            else if (txtTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tài khoản", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
            }
            else if (txtXNMK.Text == "")
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXNMK.Focus();
            }
            else if (txtXNMK.Text != txtMK.Text)
            {
                errorProvider1.SetError(txtXNMK, "Mật Khẩu không trùng khớp");
                txtXNMK.SelectAll();
                txtXNMK.Focus();
            }
            //Kiểm tra mật khẩu email đúng định đạng
            else
            {
                DangKyNguoiDung DKND = new DangKyNguoiDung(txtHT.Text, txtEMail.Text, mtxtPhone.Text, txtTK.Text, txtMK.Text);
                AccessData a = new AccessData();
                if (!DKND.KiemTraNguoiDungDungDinhDang())
                {
                    errorProvider1.SetError(txtEMail, "Email Sai định dạng");
                    txtEMail.Focus();
                }
                else
                {
                    if (DKND.KiemTraDinhDangHopLe() == true)
                    {
                        string sql = "Insert into Login values( N'" + txtHT.Text + "','" + txtTK.Text + "','" + txtMK.Text + "'," +
                            "'" + txtEMail.Text + "','" + mtxtPhone.Text + "',N'" + cmbGioiTinh.Text + "','" + txtXNMK.Text + "'," +
                            "'" + txtQuyen.Text + "' )"; //Query Insert Data
                        a.ExcuteNonQuery(sql);  //Thực thi Query
                        MessageBox.Show("Đăng ký thành công !!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Thông Báo thành công ==> Show thông tin ra  ==> các TextBox mất giá trị đó [B] ClearTextBox() [/B]
                        MessageBox.Show("Thông tin tài khoản" + "\nHọ và Tên: " + txtHT.Text + "" +
                            "\nEmail: " + txtEMail.Text + " \nPhone: " + mtxtPhone.Text + "" +
                            "\nTên Tài Khoản: " + txtTK.Text + "\nGiới Tính: " + cmbGioiTinh.Text + "" +
                            "\nQuyền: " + txtQuyen.Text + "" +
                            "\nMật Khẩu: ******** ", "Thông Tin tài Khoản");
                        ResetValue();
                    }
                    else
                    {
                        errorProvider1.SetError(txtMK, "Mật Khẩu sai định đạng");
                        txtMK.SelectAll();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXNMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                DangKyNguoiDung();
            }
        }

        private void txtHT_Leave(object sender, EventArgs e)
        {
            if(txtHT.Text !="")
            {
                string text = txtHT.Text;
                string GetVlues = string.Join(" ",text.Split(' ').ToList().ConvertAll(word => word.Substring(0,1).ToUpper() + word.Substring(1)));
                txtHT.Text = GetVlues;
            }    
        }
    }
}
