
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLySpa
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        bool themDL;
        public frmNhanVien()
        {
            InitializeComponent();
        }


        private void set_null()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cbxGioitinh.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
        }

        private void disable()
        {
            txtMaNV.Enabled = false;
            txtHoTen.Enabled = false;
            cbxGioitinh.Enabled = false;
            txtSDT.Enabled = false;
            txtLuong.Enabled = false;
            //
            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
            btnLuong.Show();
            btnLuu.Hide();

        }

        private void enable()
        {
            txtMaNV.Enabled = true;
            txtHoTen.Enabled = true;
            cbxGioitinh.Enabled = true;
            txtSDT.Enabled = true;
            txtLuong.Enabled = true;
            //
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnLuong.Show();
            btnLuu.Show();
        }

        private void hide()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            //
            txtMaNV.Hide();
            txtHoTen.Hide();
            cbxGioitinh.Hide();
            txtSDT.Hide();
            dateBD.Hide();
            dateKT.Hide();
            txtLuong.Hide();
            //
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnLuu.Hide();
            btnLuong.Hide();

        }
        private void show()
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            //
            txtMaNV.Show();
            txtHoTen.Show();
            cbxGioitinh.Show();
            txtSDT.Show();
            dateBD.Show();
            dateKT.Show();
            txtLuong.Show();
            //
            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
            btnLuu.Show();
            btnLuong.Show();

            cbxTinhluong.Hide();
            btnTinhluong.Hide();


        }
        private string matutang_nhanvien()
        {

            string str = string.Format("SELECT TOP 1 MANV FROM NHANVIEN ORDER BY MANV DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mnv;
            if (dt.Rows.Count == 0)
                mnv = "NV001";
            else
            {
                string manv = dt.Rows[0]["MANV"].ToString();
                manv = manv.Substring(2);
                int so = int.Parse(manv) + 1;
                mnv = "NV";
                mnv = mnv + so.ToString("D3");
            }
            return mnv;
        }
        private void taobang()
        {
            string str = string.Format("SELECT * FROM NHANVIEN WHERE MANV != 'ADMIN' ");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt_nv = new DataTable();
            adp.Fill(dt_nv);
            bangNV.DataSource = dt_nv;
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            cbxTinhluong.Show();
            btnTinhluong.Show();
            hide();
            string str = string.Format("SELECT * FROM NHANVIEN WHERE MANV != 'ADMIN'");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt_nv = new DataTable();
            adp.Fill(dt_nv);
            cbxTinhluong.DataSource = dt_nv;
            cbxTinhluong.DisplayMember = "MANV";
            cbxTinhluong.ValueMember = "MANV";
            cbxTinhluong.SelectedIndex = -1;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            set_null();
            disable();
            cbxTinhluong.Hide();
            btnTinhluong.Hide();
            taobang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtMaNV.Text = matutang_nhanvien();
            themDL = true;
            bangNV.CellClick -= bangnv_CellClick;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            themDL = false;
            bangNV.CellClick += bangnv_CellClick;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                return;
            }
            string sql_nv = @"SELECT MANV FROM (SELECT MANV FROM CTHDDV  UNION 
                                SELECT MANV FROM CTHDLT UNION
                                SELECT MANV FROM CTHDGOI) as manv
                                where MANV = @MANV
                                GROUP BY MANV";
            adp = new SqlDataAdapter(sql_nv, conn);
            adp.SelectCommand.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            DataTable dt_nv = new DataTable();
            adp.Fill(dt_nv);
            if (dt_nv.Rows.Count != 0)
            {
                MessageBox.Show("Không thể xóa .");
            }
            else
            {
                conn.Open();
                string sql = string.Format("DELETE FROM NHANVIEN WHERE MANV = @MANV");
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xóa thành công." : "Xóa thất bại.");
                }
                conn.Close();
            }
            set_null();
            taobang();
        }

        private bool KTDuLieu()
        {
            int i;
            if (txtHoTen.Text == null ||
                cbxGioitinh.Text == null ||
                txtSDT.Text == null ||
                txtLuong.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else if (int.TryParse(txtSDT.Text, out i) == false)
            {
                MessageBox.Show("Số điện thoại phải là số");
                return false;
            }
            else if (int.TryParse(txtLuong.Text, out i) == false)
            {
                MessageBox.Show("Lương phải là số");
                return false;
            }
            return true;
        }

        private void ThemNV()
        {
            string trangthai = "Chờ";
            string sql = string.Format("INSERT INTO NHANVIEN (MANV,HOTEN,GIOITINH,SDT,NBDHD,NKTHD,LUONG,TRANGTHAI) VALUES " +
                       "(@MANV,@HOTEN,@GIOITINH,@SDT,@NBDHD,@NKTHD,@LUONG,@TRANGTHAI)");
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("@HOTEN", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@GIOITINH", cbxGioitinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@NBDHD", dateBD.Value);
            cmd.Parameters.AddWithValue("@NKTHD", dateKT.Value);
            cmd.Parameters.AddWithValue("@LUONG", txtLuong.Text);
            cmd.Parameters.AddWithValue("@TRANGTHAI", trangthai);
            int kq = cmd.ExecuteNonQuery();
            MessageBox.Show(kq > 0 ? "Thêm thành công" : "Thêm thất bại.");
        }
        private void CapNhatNV()
        {
            string sql = string.Format("UPDATE NHANVIEN SET HOTEN = @HOTEN,GIOITINH = @GIOITINH,SDT= @SDT,NBDHD =@NBDHD ,NKTHD = @NKTHD,LUONG = @LUONG WHERE  MANV = @MANV ");
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@HOTEN", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@GIOITINH", cbxGioitinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@NBDHD", dateBD.Value);
            cmd.Parameters.AddWithValue("@NKTHD", dateKT.Value);
            cmd.Parameters.AddWithValue("@LUONG", txtLuong.Text);
            cmd.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            int kq = cmd.ExecuteNonQuery();
            MessageBox.Show(kq > 0 ? "Cập nhật thành công." : "Cập nhật thất bại.");

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KTDuLieu())
            {
                try
                {
                    conn.Open();
                    if (themDL == true)
                    {
                        ThemNV();
                    }
                    else
                    {
                        CapNhatNV();
                    }
                    conn.Close();
                    set_null();
                    disable();
                    taobang();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            show();
            disable();
            set_null();
            bangNV.CellClick += bangnv_CellClick;
        }

        private void bangnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = bangNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = bangNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxGioitinh.Text = bangNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = bangNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateBD.Text = bangNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateKT.Text = bangNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLuong.Text = bangNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                
            }
        }
        public string matutang_luongnv()
        {
            string str = string.Format("SELECT TOP 1 MATT FROM LUONGNV ORDER BY MATT DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string ml;
            if (dt.Rows.Count == 0)
            {
                ml = "LNV001";
            }
            else
            {
                string mal = dt.Rows[0]["MATT"].ToString();
                mal = mal.Substring(3);
                int so = int.Parse(mal) + 1;
                ml = "LNV";
                ml = ml + so.ToString("D3");
            }
            return ml;
        }

        private DataTable GetDataTable(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        private bool CheckNV(string MaNV, string Thang)
        {
            string check = string.Format("SELECT * FROM LUONGNV WHERE MANV = '" + MaNV + "'AND MONTH(NGAYTT) = '" + Thang + "'");
            DataTable tb_nv = GetDataTable(check);
            return tb_nv.Rows.Count > 0;
        }

        private DataRow GetNV(string MaNV)
        {
            string sql_nv = string.Format("SELECT * FROM NHANVIEN WHERE MANV = '" + MaNV + "' ");
            DataTable dt_nv = GetDataTable(sql_nv);
            if (dt_nv.Rows.Count > 0)
            {
                return dt_nv.Rows[0];
            }
            else
            {
                return null;
            }
        }
        private int GetChiecKhauLT()
        {
            string sql_lt = string.Format("SELECT * FROM LIEUTRINH ");
            DataTable dt_lt = GetDataTable(sql_lt);
            if (dt_lt.Rows.Count > 0)
            {
                return int.Parse(dt_lt.Rows[0]["CHIECKHAU"].ToString());
            }
            else
            {
                return 0;
            }
        }

        private int GetChiecKhauDV()
        {
            string sql_dv = "SELECT * FROM DICHVU";
            DataTable dt_dv = GetDataTable(sql_dv);
            if (dt_dv.Rows.Count > 0)
            {
                return int.Parse(dt_dv.Rows[0]["CHIECKHAU"].ToString());
            }
            else
            {
                return 0;
            }
        }

        private int GetChiecKhauGDV()
        {
            string sql_gdv = "SELECT * FROM GOIDICHVU";
            DataTable dt_gdv = GetDataTable(sql_gdv);
            if (dt_gdv.Rows.Count > 0)
            {
                return int.Parse(dt_gdv.Rows[0]["CHIECKHAU"].ToString());
            }
            else
            {
                return 0;
            }
        }
        private float TienThuongLT(string MaNV, string Thang)
        {
            string sql_hd = string.Format("SELECT * FROM HOADON WHERE MONTH(NGAYTAO) ='" + Thang + "'");
            DataTable tb_hd = GetDataTable(sql_hd);
            int chieckhau = GetChiecKhauLT();
            float tienthuonglt = 0;
            foreach (DataRow row in tb_hd.Rows)
            {
                string sohd = row["SOHD"].ToString();
                string sql_ctdt = string.Format("SELECT * FROM CTHDLT WHERE MANV = '" + MaNV + "' AND SOHD = '" + sohd + "'");
                DataTable tb_ctdt = GetDataTable(sql_ctdt);

                if (tb_ctdt.Rows.Count > 0)
                {
                    int soluong = int.Parse(tb_ctdt.Rows[0]["SOLUONG"].ToString());
                    int thanhtien = int.Parse(tb_ctdt.Rows[0]["THANHTIEN"].ToString());
                    tienthuonglt = (soluong * thanhtien) * chieckhau / 100;
                }

            }
            return tienthuonglt;
        }
        private float TienThuongDV(string manv, string thang)
        {
            float tienthuongdv = 0;
            string sql_hd = string.Format("SELECT * FROM HOADON WHERE MONTH(NGAYTAO) = '" + thang + "'");
            DataTable tb_hd = GetDataTable(sql_hd);
            int chieckhau = GetChiecKhauDV();
            foreach (DataRow row in tb_hd.Rows)
            {
                string sohd = row["SOHD"].ToString();
                string sql_ctdv = string.Format("SELECT * FROM CTHDDV WHERE MANV = '" + manv + "' AND SOHD = '" + sohd + "'");
                DataTable tb_ctdv = GetDataTable(sql_ctdv);
                if (tb_ctdv.Rows.Count > 0)
                {
                    int soluong = int.Parse(tb_ctdv.Rows[0]["SOLUONG"].ToString());
                    int thanhtien = int.Parse(tb_ctdv.Rows[0]["THANHTIEN"].ToString());
                    tienthuongdv = (soluong * thanhtien) * chieckhau / 100;
                }
            }
            return tienthuongdv;
        }

        private float TienThuongGDV(string manv, string thang)
        {
            float tienthuonggdv = 0;
            string sql_hd = string.Format("SELECT * FROM HOADON WHERE MONTH(NGAYTAO) = '" + thang + "'");
            DataTable tb_hd = GetDataTable(sql_hd);
            int chieckhau = GetChiecKhauGDV();
            foreach (DataRow row in tb_hd.Rows)
            {
                string sohd = row["SOHD"].ToString();
                string sql_ctdv = string.Format("SELECT * FROM CTHDGOI WHERE MANV = '" + manv + "' AND SOHD = '" + sohd + "'");
                DataTable tb_ctdv = GetDataTable(sql_ctdv);
                if (tb_ctdv.Rows.Count > 0)
                {
                    int soluong = int.Parse(tb_ctdv.Rows[0]["SOLUONG"].ToString());
                    int thanhtien = int.Parse(tb_ctdv.Rows[0]["THANHTIEN"].ToString());
                    tienthuonggdv = (soluong * thanhtien) * chieckhau / 100;
                }
            }
            return tienthuonggdv;
        }

        private float TongTienThuong(string manv, string thang)
        {
            float tienthuongLT = TienThuongLT(manv, thang);
            float tienthuongDV = TienThuongDV(manv, thang);
            float tienthuongGDV = TienThuongGDV(manv, thang);

            return tienthuongLT + tienthuongDV + tienthuongGDV;
        }

        private void ThemDLBangLuongNV(string MaNV, int TienThuong, int TongTien)
        {
            DateTime dateTime = DateTime.UtcNow.Date;

            string sql_Insert = string.Format("INSERT INTO LUONGNV (MANV,MATT,NGAYTT,TIENTHUONG,TONGTIEN) VALUES (@MANV,@MATT,@NGAYTT,@TIENTHUONG,@TONGTIEN)");
            cmd = new SqlCommand(sql_Insert, conn);
            cmd.Parameters.AddWithValue("@MANV", MaNV);
            cmd.Parameters.AddWithValue("@MATT", matutang_luongnv());
            cmd.Parameters.AddWithValue("@NGAYTT", dateTime.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TIENTHUONG", TienThuong);
            cmd.Parameters.AddWithValue("@TONGTIEN", TongTien);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxTinhluong.Text == "")
                {
                    MessageBox.Show("Chưa chọn nhân viên.Vui lòng chọn 1 nhân viên");
                    return;
                }
                string manv = cbxTinhluong.SelectedValue.ToString();
                string Thang = DateTime.Now.ToString("MM");

                if (CheckNV(manv, Thang))
                {
                    MessageBox.Show("Nhân viên đã được thanh toán lương cho tháng này.");
                    return;
                }
                DataRow ThongTinNV = GetNV(manv);
                if (ThongTinNV == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                    return;
                }
                int LuongCB = int.Parse(ThongTinNV["LUONG"].ToString());
                float TienThuong = TongTienThuong(manv, Thang);
                int TongTien = LuongCB + (int)TienThuong;

                ThemDLBangLuongNV(manv, (int)TienThuong, TongTien);
                MessageBox.Show($"Đã thanh toán lương nhân viên {manv} ngày {DateTime.UtcNow:dd-MM-yyyy} số tiền: {TongTien:N0} VND");
                show();
                set_null();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
