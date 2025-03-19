
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace QuanLySpa
{
    public partial class frmMain : Form
    {
        private Timer timer;
        private Form currentFormChild;
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        public int kt;
        public string manv_ = "";
        public frmMain(string maNV)
        {
            InitializeComponent();
            manv_ = maNV;
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;  
            timer.Start();

            dateThu.Format = DateTimePickerFormat.Custom;
            dateThu.CustomFormat = "yyyy/MM/dd";
            dateThu.Value = DateTime.Now;

            dateChi.Format = DateTimePickerFormat.Custom;
            dateChi.CustomFormat = "yyyy/MM/dd";
            dateChi.Value = DateTime.Now;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now; 
            lb_date.Text = date.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham(manv_));
        }

        private void btnLieuTrinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLieuTrinh());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon(manv_));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDichVu());
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất.", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string update = string.Format("UPDATE NHANVIEN SET TRANGTHAI = N'Chờ' where MANV = @MANV ");
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@MANV", lb_manv.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
                this.Hide();
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.ShowDialog();
                this.Close();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            bangHD.Rows.Clear();
            bangLNV.Rows.Clear();
            bangNSP.Rows.Clear();
            string sql = string.Format("SELECT * FROM NHANVIEN WHERE MANV = '" + manv_ + "'");
            SqlDataAdapter adt = new SqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            adt.Fill(dataTable);
            lb_manv.Text = dataTable.Rows[0]["MANV"].ToString();
            lb_hoten.Text = dataTable.Rows[0]["HOTEN"].ToString();
            lb_sdt.Text = dataTable.Rows[0]["SDT"].ToString();
            if (kt == 0)
            {
                btnNhanVien.Visible = false;
                btnTaiKhoan.Visible = false;
                label4.Hide();
                label5.Hide();
                pan_thu.Hide();
                pan_chi.Hide();
            }

        }

        private void pic_home_Click(object sender, EventArgs e)
        {

            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnGoiDV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGoiDichVu());
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatLich(manv_));
        }

        private void btnTinhChi_Click(object sender, EventArgs e)
        {
            bangLNV.Rows.Clear();
            bangNSP.Rows.Clear();
            int chi = 0;
            //bang luong nhan vien theo ngay
            string sqlLuong = "SELECT * FROM LUONGNV WHERE CONVERT(DATE, NGAYTT) = @NGAYTT";
            SqlDataAdapter adp = new SqlDataAdapter(sqlLuong, conn);
            adp.SelectCommand.Parameters.AddWithValue("@NGAYTT", dateChi.Value.Date);
            DataTable dt_luongnv = new DataTable();
            adp.Fill(dt_luongnv);
            if (dt_luongnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu lương nhân viên.");
            }
            else
            {
                for (int i = 0; i < dt_luongnv.Rows.Count; i++)
                {
                    string cell_0 = dt_luongnv.Rows[i]["MANV"].ToString();
                    string cell_1 = dt_luongnv.Rows[i]["TIENTHUONG"].ToString();
                    string cell_2 = dt_luongnv.Rows[i]["TONGTIEN"].ToString();
                    bangLNV.Rows.Add(cell_0, cell_1, cell_2);
                    chi = chi + int.Parse(cell_2);
                }
            }
            //bang nhap san pham theo ngay
            string sqlNhapSP = "SELECT * FROM NHAPSP WHERE CONVERT(DATE, NGAYNHAP) = @NGAYNHAP";
            SqlDataAdapter adpNhapsp = new SqlDataAdapter(sqlNhapSP, conn);
            adpNhapsp.SelectCommand.Parameters.AddWithValue("@NGAYNHAP", dateChi.Value.Date);
            DataTable dtNhapsp = new DataTable();
            adpNhapsp.Fill(dtNhapsp);
            if (dtNhapsp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhập sản phẩm.");
            }
            else
            {
                for (int i = 0; i < dtNhapsp.Rows.Count; i++)
                {
                    string cell_0 = dtNhapsp.Rows[i]["MASP"].ToString();
                    string cell_1 = dtNhapsp.Rows[i]["MANV"].ToString();
                    string cell_2 = dtNhapsp.Rows[i]["THANHTIEN"].ToString();
                    bangNSP.Rows.Add(cell_0, cell_1, cell_2);
                    chi = chi + int.Parse(cell_2);

                }
            }
            lb_tongtienchi.Text = string.Format("{0:N0}", chi);
        }

        private void btnTinhThu_Click(object sender, EventArgs e)
        {
            int thu = 0;
            bangHD.Rows.Clear();
            string sqlHoaDon = "SELECT * FROM HOADON WHERE YEAR(NGAYTAO) = @Year AND MONTH(NGAYTAO) = @Month";
            SqlDataAdapter adp = new SqlDataAdapter(sqlHoaDon, conn);
            adp.SelectCommand.Parameters.AddWithValue("@Year", dateThu.Value.Year);
            adp.SelectCommand.Parameters.AddWithValue("@Month", dateThu.Value.Month);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string cell_0 = dt.Rows[i]["SOHD"].ToString();
                    string cell_1 = dt.Rows[i]["MAKH"].ToString();
                    string cell_2 = (dt.Rows[i]["NGAYTAO"].ToString()).Substring(0, 10);
                    string cell_3 = dt.Rows[i]["MANV"].ToString();
                    string cell_4 = dt.Rows[i]["TONGTIEN"].ToString();
                    bangHD.Rows.Add(cell_0, cell_1, cell_2, cell_3, cell_4);
                    thu = thu + int.Parse(cell_4);
                }
            }
            lb_tongtienthu.Text = string.Format("{0:N0}", thu);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan(manv_));
        }
    }
}
