
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySpa
{
    public partial class frmKhachHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        bool themDL;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void set_null()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cbxGioiTinh.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }
        private string matutang_kh()
        {
            string str = string.Format("SELECT TOP 1 MAKH FROM KHACHHANG ORDER BY MAKH DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mkh;
            if (dt.Rows.Count == 0)
                mkh = "KH001";
            else
            {
                string makh = dt.Rows[0]["MAKH"].ToString();
                makh = makh.Substring(2);
                int so = int.Parse(makh) + 1;
                mkh = "KH";
                mkh = mkh + so.ToString("D3");
            }
            return mkh;
        }

        private void taobang()
        {
            string str = string.Format("SELECT * FROM KHACHHANG");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dtkh = new DataTable();
            adp.Fill(dtkh);
            bangKH.DataSource = dtkh;
        }

        private void disable()
        {
            txtTenKH.Enabled = false;
            cbxGioiTinh.Enabled = false;
            dateNamSinh.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            btnLuu.Hide();
            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
        }

        private void enable()
        {
            txtTenKH.Enabled = true;
            cbxGioiTinh.Enabled = true;
            dateNamSinh.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;

            btnLuu.Show();
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            disable();
            taobang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtMaKH.Text = matutang_kh();
            themDL = true;
            bangKH.CellClick -= bangkh_CellClick;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            themDL = false;
            bangKH.CellClick += bangkh_CellClick;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                return;
            }
            string sql_kh = "select  HOADON.MAKH from HOADON WHERE MAKH = '" + txtMaKH.Text + "' ";
            adp = new SqlDataAdapter(sql_kh, conn);
            DataTable dt_kh = new DataTable();
            adp.Fill(dt_kh);
            if (dt_kh.Rows.Count != 0)
            {
                MessageBox.Show("Không thể xóa .");
            }
            else
            {
                conn.Open();
                string strDel = string.Format("DELETE FROM KHACHHANG WHERE MAKH=@MAKH");
                cmd = new SqlCommand(strDel, conn);
                cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xóa thành công." : "Xóa thất bại.");
                    conn.Close();
                }
            }
            set_null();
            taobang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            int i = 0;
            if (txtTenKH.Text == "" || cbxGioiTinh.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(txtSDT.Text, out i) == false)
            {
                MessageBox.Show("Số điện thoại phải là số");
                return;
            }
            if (themDL == true)
            {
                string loaithe = "Thường";
                int diemtl = 0;
                int uudai = 0;
                conn.Open();
                string sql = string.Format("INSERT INTO KHACHHANG (MAKH,HOTEN,GIOITINH,NAMSINH,SDT,LOAITHE, DIEMTL,UUDAI,EMAIL) VALUES (@MAKH,@HOTEN,@GIOITINH ,@NAMSINH,@SDT,@LOAITHE,@DIEMTL,@UUDAI,@EMAIL)");
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@HOTEN", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@GIOITINH", cbxGioiTinh.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NAMSINH", dateNamSinh.Value);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@LOAITHE", loaithe);
                cmd.Parameters.AddWithValue("@DIEMTL", diemtl);
                cmd.Parameters.AddWithValue("@UUDAI", uudai);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);

                int kq = cmd.ExecuteNonQuery();
                MessageBox.Show(kq > 0 ? "Thêm thành công." : "Thêm thất bại.");
                conn.Close();
            }
            else if (themDL == false)
            {
                conn.Open();
                string sql = string.Format("UPDATE KHACHHANG SET HOTEN = @HOTEN, GIOITINH =@GIOITINH, NAMSINH = @NAMSINH, SDT = @SDT,EMAIL = @EMAIL WHERE MAKH= @MAKH ");
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HOTEN", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@GIOITINH", cbxGioiTinh.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NAMSINH", dateNamSinh.Value);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                int kq = cmd.ExecuteNonQuery();
                MessageBox.Show(kq > 0 ? "Sửa thành công." : "Sửa thất bại.");
                conn.Close();
            }
            set_null();
            disable();
            taobang();
            bangKH.CellClick += bangkh_CellClick;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            disable();
            set_null();
            bangKH.CellClick += bangkh_CellClick;
        }

        private void bangkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = bangKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = bangKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxGioiTinh.Text = bangKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNamSinh.Text = bangKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = bangKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = bangKH.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
    }
}
