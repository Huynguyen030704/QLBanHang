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
    public partial class FormHang : Form
    {
        public FormHang()
        {
            InitializeComponent();
        }

        FormMain formMain = new FormMain();
        private DataTable tblH;

        private void FormHang_Load(object sender, EventArgs e)
        {
            btnHienThiDS.Enabled = false;
            btnTimKiem.Enabled = false;
            string sql;
            sql = "Select * from THUONGHIEU";   // lấy dữ liệu cần thiết từ form Thương Hiệu
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGrdView();
            Functions.FillCombo(sql, cmbTenThuongHieu, "MaTH", "TenTH");
            cmbTenThuongHieu.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cmbTenThuongHieu.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            if (formMain.eccelenTaiKhoan.Visible == true)
            {
                txtDonGiaNhap.Enabled = true;
                txtDonGiaBan.Enabled = true;
            }
            txtGhiChu.Text = "";

        }

        private void LoadDataGrdView()
        {
            string sql;
            sql = "Select * From HANG";
            tblH = Functions.GetDataToTable(sql);
            dgvDMHangHoa.DataSource = tblH;
            dgvDMHangHoa.Columns[0].HeaderText = "Mã Hàng";
            dgvDMHangHoa.Columns[1].HeaderText = "Tên Hàng";
            dgvDMHangHoa.Columns[2].HeaderText = "Thương Hiệu";
            dgvDMHangHoa.Columns[3].HeaderText = "Số Lượng";
            dgvDMHangHoa.Columns[4].HeaderText = "Đơn Giá Nhập";
            dgvDMHangHoa.Columns[5].HeaderText = "Đơn Giá Bán";
            dgvDMHangHoa.Columns[6].HeaderText = "Ghi Chú";
            dgvDMHangHoa.Columns[0].Width = 140;
            dgvDMHangHoa.Columns[1].Width = 250;
            dgvDMHangHoa.Columns[2].Width = 200;
            dgvDMHangHoa.Columns[3].Width = 150;
            dgvDMHangHoa.Columns[4].Width = 200;
            dgvDMHangHoa.Columns[5].Width = 200;
            dgvDMHangHoa.Columns[6].Width = 300;
            dgvDMHangHoa.AllowUserToAddRows = false;
        }

        private void dgvDMHangHoa_Click(object sender, EventArgs e)
        {
            string MaThuongHieu;
            string sql;
            if(btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }   
            if(tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }   
            txtMaHang.Text = dgvDMHangHoa.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvDMHangHoa.CurrentRow.Cells["TenHang"].Value.ToString();
            MaThuongHieu = dgvDMHangHoa.CurrentRow.Cells["MaTH"].Value.ToString();
            sql = "Select MaTH from THUONGHIEU Where MaTH=N'" + MaThuongHieu + "'";
            cmbTenThuongHieu.Text =Functions.GetFieldValues(sql);
            txtSoLuong.Text = dgvDMHangHoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaNhap.Text = dgvDMHangHoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dgvDMHangHoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtGhiChu.Text = dgvDMHangHoa.CurrentRow.Cells["GhiChu"].Value.ToString();
            btnBoQua.Enabled = true;
            btnXóa.Enabled = true;
            if(formMain.eccelenTaiKhoan.Visible == true)
            {
                btnSua.Enabled = true;
                return;
            }    
            else if (formMain.eccelenTaiKhoan.Visible == false)
            {
                btnSua.Enabled = false;
                return;
            }
            return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXóa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true ;
            btnThem.Enabled = false;
            ResetValues();
            //txtMaHang.Enabled = false;
            txtMaHang.Text = Functions.CreatekeysMa("MH");
            txtMaHang.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtDonGiaNhap.Enabled = true;
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblH.Rows .Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(txtMaHang.Text =="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }    
            if(MessageBox.Show("Bạn có muốn xóa bản ghi này không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete HANG Where MaHang = N'" + txtMaHang.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGrdView();
                ResetValues();
            }        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows .Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                return;
            }    
            if(txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bảng ghi nào ", "Thông Báo");
                txtMaHang.Focus();
                return;
            }    
            if(txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông Báo");
                txtTenHang.Focus();
                return;
            }    
            if(cmbTenThuongHieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn thương hiệu", "Thông Báo");
                cmbTenThuongHieu.Focus();   
                return;
            }
            sql = "UPDATE HANG SET TenHang = N'" + txtTenHang.Text.Trim() + "'," +
                "MaTH =N'" + cmbTenThuongHieu.SelectedValue.ToString() + "'," +
                "SoLuong =N'" + txtSoLuong.Text.Trim() + "', DonGiaNhap = N'" + txtDonGiaNhap.Text.Trim() + "'," +
                "DonGiaBan =N'" + txtDonGiaBan.Text.Trim() + "',GhiChu =N'" + txtGhiChu.Text.Trim() + "'" +
                "Where MaHang =N'" + txtMaHang.Text + "'";
            Functions.RunSQL(sql);
            ResetValues();  
            LoadDataGrdView();
            btnBoQua.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXóa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mã hàng", "Thông Báo ");
                txtMaHang.Focus();
                return;
            }    
            if(txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên Hàng", "Thông Báo");
                txtTenHang.Focus();
                return;
            }    
            if(cmbTenThuongHieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn Thương hiệu", "Thông Báo");
                cmbTenThuongHieu.Focus();
                return;
            }
            sql = "Select MaHang From HANG Where MaHang = N'" + txtMaHang.Text.Trim() + "'";
            if(Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại !! \n Vui lòng nhập mã khác!!", "Thông Báo");
                txtMaHang.Focus();
                return;
            }
            sql = "INSERT INTO HANG Values(N'" + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() + "'" +
                ",N'" + cmbTenThuongHieu.SelectedValue.ToString() + "'" +
                ",N'" + txtSoLuong.Text.Trim() + "',N'" + txtDonGiaNhap.Text + "'" +
                ",N'" + txtDonGiaBan.Text + "',N'" + txtGhiChu.Text.Trim() + "')";
            Functions.RunSQL(sql);
            LoadDataGrdView();
            ResetValues();
            btnXóa.Enabled = true;
            btnThem.Enabled = true; 
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void ResetTimKiem()
        {
            dgvDMHangHoa.DataSource = null;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            //ResetTimKiem();
            if((txtMaHang.Text == "") &&(txtTenHang.Text =="") && (cmbTenThuongHieu.Text ==""))
            {
                MessageBox.Show("Bạn chưa nhập điều kiện cần tìm", "Thông Báo");
            }
            sql = "Select * from HANG Where 1=1";
            if (txtMaHang.Text != "")
                sql += "AND MaHang Like N'%" + txtMaHang.Text + "%'";
            if (txtTenHang.Text != "")
                sql += "AND TenHang Like N'%" + txtTenHang.Text + "%'";
            if (cmbTenThuongHieu.Text != "")
                sql += "AND MaTH Like N'%" + cmbTenThuongHieu.Text + "%'";
            tblH = Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện cần tìm !", "Chú Ý");
            else
                MessageBox.Show("Có" + tblH.Rows.Count + "bản ghi thỏa mãn điều kiện cần tìm", "Chú ý");
            dgvDMHangHoa.DataSource = tblH;
            ResetValues();
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "Select MaHang,TenHang,MaTH,SoLuong,DonGiaNhap,DonGiaBan,GhiChu From HANG";
            tblH =Functions.GetDataToTable(sql);
            dgvDMHangHoa.DataSource=tblH;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
