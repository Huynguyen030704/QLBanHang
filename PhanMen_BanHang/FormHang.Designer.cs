namespace PhanMen_BanHang
{
    partial class FormHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHienThiDS = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXóa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDMHangHoa = new System.Windows.Forms.DataGridView();
            this.cmbTenThuongHieu = new System.Windows.Forms.ComboBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnHienThiDS);
            this.groupBox1.Controls.Add(this.btnBoQua);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXóa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(72, 811);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1484, 118);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnHienThiDS
            // 
            this.btnHienThiDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHienThiDS.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiDS.Image = global::PhanMen_BanHang.Properties.Resources.icons8_clipboard_40;
            this.btnHienThiDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiDS.Location = new System.Drawing.Point(1052, 22);
            this.btnHienThiDS.Name = "btnHienThiDS";
            this.btnHienThiDS.Size = new System.Drawing.Size(236, 62);
            this.btnHienThiDS.TabIndex = 6;
            this.btnHienThiDS.Text = "Hiển Thị DS";
            this.btnHienThiDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiDS.UseVisualStyleBackColor = true;
            this.btnHienThiDS.Click += new System.EventHandler(this.btnHienThiDS_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBoQua.Image = global::PhanMen_BanHang.Properties.Resources.back_to_48px;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(486, 22);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(194, 62);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::PhanMen_BanHang.Properties.Resources.search_48;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(834, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(212, 62);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::PhanMen_BanHang.Properties.Resources.icons8_save_close_48;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(686, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 62);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::PhanMen_BanHang.Properties.Resources.cancel_48px;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1294, 22);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(169, 62);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::PhanMen_BanHang.Properties.Resources.paper_pencil_48;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(339, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 62);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXóa.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXóa.Image = global::PhanMen_BanHang.Properties.Resources.icons8_agreement_delete_48;
            this.btnXóa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXóa.Location = new System.Drawing.Point(186, 22);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(147, 62);
            this.btnXóa.TabIndex = 1;
            this.btnXóa.Text = "Xóa ";
            this.btnXóa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXóa.UseVisualStyleBackColor = true;
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::PhanMen_BanHang.Properties.Resources.add_48;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(21, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 62);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDMHangHoa
            // 
            this.dgvDMHangHoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDMHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMHangHoa.Font = new System.Drawing.Font("Arial", 18F);
            this.dgvDMHangHoa.Location = new System.Drawing.Point(75, 495);
            this.dgvDMHangHoa.Name = "dgvDMHangHoa";
            this.dgvDMHangHoa.Size = new System.Drawing.Size(1484, 310);
            this.dgvDMHangHoa.TabIndex = 10;
            this.dgvDMHangHoa.Click += new System.EventHandler(this.dgvDMHangHoa_Click);
            // 
            // cmbTenThuongHieu
            // 
            this.cmbTenThuongHieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTenThuongHieu.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.cmbTenThuongHieu.FormattingEnabled = true;
            this.cmbTenThuongHieu.Location = new System.Drawing.Point(382, 252);
            this.cmbTenThuongHieu.Name = "cmbTenThuongHieu";
            this.cmbTenThuongHieu.Size = new System.Drawing.Size(462, 45);
            this.cmbTenThuongHieu.TabIndex = 20;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHang.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.txtMaHang.Location = new System.Drawing.Point(382, 152);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(462, 44);
            this.txtMaHang.TabIndex = 18;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHang.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.txtTenHang.Location = new System.Drawing.Point(382, 202);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(462, 44);
            this.txtTenHang.TabIndex = 19;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.txtDonGiaNhap.Location = new System.Drawing.Point(382, 353);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(462, 44);
            this.txtDonGiaNhap.TabIndex = 22;
            this.txtDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(1007, 152);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(487, 315);
            this.txtGhiChu.TabIndex = 24;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGiaBan.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.txtDonGiaBan.Location = new System.Drawing.Point(382, 406);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(462, 44);
            this.txtDonGiaBan.TabIndex = 23;
            this.txtDonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong.Location = new System.Drawing.Point(382, 303);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(462, 44);
            this.txtSoLuong.TabIndex = 21;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(850, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ghi Chú:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(105, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đơn Giá Bán:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(99, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đơn Giá Nhập:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(99, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(99, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thương Hiệu:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(99, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Hàng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(99, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1679, 119);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh Mục Hàng Hóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 946);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDMHangHoa);
            this.Controls.Add(this.cmbTenThuongHieu);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHang";
            this.Text = "Hàng ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnHienThiDS;
        public System.Windows.Forms.Button btnBoQua;
        public System.Windows.Forms.Button btnTimKiem;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnDong;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnXóa;
        public System.Windows.Forms.DataGridView dgvDMHangHoa;
        public System.Windows.Forms.ComboBox cmbTenThuongHieu;
        public System.Windows.Forms.TextBox txtMaHang;
        public System.Windows.Forms.TextBox txtTenHang;
        public System.Windows.Forms.TextBox txtDonGiaNhap;
        public System.Windows.Forms.TextBox txtGhiChu;
        public System.Windows.Forms.TextBox txtDonGiaBan;
        public System.Windows.Forms.TextBox txtSoLuong;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}