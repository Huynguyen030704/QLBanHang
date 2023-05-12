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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace PhanMen_BanHang
{
    public partial class FormHDBan : Form
    {
        public FormHDBan()
        {
            InitializeComponent();
        }

        DataTable tblCTHD;

        private void FormHDBan_Load(object sender, EventArgs e)
        {
            btnThemHoaDon.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuuHoaDon.Enabled = false;
            btnHuyHoaDon.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaHoaDon.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhachHang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            mtxtDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            Functions.FillCombo("Select MaKH, TenKH From KHACHHANG", cmbMaKhachHang, "MaKH", "MaKH");
            cmbMaKhachHang.SelectedIndex = -1;
            Functions.FillCombo("Select MaNV, TenNV From NHANVIEN", cmbMaNhanVien, "MaNV", "TenNV");
            cmbMaNhanVien.SelectedIndex = -1;
            Functions.FillCombo("Select MaHang, TenHang From HANG", cmbMaHang, "MaHang", "TenHang");
            cmbMaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if(txtMaHoaDon.Text !="")
            {
                LoadInfoHoaDon();
                btnHuyHoaDon.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "Select a.MaHang, b.TenHang, a.SoLuong, a.DonGia, a.GiamGia, a.ThanhTien From CHITIETHD AS a,Hang AS b Where a.MaHDBan='" + txtMaHoaDon.Text + "' AND a.MaHang=b.MaHang";
            tblCTHD = Functions.GetDataToTable(sql);
            dgvHoaDonBan.DataSource = tblCTHD;
            dgvHoaDonBan.Columns[0].HeaderText = "Mã Hàng";
            dgvHoaDonBan.Columns[1].HeaderText = "Tên Hàng";
            dgvHoaDonBan.Columns[2].HeaderText = "Số Lượng";
            dgvHoaDonBan.Columns[3].HeaderText = "Đơn giá";
            dgvHoaDonBan.Columns[4].HeaderText = "Giảm Giá %";
            dgvHoaDonBan.Columns[5].HeaderText = "Thành Tiền";
            dgvHoaDonBan.Columns[0].Width = 200;
            dgvHoaDonBan.Columns[1].Width = 300;
            dgvHoaDonBan.Columns[2].Width = 150;
            dgvHoaDonBan.Columns[3].Width = 150;
            dgvHoaDonBan.Columns[4].Width = 170;
            dgvHoaDonBan.Columns[5].Width = 180;
            dgvHoaDonBan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "Select NgayBan From HOADONBAN Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
            dttNgayBan.Text = Functions.GetFieldValues(str);
            str = "Select MaNV From HOADONBAN Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
            cmbMaNhanVien.Text = Functions.GetFieldValues(str);
            str = "Select MaKH From HOADONBAN Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
            cmbMaKhachHang.Text = Functions.GetFieldValues(str);
            str = "Select TongTien From HOADONBAN Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
            lbBangChu.Text = "Bằng Chữ: "+ Functions.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
        }

        private void ResetValues()
        {
            txtMaHoaDon.Text ="";
            dttNgayBan.Text = DateTime.Now.ToShortDateString();
            cmbMaNhanVien.Text = "";
            cmbMaKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtTenKhachHang.Text = "";
            txtTenNhanVien.Text = "";
            mtxtDienThoai.Text = "";
            cmbMaHang.Text = "";
            cmbMaHoaDon.Text = "";
            txtTongTien.Text = "0";
            lbBangChu.Text = "Bằng chữ: ";
            txtSoLuong.Text = "0";
            txtGiamGia.Text = "0";
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            btnHuyHoaDon.Enabled = false;
            btnLuuHoaDon.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThemHoaDon.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValues();
            txtMaHoaDon.Text = Functions.Createkey("HDB");
            LoadDataGridView();
        }

        private void cmbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if(cmbMaNhanVien.Text =="")
                txtTenNhanVien.Text = "";
            //khi Chọn sẽ hiện
            str = "Select TenNV From NHANVIEN Where MaNV = N'" + cmbMaNhanVien.SelectedValue + "'";
            txtTenNhanVien.Text = Functions.GetFieldValues(str);
        }

        private void cmbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if(cmbMaKhachHang.Text =="")
            {
                txtTenKhachHang.Text = "";
                txtDiaChi.Text = "";
                mtxtDienThoai.Text = "";
            }
            //khi Chọn sẽ hiện
            str = "Select TenKH From KHACHHANG Where MaKH = N'" + cmbMaKhachHang.SelectedValue + "'";
            txtTenKhachHang.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi From KHACHHANG Where MaKH = N'" + cmbMaKhachHang.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai From KHACHHANG Where MaKH = N'" + cmbMaKhachHang.SelectedValue + "'";
            mtxtDienThoai.Text = Functions.GetFieldValues(str);
        }

        private void cmbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if(cmbMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGia.Text = "";
            }
            //khi Chọn sẽ hiện
            str = "Select TenHang From HANG Where MaHang =N'" + cmbMaHang.SelectedValue + "'";
            txtTenHang.Text = Functions.GetFieldValues(str);
            str = "Select DonGiaBan From HANG Where MaHang = N'" + cmbMaHang.SelectedValue + "'";
            txtDonGia.Text = Functions.GetFieldValues(str);
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, Slcon, tong, Tongmoi;
            sql = "Select MaHDBan From HOADONBAN Where MaHDBan =N'" + txtMaHoaDon.Text + "'";
            if(!Functions.CheckKey(sql))
            {
                // Mã Hóa Đơn chưa có, Tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa 
                if(cmbMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông Báo");
                    cmbMaNhanVien.Focus();
                    return;
                }  
                if(cmbMaKhachHang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo");
                    cmbMaKhachHang.Focus();
                    return ;
                }
                sql = "Insert Into HOADONBAN Values (N'" + txtMaHoaDon.Text.Trim() + "'," +
                    " N'" + cmbMaNhanVien.SelectedValue + "',N'" + dttNgayBan.Text + "'," +
                    " N'" + cmbMaKhachHang.SelectedValue + "',N'" + txtTongTien.Text.Trim() + "') ";
                Functions.RunSQL(sql);
            } 
            // Lưu Thông Tin Các Mặt Hàng
            if(cmbMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaHang.Focus();
                return;
            }    
            if((txtSoLuong.Text.Trim().Length == 0) ||(txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn Chưa nhập số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "0";
                txtSoLuong.Focus();
                return ;
            }    
            if(txtGiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa nhập giảm giá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamGia.Focus();
                return;
            }
            sql = "Select MaHang From CHITIETHD Where MaHang = N'" + cmbMaHang.SelectedValue + "' AND MaHDBan = N'" + txtMaHoaDon.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Hàng Này đã có, bạn phải nhập mã khác", "Thông Báo");
                ReserValuesHang();
                cmbMaHang.Focus();
                return;
            }
            //Kiểm Tra xem số lượng hàng trong kho còn đủ để cung cấp không? 
            sl = Convert.ToDouble(Functions.GetFieldValues("Select SoLuong From HANG Where MaHang = N'" + cmbMaHang.SelectedValue + "'"));
            if(Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này còn " + sl, "Thông báo");
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "Insert Into CHITIETHD Values(N'" + txtMaHoaDon.Text.Trim() + "',N'" + cmbMaHang.SelectedValue + "'," +
                "N'" + txtSoLuong.Text.Trim() + "',N'" + txtDonGia.Text.Trim() + "',N'" + txtGiamGia.Text.Trim() + "'," +
                "N'" + txtThanhTien.Text.Trim() + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            //Cập nhập Lại Số lượng của mặt hàng đó vào bảng Hàng
            Slcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UpDate HANG Set SoLuong = '" + Slcon + "' Where MaHang = N'" + cmbMaHang.SelectedValue + "'";
            Functions.RunSQL(sql);
            //Cập Nhật lại tổng tiền cho hóa đơn bán 
            tong = Convert.ToDouble(Functions.GetFieldValues("Select TongTien From HOADONBAN Where MaHDBan =N'" + txtMaHoaDon.Text.Trim() + "' "));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UpDate HOADONBAN Set TongTien = " + Tongmoi + " Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lbBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
            ReserValuesHang();
            txtGiamGia.Text = "0";
            btnHuyHoaDon.Enabled = true;
            btnThemHoaDon.Enabled = true;
            btnInHoaDon.Enabled = true;
        }

        //Reset lại dữ liệu của Hàng
        private void ReserValuesHang()
        {
            cmbMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            txtTenHang.Text = "";
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không ??","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "Select MaHang, SoLuong From CHITIETHD Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
                DataTable tblH = Functions.GetDataToTable(sql);
                for(int hang =0; hang <= tblH.Rows.Count - 1; hang++)
                {
                    //Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("Select SoLuong From HANG Where MaHang = N'" + tblH.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblH.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "Update HANG Set SoLuong = " + slcon + " Where MaHang = N'" + tblH.Rows[hang][0].ToString() + "'";
                    Functions.RunSQL(sql);
                    //Xóa Chi Tiết Hóa Đơn
                    sql = "Delete CHITIETHD Where MaHDBan =N'" + txtMaHoaDon.Text + "'";
                    Functions.RunSQL(sql);

                    //Xóa Hóa Đơn
                    sql = "Delete HOADONBAN Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
                    Functions.RunSQL (sql);
                    ResetValues();
                    LoadDataGridView();
                    btnHuyHoaDon.Enabled = false;
                    btnInHoaDon.Enabled = false;
                }    
            }    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cmbMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn Phải chọn một mã hóa đơn để tìm", "Thông Báo");
                cmbMaHoaDon.Focus();
                return;
            }    
            txtMaHoaDon.Text =cmbMaHoaDon.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnHuyHoaDon.Enabled = true;
            btnLuuHoaDon.Enabled = true;
            btnInHoaDon.Enabled = true;
            cmbMaHoaDon.SelectedIndex = -1;
        }

        private void cmbMaHoaDon_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("Select MaHDBan From HOADONBAN", cmbMaHoaDon, "MaHDBan", "MaHDBan");
            cmbMaHoaDon.SelectedIndex = -1;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi Thây đổi số lượng thì thức hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if(txtSoLuong.Text == "")
            {
                sl = 0;
            }    
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if(txtGiamGia.Text == "")
            {
                gg = 0;
            }    
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if(txtDonGia.Text =="")
                dg = 0; 
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi Thây đổi số lượng thì thức hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
            {
                sl = 0;
            }
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
            {
                gg = 0;
            }
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void dgvHoaDonBan_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if(tblCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông Báo");
                return;
            }
            if (MessageBox.Show("Ban có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Xóa hàng và cập nhật lại số lượng
                MaHangxoa = dgvHoaDonBan.CurrentRow.Cells["MaHang"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHoaDonBan.CurrentRow.Cells["Soluong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHoaDonBan.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "Detele CHITIETHD Where MaHDBan = N'" + txtMaHoaDon.Text + "' And MaHang = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                //Cập Nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("Select Soluong From HANG Where MaHang =N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "Update HANG Set Soluong = " + slcon + " Where MaHang = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                //Cập Nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("Select TongTien From HOADONBAN Where MaHDBan = N'" + txtMaHoaDon.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "Update HOADONBAN Set TongTien = " + tongmoi + " Where MaHDBan = N'" + txtMaHoaDon.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                lbBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tongmoi.ToString()));
                LoadDataGridView();
            }               
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;   // Trong 1 chương trình Excel có nhiều WorkBook
            COMExcel.Worksheet exSheet; // Trong 1 WorkBook Có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            //Định Đạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 17;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Đậu Đậu";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Gò Công - Tiền Giang";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (033)9615130";
            exRange.Range["C2:E2"].Font.Size = 19;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaHDBan, a.NgayBan, a.TongTien, b.TenKH, b.DiaChi, b.DienThoai, c.TenNV FROM HOADONBAN AS a, KHACHHANG AS b, NHANVIEN AS c WHERE a.MaHDBan = N'" + txtMaHoaDon.Text + "' AND a.MaKH = b.MaKH AND a.MaNV = c.MaNV";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 15;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value ="'"+tblThongtinHD.Rows[0][5].ToString();
            exRange.Range["C9:E9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenHang, a.SoLuong, DonGia, a.GiamGia, a.ThanhTien " +
                "FROM CHITIETHD AS a , HANG AS b WHERE a.MaHDBan = N'" + txtMaHoaDon.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Tiền Giang, Ngày " + d.Day + " Tháng " + d.Month + " Năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn bán hàng";
            exApp.Visible = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
           ResetValues();
            btnThemHoaDon.Enabled = true;
            btnHuyHoaDon.Enabled = false;
            btnLuuHoaDon.Enabled = false;
            btnBoQua.Enabled = false;
        }
    }
}
