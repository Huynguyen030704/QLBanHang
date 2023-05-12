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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        DataTable tblHDB;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
           
            string sql = "Select * From HOADONBAN";
            LoadDataGriView();
            Functions.RunSQL(sql);
        }

        private void LoadDataGriView()
        {
            string sql;
            sql = "Select * From HOADONBAN";
            tblHDB =Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblHDB;
            dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn Bán";
            dataGridView1.Columns[0].Width = 350;
            dataGridView1.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].HeaderText = "Ngày Bán";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[3].Width = 400;
            dataGridView1.Columns[4].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[4].Width = 300;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn Có muốn hiện thông tin chi tiết không ??", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mahd = dataGridView1.CurrentRow.Cells["MaHDBan"].Value.ToString();
                FormHDBan frm  = new FormHDBan();
                frm.txtMaHoaDon.Text = mahd;
                frm.MdiParent = FormMain.ActiveForm;
                frm.Show();
                frm.btnDong.Location = new System.Drawing.Point(641, 427);
                frm.btnInHoaDon.Location = new System.Drawing.Point(406, 427);
                frm.btnHuyHoaDon.Visible = false;
                frm.btnLuuHoaDon.Visible = false;   
                frm.btnThemHoaDon.Visible = false;
                
            } 
                
        }
    }
}
