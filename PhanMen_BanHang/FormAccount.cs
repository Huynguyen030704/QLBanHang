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
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }
        private DataTable tblLogin;

        private void FormAccount_Load(object sender, EventArgs e)
        {
            /*string sql;
            sql = "Select * Form Login"; // lấy dữ liệu*/
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "Select * from Login";
            tblLogin = Functions.GetDataToTable(sql);
            dgvAccount.DataSource = tblLogin;
            dgvAccount.Columns[0].HeaderText = "Họ Tên";
            dgvAccount.Columns[1].HeaderText = "Tài Khoản";
            dgvAccount.Columns[2].HeaderText = "Mật Khẩu";
            dgvAccount.Columns[3].HeaderText = "Email";
            dgvAccount.Columns[4].HeaderText = "SDT";
            dgvAccount.Columns[5].HeaderText = "Giới Tính";
            dgvAccount.Columns[6].HeaderText = "XN_MK";
            dgvAccount.Columns[7].HeaderText = "Quyền";
            dgvAccount.Columns[0].Width = 300;
            dgvAccount.Columns[1].Width = 200;
            dgvAccount.Columns[2].Width = 240;
            dgvAccount.Columns[3].Width = 300;
            dgvAccount.Columns[4].Width = 240;
            dgvAccount.Columns[5].Width = 150;
            dgvAccount.Columns[6].Width = 240;
            dgvAccount.Columns[7].Width = 100;
            dgvAccount.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
