
using Guna.UI2.WinForms.Suite;
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
namespace QuanLySpa
{
    public partial class frmSanPham : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        bool themDL = true;
        private Timer timer;
        private string manv_;
        public frmSanPham(string maNV)
        {
            InitializeComponent();
            manv_ = maNV;
            dateNgayNhap.Format = DateTimePickerFormat.Custom;
            dateNgayNhap.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            
            timer = new Timer();
            timer.Interval = 1000;  
            timer.Tick += Timer_Tick;  
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dateNgayNhap.Value = DateTime.Now;
        }

        private void set_null()
        {
            txtMaNSP.Text = "";
            txtDonGia.Text = "";
            txtSLNhap.Text = "";
            txtSLTon.Text = "";
            txtThanhTien.Text = "";
            txtGiaBan.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtChiecKhauSP.Text = "";
            txtDiemSP.Text = "";
        }

        private string matutang_sp()
        {

            string str = string.Format("SELECT TOP 1 MASP FROM SANPHAM ORDER BY MASP DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string msp;
            if (dt.Rows.Count == 0)
                msp = "SP001";
            else
            {
                string masp = dt.Rows[0]["MASP"].ToString();
                masp = masp.Substring(2);
                int so = int.Parse(masp) + 1;
                msp = "SP" + so.ToString("D3"); // d3 =  1 -> 001 , 10 -> 010
            }
            return msp;
        }

        private string matutang_nhapsp()
        {

            string str = string.Format("SELECT TOP 1 MANSP FROM NHAPSP ORDER BY MANSP DESC");// lay ma nhap sp moi nhat
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mnsp;
            if (dt.Rows.Count == 0)
                mnsp = "NSP001";
            else
            {
                string mansp = dt.Rows[0]["MANSP"].ToString();
                mansp = mansp.Substring(3);
                int so = int.Parse(mansp) + 1;
                mnsp = "NSP";
                mnsp = mnsp + so.ToString("D3");
            }
            return mnsp;
        }

        private void taobang()
        {
            string str = string.Format("SELECT * FROM SANPHAM");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt_sp = new DataTable();
            adp.Fill(dt_sp);
            bangSP.DataSource = dt_sp;
        }

        private void disable()
        {
            txtTenSP.Enabled = false;
            txtDonGia.Enabled = false;
            txtSLNhap.Enabled = false;
            txtSLTon.Enabled = false;
            txtGiaBan.Enabled = false;
            txtChiecKhauSP.Enabled = false;
            txtDiemSP.Enabled = false;
            //
            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
            btnLuu.Hide();
        }

        private void enable()
        {
            txtTenSP.Enabled = true;
            txtDonGia.Enabled = true;
            txtSLNhap.Enabled = true;
            txtGiaBan.Enabled = true;
            txtChiecKhauSP.Enabled = true;
            txtDiemSP.Enabled = true;
            //
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnLuu.Show();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            disable();
            taobang();
            txtMaNV.Text = manv_;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtMaSP.Text = matutang_sp();
            txtMaNSP.Text = matutang_nhapsp();
            txtSLTon.Enabled = false;
            themDL = true;
            timer.Start();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtDonGia.Enabled = false;
            txtSLNhap.Enabled = false;
            txtThanhTien.Enabled = false;
            dateNgayNhap.Enabled = false;
            themDL = false;
            timer.Start();
        }

        private bool check_null()
        {
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Không được để trống đơn giá.");
                return true;
            }
            if (txtSLNhap.Text == "")
            {
                MessageBox.Show("Không được để trống số lượng nhập");
                return true;
            }
            if (txtThanhTien.Text == "")
            {
                MessageBox.Show("Không được để trống thành tiền.");
                return true;
            }
            if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Không được để trống giá bán.");
                return true;
            }
            else
            {
                if (int.Parse(txtGiaBan.Text) <= int.Parse(txtDonGia.Text))
                {
                    MessageBox.Show("Giá bán phải lớn hơn giá nhập");
                    return true;
                }
            }
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Không được để trống tên mỹ phẩm.");
                return true;
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                return;
            }
            string sql_cthd = "SELECT * FROM CTHD WHERE MASP = '" + txtMaSP.Text + "'";
            adp = new SqlDataAdapter(sql_cthd, conn);
            DataTable dt_cthd = new DataTable();
            adp.Fill(dt_cthd);
            if (dt_cthd.Rows.Count != 0)
            {
                MessageBox.Show("Không thể xóa .");
            }
            else
            {
                conn.Open();
                string sqlDelnhapsp = string.Format("DELETE FROM NHAPSP WHERE MANSP = @MANSP");
                cmd = new SqlCommand(sqlDelnhapsp, conn);
                cmd.Parameters.AddWithValue("@MANSP", txtMaNSP.Text);
                int kq = cmd.ExecuteNonQuery();
                //
                string sqlSanpham = string.Format("DELETE FROM SANPHAM WHERE MASP = @MASP");
                SqlCommand cmd1 = new SqlCommand(sqlSanpham, conn);
                cmd1.Parameters.AddWithValue("@MASP", txtMaSP.Text);

                int kq1 = cmd1.ExecuteNonQuery();
                if (kq > 0 || kq1 > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                conn.Close();
            }
            set_null();
            disable();
            taobang();
        }

        private void ThemSP()
        {
            // thêm dữ liệu bảng sản phẩm
            string str_sp = string.Format("INSERT INTO SANPHAM (MASP, TENSP, SOLUONGTON, GIABAN, CHIECKHAU,DIEMSP) VALUES (@MASP, @TENSP, @SOLUONGTON, @GIABAN, @CHIECKHAU,@DIEMSP)");
            SqlCommand cmd_sp = new SqlCommand(str_sp, conn);
            cmd_sp.Parameters.AddWithValue("@MASP", txtMaSP.Text);
            cmd_sp.Parameters.AddWithValue("@TENSP", txtTenSP.Text);
            cmd_sp.Parameters.AddWithValue("@SOLUONGTON", txtSLNhap.Text);
            cmd_sp.Parameters.AddWithValue("@GIABAN", txtGiaBan.Text);
            cmd_sp.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhauSP.Text);
            cmd_sp.Parameters.AddWithValue("@DIEMSP", txtDiemSP.Text);
            int kq = cmd_sp.ExecuteNonQuery();
            //thêm dữ liệu bảng nhập sản phẩm
            string str_nsp = string.Format("INSERT INTO NHAPSP (MANSP,MASP,DONGIA,NGAYNHAP,SLNHAP,THANHTIEN,MANV) VALUES (@MANSP,@MASP,@DONGIA,@NGAYNHAP,@SLNHAP,@THANHTIEN,@MANV)");
            SqlCommand cmd_nsp = new SqlCommand(str_nsp, conn);
            cmd_nsp.Parameters.AddWithValue("@MANSP", txtMaNSP.Text);
            cmd_nsp.Parameters.AddWithValue("@MASP", txtMaSP.Text);
            cmd_nsp.Parameters.AddWithValue("@DONGIA", txtDonGia.Text);
            cmd_nsp.Parameters.AddWithValue("@NGAYNHAP", dateNgayNhap.Value);
            cmd_nsp.Parameters.AddWithValue("@SLNHAP", txtSLNhap.Text);
            cmd_nsp.Parameters.AddWithValue("@THANHTIEN", txtThanhTien.Text);
            cmd_nsp.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            int kq1 = cmd_nsp.ExecuteNonQuery();
            if (kq > 0 || kq1 > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void CapNhatSP()
        {
            string sql_updatesp = string.Format("UPDATE SANPHAM SET TENSP = @TENSP,GIABAN = @GIABAN,CHIECKHAU = @CHIECKHAU,DIEMSP = @DIEMSP WHERE MASP = @MASP ");
            SqlCommand cmd_updatesp = new SqlCommand(sql_updatesp, conn);
            cmd_updatesp.Parameters.AddWithValue("@TENSP", txtTenSP.Text);
            cmd_updatesp.Parameters.AddWithValue("@GIABAN", txtGiaBan.Text);
            cmd_updatesp.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhauSP.Text);
            cmd_updatesp.Parameters.AddWithValue("@DIEMSP", txtDiemSP.Text);
            cmd_updatesp.Parameters.AddWithValue("@MASP", txtMaSP.Text);
            int kq = cmd_updatesp.ExecuteNonQuery();
            MessageBox.Show(kq > 0 ? "Cập nhật thành công" : "Cập nhật thất bại");
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (themDL == true)
            {
                //kt thong tin co de trong hay khong
                bool null_ = check_null();
                if (null_ != true)
                {
                    ThemSP();
                }
            }
            else if (themDL == false)
            {
                CapNhatSP();
            }
            conn.Close();   
            set_null();
            disable();
            taobang();
            timer.Stop();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            disable();
            set_null();
            timer.Start();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            int dongia = 0;
            int soluong = 0;
            int giaban = 0;

            if (txtDonGia.Text == "")
            {
                txtThanhTien.Text = "";
                return;
            }
            else
            {
                if (int.TryParse(txtDonGia.Text, out giaban) == true)
                {
                    if (giaban <= 0)
                    {
                        MessageBox.Show("Đơn giá phải lớn hơn 0");
                        txtDonGia.Text = "";
                        return;
                    }
                    float gb = giaban * 110 / 100;
                    txtGiaBan.Text = ((int)gb).ToString();
                }
                else
                {
                    MessageBox.Show("Đơn giá phải là số");
                    txtDonGia.Text = "";
                    return;
                }
            }
            if (txtSLNhap.Text != "")
            {
                if (int.TryParse(txtDonGia.Text, out dongia) == true)
                {
                    if (int.TryParse(txtSLNhap.Text, out soluong) == true)
                    {
                        int thanhtien = dongia * soluong;
                        txtThanhTien.Text = thanhtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng phải là số.");
                        txtSLNhap.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Đơn giá phải là số.");
                    txtDonGia.Text = "";
                    return;
                }
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            int dg = 0;
            int sl = 0;
            if (txtSLNhap.Text == "")
            {
                txtThanhTien.Text = "";
                return;
            }
            else
            {
                if (int.TryParse(txtSLNhap.Text, out sl) == false)
                {
                    MessageBox.Show("Số lượng phải là số.");
                    txtSLNhap.Text = "";
                    return;
                }
                else
                {
                    if (sl <= 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0.");
                        txtSLNhap.Text = "";
                        return;
                    }
                }
            }
            if (txtDonGia.Text != "")
            {
                if (int.TryParse(txtSLNhap.Text, out sl) == true)
                {
                    if (int.TryParse(txtDonGia.Text, out dg) == true)
                    {
                        int thanhtien = dg * sl;
                        txtThanhTien.Text = thanhtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số.");
                        txtDonGia.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số.");
                    txtSLNhap.Text = "";
                }

            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            int gb = 0;
            if (txtGiaBan.Text == "")
            {
                return;
            }
            if (int.TryParse(txtGiaBan.Text, out gb) == false)
            {
                MessageBox.Show("Giá bán phải là số");
                txtGiaBan.Text = "";
                return;
            }
        }

        private void bangsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = bangSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = bangSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSLTon.Text = bangSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaBan.Text = bangSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChiecKhauSP.Text = bangSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiemSP.Text = bangSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void txtMasp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // lay ra mansp, dongia, thanhtien,manv  theo masp
                string sql = "SELECT * FROM NHAPSP WHERE MASP = '" + txtMaSP.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                DataTable dt_nsp = new DataTable();
                adp.Fill(dt_nsp);
                txtMaNSP.Text = dt_nsp.Rows[0]["MANSP"].ToString();
                txtDonGia.Text = dt_nsp.Rows[0]["DONGIA"].ToString();
                txtThanhTien.Text = dt_nsp.Rows[0]["THANHTIEN"].ToString();
                dateNgayNhap.Text = dt_nsp.Rows[0]["NGAYNHAP"].ToString();
            }
            catch
            {
               
            }

        }
    }
}
