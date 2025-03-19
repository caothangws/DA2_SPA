using Microsoft.Bot.Schema.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLySpa
{
    public partial class frmGoiDichVu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;
        bool themDL;


        public frmGoiDichVu()
        {
            InitializeComponent();
        }

        private void set_null()
        {
            txtMaGoiDV.Text = "";
            txtTenGoiDV.Text = "";
            txtThoigiandtgoidv.Text = "";
            txtGiaTienGDV.Text = "";
            txtChiecKhau.Text = "";
            txtDiemGDV.Text = "";
            cbxDichVu.SelectedIndex = -1;
            bangDV.Rows.Clear();
        }

        private string matutang_goidichvu()
        {
            string str = string.Format("SELECT TOP 1 MAGOIDV FROM GOIDICHVU ORDER BY MAGOIDV DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mag;
            if (dt.Rows.Count == 0)
                mag = "GDV001";
            else
            {
                string magoi = dt.Rows[0]["MAGOIDV"].ToString();
                magoi = magoi.Substring(3);
                int so = int.Parse(magoi) + 1;
                mag = "GDV";
                mag = mag + so.ToString("D3");
            }
            return mag;
        }
        private void disable()
        {
            txtTenGoiDV.Enabled = false;
            txtThoigiandtgoidv.Enabled = false;
            txtGiaTienGDV.Enabled = false;
            txtChiecKhau.Enabled = false;
            txtDiemGDV.Enabled = false;
            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
            btnLuu.Hide();
        }
        private void enable()
        {
            txtTenGoiDV.Enabled = true;
            txtThoigiandtgoidv.Enabled = true;
            txtGiaTienGDV.Enabled = true;
            txtChiecKhau.Enabled = true;
            txtDiemGDV.Enabled = true;
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnLuu.Show();
        }
        private void taobang()
        {
            string sql = string.Format("SELECT * FROM GOIDICHVU");
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataTable dt_gdv = new DataTable();
            adp.Fill(dt_gdv);
            bangGDV.DataSource = dt_gdv;
        }
        private void load_dv()
        {
            string str = string.Format("SELECT * FROM DICHVU");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbxDichVu.DataSource = dt;
            cbxDichVu.DisplayMember = "TENDV";
            cbxDichVu.ValueMember = "MADV";
            cbxDichVu.SelectedIndex = -1;
        }

        private void frmGoiDichVu_Load(object sender, EventArgs e)
        {

            set_null();
            disable();
            taobang();
            load_dv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtMaGoiDV.Text = matutang_goidichvu();
            themDL = true;
            bangGDV.CellClick -= banggdvInsert_CellClick;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            themDL = false;
            bangGDV.CellClick += banggdvInsert_CellClick;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGoiDV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                return;
            }
            string sql_cthdgoi = "SELECT * FROM CTHDGOI WHERE MAGOIDV = '" + txtMaGoiDV.Text + "'";
            adp = new SqlDataAdapter(sql_cthdgoi, conn);
            DataTable dt_cthdgoi = new DataTable();
            adp.Fill(dt_cthdgoi);
            if (dt_cthdgoi.Rows.Count != 0)
            {
                MessageBox.Show("Không thể xóa.");
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string strDel = string.Format("DELETE FROM CTGDV WHERE MAGOIDV='" + txtMaGoiDV.Text + "'");
                cmd.CommandText = strDel;
                cmd.Connection = conn;
                int delctgdv = cmd.ExecuteNonQuery();

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = string.Format("DELETE FROM GOIDICHVU WHERE MAGOIDV='" + txtMaGoiDV.Text + "'");
                cmd.CommandText = sql;
                cmd.Connection = conn;
                int delgoidv = cmd.ExecuteNonQuery();
                if (delctgdv > 0 || delgoidv > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
                conn.Close();
            }
            frmGoiDichVu_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu
            int i = 0;
            if (txtTenGoiDV.Text == "" || txtThoigiandtgoidv.Text == "" || txtGiaTienGDV.Text == "" || txtChiecKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            else if (bangDV.Rows.Count <= 1 && themDL == true)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 dịch vụ.");
                return;
            }
            else if (int.TryParse(txtThoigiandtgoidv.Text, out i) == false)
            {
                MessageBox.Show("Thời gian điều trị phải là số");
                return;
            }
            else if (int.TryParse(txtGiaTienGDV.Text, out i) == false)
            {
                MessageBox.Show("Giá tiền phải là số");
                return;
            }
            else if (int.TryParse(txtChiecKhau.Text, out i) == false)
            {
                MessageBox.Show("Chiếc khấu phải là số");
                return;
            }

            else if (themDL == true)
            {
                conn.Open();
                string sql = string.Format("INSERT INTO GOIDICHVU (MAGOIDV,TENGOI,THOIGIANDT,GIATIEN,CHIECKHAU,DIEMGDV) VALUES (@MAGOIDV,@TENGOI,@THOIGIANDT,@GIATIEN,@CHIECKHAU,@DIEMGDV)");
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAGOIDV", txtMaGoiDV.Text);
                cmd.Parameters.AddWithValue("@TENGOI", txtTenGoiDV.Text);
                cmd.Parameters.AddWithValue("@THOIGIANDT", txtThoigiandtgoidv.Text);
                cmd.Parameters.AddWithValue("@GIATIEN", txtGiaTienGDV.Text);
                cmd.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhau.Text);
                cmd.Parameters.AddWithValue("@DIEMGDV", 0);
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow row in bangDV.Rows)
                {
                    if (row.Cells["MADV"].Value != null)
                    {
                        string madv = row.Cells["MADV"].Value.ToString();
                        //them dich vu vao chi tiet goi dich vu
                        string sql1 = string.Format("INSERT INTO CTGDV (MAGOIDV, MADV) VALUES(@MAGOIDV, @MADV) ");
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        cmd1.Parameters.AddWithValue("@MAGOIDV", txtMaGoiDV.Text);
                        cmd1.Parameters.AddWithValue("@MADV", madv);
                        cmd1.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("thêm gói dịch vụ thành công.");
                conn.Close();
            }
            else if (themDL == false)
            {
                conn.Open();
                string sql_upd = string.Format("UPDATE GOIDICHVU SET TENGOI = @TENGOI ,THOIGIANDT = @THOIGIANDT,GIATIEN = @GIATIEN ,CHIECKHAU = @CHIECKHAU ,DIEMGDV = @DIEMGDV WHERE MAGOIDV = @MAGOIDV ");
                SqlCommand cmd_upd = new SqlCommand();
                cmd_upd.Parameters.AddWithValue("@TENGOI", txtTenGoiDV.Text);
                cmd_upd.Parameters.AddWithValue("@THOIGIANDT", txtThoigiandtgoidv.Text);
                cmd_upd.Parameters.AddWithValue("@GIATIEN", txtGiaTienGDV.Text);
                cmd_upd.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhau.Text);
                cmd_upd.Parameters.AddWithValue("@DIEMGDV", txtDiemGDV.Text);
                cmd_upd.Parameters.AddWithValue("@MAGOIDV", txtMaGoiDV.Text);
                int kq = cmd_upd.ExecuteNonQuery();
                MessageBox.Show(kq > 0 ? "Cập nhật thành công." : "Cập nhật Thất bại.");
            }
            disable();
            taobang();
            set_null();

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            set_null();
            disable();
            bangGDV.CellClick += banggdvInsert_CellClick;
        }
        int dong = 0;
        private void lb_xoadv_Click(object sender, EventArgs e)
        {
            try
            {
                bangDV.Rows.RemoveAt(dong);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private void banggdvInsert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaGoiDV.Text = bangGDV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenGoiDV.Text = bangGDV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtThoigiandtgoidv.Text = bangGDV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaTienGDV.Text = bangGDV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChiecKhau.Text = bangGDV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiemGDV.Text = bangGDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void lb_them_Click(object sender, EventArgs e)
        {
            if (cbxDichVu.SelectedValue != null)
            {
                foreach (DataGridViewRow row in bangDV.Rows)
                {
                    if (row.Cells[1].Value?.ToString() == cbxDichVu.Text)
                    {
                        MessageBox.Show("Giá trị đã tồn tại.", "Thông báo");
                        return;
                    }
                }
                string Madv = cbxDichVu.SelectedValue.ToString();
                string query = "SELECT * FROM DICHVU";
                adp = new SqlDataAdapter(query, conn);
                DataTable dt_dv = new DataTable();
                adp.Fill(dt_dv);
                if (dt_dv.Rows.Count > 0)
                {
                    string tendv = dt_dv.Rows[0]["TENDV"].ToString();
                    string tg = dt_dv.Rows[0]["THOIGIANDT"].ToString();
                    string giatien = dt_dv.Rows[0]["GIATIEN"].ToString();
                    string chieckhau = dt_dv.Rows[0]["CHIECKHAU"].ToString();
                    string diem = dt_dv.Rows[0]["DIEMDV"].ToString();
                  
                    bangDV.Rows.Add(Madv, tendv, tg, giatien, chieckhau, diem);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên dịch vụ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ.");
            }
        }

    }
}
