using PhanMen_BanHang.Class;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PhanMen_BanHang
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        DataTable tblNV;

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "Select * From NHANVIEN";
            tblNV = Functions.GetDataToTable(sql);
            dgvNhanVien.DataSource = tblNV;
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[0].Width = 200;
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[1].Width = 265;
            dgvNhanVien.Columns[2].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[2].Width = 170;
            dgvNhanVien.Columns[3].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[3].Width = 200;
            dgvNhanVien.Columns[4].HeaderText = "Điện Thoại";
            dgvNhanVien.Columns[4].Width = 170;
            dgvNhanVien.Columns[5].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[5].Width = 150;
            tblNV = Functions.GetDataToTable(sql);
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            cmbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtxtDienThoai.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXóa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXóa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            //Tự Động thêm mã khách hàng 
            txtMaNhanVien.Text = Functions.CreatekeysMa("NV");
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Focus();
        }

        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            mtxtDienThoai.Text = "";
            cmbGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn Chưa chọn bản ghi nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete NHANVIEN Where MaNV =N'" + txtMaNhanVien.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);    
                return ;
            }    
            if(txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Nhân Viên","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return ;
            }    
            if(txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }    
            if(mtxtDienThoai.Text == "(   )   -   ")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtDienThoai.Focus();
                return;
            }
            if (dtpNgaySinh.Text == "  /  /  ")
            {
                MessageBox.Show("Bạn Chưa Nhập Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgaySinh.Focus();
                return;
            }
            sql = "Update NHANVIEN Set TenNV = N'" + txtTenNhanVien.Text.Trim() + "',DiaChi =N'" + txtDiaChi.Text.Trim() + "'" +
                ",DienThoai = '" + mtxtDienThoai.Text.ToString() + "', GioiTinh = N'" + cmbGioiTinh.Text + "'," +
                "NgaySinh = '" + dtpNgaySinh.Text + "' Where MaNV = N'" + txtMaNhanVien.Text.Trim() + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXóa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            txtMaNhanVien.Enabled = true;
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn Chưa nhập Tên Nhân Viên","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }    
            if(txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa Chỉ","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }    
            if(cmbGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa cập nhật máy tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbGioiTinh.Focus();
                return;
            }
            // Không cần check lại Khóa chính vì có Functions CreateKey Tự động tạo ta Khóa chính theo thời gian
            sql = "Insert Into NHANVIEN Values (N'" + txtMaNhanVien.Text.Trim() + "'," +
                " N'" + txtTenNhanVien.Text.Trim() + "', N'" + cmbGioiTinh.Text + "',N'" + txtDiaChi.Text + "'" +
                ", N'" + mtxtDienThoai.Text + "', '" + dtpNgaySinh.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXóa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNhanVien_Leave(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text != "")
            {
                string text = txtTenNhanVien.Text;
                string GetVlues = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
                txtTenNhanVien.Text = GetVlues;
            }
        }
    }
}
