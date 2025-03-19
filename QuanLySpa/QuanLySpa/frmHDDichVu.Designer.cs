namespace QuanLySpa
{
    partial class frmHDDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.col_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangDV = new System.Windows.Forms.DataGridView();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TENDV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_TGDTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuongDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TENSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangSP = new System.Windows.Forms.DataGridView();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_sanpham = new System.Windows.Forms.Label();
            this.pnl_tongtien = new System.Windows.Forms.Panel();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbXoaSP = new System.Windows.Forms.Label();
            this.lbXoaDV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXemHD = new Guna.UI2.WinForms.Guna2Button();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoHD = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.lb_date = new System.Windows.Forms.Label();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.lb_layma = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lb_makh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lb_hd = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lb_nvb = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bangDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangSP)).BeginInit();
            this.pnl_tongtien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // col_DonGia
            // 
            this.col_DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DonGia.HeaderText = "Đơn giá";
            this.col_DonGia.MinimumWidth = 6;
            this.col_DonGia.Name = "col_DonGia";
            // 
            // bangDV
            // 
            this.bangDV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bangDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADV,
            this.col_TENDV,
            this.col_TGDTDV,
            this.col_SoLuongDV,
            this.col_DonGiaDV,
            this.col_TTDV,
            this.col_NhanVien});
            this.bangDV.Location = new System.Drawing.Point(3, 210);
            this.bangDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bangDV.Name = "bangDV";
            this.bangDV.RowHeadersWidth = 51;
            this.bangDV.RowTemplate.Height = 24;
            this.bangDV.Size = new System.Drawing.Size(1276, 183);
            this.bangDV.TabIndex = 96;
            this.bangDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangDV_CellClick);
            this.bangDV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangDV_CellValueChanged);
            this.bangDV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.bangDV_RowsRemoved);
            // 
            // MADV
            // 
            this.MADV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.MADV.DefaultCellStyle = dataGridViewCellStyle1;
            this.MADV.HeaderText = "Mã dịch vụ";
            this.MADV.MinimumWidth = 6;
            this.MADV.Name = "MADV";
            // 
            // col_TENDV
            // 
            this.col_TENDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TENDV.DataPropertyName = "MADV";
            this.col_TENDV.HeaderText = "Tên dịch vụ";
            this.col_TENDV.MinimumWidth = 6;
            this.col_TENDV.Name = "col_TENDV";
            // 
            // col_TGDTDV
            // 
            this.col_TGDTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TGDTDV.HeaderText = "Thời gian điều trị";
            this.col_TGDTDV.MinimumWidth = 6;
            this.col_TGDTDV.Name = "col_TGDTDV";
            // 
            // col_SoLuongDV
            // 
            this.col_SoLuongDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_SoLuongDV.HeaderText = "Số lượng";
            this.col_SoLuongDV.MinimumWidth = 6;
            this.col_SoLuongDV.Name = "col_SoLuongDV";
            // 
            // col_DonGiaDV
            // 
            this.col_DonGiaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DonGiaDV.HeaderText = "Đơn giá";
            this.col_DonGiaDV.MinimumWidth = 6;
            this.col_DonGiaDV.Name = "col_DonGiaDV";
            // 
            // col_TTDV
            // 
            this.col_TTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.col_TTDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_TTDV.HeaderText = "Thành Tiền";
            this.col_TTDV.MinimumWidth = 6;
            this.col_TTDV.Name = "col_TTDV";
            this.col_TTDV.ReadOnly = true;
            // 
            // col_NhanVien
            // 
            this.col_NhanVien.DataPropertyName = "MANV";
            this.col_NhanVien.HeaderText = "Nhân viên";
            this.col_NhanVien.MinimumWidth = 6;
            this.col_NhanVien.Name = "col_NhanVien";
            this.col_NhanVien.Width = 125;
            // 
            // col_TonKho
            // 
            this.col_TonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TonKho.HeaderText = "Tồn Kho";
            this.col_TonKho.MinimumWidth = 6;
            this.col_TonKho.Name = "col_TonKho";
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // col_TENSP
            // 
            this.col_TENSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TENSP.HeaderText = "Tên sản phẩm";
            this.col_TENSP.MinimumWidth = 6;
            this.col_TENSP.Name = "col_TENSP";
            // 
            // col_MASP
            // 
            this.col_MASP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.col_MASP.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_MASP.HeaderText = "Mã sản phẩm";
            this.col_MASP.MinimumWidth = 6;
            this.col_MASP.Name = "col_MASP";
            // 
            // bangSP
            // 
            this.bangSP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bangSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MASP,
            this.col_TENSP,
            this.col_SoLuong,
            this.col_TonKho,
            this.col_DonGia,
            this.col_ThanhTien});
            this.bangSP.Location = new System.Drawing.Point(3, 422);
            this.bangSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bangSP.Name = "bangSP";
            this.bangSP.RowHeadersWidth = 51;
            this.bangSP.RowTemplate.Height = 24;
            this.bangSP.Size = new System.Drawing.Size(1276, 183);
            this.bangSP.TabIndex = 94;
            this.bangSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangSP_CellClick);
            this.bangSP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangSP_CellValueChanged);
            this.bangSP.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.bangSP_RowsRemoved);
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.col_ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_ThanhTien.HeaderText = "Thành Tiền";
            this.col_ThanhTien.MinimumWidth = 6;
            this.col_ThanhTien.Name = "col_ThanhTien";
            this.col_ThanhTien.ReadOnly = true;
            // 
            // lb_sanpham
            // 
            this.lb_sanpham.AutoSize = true;
            this.lb_sanpham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sanpham.Location = new System.Drawing.Point(581, 396);
            this.lb_sanpham.Name = "lb_sanpham";
            this.lb_sanpham.Size = new System.Drawing.Size(89, 23);
            this.lb_sanpham.TabIndex = 95;
            this.lb_sanpham.Text = "Sản Phẩm";
            // 
            // pnl_tongtien
            // 
            this.pnl_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_tongtien.Controls.Add(this.lb_tongtien);
            this.pnl_tongtien.Controls.Add(this.label11);
            this.pnl_tongtien.Controls.Add(this.label10);
            this.pnl_tongtien.Location = new System.Drawing.Point(893, 609);
            this.pnl_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_tongtien.Name = "pnl_tongtien";
            this.pnl_tongtien.Size = new System.Drawing.Size(387, 36);
            this.pnl_tongtien.TabIndex = 119;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.Location = new System.Drawing.Point(200, 5);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(20, 23);
            this.lb_tongtien.TabIndex = 79;
            this.lb_tongtien.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(333, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 23);
            this.label11.TabIndex = 78;
            this.label11.Text = "VND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 23);
            this.label10.TabIndex = 77;
            this.label10.Text = "Tổng tiền thanh toán";
            // 
            // lbXoaSP
            // 
            this.lbXoaSP.AutoSize = true;
            this.lbXoaSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXoaSP.Location = new System.Drawing.Point(1227, 396);
            this.lbXoaSP.Name = "lbXoaSP";
            this.lbXoaSP.Size = new System.Drawing.Size(39, 23);
            this.lbXoaSP.TabIndex = 135;
            this.lbXoaSP.Text = "Xóa";
            this.lbXoaSP.Click += new System.EventHandler(this.lbXoaSP_Click);
            // 
            // lbXoaDV
            // 
            this.lbXoaDV.AutoSize = true;
            this.lbXoaDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXoaDV.Location = new System.Drawing.Point(1227, 185);
            this.lbXoaDV.Name = "lbXoaDV";
            this.lbXoaDV.Size = new System.Drawing.Size(39, 23);
            this.lbXoaDV.TabIndex = 136;
            this.lbXoaDV.Text = "Xóa";
            this.lbXoaDV.Click += new System.EventHandler(this.lbXoaDV_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnXuatHD);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXemHD);
            this.panel1.Controls.Add(this.cbxMaHD);
            this.panel1.Controls.Add(this.lb_mahd);
            this.panel1.Controls.Add(this.txtMANV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTaoHD);
            this.panel1.Controls.Add(this.pnl_date);
            this.panel1.Controls.Add(this.cbxTenKH);
            this.panel1.Controls.Add(this.lb_layma);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.lb_makh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lb_hd);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.lb_nvb);
            this.panel1.Controls.Add(this.lb_tenkh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 173);
            this.panel1.TabIndex = 177;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.AutoRoundedCorners = true;
            this.btnXuatHD.BorderRadius = 18;
            this.btnXuatHD.CheckedState.Parent = this.btnXuatHD;
            this.btnXuatHD.CustomImages.Parent = this.btnXuatHD;
            this.btnXuatHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnXuatHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.ForeColor = System.Drawing.Color.Black;
            this.btnXuatHD.HoverState.Parent = this.btnXuatHD;
            this.btnXuatHD.Location = new System.Drawing.Point(475, 125);
            this.btnXuatHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.ShadowDecoration.Parent = this.btnXuatHD;
            this.btnXuatHD.Size = new System.Drawing.Size(100, 38);
            this.btnXuatHD.TabIndex = 206;
            this.btnXuatHD.Text = "Xem";
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 17;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(1077, 124);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(143, 37);
            this.btnLamMoi.TabIndex = 201;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXemHD
            // 
            this.btnXemHD.AutoRoundedCorners = true;
            this.btnXemHD.BorderRadius = 18;
            this.btnXemHD.CheckedState.Parent = this.btnXemHD;
            this.btnXemHD.CustomImages.Parent = this.btnXemHD;
            this.btnXemHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnXemHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemHD.ForeColor = System.Drawing.Color.Black;
            this.btnXemHD.HoverState.Parent = this.btnXemHD;
            this.btnXemHD.Location = new System.Drawing.Point(711, 125);
            this.btnXemHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.ShadowDecoration.Parent = this.btnXemHD;
            this.btnXemHD.Size = new System.Drawing.Size(165, 38);
            this.btnXemHD.TabIndex = 200;
            this.btnXemHD.Text = "Xem hóa đơn";
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(303, 131);
            this.cbxMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(152, 31);
            this.cbxMaHD.TabIndex = 199;
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahd.Location = new System.Drawing.Point(206, 140);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(82, 23);
            this.lb_mahd.TabIndex = 198;
            this.lb_mahd.Text = "Chọn HD";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(256, 64);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(175, 30);
            this.txtMANV.TabIndex = 196;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 195;
            this.label3.Text = "Mã nhân viên";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.AutoRoundedCorners = true;
            this.btnTaoHD.BorderRadius = 17;
            this.btnTaoHD.CheckedState.Parent = this.btnTaoHD;
            this.btnTaoHD.CustomImages.Parent = this.btnTaoHD;
            this.btnTaoHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnTaoHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.Color.Black;
            this.btnTaoHD.HoverState.Parent = this.btnTaoHD;
            this.btnTaoHD.Location = new System.Drawing.Point(891, 125);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.ShadowDecoration.Parent = this.btnTaoHD;
            this.btnTaoHD.Size = new System.Drawing.Size(169, 37);
            this.btnTaoHD.TabIndex = 194;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // pnl_date
            // 
            this.pnl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pnl_date.Controls.Add(this.lb_date);
            this.pnl_date.Location = new System.Drawing.Point(10, 119);
            this.pnl_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(188, 43);
            this.pnl_date.TabIndex = 193;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_date.Location = new System.Drawing.Point(7, 5);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(53, 28);
            this.lb_date.TabIndex = 83;
            this.lb_date.Text = "Date";
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(256, 14);
            this.cbxTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(175, 31);
            this.cbxTenKH.TabIndex = 192;
            this.cbxTenKH.SelectedIndexChanged += new System.EventHandler(this.cbxTenKH_SelectedIndexChanged);
            this.cbxTenKH.SelectionChangeCommitted += new System.EventHandler(this.cbxTenKH_SelectionChangeCommitted);
            // 
            // lb_layma
            // 
            this.lb_layma.AutoSize = true;
            this.lb_layma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_layma.Location = new System.Drawing.Point(759, 81);
            this.lb_layma.Name = "lb_layma";
            this.lb_layma.Size = new System.Drawing.Size(56, 20);
            this.lb_layma.TabIndex = 191;
            this.lb_layma.Text = "Lấy mã";
            this.lb_layma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_layma_MouseClick);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(624, 10);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(169, 30);
            this.txtMaKH.TabIndex = 190;
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_makh.Location = new System.Drawing.Point(471, 22);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(132, 23);
            this.lb_makh.TabIndex = 189;
            this.lb_makh.Text = "Mã khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(1055, 10);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 30);
            this.txtSDT.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(865, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 187;
            this.label2.Text = "Số điện thoại";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(624, 68);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(120, 30);
            this.txtMaHD.TabIndex = 186;
            // 
            // lb_hd
            // 
            this.lb_hd.AutoSize = true;
            this.lb_hd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hd.Location = new System.Drawing.Point(471, 78);
            this.lb_hd.Name = "lb_hd";
            this.lb_hd.Size = new System.Drawing.Size(106, 23);
            this.lb_hd.TabIndex = 185;
            this.lb_hd.Text = "Mã hóa đơn";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(1055, 68);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(175, 30);
            this.txtTenNV.TabIndex = 184;
            // 
            // lb_nvb
            // 
            this.lb_nvb.AutoSize = true;
            this.lb_nvb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nvb.Location = new System.Drawing.Point(865, 78);
            this.lb_nvb.Name = "lb_nvb";
            this.lb_nvb.Size = new System.Drawing.Size(170, 23);
            this.lb_nvb.TabIndex = 183;
            this.lb_nvb.Text = "Nhân viên bán hàng";
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.lb_tenkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkh.Location = new System.Drawing.Point(57, 22);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(138, 23);
            this.lb_tenkh.TabIndex = 182;
            this.lb_tenkh.Text = "Tên Khách Hàng";
            // 
            // frmHDDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1283, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbXoaDV);
            this.Controls.Add(this.lbXoaSP);
            this.Controls.Add(this.pnl_tongtien);
            this.Controls.Add(this.bangDV);
            this.Controls.Add(this.bangSP);
            this.Controls.Add(this.lb_sanpham);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHDDichVu";
            this.Text = "frmHDDichVu";
            this.Load += new System.EventHandler(this.frmHDDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangSP)).EndInit();
            this.pnl_tongtien.ResumeLayout(false);
            this.pnl_tongtien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_date.ResumeLayout(false);
            this.pnl_date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGia;
        private System.Windows.Forms.DataGridView bangDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MASP;
        private System.Windows.Forms.DataGridView bangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.Label lb_sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TGDTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuongDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TTDV;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_NhanVien;
        private System.Windows.Forms.Panel pnl_tongtien;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbXoaSP;
        private System.Windows.Forms.Label lbXoaDV;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnXemHD;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.Label lb_mahd;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnTaoHD;
        private System.Windows.Forms.Panel pnl_date;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private System.Windows.Forms.Label lb_layma;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lb_hd;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lb_nvb;
        private System.Windows.Forms.Label lb_tenkh;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXuatHD;
    }
}