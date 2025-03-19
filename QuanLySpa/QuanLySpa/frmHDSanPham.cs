using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace QuanLySpa.Image
{
    public partial class frmHDSanPham : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        int tongtien = 0;
        int dong = 0;
        private string manv_;
        public frmHDSanPham(string maNV)
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
            cbxTenKH.Enabled = true;
            guna2Button1.Show();
            lb_mahd.Hide();
            cbxMaHD.Hide();
            btnXuatHD.Hide();
          
        }
        public string matutang_hoadon()
        {
            string str = string.Format("SELECT TOP 1 SOHD FROM HOADON ORDER BY SOHD DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mhd;
            if (dt.Rows.Count == 0)
                mhd = "HD001";
            else
            {
                string mahd = dt.Rows[0]["SOHD"].ToString();
                mahd = mahd.Substring(2);
                int so = int.Parse(mahd) + 1;
                mhd = "HD" + so.ToString("D3"); // d3 1 -> 001 , 10 -> 010
            }
            return mhd;
        }
        private void frmHDSanPham_Load(object sender, EventArgs e)
        {
            set_null();
            load_kh();
            load_sp();
            load_txtNV();
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
                // Kiểm tra khách hàng hợp lệ
                if (cbxTenKH.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.");
                    set_null();
                    return;
                }
                //
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
                //
                if (bangSP.Rows[dong].Cells[2].Value != null && bangSP.Rows[dong].Cells[4].Value != null)
                {
                    double soluong = double.Parse(bangSP.Rows[dong].Cells[2].Value.ToString());
                    double giaban = double.Parse(bangSP.Rows[dong].Cells[4].Value.ToString());
                    bangSP.Rows[dong].Cells[5].Value = (soluong * giaban * (1 - uudai / 100.0)).ToString();
                }
                //
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
                //
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
                            return ;
                        }
                        if (bangSP.Rows[i].Cells[5].Value != null)
                        {
                            tongtien += int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng phải là số nguyên hợp lệ.");
                        return ;
                    }
                }

                lb_tongtien.Text = tongtien.ToString("N0");
                col_SoLuong.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
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

        // kiem tra so luong san pham
        bool kiemtra_slsp()
        {
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                if (bangSP.Rows[i].Cells[2].Value == null)
                    return true;
            }
            return false;
        }

        private void lb_layma_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now;
            txtMaHD.Text = matutang_hoadon();
            lb_date.Text = date.ToString("yyyy/MM/dd");
        }

        private void lb_xoa_Click(object sender, EventArgs e)
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

        private void bangSP_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //tinh lai tong tien cua bang san pham
            tongtien = 0;
            for (int i = 0; i < bangSP.Rows.Count - 1; i++)
            {
                if (bangSP.Rows[i].Cells[5].Value != null)
                    tongtien = tongtien + int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
            }
            lb_tongtien.Text = tongtien.ToString("N0");
        }

        private bool KTDuLieu()
        {
            if (string.IsNullOrEmpty(cbxTenKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return false;
            }
            else if (bangSP.Rows.Count <= 1)
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm.");
                return false;
            }
            else if (kiemtra_slsp() == true)
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return false;
            }
            return true;
        }
        private bool KTSanPham()
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
            // cập nhật điểm tích lũy của khách hàng
            string diemtl = @"UPDATE KHACHHANG SET DIEMTL = DIEMTL + (
                SELECT COALESCE(SUM(SANPHAM.DIEMSP * CTHD.SOLUONG), 0) 
                FROM CTHD 
                INNER JOIN SANPHAM  ON CTHD.MASP = SANPHAM.MASP
                WHERE CTHD.SOHD = @SOHD) 
                WHERE KHACHHANG.MAKH = (
                SELECT HOADON.MAKH FROM HOADON WHERE HOADON.SOHD = @SOHD)";
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
                    WHERE KHACHHANG.MAKH = (
                SELECT MAKH FROM HOADON WHERE SOHD = @SOHD)";
            cmd = new SqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
            cmd.ExecuteNonQuery();
        }
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KTDuLieu()) return;
                if (!KTSanPham()) return;
                int.TryParse(lb_tongtien.Text.Replace(",", "").Replace(".", ""), out int tongtien);
                conn.Open();
                ThemDLHoaDon(tongtien);
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
                        foreach (DataGridViewRow row in bangSP.Rows)
                        {
                            if (row.Cells[1].Value != null) 
                            {
                                double soluong = double.Parse(row.Cells[2].Value.ToString());
                                double giaban = double.Parse(row.Cells[4].Value.ToString());
                                row.Cells[5].Value = (soluong * giaban * (1 - uudai / 100.0)).ToString(); 
                            }
                        }
                        tongtien = 0;
                        for (int i = 0; i < bangSP.Rows.Count - 1; i++)
                        {
                            if (bangSP.Rows[i].Cells[5].Value != null)
                                tongtien = tongtien + int.Parse(bangSP.Rows[i].Cells[5].Value.ToString());
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

        // xem hd
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //load sohd vao combobox
            string str_hd = @"SELECT HOADON.SOHD 
                FROM HOADON 
                JOIN CTHD  ON HOADON.SOHD =CTHD.SOHD 
                WHERE NOT EXISTS (SELECT 1 FROM CTHDLT JOIN LIEUTRINH  ON CTHDLT.MALT = LIEUTRINH.MALT    WHERE CTHDLT.SOHD = HOADON.SOHD ) 
                and not exists ( select 1 from CTHDDV join DICHVU on DICHVU.MADV = CTHDDV.MADV where CTHDDV.SOHD = HOADON.SOHD) 
                and not exists ( select 1 from CTHDGOI join GOIDICHVU on GOIDICHVU.MAGOIDV = CTHDGOI.MAGOIDV where CTHDGOI.SOHD = HOADON.SOHD)
                GROUP BY HOADON.SOHD";
            adp = new SqlDataAdapter(str_hd, conn);
            DataTable dt_hd = new DataTable();
            adp.Fill(dt_hd);
            cbxMaHD.DataSource = dt_hd;
            cbxMaHD.DisplayMember = "SOHD";
            cbxMaHD.ValueMember = "SOHD";
            cbxMaHD.SelectedIndex = -1;
            //
            lb_mahd.Show();
            cbxMaHD.Show();
            btnXuatHD.Show();
            guna2Button1.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            set_null();
          
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (cbxMaHD.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            string sohd = cbxMaHD.SelectedValue.ToString();
            frmPhieuHD frm = new frmPhieuHD(sohd,conn);
            frm.Show();
        }

  
    }
}
