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

namespace PhanMen_BanHang
{
    public partial class FormTK : Form
    {
        public FormTK()
        {
            InitializeComponent();
        }
        DataTable tblHDB;

        private void FormTK_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiem.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHoaDon.Focus();
        }

        private void LoadDataGridView()
        {
            dgvTimKiem.Columns[0].HeaderText = "Mã HDB";
            dgvTimKiem.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvTimKiem.Columns[2].HeaderText = "Ngày Bán";
            dgvTimKiem.Columns[3].HeaderText = "Mã Khách";
            dgvTimKiem.Columns[4].HeaderText = "Tổng Tiền";
            dgvTimKiem.Columns[0].Width = 300;
            dgvTimKiem.Columns[1].Width = 200;
            dgvTimKiem.Columns[2].Width = 200;
            dgvTimKiem.Columns[3].Width = 300;
            dgvTimKiem.Columns[4].Width = 200;
            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHoaDon.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
              (txtMaNhanVien.Text == "") && (txtMaKhachHang.Text == "") && txtTongTien.Text == "")
            {
                MessageBox.Show("Hãy nhập 1 điều kiển để tìm kiếm !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information); ;
                return;
            }
            sql = "Select * From HOADONBAN Where 1=1";
            if (txtMaHoaDon.Text != "")
                sql = sql + "AND MaHDBan Like N'%" + txtMaHoaDon.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + "And MONTH(NgayBan) = " + txtThang.Text + "";
            if (txtNam.Text != "")
                sql = sql + "And YEAR(NgayBan) = " + txtNam.Text + "";
            if (txtMaNhanVien.Text != "")
                sql = sql + "And MaNV Like N'%" + txtMaNhanVien.Text + "%'";
            if (txtMaKhachHang.Text != "")
                sql = sql + "And MaKH Like N'%" + txtMaKhachHang.Text + "%'";
            if (txtTongTien.Text != "")
                sql = sql + "And TongTien <= " + txtTongTien.Text + "";
            tblHDB = Functions.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không Có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có" + tblHDB.Rows.Count + "bản ghi thỏa mãn điều kiện !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimKiem.DataSource = tblHDB;
            LoadDataGridView();
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiem = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTimKiem_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if(MessageBox.Show("Bạn Có muốn hiện thông Tin chi tiết ?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                mahd = dgvTimKiem.CurrentRow.Cells["MaHDBan"].Value.ToString();
                FormHDBan frm = new FormHDBan();
                FormMain frmMain = new FormMain();
                frm.txtMaHoaDon.Text = mahd;
                frm.MdiParent = FormMain.ActiveForm;
                frm.Show();
                frm.lbTT.Text = "Thông Tin Chi Tiết";
                frm.btnDong.Location = new System.Drawing.Point(641, 427);
                frm.btnInHoaDon.Location = new System.Drawing.Point(406, 427);
                frm.btnHuyHoaDon.Visible = false;
                frm.btnLuuHoaDon.Visible = false;
                frm.btnThemHoaDon.Visible=false;
                frm.btnTimKiem.Visible = false;
            }
        }
    }
}
