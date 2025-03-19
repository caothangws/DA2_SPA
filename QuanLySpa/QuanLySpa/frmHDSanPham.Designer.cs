namespace QuanLySpa.Image
{
    partial class frmHDSanPham
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
            this.bangSP = new System.Windows.Forms.DataGridView();
            this.col_MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TENSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_xoa = new System.Windows.Forms.Label();
            this.pnl_tongtien = new System.Windows.Forms.Panel();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoHD = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.lb_date = new System.Windows.Forms.Label();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.lb_layma = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lb_makh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lb_hd = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lb_nvb = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bangSP)).BeginInit();
            this.pnl_tongtien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.SuspendLayout();
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
            this.bangSP.Location = new System.Drawing.Point(3, 201);
            this.bangSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bangSP.Name = "bangSP";
            this.bangSP.RowHeadersWidth = 51;
            this.bangSP.RowTemplate.Height = 24;
            this.bangSP.Size = new System.Drawing.Size(1276, 400);
            this.bangSP.TabIndex = 0;
            this.bangSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangSP_CellClick);
            this.bangSP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangSP_CellValueChanged);
            this.bangSP.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.bangSP_RowsRemoved);
            // 
            // col_MASP
            // 
            this.col_MASP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.col_MASP.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_MASP.HeaderText = "Mã sản phẩm";
            this.col_MASP.MinimumWidth = 6;
            this.col_MASP.Name = "col_MASP";
            // 
            // col_TENSP
            // 
            this.col_TENSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TENSP.HeaderText = "Tên sản phẩm";
            this.col_TENSP.MinimumWidth = 6;
            this.col_TENSP.Name = "col_TENSP";
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // col_TonKho
            // 
            this.col_TonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TonKho.HeaderText = "Tồn Kho";
            this.col_TonKho.MinimumWidth = 6;
            this.col_TonKho.Name = "col_TonKho";
            // 
            // col_DonGia
            // 
            this.col_DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DonGia.HeaderText = "Đơn giá";
            this.col_DonGia.MinimumWidth = 6;
            this.col_DonGia.Name = "col_DonGia";
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.col_ThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_ThanhTien.HeaderText = "Thành Tiền";
            this.col_ThanhTien.MinimumWidth = 6;
            this.col_ThanhTien.Name = "col_ThanhTien";
            this.col_ThanhTien.ReadOnly = true;
            // 
            // lb_xoa
            // 
            this.lb_xoa.AutoSize = true;
            this.lb_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xoa.Location = new System.Drawing.Point(1236, 176);
            this.lb_xoa.Name = "lb_xoa";
            this.lb_xoa.Size = new System.Drawing.Size(39, 23);
            this.lb_xoa.TabIndex = 117;
            this.lb_xoa.Text = "Xóa";
            this.lb_xoa.Click += new System.EventHandler(this.lb_xoa_Click);
            // 
            // pnl_tongtien
            // 
            this.pnl_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_tongtien.Controls.Add(this.lb_tongtien);
            this.pnl_tongtien.Controls.Add(this.label11);
            this.pnl_tongtien.Controls.Add(this.label10);
            this.pnl_tongtien.Location = new System.Drawing.Point(888, 608);
            this.pnl_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_tongtien.Name = "pnl_tongtien";
            this.pnl_tongtien.Size = new System.Drawing.Size(387, 36);
            this.pnl_tongtien.TabIndex = 118;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnXuatHD);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.cbxMaHD);
            this.panel1.Controls.Add(this.lb_mahd);
            this.panel1.Controls.Add(this.txtMANV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTaoHD);
            this.panel1.Controls.Add(this.pnl_date);
            this.panel1.Controls.Add(this.cbxTenKH);
            this.panel1.Controls.Add(this.lb_layma);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.lb_makh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label1);
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
            this.panel1.TabIndex = 126;
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
            this.btnXuatHD.Location = new System.Drawing.Point(513, 121);
            this.btnXuatHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.ShadowDecoration.Parent = this.btnXuatHD;
            this.btnXuatHD.Size = new System.Drawing.Size(100, 38);
            this.btnXuatHD.TabIndex = 203;
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
            this.btnLamMoi.Location = new System.Drawing.Point(1126, 121);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(143, 37);
            this.btnLamMoi.TabIndex = 202;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(752, 121);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(165, 38);
            this.guna2Button1.TabIndex = 145;
            this.guna2Button1.Text = "Xem hóa đơn";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(338, 127);
            this.cbxMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(152, 31);
            this.cbxMaHD.TabIndex = 144;
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahd.Location = new System.Drawing.Point(230, 135);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(82, 23);
            this.lb_mahd.TabIndex = 143;
            this.lb_mahd.Text = "Chọn HD";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(253, 62);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(175, 30);
            this.txtMANV.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 140;
            this.label2.Text = "Mã nhân viên";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.AutoRoundedCorners = true;
            this.btnTaoHD.BorderRadius = 18;
            this.btnTaoHD.CheckedState.Parent = this.btnTaoHD;
            this.btnTaoHD.CustomImages.Parent = this.btnTaoHD;
            this.btnTaoHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnTaoHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.Color.Black;
            this.btnTaoHD.HoverState.Parent = this.btnTaoHD;
            this.btnTaoHD.Location = new System.Drawing.Point(941, 121);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.ShadowDecoration.Parent = this.btnTaoHD;
            this.btnTaoHD.Size = new System.Drawing.Size(165, 38);
            this.btnTaoHD.TabIndex = 139;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // pnl_date
            // 
            this.pnl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pnl_date.Controls.Add(this.lb_date);
            this.pnl_date.Location = new System.Drawing.Point(10, 115);
            this.pnl_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(197, 43);
            this.pnl_date.TabIndex = 138;
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
            this.cbxTenKH.Location = new System.Drawing.Point(253, 15);
            this.cbxTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(175, 31);
            this.cbxTenKH.TabIndex = 137;
            this.cbxTenKH.SelectedIndexChanged += new System.EventHandler(this.cbxTenKH_SelectedIndexChanged);
            this.cbxTenKH.SelectionChangeCommitted += new System.EventHandler(this.cbxTenKH_SelectionChangeCommitted);
            // 
            // lb_layma
            // 
            this.lb_layma.AutoSize = true;
            this.lb_layma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_layma.Location = new System.Drawing.Point(748, 78);
            this.lb_layma.Name = "lb_layma";
            this.lb_layma.Size = new System.Drawing.Size(56, 20);
            this.lb_layma.TabIndex = 136;
            this.lb_layma.Text = "Lấy mã";
            this.lb_layma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_layma_MouseClick);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(621, 11);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(169, 30);
            this.txtMaKH.TabIndex = 135;
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_makh.Location = new System.Drawing.Point(469, 23);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(132, 23);
            this.lb_makh.TabIndex = 134;
            this.lb_makh.Text = "Mã khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(1053, 11);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 30);
            this.txtSDT.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(863, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 132;
            this.label1.Text = "Số điện thoại";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(621, 69);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(120, 30);
            this.txtMaHD.TabIndex = 131;
            // 
            // lb_hd
            // 
            this.lb_hd.AutoSize = true;
            this.lb_hd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hd.Location = new System.Drawing.Point(469, 78);
            this.lb_hd.Name = "lb_hd";
            this.lb_hd.Size = new System.Drawing.Size(106, 23);
            this.lb_hd.TabIndex = 130;
            this.lb_hd.Text = "Mã hóa đơn";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(1053, 69);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(175, 30);
            this.txtTenNV.TabIndex = 129;
            // 
            // lb_nvb
            // 
            this.lb_nvb.AutoSize = true;
            this.lb_nvb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nvb.Location = new System.Drawing.Point(863, 79);
            this.lb_nvb.Name = "lb_nvb";
            this.lb_nvb.Size = new System.Drawing.Size(170, 23);
            this.lb_nvb.TabIndex = 128;
            this.lb_nvb.Text = "Nhân viên bán hàng";
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.lb_tenkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkh.Location = new System.Drawing.Point(55, 23);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(138, 23);
            this.lb_tenkh.TabIndex = 127;
            this.lb_tenkh.Text = "Tên Khách Hàng";
            // 
            // frmHDSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1283, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_tongtien);
            this.Controls.Add(this.lb_xoa);
            this.Controls.Add(this.bangSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHDSanPham";
            this.Text = "frmHDSanPham";
            this.Load += new System.EventHandler(this.frmHDSanPham_Load);
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

        private System.Windows.Forms.DataGridView bangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MASP;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.Label lb_xoa;
        private System.Windows.Forms.Panel pnl_tongtien;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.Label lb_mahd;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTaoHD;
        private System.Windows.Forms.Panel pnl_date;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private System.Windows.Forms.Label lb_layma;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lb_hd;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lb_nvb;
        private System.Windows.Forms.Label lb_tenkh;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXuatHD;
    }
}