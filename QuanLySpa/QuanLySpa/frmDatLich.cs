using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace QuanLySpa
{
    public partial class frmDatLich : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        private string manv_;
        public frmDatLich(string maNV)
        {
            InitializeComponent();
            dateBD.Format = DateTimePickerFormat.Custom;
            dateBD.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dateBD.Value = DateTime.Now;

            dateKT.Format = DateTimePickerFormat.Custom;
            dateKT.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dateKT.Value = DateTime.Now;
            manv_ = maNV;

        }

        private void calculateKT()
        {
            DateTime timeBD = dateBD.Value;
            if (int.TryParse(txtThoigianDT.Text, out int timeDT))
            {
                DateTime timeKT = timeBD.AddMinutes(timeDT);
                dateKT.Value = timeKT;
            }
        }

        private void set_null()
        {
            txtMaLH.Text = "";
            cbxTenKH.Text = "";
            cbxTenLT.Text = "";
            cbxNhanVien.Text = "";
            txtThoigianDT.Text = "";
            txtGiaTien.Text = "";
            txtMaHD.Text = "";

        }
        private string matutang_datlich()
        {

            string str = string.Format("SELECT TOP 1 MALICHHEN FROM LICHHEN ORDER BY MALICHHEN DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mlt;
            if (dt.Rows.Count == 0)
                mlt = "LH001";
            else
            {
                string malt = dt.Rows[0]["MALICHHEN"].ToString();
                malt = malt.Substring(2);
                int so = int.Parse(malt) + 1;
                mlt = "LH";
                mlt = mlt + so.ToString("D3");
            }
            return mlt;
        }

        private void frmDatLich_Load(object sender, EventArgs e)
        {
            load_kh();
            load_nv();
            load_lieutrinh();
            set_null();
            taobang();
            btnLuu.Hide();
            btnDatLich.Show();
            txtMaNV.Text = manv_;
        }
        private void taobang()
        {
            string sql_lh = string.Format("SELECT * FROM LICHHEN");
            adp = new SqlDataAdapter(sql_lh, conn);
            DataTable dt_lh = new DataTable();
            adp.Fill(dt_lh);
            bangDatLich.DataSource = dt_lh;
        }

        private void load_kh()
        {
            string sql_kh = string.Format("SELECT * FROM KHACHHANG");
            adp = new SqlDataAdapter(sql_kh, conn);
            DataTable dt_kh = new DataTable();
            adp.Fill(dt_kh);
            cbxTenKH.DataSource = dt_kh;
            cbxTenKH.DisplayMember = "HOTEN";
            cbxTenKH.ValueMember = "MAKH";
        }

        private void load_nv()
        {
            string trangthai = "Chờ";
            string sql_nv = string.Format("SELECT * FROM NHANVIEN WHERE TRANGTHAI = N'" + trangthai + "'");
            adp = new SqlDataAdapter(sql_nv, conn);
            DataTable dt_nv = new DataTable();
            adp.Fill(dt_nv);
            cbxNhanVien.DataSource = dt_nv;
            cbxNhanVien.DisplayMember = "HOTEN";
            cbxNhanVien.ValueMember = "MANV";
        }

        private void load_lieutrinh()
        {
            string sql_lt = string.Format("SELECT * FROM LIEUTRINH");
            adp = new SqlDataAdapter(sql_lt, conn);
            DataTable dt_lt = new DataTable();
            adp.Fill(dt_lt);
            cbxTenLT.DataSource = dt_lt;
            cbxTenLT.DisplayMember = "TENLT";
            cbxTenLT.ValueMember = "MALT";
        }

        private void cbxTenLT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql_lt = string.Format("SELECT * FROM LIEUTRINH WHERE MALT = @MALT");
            adp = new SqlDataAdapter(sql_lt, conn);
            adp.SelectCommand.Parameters.AddWithValue("@MALT", cbxTenLT.SelectedValue.ToString());
            DataTable dt_lt = new DataTable();
            adp.Fill(dt_lt);
            txtThoigianDT.Text = dt_lt.Rows[0]["THOIGIANDT"].ToString();
            txtGiaTien.Text = dt_lt.Rows[0]["GIATIEN"].ToString();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            set_null();
            btnLuu.Show();
            btnDatLich.Hide();
            txtMaLH.Text = matutang_datlich();
            bangDatLich.CellClick -= bangdatlich_CellClick;
        }

        private void bangdatlich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLH.Text = bangDatLich.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbxTenKH.Text = bangDatLich.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxTenLT.Text = bangDatLich.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxNhanVien.Text = bangDatLich.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateBD.Text = bangDatLich.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateKT.Text = bangDatLich.Rows[e.RowIndex].Cells[6].Value.ToString();
            //
            string sql_lt = string.Format("SELECT * FROM LIEUTRINH WHERE MALT = @MALT");
            adp = new SqlDataAdapter(sql_lt, conn);
            adp.SelectCommand.Parameters.AddWithValue("@MALT", cbxTenLT.Text);
            DataTable dt_lt = new DataTable();
            adp.Fill(dt_lt);
            txtThoigianDT.Text = dt_lt.Rows[0]["THOIGIANDT"].ToString();
            txtGiaTien.Text = dt_lt.Rows[0]["GIATIEN"].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string trangthai = "Đã đặt";
            if (txtMaLH.Text == "" || cbxTenKH.Text == "" || cbxTenLT.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            else if (cbxTenLT.Text == "")
            {
                MessageBox.Show("Chưa chọn liệu trình");
                return;
            }
            else if (cbxTenKH.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng");
                return;
            }
            else
            {
                conn.Open();
                string sql = string.Format("INSERT INTO LICHHEN (MALICHHEN,MAKH,MALT,MANV,TRANGTHAI,THOIGIANBD,THOIGIANKT) VALUES (@MALICHHEN,@MAKH,@MALT,@MANV,@TRANGTHAI,@THOIGIANBD,@THOIGIANKT)");
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
                cmd.Parameters.AddWithValue("@MAKH", cbxTenKH.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MALT", cbxTenLT.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MANV", cbxNhanVien.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TRANGTHAI", trangthai);
                cmd.Parameters.AddWithValue("@THOIGIANBD", dateBD.Value);
                cmd.Parameters.AddWithValue("@THOIGIANKT", dateKT.Value);
                int kq = cmd.ExecuteNonQuery();
                string tt = "Đang phục vụ";
                string update = string.Format("update NHANVIEN set TRANGTHAI = @TRANGTHAI where MANV in (select MANV from LICHHEN where MALICHHEN = @MALICHHEN)");
                SqlCommand cmd_update = new SqlCommand(update, conn);
                cmd_update.Parameters.AddWithValue("@TRANGTHAI", tt);
                cmd_update.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
                cmd_update.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đặt lịch thành công.");
                }
                else
                {
                    MessageBox.Show("Đặt lịch thất bại.");
                }
                conn.Close();
            }
            frmDatLich_Load(sender, e);
            bangDatLich.CellClick += bangdatlich_CellClick;
        }

        private void txtThoigianDT_TextChanged(object sender, EventArgs e)
        {
            calculateKT();
        }

        private void dateBD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                calculateKT();
            }
            catch 
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            set_null();
            btnDatLich.Show();
            btnLuu.Hide();
            bangDatLich.CellClick += bangdatlich_CellClick;

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
        private void lb_layma_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = matutang_hoadon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string tt ="Đã thanh toán";
            string tt_nv = "Chờ";
            if (txtMaLH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn để thanh toán.");
                return;
            }
            else if(txtMaHD.Text == "")
            {
                MessageBox.Show("Chưa lấy mã hóa đơn.");
                return;
            }
            conn.Open();
            //1.kiem tra trang thai lich hen
            string chkTT = @" SELECT TRANGTHAI FROM LICHHEN WHERE MALICHHEN = @MALICHHEN";
            cmd = new SqlCommand(chkTT, conn);
            cmd.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
            string trangthai = cmd.ExecuteScalar()?.ToString();
            if (trangthai != tt)
            {
                //1.them vao bang hoa don
                string sql = @"INSERT INTO HOADON (SOHD, MANV, MAKH, TONGTIEN, NGAYTAO)
                       SELECT @SOHD, @MANV, LICHHEN.MAKH, LIEUTRINH.GIATIEN, GETDATE()
                       FROM LICHHEN 
                       INNER JOIN LIEUTRINH ON LICHHEN.MALT = LIEUTRINH.MALT
                       INNER JOIN NHANVIEN ON LICHHEN.MANV = NHANVIEN.MANV
                       WHERE LICHHEN.MALICHHEN = @MALICHHEN";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
                cmd.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
                cmd.ExecuteNonQuery();
                //2.them vao bang cthdlieutrinh
                string insertCTDT = @"
                    INSERT INTO CTHDLT (SOHD, MALT, MANV, SOLUONG, THANHTIEN)
                    SELECT @SOHD, LICHHEN.MALT, LICHHEN.MANV, 1, LIEUTRINH.GIATIEN
                    FROM LICHHEN
                    INNER JOIN LIEUTRINH ON LICHHEN.MALT = LIEUTRINH.MALT
                    WHERE LICHHEN.MALICHHEN = @MALICHHEN";
                SqlCommand cmdInsertCTDT = new SqlCommand(insertCTDT, conn);
                cmdInsertCTDT.Parameters.AddWithValue("@SOHD", txtMaHD.Text);
                cmdInsertCTDT.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
                cmdInsertCTDT.ExecuteNonQuery();
                //3.cap nhat lai trang thai cua lich hen.
                string updateLichHen = "UPDATE LICHHEN SET TRANGTHAI =  N'" + tt + "' WHERE MALICHHEN = @MALICHHEN";
                SqlCommand cmdUpdateLichHen = new SqlCommand(updateLichHen, conn);
                cmdUpdateLichHen.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
                cmdUpdateLichHen.ExecuteNonQuery();
                //4. cap nhat lai trang thai cua nhan vien
                string updateNhanVien = @"UPDATE NHANVIEN SET TRANGTHAI = N'" + tt_nv + "' WHERE MANV IN (SELECT MANV FROM LICHHEN WHERE MALICHHEN = @MALICHHEN)";
                SqlCommand cmdUpdateNhanVien = new SqlCommand(updateNhanVien, conn);
                cmdUpdateNhanVien.Parameters.AddWithValue("@MALICHHEN", txtMaLH.Text);
                cmdUpdateNhanVien.ExecuteNonQuery();
                MessageBox.Show("Thanh toán thành công!");
            }
            else
            {
                MessageBox.Show("Lịch hẹn này đã được thanh toán.");
            }
            conn.Close();
            frmDatLich_Load(sender, e);
        }
    }
}
