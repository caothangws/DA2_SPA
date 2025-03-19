
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
    public partial class frmDichVu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        bool themDL;
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void set_null()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtThoiGianDTDV.Text = "";
            txtGiaTienDV.Text = "";
            txtChiecKhauDV.Text = "";
            txtDiemDV.Text = "";
        }

        private string matutang_dichvu()
        {

            string str = string.Format("SELECT TOP 1 MADV FROM DICHVU ORDER BY MADV DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mdv;
            if (dt.Rows.Count == 0)
                mdv = "DV001";
            else
            {
                string madv = dt.Rows[0]["MADV"].ToString();
                madv = madv.Substring(2);
                int so = int.Parse(madv) + 1;
                mdv = "DV";
                mdv = mdv + so.ToString("D3");
            }
            return mdv;
        }

        private void taobang()
        {
            string str = string.Format("SELECT * FROM DICHVU");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt_dv = new DataTable();
            adp.Fill(dt_dv);
            bangDV.DataSource = dt_dv;
        }

        private void disable()
        {
            txtTenDV.Enabled = false;
            txtThoiGianDTDV.Enabled = false;
            txtGiaTienDV.Enabled = false;
            txtChiecKhauDV.Enabled = false;
            txtDiemDV.Enabled = false;

            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
            btnLuu.Hide();
        }

        private void enable()
        {
            txtTenDV.Enabled = true;
            txtThoiGianDTDV.Enabled = true;
            txtGiaTienDV.Enabled = true;
            txtChiecKhauDV.Enabled = true;
            txtDiemDV.Enabled = true;

            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnLuu.Show();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            disable();
            taobang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtMaDV.Text = matutang_dichvu();
            themDL = true;
            bangDV.CellClick -= bangdv_CellClick;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            themDL = false;
            bangDV.CellClick += bangdv_CellClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                return;
            }
            string sql_ctdv = "SELECT * FROM CTHDDV WHERE MADV = '" + txtMaDV.Text + "'";
            adp = new SqlDataAdapter(sql_ctdv, conn);
            DataTable dt_ctdv = new DataTable();
            adp.Fill(dt_ctdv);
            if (dt_ctdv.Rows.Count != 0)
            {
                MessageBox.Show("Không thể xóa .");
            }
            else
            {
                conn.Open();
                string strDel = string.Format("DELETE FROM DICHVU WHERE MADV=@MADV");
                cmd = new SqlCommand(strDel, conn);
                cmd.Parameters.AddWithValue("@MADV", txtMaDV.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Xóa thành công." : "Xóa thất bại.");
                }
            }
            conn.Close();
            set_null();
            taobang();
        }
        private bool KTDuLieu()
        {
            int i;
            if (txtTenDV.Text == "" || txtThoiGianDTDV.Text == "" || txtGiaTienDV.Text == "" || txtChiecKhauDV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else if (int.TryParse(txtThoiGianDTDV.Text, out i) == false)
            {
                MessageBox.Show("Thời gian phải là số");
                return false;
            }
            else if (int.TryParse(txtGiaTienDV.Text, out i) == false)
            {
                MessageBox.Show("Giá tiền phải là số");
                return false;
            }
            else if (int.TryParse(txtChiecKhauDV.Text, out i) == false)
            {
                MessageBox.Show("Chiếc khấu phải là số.");
                return false;
            }
            return true;
        }

        private void ThemDV()
        {
            string str = string.Format("INSERT INTO DICHVU (MADV,TENDV,THOIGIANDT,GIATIEN,CHIECKHAU,DIEMDV) VALUES (@MADV,@TENDV,@THOIGIANDT,@GIATIEN,@CHIECKHAU,@DIEMDV)");
            cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("@MADV", txtMaDV.Text);
            cmd.Parameters.AddWithValue("@TENDV", txtTenDV.Text);
            cmd.Parameters.AddWithValue("@THOIGIANDT", txtThoiGianDTDV.Text);
            cmd.Parameters.AddWithValue("@GIATIEN", txtGiaTienDV.Text);
            cmd.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhauDV.Text);
            cmd.Parameters.AddWithValue("@DIEMDV", txtDiemDV.Text);
            int kq = cmd.ExecuteNonQuery();

            MessageBox.Show(kq > 0 ? "Thêm thành công." : "Thêm thất bại.");
        }
        private void CapNhatDV()
        {
            string sql = string.Format("UPDATE DICHVU SET TENDV =@TENDV, THOIGIANDT =@THOIGIANDT, GIATIEN =@GIATIEN,CHIECKHAU =@CHIECKHAU ,DIEMDV = @DIEMDV WHERE MADV =@MADV ");
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENDV", txtTenDV.Text);
            cmd.Parameters.AddWithValue("@THOIGIANDT", txtThoiGianDTDV.Text);
            cmd.Parameters.AddWithValue("@GIATIEN", txtGiaTienDV.Text);
            cmd.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhauDV.Text);
            cmd.Parameters.AddWithValue("@DIEMDV", txtDiemDV.Text);
            cmd.Parameters.AddWithValue("@MADV", txtMaDV.Text);
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
                        ThemDV();
                    }
                    else
                    {
                        CapNhatDV();
                    }
                    conn.Close();
                    set_null();
                    taobang();
                    disable();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            disable();
            set_null();
            bangDV.CellClick += bangdv_CellClick;
        }

        private void bangdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDV.Text = bangDV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDV.Text = bangDV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtThoiGianDTDV.Text = bangDV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaTienDV.Text = bangDV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChiecKhauDV.Text = bangDV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiemDV.Text = bangDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi.");
                return;
            }
        }
    }
}
