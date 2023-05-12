using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMen_BanHang.Class;
using System.Data.SqlClient;

namespace PhanMen_BanHang
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        DataTable tblKH;

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "Select * From KHACHHANG";
            tblKH = Functions.GetDataToTable(sql);
            dgvKhachHang.DataSource = tblKH;
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách";
            dgvKhachHang.Columns[0].Width = 300;
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng ";
            dgvKhachHang.Columns[1].Width = 343;
            dgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns[2].Width = 255;
            dgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[3].Width = 220;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnXóa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            ResetValues();
            txtMaKhachHang.Text = Functions.CreatekeysMa("KH");
            txtTenKhachHang.Focus();
        }

        private void ResetValues()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            mtxtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblKH .Rows .Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo");
                return;
            }    
            if(txtMaKhachHang.Text.Trim() =="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi để xóa", "Thông Báo");
                return;
            }    
            if(MessageBox.Show("Bạn có muốn xóa bản ghi đã chọn không","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                sql = "Delete KHACHHANG Where MaKH = N'" + txtMaKhachHang.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }    
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return;
            }    
            if(tblKH.Rows .Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }    
            txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtxtSDT.Text = dgvKhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXóa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghỉ nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Tên Khách Hàng", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }    
            if(txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return ;
            }
            sql = "Update KHACHHANG Set TenKH =N'" + txtTenKhachHang.Text + "',DiaChi =N'" + txtDiaChi.Text + "'" +
                ",DienThoai =N'" + mtxtSDT.Text.Trim() + "' Where MaKH = N'" + txtMaKhachHang.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled=false;
            btnThem.Enabled = true;
            btnXóa.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            txtMaKhachHang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuKhachHang();
        }

        private void LuuKhachHang()
        {
            string sql;
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Bạn Chưa nhập tên Khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa nhập địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            // Không cần kiểm tra " Mã Khách Hàng " Vì Có Functions.CreateKey nên sẽ ko có mã Trùng !!
            // Thêm SQL
            sql = "Insert Into KHACHHANG Values(N'" + txtMaKhachHang.Text.Trim() + "', N'" + txtTenKhachHang.Text.Trim() + "'" +
                ", N'" + txtDiaChi.Text.Trim() + "',N'" + mtxtSDT.Text.Trim() + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            // Khởi Tạo lại các nút button
            btnXóa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKhachHang.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void mtxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( (Keys)e.KeyChar == Keys.Enter)
            {
                LuuKhachHang();
            }    
        }

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text != "")
            {
                string text = txtTenKhachHang.Text;
                string GetVlues = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtTenKhachHang.Text = GetVlues;
            }
        }
    }
}
