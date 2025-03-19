namespace QuanLySpa
{
    partial class frmDatLich
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
            this.bangDatLich = new System.Windows.Forms.DataGridView();
            this.MALT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDatLich = new Guna.UI2.WinForms.Guna2Button();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTenLT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoigianDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.lb_nv = new System.Windows.Forms.Label();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lb_layma = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bangDatLich)).BeginInit();
            this.SuspendLayout();
            // 
            // bangDatLich
            // 
            this.bangDatLich.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bangDatLich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bangDatLich.ColumnHeadersHeight = 29;
            this.bangDatLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALT,
            this.TENLT,
            this.THOIGIANDT,
            this.MANV,
            this.GIATIEN,
            this.Thoigian,
            this.THOIGIANKT});
            this.bangDatLich.Location = new System.Drawing.Point(1, 337);
            this.bangDatLich.Name = "bangDatLich";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bangDatLich.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bangDatLich.RowHeadersWidth = 51;
            this.bangDatLich.RowTemplate.Height = 24;
            this.bangDatLich.Size = new System.Drawing.Size(1280, 392);
            this.bangDatLich.TabIndex = 33;
            this.bangDatLich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangdatlich_CellClick);
            // 
            // MALT
            // 
            this.MALT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALT.DataPropertyName = "MALICHHEN";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.MALT.DefaultCellStyle = dataGridViewCellStyle2;
            this.MALT.HeaderText = "Mã lịch hẹn";
            this.MALT.MinimumWidth = 6;
            this.MALT.Name = "MALT";
            // 
            // TENLT
            // 
            this.TENLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLT.DataPropertyName = "MAKH";
            this.TENLT.HeaderText = "Mã khách hàng";
            this.TENLT.MinimumWidth = 6;
            this.TENLT.Name = "TENLT";
            // 
            // THOIGIANDT
            // 
            this.THOIGIANDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANDT.DataPropertyName = "MALT";
            this.THOIGIANDT.HeaderText = "Mã liệu trình";
            this.THOIGIANDT.MinimumWidth = 6;
            this.THOIGIANDT.Name = "THOIGIANDT";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // GIATIEN
            // 
            this.GIATIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIATIEN.DataPropertyName = "TRANGTHAI";
            this.GIATIEN.HeaderText = "Trạng thái";
            this.GIATIEN.MinimumWidth = 6;
            this.GIATIEN.Name = "GIATIEN";
            // 
            // Thoigian
            // 
            this.Thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thoigian.DataPropertyName = "THOIGIANBD";
            this.Thoigian.HeaderText = "Thời gian bắt đầu";
            this.Thoigian.MinimumWidth = 6;
            this.Thoigian.Name = "Thoigian";
            // 
            // THOIGIANKT
            // 
            this.THOIGIANKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANKT.DataPropertyName = "THOIGIANKT";
            this.THOIGIANKT.HeaderText = "Thời gian kết thúc";
            this.THOIGIANKT.MinimumWidth = 6;
            this.THOIGIANKT.Name = "THOIGIANKT";
            // 
            // btnDatLich
            // 
            this.btnDatLich.AutoRoundedCorners = true;
            this.btnDatLich.BorderRadius = 21;
            this.btnDatLich.CheckedState.Parent = this.btnDatLich;
            this.btnDatLich.CustomImages.Parent = this.btnDatLich;
            this.btnDatLich.FillColor = System.Drawing.Color.LightCoral;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.HoverState.Parent = this.btnDatLich;
            this.btnDatLich.Location = new System.Drawing.Point(1103, 103);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.ShadowDecoration.Parent = this.btnDatLich;
            this.btnDatLich.Size = new System.Drawing.Size(168, 45);
            this.btnDatLich.TabIndex = 37;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(552, 100);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(174, 31);
            this.cbxTenKH.TabIndex = 82;
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.lb_tenkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkh.Location = new System.Drawing.Point(373, 108);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(138, 23);
            this.lb_tenkh.TabIndex = 81;
            this.lb_tenkh.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 83;
            this.label1.Text = "Đặt Lịch Liệu Trình";
            // 
            // cbxTenLT
            // 
            this.cbxTenLT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenLT.FormattingEnabled = true;
            this.cbxTenLT.Location = new System.Drawing.Point(186, 159);
            this.cbxTenLT.Name = "cbxTenLT";
            this.cbxTenLT.Size = new System.Drawing.Size(174, 31);
            this.cbxTenLT.TabIndex = 85;
            this.cbxTenLT.SelectionChangeCommitted += new System.EventHandler(this.cbxTenLT_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = "Tên Liệu Trình";
            // 
            // txtThoigianDT
            // 
            this.txtThoigianDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoigianDT.Location = new System.Drawing.Point(186, 210);
            this.txtThoigianDT.Name = "txtThoigianDT";
            this.txtThoigianDT.ReadOnly = true;
            this.txtThoigianDT.Size = new System.Drawing.Size(158, 30);
            this.txtThoigianDT.TabIndex = 89;
            this.txtThoigianDT.TextChanged += new System.EventHandler(this.txtThoigianDT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 23);
            this.label6.TabIndex = 88;
            this.label6.Text = "Thời Gian ĐT(phút)";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(186, 260);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.Size = new System.Drawing.Size(158, 30);
            this.txtGiaTien.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "Giá Tiền ";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Location = new System.Drawing.Point(186, 105);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.ReadOnly = true;
            this.txtMaLH.Size = new System.Drawing.Size(174, 30);
            this.txtMaLH.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 92;
            this.label4.Text = "Mã LH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(373, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 98;
            this.label9.Text = "Thời Gian Bắt Đầu";
            // 
            // dateBD
            // 
            this.dateBD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateBD.Location = new System.Drawing.Point(552, 208);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(235, 30);
            this.dateBD.TabIndex = 97;
            this.dateBD.Value = new System.DateTime(2024, 11, 18, 21, 30, 11, 0);
            this.dateBD.ValueChanged += new System.EventHandler(this.dateBD_ValueChanged);
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
            this.btnLuu.Location = new System.Drawing.Point(1103, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(168, 45);
            this.btnLuu.TabIndex = 99;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 101;
            this.label3.Text = "Thời Gian Kết Thúc";
            // 
            // dateKT
            // 
            this.dateKT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateKT.Location = new System.Drawing.Point(552, 267);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(235, 30);
            this.dateKT.TabIndex = 100;
            this.dateKT.Value = new System.DateTime(2024, 11, 18, 21, 30, 11, 0);
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(552, 159);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(174, 31);
            this.cbxNhanVien.TabIndex = 103;
            // 
            // lb_nv
            // 
            this.lb_nv.AutoSize = true;
            this.lb_nv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.lb_nv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nv.Location = new System.Drawing.Point(373, 162);
            this.lb_nv.Name = "lb_nv";
            this.lb_nv.Size = new System.Drawing.Size(115, 23);
            this.lb_nv.TabIndex = 102;
            this.lb_nv.Text = "NV Phụ trách";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 21;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.LightCoral;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(1102, 276);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(168, 45);
            this.btnLamMoi.TabIndex = 104;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoRoundedCorners = true;
            this.btnThanhToan.BorderRadius = 21;
            this.btnThanhToan.CheckedState.Parent = this.btnThanhToan;
            this.btnThanhToan.CustomImages.Parent = this.btnThanhToan;
            this.btnThanhToan.FillColor = System.Drawing.Color.LightCoral;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.Parent = this.btnThanhToan;
            this.btnThanhToan.Location = new System.Drawing.Point(1102, 219);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(168, 45);
            this.btnThanhToan.TabIndex = 105;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(807, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 106;
            this.label7.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(924, 217);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(144, 30);
            this.txtMaHD.TabIndex = 107;
            // 
            // lb_layma
            // 
            this.lb_layma.AutoSize = true;
            this.lb_layma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_layma.Location = new System.Drawing.Point(1012, 194);
            this.lb_layma.Name = "lb_layma";
            this.lb_layma.Size = new System.Drawing.Size(56, 20);
            this.lb_layma.TabIndex = 113;
            this.lb_layma.Text = "Lấy mã";
            this.lb_layma.Click += new System.EventHandler(this.lb_layma_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(807, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 114;
            this.label8.Text = "NV Tạo HD";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(924, 269);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(144, 30);
            this.txtMaNV.TabIndex = 115;
            // 
            // frmDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1282, 730);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_layma);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbxNhanVien);
            this.Controls.Add(this.lb_nv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateKT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateBD);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThoigianDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTenLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTenKH);
            this.Controls.Add(this.lb_tenkh);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.bangDatLich);
            this.Name = "frmDatLich";
            this.Text = "frmDatLich";
            this.Load += new System.EventHandler(this.frmDatLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangDatLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bangDatLich;
        private Guna.UI2.WinForms.Guna2Button btnDatLich;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private System.Windows.Forms.Label lb_tenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoigianDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateBD;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateKT;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label lb_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANKT;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lb_layma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNV;
    }
}