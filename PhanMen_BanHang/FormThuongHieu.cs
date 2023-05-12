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
    public partial class FormThuongHieu : Form
    {
        public FormThuongHieu()
        {
            InitializeComponent();
        }

        DataTable THUONGHIEU;

        private void FormThuongHieu_Load(object sender, EventArgs e)
        {
            txtMaTH.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
            btnBoQua.Enabled = false;
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "Select * From THUONGHIEU";
            THUONGHIEU= Functions.GetDataToTable(sql);
            dataGridView1.DataSource = THUONGHIEU;
            dataGridView1.Columns[0].HeaderText = "Mã Thương Hiệu";
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].HeaderText = "Tên Thương Hiệu";
            dataGridView1.Columns[1].Width = 700;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMaTH.Text = "";
            txtTenTH.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if( btnThem.Enabled == false )
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTH.Focus();
                return;
            }
            if(THUONGHIEU.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }    
            txtMaTH.Text = dataGridView1.CurrentRow.Cells["MaTH"].Value.ToString();
            txtTenTH.Text = dataGridView1.CurrentRow.Cells["TenTH"].Value.ToString();
            btnSua.Enabled = true;
            btnXóa.Enabled = true;
            btnBoQua.Enabled = true;    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtMaTH.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã thương hiệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTH.Focus();
                return;
            }    
            if(txtTenTH.Text == "")
            {
                MessageBox.Show("Bạn Chưa nhập Tên Thương hiệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTH.Focus();
                return;
            }
            sql = "Select MaTH From THUONGHIEU Where MaTH = N'" + txtMaTH.Text + "'";
            if(Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Thương Hiệu này đã được dùng.\nBạn phải nhập Mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTH.Focus();
                return;
            }
            sql = "Insert Into THUONGHIEU Values(N'" + txtMaTH.Text.Trim() + "',N'" + txtTenTH.Text.Trim() + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXóa.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaTH.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnBoQua.Enabled =false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXóa.Enabled = true;
            txtMaTH.Enabled = false;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if(THUONGHIEU.Rows.Count == 0)
            {
                MessageBox.Show("Không Có dữ liệu","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(txtMaTH.Text =="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }    
            if(txtTenTH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên Thương Hiệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Update THUONGHIEU Set TenTH = N'" + txtTenTH.Text.Trim() +"'" +
                "Where MaTH = N'" + txtMaTH.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView(); 
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            string sql;
            if(THUONGHIEU.Rows.Count ==0)
            {
                MessageBox.Show("Chưa có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(txtMaTH.Text == "")
            {
                MessageBox.Show("Bạn Chưa chọn bản ghi nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(MessageBox.Show("Bạn Muốn xóa bản ghi này không", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete THUONGHIEU Where MaTH = N'" + txtMaTH.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXóa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            ResetValues();
            txtMaTH.Enabled = true;
            txtMaTH.Focus();
        }
    }
}
