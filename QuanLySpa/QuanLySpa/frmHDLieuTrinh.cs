using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLySpa
{
    public partial class frmHDLieuTrinh : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        int tongtien = 0;
        int dong = 0;
        int dong_lt = 0;
        private string manv_;
        public frmHDLieuTrinh(string maNV)
        {
            InitializeComponent();
            manv_ = maNV;
        }

        private void set_null()
        {
            cbxTenKH.Text = "";
            txtMaKH.Text = "";
            txtMaHD.Text = "";
            txtSDT.Text = "";
            lb_date.Text = "";
            bangSP.Rows.Clear();
            bangLT.Rows.Clear();
            //
            cbxTenKH.Enabled = true;
            btnXemHD.Show();
            lb_mahd.Hide();
            cbxMaHD.Hide();
            btnXuatHD.Hide();
        }
        public string matutang_hoadon()
        {
            string str = string.Format("SELECT TOP 1 SOHD FROM HOADON ORDER BY SOHD DESC");// lay mahd moi nhat
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mhd;
            if (dt.Rows.Count == 0)
                mhd = "HD001";
            else
            {
                string mahd = dt.Rows[0]["SOHD"].ToString();
                mahd = mahd.Substring(2);//lay phan so bo phan chu
                int so = int.Parse(mahd) + 1;
                mhd = "HD" + so.ToString("D3"); // d3 1 -> 001 , 10 -> 010
            }

            return mhd;
        }

        private void frmHDLieuTrinh_Load(object sender, EventArgs e)
        {
            set_null();
            load_kh();
            load_txtNV();
            load_sp();
            load_lieutrinh();
            load_nhanviengdv();
        }
        private void load_kh()
        {
            string khachhang = string.Format("SELECT * FROM KHACHHANG");
            adp = new SqlDataAdapter(khachhang, conn);
            DataTable dt_kh = new DataTable();
            adp.Fill(dt_kh);
            cbxTenKH.DataSource = dt_kh;
            cbxTenKH.DisplayMember = "HOTEN";
            cbxTenKH.ValueMember = "MAKH";
            cbxTenKH.SelectedIndex = -1;
        }

        private void load_txtNV()
        {

            string sql_nv = string.Format("SELECT * FROM NHANVIEN WHERE MANV= '" + manv_ + "'");
            adp = new SqlDataAdapter(sql_nv, conn);
            DataTable dt_qlnv = new DataTable();
            adp.Fill(dt_qlnv);
            txtMANV.Text = manv_;
            txtTenNV.Text = dt_qlnv.Rows[0]["HOTEN"].ToString();
        }

        private void load_sp()
        {
            //san pham
            string sp = string.Format("SELECT * FROM SANPHAM WHERE SOLUONGTON > 0");
            adp = new SqlDataAdapter(sp, conn);
            DataTable dt_sp = new DataTable();
            adp.Fill(dt_sp);
            col_TENSP.DataSource = dt_sp;
            col_TENSP.DisplayMember = "TENSP";
            col_TENSP.ValueMember = "MASP";
        }
        private void load_lieutrinh()
        {
            //lieu trinh
            string dichvu = string.Format("SELECT * FROM LIEUTRINH");
            adp = new SqlDataAdapter(dichvu, conn);
            DataTable dt_dichvu = new DataTable();
            adp.Fill(dt_dichvu);
            col_TENLT.DataSource = dt_dichvu;
            col_TENLT.DisplayMember = "TENLT";
            col_TENLT.ValueMember = "MALT";
        }

        private void load_nhanviengdv()
        {
            string trangthai = "Chờ";
            string col_nhanvien = string.Format("SELECT * FROM NHANVIEN WHERE TRANGTHAI = @TRANGTHAI");
            adp = new SqlDataAdapter(col_nhanvien, conn);
            adp.SelectCommand.Parameters.AddWithValue("@TRANGTHAI", trangthai);
            DataTable dt_nv = new DataTable();
            adp.Fill(dt_nv);
            col_NhanVien.DataSource = dt_nv;
            col_NhanVien.DisplayMember = "HOTEN";
            col_NhanVien.ValueMember = "MANV";
        }
        private bool kiemtra_slsp()
        {
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                if (bangSP.Rows[i].Cells[2].Value == null)
                    return true;
            }
            return false;
        }
        private void cbxTenKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string sql_kh = string.Format("SELECT * FROM KHACHHANG WHERE MAKH= '" + cbxTenKH.SelectedValue.ToString() + "' ");
                adp = new SqlDataAdapter(sql_kh, conn);
                DataTable dt_kh = new DataTable();
                adp.Fill(dt_kh);
                txtSDT.Text = dt_kh.Rows[0]["SDT"].ToString();
                txtMaKH.Text = dt_kh.Rows[0]["MAKH"].ToString();
            }
            catch
            {

            }
        }

        private void lb_layma_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now;
            txtMaHD.Text = matutang_hoadon();
            lb_date.Text = date.ToString("yyyy/MM/dd");
        }

        private void bangSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong != -1)
            {
                if (bangSP.Rows[dong].Cells[1].Value != null)
                    col_SoLuong.ReadOnly = false;
                else
                    col_SoLuong.ReadOnly = true;
            }
        }

        private void bangSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int uudai = 0;
            try
            {
                if (cbxTenKH.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.");
                    set_null();
                    return;
                }
                // Lấy thông tin khách hàng từ cơ sở dữ liệu
                string sql_kh = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH";
                SqlDataAdapter adpKH = new SqlDataAdapter(sql_kh, conn);
                adpKH.SelectCommand.Parameters.AddWithValue("@MAKH", cbxTenKH.SelectedValue.ToString());
                DataTable dtKH = new DataTable();
                adpKH.Fill(dtKH);
                if (dtKH.Rows.Count > 0)
                {
                    uudai = dtKH.Rows[0]["UUDAI"] == DBNull.Value ? 0 : int.Parse(dtKH.Rows[0]["UUDAI"].ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                    return;
                }
                // Tính thành tiền với ưu đãi
                int dong = e.RowIndex;
                if (bangSP.Rows[dong].Cells[2].Value != null && bangSP.Rows[dong].Cells[4].Value != null)
                {
                    double soluong = double.Parse(bangSP.Rows[dong].Cells[2].Value.ToString());
                    double giaban = double.Parse(bangSP.Rows[dong].Cells[4].Value.ToString());
                    bangSP.Rows[dong].Cells[5].Value = (soluong * giaban * (1 - uudai / 100.0)).ToString();
                }
                // Lấy thông tin sản phẩm từ cơ sở dữ liệu
                string masp = bangSP.Rows[e.RowIndex].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(masp))
                {
                    string sql_sp = "SELECT * FROM SANPHAM WHERE MASP = @MASP";
                    SqlDataAdapter adpSP = new SqlDataAdapter(sql_sp, conn);
                    adpSP.SelectCommand.Parameters.AddWithValue("@MASP", masp);
                    DataTable dtSP = new DataTable();
                    adpSP.Fill(dtSP);
                    if (dtSP.Rows.Count > 0)
                    {
                        bangSP.Rows[dong].Cells[0].Value = dtSP.Rows[0]["MASP"].ToString();
                        bangSP.Rows[dong].Cells[3].Value = dtSP.Rows[0]["SOLUONGTON"].ToString();
                        bangSP.Rows[dong].Cells[4].Value = dtSP.Rows[0]["GIABAN"].ToString();
                    }
                }
                // Kiểm tra số lượng và tính tổng tiền
                tongtien = 0;
                for (int i = 0; i < bangSP.Rows.Count - 1; i++)
                {
                    if (bangSP.Rows[i].Cells[1].Value != null && bangSP.Rows[i].Cells[2].Value == null)
                        bangSP.Rows[i].Cells[2].Value = "1";
                    if (int.TryParse(bangSP.Rows[i].Cells[2].Value?.ToString(), out int soluongNhap))
                    {
                        int soluongTon = int.Parse(bangSP.Rows[i].Cells[3].Value.ToString());
                        if (soluongNhap > soluongTon)
                        {
                            MessageBox.Show("Số lượng phải nhỏ hơn hoặc bằng số lượng tồn kho.");
                            return;
                        }
                        if (bangSP.Rows[i].Cells[5].Value != null)
                        {
                            tongtien += int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng phải là số nguyên hợp lệ.");
                        return;
                    }
                }
                for (int i = 0; i < bangLT.Rows.Count - 1; i++)
                {
                    if (bangLT.Rows[i].Cells[5].Value != null)
                        tongtien = tongtien + int.Parse(bangLT.Rows[i].Cells[5].Value.ToString());
                }
                lb_tongtien.Text = tongtien.ToString("N0");
                col_SoLuong.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void bangSP_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tongtien = 0;
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                if (bangSP.Rows[i].Cells[5].Value != null)
                    tongtien = tongtien + int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
            }
            for (int i = 0; i < bangLT.Rows.Count - 1; i++)
            {
                if (bangLT.Rows[i].Cells[5].Value != null)
                    tongtien = tongtien + int.Parse(bangLT.Rows[i].Cells[5].Value.ToString());

            }
            lb_tongtien.Text = tongtien.ToString("N0");
        }

        private void bangLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong_lt = e.RowIndex;
            if (dong_lt != -1)
            {
                if (bangLT.Rows[dong_lt].Cells[1].Value != null)
                {
                    col_SoLuongLT.ReadOnly = false;
                    col_NhanVien.ReadOnly = false;
                }
                else
                {
                    col_SoLuongLT.ReadOnly = true;
                    col_NhanVien.ReadOnly = true;
                }
            }
        }

        private void bangLT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int uudai = 0;
            try
            {
                if (cbxTenKH.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.");
                    set_null();
                    return;
                }
                string sql_kh = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH";
                SqlDataAdapter adpKH = new SqlDataAdapter(sql_kh, conn);
                adpKH.SelectCommand.Parameters.AddWithValue("@MAKH", cbxTenKH.SelectedValue.ToString());

                DataTable dtKH = new DataTable();
                adpKH.Fill(dtKH);
                if (dtKH.Rows.Count > 0)
                {
                    uudai = dtKH.Rows[0]["UUDAI"] == DBNull.Value ? 0 : int.Parse(dtKH.Rows[0]["UUDAI"].ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                    return;
                }
                dong_lt = e.RowIndex;
                //tinh tong tien
                if (bangLT.Rows[dong_lt].Cells[3].Value != null && bangLT.Rows[dong_lt].Cells[4].Value != null)
                {
                    double soluong = double.Parse(bangLT.Rows[dong_lt].Cells[3].Value.ToString());
                    double giatien = double.Parse(bangLT.Rows[dong_lt].Cells[4].Value.ToString());
                    bangLT.Rows[dong_lt].Cells[5].Value = (soluong * giatien * (1 - uudai / 100.0)).ToString();
                }
                //lay thong tin lieu trinh
                string malt = bangLT.Rows[e.RowIndex].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(malt))
                {
                    string str_dv = string.Format("SELECT * FROM LIEUTRINH WHERE MALT = '" + malt + "'");
                    SqlDataAdapter adp = new SqlDataAdapter(str_dv, conn);
                    DataTable dt_lt = new DataTable();
                    adp.Fill(dt_lt);
                    if (dt_lt.Rows.Count > 0)
                    {
                        bangLT.Rows[dong_lt].Cells[0].Value = dt_lt.Rows[0]["MALT"].ToString();
                        bangLT.Rows[dong_lt].Cells[2].Value = dt_lt.Rows[0]["THOIGIANDT"].ToString();
                        bangLT.Rows[dong_lt].Cells[4].Value = dt_lt.Rows[0]["GIATIEN"].ToString();
                    }
                }
                //them so luong con trong
                for (int i = 0; i < bangLT.Rows.Count - 1; i++)
                {
                    if (bangLT.Rows[i].Cells[1].Value != null && bangLT.Rows[i].Cells[3].Value == null)
                        bangLT.Rows[i].Cells[3].Value = "1";
                }
                //tinh  tong tien hoa don
                tongtien = 0;
                for (int i = 0; i < bangSP.Rows.Count - 1; i++)
                {
                    if (bangSP.Rows[i].Cells[5].Value != null)
                        tongtien = tongtien + int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
                }
                for (int i = 0; i < bangLT.Rows.Count - 1; i++)
                {
                    if (bangLT.Rows[i].Cells[5].Value != null)
                        tongtien = tongtien + int.Parse(bangLT.Rows[i].Cells[5].Value.ToString());
                }
                lb_tongtien.Text = tongtien.ToString("N0");
                col_SoLuongLT.ReadOnly = true;
                col_NhanVien.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void bangLT_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tongtien = 0;
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                if (bangSP.Rows[i].Cells[5].Value != null)
                    tongtien = tongtien + int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
            }
            for (int i = 0; i < bangLT.Rows.Count - 1; i++)
            {
                if (bangLT.Rows[i].Cells[5].Value != null)
                    tongtien = tongtien + int.Parse(bangLT.Rows[i].Cells[5].Value.ToString());

            }
            lb_tongtien.Text = tongtien.ToString("N0");
        }

        private void lbXoaLT_Click(object sender, EventArgs e)
        {
            try
            {
                bangLT.Rows.RemoveAt(dong_lt);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private void lbXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                bangSP.Rows.RemoveAt(dong);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private bool KTDuLieu()
        {
            if (string.IsNullOrEmpty(cbxTenKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return false;
            }
            else if (kiemtra_slsp() == true)
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return false;
            }
            return true;
        }
        private bool KTThongTin()
        {
            // kiểm tra số lương tồn kho
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                if (int.Parse(bangSP.Rows[i].Cells[2].Value.ToString()) > int.Parse(bangSP.Rows[i].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Số lượng phải nhỏ hơn tồn kho.");
                    return false;
                }
            }
            // kiểm tra trùng sản phầm
            for (int i = 0; i < bangSP.Rows.Count - 2; i++)
            {
                for (int j = i + 1; j < bangSP.Rows.Count - 1; j++)
                {
                    if (bangSP.Rows[i].Cells[0].Value.ToString() == bangSP.Rows[j].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Trùng sản phẩm " + bangSP.Rows[i].Cells[0].Value.ToString());
                        return false;
                    }
                }
            }
            for (int i = 0; i < bangLT.Rows.Count - 1; i++)
            {
                if (bangLT.Rows[i].Cells[6].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên.");
                    return false;
                }
            }
            for (int i = 0; i < bangLT.Rows.Count - 2; i++)
            {
                for (int j = i + 1; j < bangLT.Rows.Count - 1; j++)
                {
                    if (bangLT.Rows[i].Cells[0].Value.ToString() == bangLT.Rows[j].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Trùng liệu trình" + bangLT.Rows[i].Cells[0].Value.ToString());
                        return false;
                    }
                }
            }
            return true;
        }
        private void ThemDLHoaDon(int tongtien)
        {
            //thêm vào bảng hóa đơn
            string sql_hd = string.Format("INSERT INTO HOADON (SOHD,MANV,MAKH,TONGTIEN,NGAYTAO) VALUES (@SOHD,@MANV,@MAKH,@TONGTIEN,@NGAYTAO)");
            cmd = new SqlCommand(sql_hd, conn);
            cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
            cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
            cmd.Parameters.AddWithValue("@MAKH", cbxTenKH.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@TONGTIEN", tongtien);
            cmd.Parameters.AddWithValue("@NGAYTAO", lb_date.Text.ToString());
            cmd.ExecuteNonQuery();
        }
        private void ThemDLCTHDLT()
        {
            //them du lieu bang ctdt
            for (int i = 0; i < bangLT.Rows.Count - 1; i++)
            {
                string ctdv = string.Format("INSERT INTO CTHDLT (SOHD,MALT,MANV,SOLUONG,THANHTIEN)VALUES (@SOHD,@MALT,@MANV,@SOLUONG,@THANHTIEN)");
                cmd = new SqlCommand(ctdv, conn);
                cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
                cmd.Parameters.AddWithValue("@MALT", bangLT.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@MANV", bangLT.Rows[i].Cells[6].Value.ToString());
                cmd.Parameters.AddWithValue("@SOLUONG", bangLT.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@THANHTIEN", bangLT.Rows[i].Cells[5].Value.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        private void ThemDLCTHD()
        {
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                string cthd = string.Format("INSERT INTO CTHD (SOHD,MASP,THANHTIENSP,SOLUONG)VALUES (@SOHD,@MASP,@THANHTIENSP,@SOLUONG)");
                cmd = new SqlCommand(cthd, conn);
                cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
                cmd.Parameters.AddWithValue("@MASP", bangSP.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@THANHTIENSP", bangSP.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@SOLUONG", bangSP.Rows[i].Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();
            }
        }
        private void CapNhatSLTon()
        {
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                int sl_updated = 0;
                sl_updated = int.Parse(bangSP.Rows[i].Cells[3].Value.ToString()) - int.Parse(bangSP.Rows[i].Cells[2].Value.ToString());
                string updateSL = string.Format("UPDATE SANPHAM SET SOLUONGTON = @SOLUONGTON WHERE MASP = @MASP");
                cmd = new SqlCommand(updateSL, conn);
                cmd.Parameters.AddWithValue("@SOLUONGTON", sl_updated);
                cmd.Parameters.AddWithValue("@MASP", bangSP.Rows[i].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
            }
        }
        private void CapNhatDiemKH()
        {
            //cập nhật điểm tích lũy khách hàng
            string diemtl = @"
                UPDATE KHACHHANG 
                SET DIEMTL = DIEMTL + ( SELECT COALESCE(SUM(SANPHAM.DIEMSP * CTHD.SOLUONG), 0)
                FROM CTHD
                INNER JOIN SANPHAM ON CTHD.MASP = SANPHAM.MASP
                WHERE CTHD.SOHD = @SOHD)
                + ( SELECT COALESCE(SUM(LIEUTRINH.DIEMLT * CTHDLT.SOLUONG), 0)
                FROM CTHDLT
                INNER JOIN LIEUTRINH ON CTHDLT.MALT = LIEUTRINH.MALT
                WHERE CTHDLT.SOHD = @SOHD)
                WHERE KHACHHANG.MAKH = ( SELECT HOADON.MAKH FROM HOADON WHERE HOADON.SOHD = @SOHD)";
            cmd = new SqlCommand(diemtl, conn);
            cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
            cmd.ExecuteNonQuery();
        }
        private void CapNhatLoaiThe()
        {
            string update = @"
                UPDATE KHACHHANG
                SET
                    LOAITHE = CASE 
                    WHEN DIEMTL >= 10000 THEN N'Vàng'
                    WHEN DIEMTL >= 5000 THEN N'Bạc'
                    ELSE N'Thường'
                END,
                UUDAI = CASE 
                    WHEN DIEMTL >= 10000 THEN 5  -- Ưu đãi 5% cho thẻ vàng
                    WHEN DIEMTL >= 5000 THEN 2   -- Ưu đãi 2% cho thẻ bạc
                    ELSE 0                       -- Không có ưu đãi cho thẻ thường
                END
                    WHERE KHACHHANG.MAKH = (SELECT MAKH FROM HOADON WHERE SOHD = @SOHD)";
            cmd = new SqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
            cmd.ExecuteNonQuery();
        }
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KTDuLieu()) return;
                if (!KTThongTin()) return;
                int.TryParse(lb_tongtien.Text.Replace(",", "").Replace(".", ""), out int tongtien);
                conn.Open();
                ThemDLHoaDon(tongtien);
                ThemDLCTHDLT();
                ThemDLCTHD();
                CapNhatSLTon();
                CapNhatDiemKH();
                CapNhatLoaiThe();
                MessageBox.Show("Tạo hóa đơn thành công");
                set_null();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenKH.SelectedValue != null)
            {
                try
                {
                    string sql_kh = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH";
                    SqlDataAdapter adpKH = new SqlDataAdapter(sql_kh, conn);
                    adpKH.SelectCommand.Parameters.AddWithValue("@MAKH", cbxTenKH.SelectedValue.ToString());

                    DataTable dtKH = new DataTable();
                    adpKH.Fill(dtKH);

                    if (dtKH.Rows.Count > 0)
                    {
                        int uudai = dtKH.Rows[0]["UUDAI"] == DBNull.Value ? 0 : int.Parse(dtKH.Rows[0]["UUDAI"].ToString());

                        // Làm mới bảng sản phẩm
                        foreach (DataGridViewRow row in bangSP.Rows)
                        {
                            if (row.Cells[1].Value != null) // Nếu có sản phẩm được chọn
                            {
                                double soluong = double.Parse(row.Cells[2].Value.ToString());
                                double giaban = double.Parse(row.Cells[4].Value.ToString());
                                row.Cells[5].Value = (soluong * giaban * (1 - uudai / 100.0)).ToString(); // Tính lại thành tiền
                            }
                        }

                        // Làm mới bảng liệu trình
                        foreach (DataGridViewRow row in bangLT.Rows)
                        {
                            if (row.Cells[1].Value != null) // Nếu có liệu trình được chọn
                            {
                                double soluong = double.Parse(row.Cells[2].Value.ToString());
                                double giaban = double.Parse(row.Cells[4].Value.ToString());
                                row.Cells[5].Value = (soluong * giaban * (1 - uudai / 100.0)).ToString(); // Tính lại thành tiền
                            }
                        }

                        // Cập nhật lại tổng tiền
                        tongtien = 0;
                        for (int i = 0; i < bangSP.Rows.Count - 1; i++)
                        {
                            if (bangSP.Rows[i].Cells[5].Value != null)
                                tongtien = tongtien + int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
                        }
                        for (int i = 0; i < bangLT.Rows.Count - 1; i++)
                        {
                            if (bangLT.Rows[i].Cells[5].Value != null)
                                tongtien = tongtien + int.Parse(bangLT.Rows[i].Cells[5].Value.ToString());

                        }
                        lb_tongtien.Text = tongtien.ToString("N0");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            string str_hd = @"
            SELECT HOADON.SOHD FROM HOADON
            JOIN CTHDLT ON HOADON.SOHD = CTHDLT.SOHD
            LEFT JOIN CTHD  ON HOADON.SOHD =CTHD.SOHD
            WHERE not exists ( select 1 from CTHDDV join DICHVU on DICHVU.MADV = CTHDDV.MADV where CTHDDV.SOHD = HOADON.SOHD)
	              and not exists ( select 1 from CTHDGOI join GOIDICHVU on GOIDICHVU.MAGOIDV = CTHDGOI.MAGOIDV where CTHDGOI.SOHD = HOADON.SOHD)
            GROUP BY HOADON.SOHD";
            adp = new SqlDataAdapter(str_hd,conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbxMaHD.DataSource = dt;
            cbxMaHD.DisplayMember = "SOHD";
            cbxMaHD.ValueMember = "SOHD";
            cbxMaHD.SelectedIndex = -1;
            //
            lb_mahd.Show();
            cbxMaHD.Show();
            btnXuatHD.Show();
            btnXemHD.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            set_null();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (cbxMaHD.SelectedValue == null )
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            string sohd = cbxMaHD.SelectedValue.ToString();
            
            frmPhieuHD frm = new frmPhieuHD(sohd, conn);
            frm.Show();
        }

    }
      
}
