using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMen_BanHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)  //Btn Đăng ký 
        {
            FormDangKy Dk = new FormDangKy();
            DialogResult DialogDk = MessageBox.Show("Bạn muốn tại tài khoản","Chý Ý",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(DialogDk == DialogResult.OK)
            {
                Dk.MdiParent = FormMain.ActiveForm;
                Dk.MdiParent = this;
                Dk.Show();
            }    
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement3_Click(object sender, EventArgs e) //Btn Đăng Xuất
        {
            FormLogin fmLogin = new FormLogin();
            DialogResult DX =  MessageBox.Show("Có muốn đăng xuất","Chú Ý", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (DX == DialogResult.OK)
            {
                fmLogin.Show();
                this.Hide();
            }
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e) //Btn Tài Khoản
        {
            DialogResult DialogTK = MessageBox.Show("Cân nhắc trước khi vào","Chú ý",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (DialogTK == DialogResult.OK)
            {
                FormAccount fmAccount = new FormAccount();
                fmAccount.MdiParent = FormMain.ActiveForm;
                fmAccount.Show();
            }
        }

        private void elThoat_Click(object sender, EventArgs e) //btnThoát
        {
            Application.Exit();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e) //btn Thương Hiệu
        {
            FormThuongHieu fTH = new FormThuongHieu();
            fTH.MdiParent = FormMain.ActiveForm;
            fTH.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e) //btn Hàng
        {
            FormHang fH = new FormHang();
            fH.MdiParent = FormMain.ActiveForm;
            fH.Show();
            if(eccelenTaiKhoan.Visible == false)
            {
                fH.btnSua.Visible = false;
                fH.btnHienThiDS.Location = new System.Drawing.Point(979, 22);
                fH.btnBoQua.Location = new System.Drawing.Point(413, 22);
                fH.btnTimKiem.Location = new System.Drawing.Point(761, 22);
                fH.btnLuu.Location = new System.Drawing.Point(613, 22);
                fH.btnDong.Location = new System.Drawing.Point(1221, 22);
                fH.btnXóa.Location = new System.Drawing.Point(260, 22);
                fH.btnThem.Location = new System.Drawing.Point(95, 22);
                return;
            }    
            if (eccelenTaiKhoan.Visible == true)
            {
                fH.txtDonGiaBan.Enabled = true;
                fH.txtDonGiaNhap.Enabled = true;
                return;
            }
        }

        private void accordionControlElement9_Click(object sender, EventArgs e) // btn Nhân viên
        {
            FormNhanVien fNV = new FormNhanVien();
            fNV.MdiParent = FormMain.ActiveForm;
            fNV.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)    //btn Khách Hàng
        {
            FormKhachHang fKH = new FormKhachHang();
            fKH.MdiParent = FormMain.ActiveForm;
            fKH.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e) //btn Hóa Đơn
        {
            FormHoaDon fHD = new FormHoaDon();
            fHD.MdiParent = FormMain.ActiveForm;
            fHD.Show();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)    // btn chi tiết Hóa Đơn
        {
            FormHDBan fHDB = new FormHDBan();
            fHDB.MdiParent = FormMain.ActiveForm;
            fHDB.Show();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)    //btn Accout
        {
            FormTK fTK = new FormTK();
            fTK.MdiParent=FormMain.ActiveForm;  
            fTK.Show();
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)    //btnTimKiem Hàng
        {
            FormHang fHang = new FormHang();
            fHang.MdiParent= FormMain.ActiveForm;    
            fHang.Show();
            fHang.Text = "Tìm Kiếm Hàng Hóa";
            fHang.label1.Text = "Tìm Kiếm Hàng Hóa"; 
            fHang.btnLuu.Visible = false;
            fHang.btnSua.Visible = false;
            fHang.btnThem.Visible = false;
            fHang.btnXóa.Visible = false;
            fHang.btnBoQua.Visible = false;
            fHang.btnTimKiem.Location = new System.Drawing.Point(402, 31);
            fHang.btnHienThiDS.Location = new System.Drawing.Point(633, 31);
            fHang.btnDong.Location = new System.Drawing.Point(884, 31);
            fHang.btnTimKiem.Enabled = true;
            fHang.btnHienThiDS.Enabled = true;
        } 

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.MdiParent = FormMain.ActiveForm;  
            about.Show();

        }
    }
}
