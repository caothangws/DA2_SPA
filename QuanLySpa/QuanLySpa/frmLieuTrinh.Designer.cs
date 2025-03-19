namespace QuanLySpa
{
    partial class frmLieuTrinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.bangLT = new System.Windows.Forms.DataGridView();
            this.MALT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chieckhault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnLammoi = new Guna.UI2.WinForms.Guna2Button();
            this.lb_xoadv = new System.Windows.Forms.Label();
            this.lb_xoasp = new System.Windows.Forms.Label();
            this.bangDV = new System.Windows.Forms.DataGridView();
            this.bangSP = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTienSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSanPham = new System.Windows.Forms.ComboBox();
            this.lb_sp = new System.Windows.Forms.Label();
            this.cbxMaDV = new System.Windows.Forms.ComboBox();
            this.lb_dv = new System.Windows.Forms.Label();
            this.lb_themsp = new System.Windows.Forms.Label();
            this.lb_themdv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChiecKhauLT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemLT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThoiGianDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTienDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bangLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(406, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 31);
            this.label12.TabIndex = 59;
            this.label12.Text = "Danh Sách Liệu Trình";
            // 
            // bangLT
            // 
            this.bangLT.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bangLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bangLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangLT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALT,
            this.TENLT,
            this.THOIGIANDT,
            this.GIATIEN,
            this.chieckhault,
            this.diemlt});
            this.bangLT.Location = new System.Drawing.Point(2, 501);
            this.bangLT.Name = "bangLT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bangLT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bangLT.RowHeadersWidth = 51;
            this.bangLT.RowTemplate.Height = 24;
            this.bangLT.Size = new System.Drawing.Size(1067, 227);
            this.bangLT.TabIndex = 32;
            this.bangLT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.banglt_CellClick);
            // 
            // MALT
            // 
            this.MALT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALT.DataPropertyName = "MALT";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.MALT.DefaultCellStyle = dataGridViewCellStyle2;
            this.MALT.HeaderText = "Mã Liệu Trình";
            this.MALT.MinimumWidth = 6;
            this.MALT.Name = "MALT";
            // 
            // TENLT
            // 
            this.TENLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLT.DataPropertyName = "TENLT";
            this.TENLT.HeaderText = "Tên Liệu Trình";
            this.TENLT.MinimumWidth = 6;
            this.TENLT.Name = "TENLT";
            // 
            // THOIGIANDT
            // 
            this.THOIGIANDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANDT.DataPropertyName = "THOIGIANDT";
            this.THOIGIANDT.HeaderText = "Thời Gian Điều Trị";
            this.THOIGIANDT.MinimumWidth = 6;
            this.THOIGIANDT.Name = "THOIGIANDT";
            // 
            // GIATIEN
            // 
            this.GIATIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIATIEN.DataPropertyName = "GIATIEN";
            this.GIATIEN.HeaderText = "Giá Tiền";
            this.GIATIEN.MinimumWidth = 6;
            this.GIATIEN.Name = "GIATIEN";
            // 
            // chieckhault
            // 
            this.chieckhault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chieckhault.DataPropertyName = "CHIECKHAU";
            this.chieckhault.HeaderText = "Chiếc khấu";
            this.chieckhault.MinimumWidth = 6;
            this.chieckhault.Name = "chieckhault";
            // 
            // diemlt
            // 
            this.diemlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diemlt.DataPropertyName = "DIEMLT";
            this.diemlt.HeaderText = "Điểm";
            this.diemlt.MinimumWidth = 6;
            this.diemlt.Name = "diemlt";
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 21;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.LightCoral;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(1086, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 21;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.LightCoral;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(1090, 375);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(180, 45);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 21;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.LightCoral;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(1090, 453);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 21;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.LightCoral;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(1090, 531);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(180, 45);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.AutoRoundedCorners = true;
            this.btnLammoi.BorderRadius = 21;
            this.btnLammoi.CheckedState.Parent = this.btnLammoi;
            this.btnLammoi.CustomImages.Parent = this.btnLammoi;
            this.btnLammoi.FillColor = System.Drawing.Color.LightCoral;
            this.btnLammoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.White;
            this.btnLammoi.HoverState.Parent = this.btnLammoi;
            this.btnLammoi.Location = new System.Drawing.Point(1090, 608);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ShadowDecoration.Parent = this.btnLammoi;
            this.btnLammoi.Size = new System.Drawing.Size(180, 45);
            this.btnLammoi.TabIndex = 33;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // lb_xoadv
            // 
            this.lb_xoadv.AutoSize = true;
            this.lb_xoadv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xoadv.Location = new System.Drawing.Point(1030, 238);
            this.lb_xoadv.Name = "lb_xoadv";
            this.lb_xoadv.Size = new System.Drawing.Size(39, 23);
            this.lb_xoadv.TabIndex = 99;
            this.lb_xoadv.Text = "Xóa";
            this.lb_xoadv.Click += new System.EventHandler(this.lb_xoadv_Click);
            // 
            // lb_xoasp
            // 
            this.lb_xoasp.AutoSize = true;
            this.lb_xoasp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xoasp.Location = new System.Drawing.Point(477, 243);
            this.lb_xoasp.Name = "lb_xoasp";
            this.lb_xoasp.Size = new System.Drawing.Size(39, 23);
            this.lb_xoasp.TabIndex = 98;
            this.lb_xoasp.Text = "Xóa";
            this.lb_xoasp.Click += new System.EventHandler(this.lb_xoasp_Click);
            // 
            // bangDV
            // 
            this.bangDV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bangDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADV,
            this.colThoiGianDT,
            this.colGiaTienDV});
            this.bangDV.Location = new System.Drawing.Point(555, 272);
            this.bangDV.Name = "bangDV";
            this.bangDV.RowHeadersWidth = 51;
            this.bangDV.RowTemplate.Height = 24;
            this.bangDV.Size = new System.Drawing.Size(514, 187);
            this.bangDV.TabIndex = 97;
            // 
            // bangSP
            // 
            this.bangSP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bangSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.colGiaTienSP});
            this.bangSP.Location = new System.Drawing.Point(2, 272);
            this.bangSP.Name = "bangSP";
            this.bangSP.RowHeadersWidth = 51;
            this.bangSP.RowTemplate.Height = 24;
            this.bangSP.Size = new System.Drawing.Size(514, 187);
            this.bangSP.TabIndex = 95;
            // 
            // MASP
            // 
            this.MASP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASP.DataPropertyName = "MASP";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            this.MASP.DefaultCellStyle = dataGridViewCellStyle5;
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.MinimumWidth = 6;
            this.MASP.Name = "MASP";
            // 
            // colGiaTienSP
            // 
            this.colGiaTienSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaTienSP.DataPropertyName = "GIABAN";
            this.colGiaTienSP.HeaderText = "Giá tiền";
            this.colGiaTienSP.MinimumWidth = 6;
            this.colGiaTienSP.Name = "colGiaTienSP";
            // 
            // cbxSanPham
            // 
            this.cbxSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSanPham.FormattingEnabled = true;
            this.cbxSanPham.Location = new System.Drawing.Point(155, 230);
            this.cbxSanPham.Name = "cbxSanPham";
            this.cbxSanPham.Size = new System.Drawing.Size(210, 31);
            this.cbxSanPham.TabIndex = 101;
            // 
            // lb_sp
            // 
            this.lb_sp.AutoSize = true;
            this.lb_sp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sp.Location = new System.Drawing.Point(-2, 241);
            this.lb_sp.Name = "lb_sp";
            this.lb_sp.Size = new System.Drawing.Size(90, 23);
            this.lb_sp.TabIndex = 100;
            this.lb_sp.Text = "Sản phẩm";
            // 
            // cbxMaDV
            // 
            this.cbxMaDV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaDV.FormattingEnabled = true;
            this.cbxMaDV.Location = new System.Drawing.Point(706, 230);
            this.cbxMaDV.Name = "cbxMaDV";
            this.cbxMaDV.Size = new System.Drawing.Size(210, 31);
            this.cbxMaDV.TabIndex = 103;
            // 
            // lb_dv
            // 
            this.lb_dv.AutoSize = true;
            this.lb_dv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dv.Location = new System.Drawing.Point(551, 238);
            this.lb_dv.Name = "lb_dv";
            this.lb_dv.Size = new System.Drawing.Size(70, 23);
            this.lb_dv.TabIndex = 102;
            this.lb_dv.Text = "Dịch vụ";
            // 
            // lb_themsp
            // 
            this.lb_themsp.AutoSize = true;
            this.lb_themsp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_themsp.Location = new System.Drawing.Point(408, 243);
            this.lb_themsp.Name = "lb_themsp";
            this.lb_themsp.Size = new System.Drawing.Size(53, 23);
            this.lb_themsp.TabIndex = 104;
            this.lb_themsp.Text = "Thêm";
            this.lb_themsp.Click += new System.EventHandler(this.lb_themsp_Click);
            // 
            // lb_themdv
            // 
            this.lb_themdv.AutoSize = true;
            this.lb_themdv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_themdv.Location = new System.Drawing.Point(971, 238);
            this.lb_themdv.Name = "lb_themdv";
            this.lb_themdv.Size = new System.Drawing.Size(53, 23);
            this.lb_themdv.TabIndex = 105;
            this.lb_themdv.Text = "Thêm";
            this.lb_themdv.Click += new System.EventHandler(this.lb_themdv_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtChiecKhauLT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiemLT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtThoiGianDT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenLT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaLT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 199);
            this.panel1.TabIndex = 106;
            // 
            // txtChiecKhauLT
            // 
            this.txtChiecKhauLT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiecKhauLT.Location = new System.Drawing.Point(990, 86);
            this.txtChiecKhauLT.Name = "txtChiecKhauLT";
            this.txtChiecKhauLT.Size = new System.Drawing.Size(158, 30);
            this.txtChiecKhauLT.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Chiếc khấu(%)";
            // 
            // txtDiemLT
            // 
            this.txtDiemLT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLT.Location = new System.Drawing.Point(990, 147);
            this.txtDiemLT.Name = "txtDiemLT";
            this.txtDiemLT.Size = new System.Drawing.Size(158, 30);
            this.txtDiemLT.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(834, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 73;
            this.label7.Text = "Điểm";
            // 
            // txtThoiGianDT
            // 
            this.txtThoiGianDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianDT.Location = new System.Drawing.Point(635, 86);
            this.txtThoiGianDT.Name = "txtThoiGianDT";
            this.txtThoiGianDT.Size = new System.Drawing.Size(158, 30);
            this.txtThoiGianDT.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Thời Gian Điều Trị(Phút)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Thông Tin Liệu Trình";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(635, 143);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(158, 30);
            this.txtGiaTien.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Giá Tiền Liệu Trình";
            // 
            // txtTenLT
            // 
            this.txtTenLT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLT.Location = new System.Drawing.Point(185, 143);
            this.txtTenLT.Name = "txtTenLT";
            this.txtTenLT.Size = new System.Drawing.Size(209, 30);
            this.txtTenLT.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tên Liệu Trình";
            // 
            // txtMaLT
            // 
            this.txtMaLT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLT.Location = new System.Drawing.Point(184, 90);
            this.txtMaLT.Name = "txtMaLT";
            this.txtMaLT.ReadOnly = true;
            this.txtMaLT.Size = new System.Drawing.Size(209, 30);
            this.txtMaLT.TabIndex = 66;
          //  this.txtMaLT.TextChanged += new System.EventHandler(this.txtMaLT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã Liệu Trình";
            // 
            // MADV
            // 
            this.MADV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MADV.DataPropertyName = "MADV";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.MADV.DefaultCellStyle = dataGridViewCellStyle4;
            this.MADV.HeaderText = "Mã dịch vụ";
            this.MADV.MinimumWidth = 6;
            this.MADV.Name = "MADV";
            this.MADV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colThoiGianDT
            // 
            this.colThoiGianDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThoiGianDT.DataPropertyName = "THOIGIANDT";
            this.colThoiGianDT.HeaderText = "Thời gian DT";
            this.colThoiGianDT.MinimumWidth = 6;
            this.colThoiGianDT.Name = "colThoiGianDT";
            // 
            // colGiaTienDV
            // 
            this.colGiaTienDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaTienDV.DataPropertyName = "GIATIEN";
            this.colGiaTienDV.HeaderText = "Giá tiền";
            this.colGiaTienDV.MinimumWidth = 6;
            this.colGiaTienDV.Name = "colGiaTienDV";
            // 
            // frmLieuTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1282, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_themdv);
            this.Controls.Add(this.lb_themsp);
            this.Controls.Add(this.cbxMaDV);
            this.Controls.Add(this.lb_dv);
            this.Controls.Add(this.cbxSanPham);
            this.Controls.Add(this.lb_sp);
            this.Controls.Add(this.lb_xoadv);
            this.Controls.Add(this.lb_xoasp);
            this.Controls.Add(this.bangDV);
            this.Controls.Add(this.bangSP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bangLT);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLammoi);
            this.Name = "frmLieuTrinh";
            this.Text = "frmLieuTrinh";
            this.Load += new System.EventHandler(this.frmLieuTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView bangLT;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnLammoi;
        private System.Windows.Forms.Label lb_xoadv;
        private System.Windows.Forms.Label lb_xoasp;
        private System.Windows.Forms.DataGridView bangDV;
        private System.Windows.Forms.DataGridView bangSP;
        private System.Windows.Forms.ComboBox cbxSanPham;
        private System.Windows.Forms.Label lb_sp;
        private System.Windows.Forms.ComboBox cbxMaDV;
        private System.Windows.Forms.Label lb_dv;
        private System.Windows.Forms.Label lb_themsp;
        private System.Windows.Forms.Label lb_themdv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtChiecKhauLT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemLT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThoiGianDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn chieckhault;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTienSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTienDV;
    }
}