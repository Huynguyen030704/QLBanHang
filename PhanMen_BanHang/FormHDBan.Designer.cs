namespace PhanMen_BanHang
{
    partial class FormHDBan
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
            this.cmbMaHoaDon = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbMaHang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbBangChu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.cmbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dttNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMaHoaDon
            // 
            this.cmbMaHoaDon.FormattingEnabled = true;
            this.cmbMaHoaDon.Location = new System.Drawing.Point(366, 861);
            this.cmbMaHoaDon.Name = "cmbMaHoaDon";
            this.cmbMaHoaDon.Size = new System.Drawing.Size(279, 23);
            this.cmbMaHoaDon.TabIndex = 9;
            this.cmbMaHoaDon.DropDown += new System.EventHandler(this.cmbMaHoaDon_DropDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(189, 856);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 33);
            this.label18.TabIndex = 6;
            this.label18.Text = "Mã Hóa Đơn:";
            // 
            // cmbMaHang
            // 
            this.cmbMaHang.FormattingEnabled = true;
            this.cmbMaHang.Location = new System.Drawing.Point(146, 36);
            this.cmbMaHang.Name = "cmbMaHang";
            this.cmbMaHang.Size = new System.Drawing.Size(208, 39);
            this.cmbMaHang.TabIndex = 0;
            this.cmbMaHang.SelectedIndexChanged += new System.EventHandler(this.cmbMaHang_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.cmbMaHang);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.btnHuyHoaDon);
            this.groupBox2.Controls.Add(this.btnLuuHoaDon);
            this.groupBox2.Controls.Add(this.btnThemHoaDon);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.dgvHoaDonBan);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbBangChu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(188, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1258, 503);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Các Mặt Hàng";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.btnBoQua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBoQua.Image = global::PhanMen_BanHang.Properties.Resources.back_to_48px1;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(732, 427);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(149, 55);
            this.btnBoQua.TabIndex = 13;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::PhanMen_BanHang.Properties.Resources.receipt_declined_48px;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1087, 427);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(123, 55);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Image = global::PhanMen_BanHang.Properties.Resources.receipt_48px;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(887, 427);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(194, 55);
            this.btnInHoaDon.TabIndex = 10;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Image = global::PhanMen_BanHang.Properties.Resources.delete_receipt_48px;
            this.btnHuyHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(503, 427);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(223, 55);
            this.btnHuyHoaDon.TabIndex = 9;
            this.btnHuyHoaDon.Text = "Xóa Hóa Đơn";
            this.btnHuyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Image = global::PhanMen_BanHang.Properties.Resources.save_48px;
            this.btnLuuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHoaDon.Location = new System.Drawing.Point(276, 427);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(222, 55);
            this.btnLuuHoaDon.TabIndex = 8;
            this.btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            this.btnLuuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Image = global::PhanMen_BanHang.Properties.Resources.add_receipt_48px;
            this.btnThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHoaDon.Location = new System.Drawing.Point(30, 427);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(240, 55);
            this.btnThemHoaDon.TabIndex = 7;
            this.btnThemHoaDon.Text = "Thêm Hóa Đơn";
            this.btnThemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(965, 362);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(246, 39);
            this.txtTongTien.TabIndex = 6;
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(18, 128);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.Size = new System.Drawing.Size(1193, 228);
            this.dgvHoaDonBan.TabIndex = 2;
            this.dgvHoaDonBan.DoubleClick += new System.EventHandler(this.dgvHoaDonBan_DoubleClick);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(935, 38);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(276, 39);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(512, 38);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(266, 39);
            this.txtTenHang.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(935, 83);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(276, 39);
            this.txtThanhTien.TabIndex = 5;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(512, 83);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(266, 39);
            this.txtGiamGia.TabIndex = 4;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(146, 81);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(208, 39);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(784, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 31);
            this.label15.TabIndex = 0;
            this.label15.Text = "Thành Tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "Giảm Giá %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số Lượng ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(784, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Đơn Giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên Hàng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(834, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 31);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tổng Tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(14, 359);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nháy đúp một dòng để xóa";
            // 
            // lbBangChu
            // 
            this.lbBangChu.AutoSize = true;
            this.lbBangChu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangChu.Location = new System.Drawing.Point(14, 392);
            this.lbBangChu.Name = "lbBangChu";
            this.lbBangChu.Size = new System.Drawing.Size(99, 23);
            this.lbBangChu.TabIndex = 0;
            this.lbBangChu.Text = "Bằng Chữ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Bán:";
            // 
            // lbTT
            // 
            this.lbTT.BackColor = System.Drawing.Color.Transparent;
            this.lbTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTT.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.ForeColor = System.Drawing.Color.Red;
            this.lbTT.Location = new System.Drawing.Point(0, 0);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(1679, 70);
            this.lbTT.TabIndex = 5;
            this.lbTT.Text = "Hóa Đơn Bán";
            this.lbTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mtxtDienThoai);
            this.groupBox1.Controls.Add(this.cmbMaKhachHang);
            this.groupBox1.Controls.Add(this.cmbMaNhanVien);
            this.groupBox1.Controls.Add(this.dttNgayBan);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(188, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // mtxtDienThoai
            // 
            this.mtxtDienThoai.Location = new System.Drawing.Point(829, 178);
            this.mtxtDienThoai.Mask = "(999) 000-0000";
            this.mtxtDienThoai.Name = "mtxtDienThoai";
            this.mtxtDienThoai.Size = new System.Drawing.Size(382, 39);
            this.mtxtDienThoai.TabIndex = 8;
            // 
            // cmbMaKhachHang
            // 
            this.cmbMaKhachHang.FormattingEnabled = true;
            this.cmbMaKhachHang.Location = new System.Drawing.Point(831, 43);
            this.cmbMaKhachHang.Name = "cmbMaKhachHang";
            this.cmbMaKhachHang.Size = new System.Drawing.Size(380, 39);
            this.cmbMaKhachHang.TabIndex = 5;
            this.cmbMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhachHang_SelectedIndexChanged);
            // 
            // cmbMaNhanVien
            // 
            this.cmbMaNhanVien.FormattingEnabled = true;
            this.cmbMaNhanVien.Location = new System.Drawing.Point(191, 133);
            this.cmbMaNhanVien.Name = "cmbMaNhanVien";
            this.cmbMaNhanVien.Size = new System.Drawing.Size(380, 39);
            this.cmbMaNhanVien.TabIndex = 3;
            this.cmbMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbMaNhanVien_SelectedIndexChanged);
            // 
            // dttNgayBan
            // 
            this.dttNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dttNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttNgayBan.Location = new System.Drawing.Point(191, 88);
            this.dttNgayBan.Name = "dttNgayBan";
            this.dttNgayBan.Size = new System.Drawing.Size(380, 39);
            this.dttNgayBan.TabIndex = 2;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(191, 178);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(380, 39);
            this.txtTenNhanVien.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(831, 133);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(380, 39);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(831, 88);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(380, 39);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(191, 43);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(380, 39);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Điện Thoại:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::PhanMen_BanHang.Properties.Resources.search_48px;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(651, 851);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 49);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 946);
            this.Controls.Add(this.cmbMaHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormHDBan";
            this.Text = "Hóa Đơn Bán ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHDBan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaHoaDon;
        public System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbMaHang;
        public System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnInHoaDon;
        public System.Windows.Forms.Button btnHuyHoaDon;
        public System.Windows.Forms.Button btnLuuHoaDon;
        public System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbBangChu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtDienThoai;
        private System.Windows.Forms.ComboBox cmbMaKhachHang;
        private System.Windows.Forms.ComboBox cmbMaNhanVien;
        private System.Windows.Forms.DateTimePicker dttNgayBan;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        public System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBoQua;
    }
}