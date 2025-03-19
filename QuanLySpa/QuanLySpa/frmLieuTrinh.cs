
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
using Twilio.TwiML.Voice;

namespace QuanLySpa
{
    public partial class frmLieuTrinh : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlDataAdapter adp;
        SqlCommand cmd;
        bool themDL;
        int dong = 0;
        int dong_dv = 0;
        public frmLieuTrinh()
        {
            InitializeComponent();
        }

        private void set_null()
        {
            txtMaLT.Text = "";
            txtTenLT.Text = "";
            txtThoiGianDT.Text = "";
            txtGiaTien.Text = "";
            txtChiecKhauLT.Text = "";
            txtDiemLT.Text = "";
            cbxSanPham.SelectedIndex = -1;
            cbxMaDV.SelectedIndex = -1;
            bangSP.Rows.Clear();
            bangDV.Rows.Clear();

        }
        private string matutang_lieutrinh()
        {

            string str = string.Format("SELECT TOP 1 MALT FROM LIEUTRINH ORDER BY MALT DESC");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string mlt;
            if (dt.Rows.Count == 0)
                mlt = "LT001";
            else
            {
                string malt = dt.Rows[0]["MALT"].ToString();
                malt = malt.Substring(2);
                int so = int.Parse(malt) + 1;
                mlt = "LT";
                mlt = mlt + so.ToString("D3");
            }
            return mlt;
        }

        private void taobang()
        {
            string str = string.Format("SELECT * FROM LIEUTRINH");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt_lt = new DataTable();
            adp.Fill(dt_lt);
            bangLT.DataSource = dt_lt;
        }

        private void disable()
        {
            txtTenLT.Enabled = false;
            txtThoiGianDT.Enabled = false;
            txtGiaTien.Enabled = false;
            txtChiecKhauLT.Enabled = false;
            txtDiemLT.Enabled = false;

            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
            btnLuu.Hide();
        }

        private void enable()
        {
            txtTenLT.Enabled = true;
            txtThoiGianDT.Enabled = true;
            txtGiaTien.Enabled = true;
            txtChiecKhauLT.Enabled = true;
            txtDiemLT.Enabled = true;
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnLuu.Show();

        }
        private void load_dichvu()
        {
            string str = string.Format("SELECT * FROM DICHVU");
            SqlDataAdapter adp = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbxMaDV.DataSource = dt;
            cbxMaDV.DisplayMember = "TENDV";
            cbxMaDV.ValueMember = "MADV";
            cbxMaDV.SelectedIndex = -1;
        }

        private void load_sanpham()
        {
            string sp = string.Format("SELECT * FROM SANPHAM WHERE SOLUONGTON > 0 ");
            adp = new SqlDataAdapter(sp, conn);
            DataTable dt_sp = new DataTable();
            adp.Fill(dt_sp);
            cbxSanPham.DataSource = dt_sp;
            cbxSanPham.DisplayMember = "TENSP";
            cbxSanPham.ValueMember = "MASP";
            cbxSanPham.SelectedIndex = -1;
        }

        private void frmLieuTrinh_Load(object sender, EventArgs e)
        {
            disable();
            set_null();
            taobang();
            load_dichvu();
            load_sanpham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            txtMaLT.Text = matutang_lieutrinh();
            themDL = true;
            bangLT.CellClick -= banglt_CellClick;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            enable();
            set_null();
            themDL = false;
            bangLT.CellClick += banglt_CellClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.");
                return;
            }
            string sql_ctdt = "SELECT * FROM CTHDLT WHERE MALT = '" + txtMaLT.Text + "'";
            adp = new SqlDataAdapter(sql_ctdt, conn);
            DataTable dt_ctdt = new DataTable();
            adp.Fill(dt_ctdt);
            if (dt_ctdt.Rows.Count != 0)
            {
                MessageBox.Show("Không thể xóa.");
            }
            else
            {
                conn.Open();
                string str_ = "DELETE FROM CTLIEUTRINH WHERE MALT = @MALT";
                SqlCommand cmd_ctlt = new SqlCommand(str_, conn);
                cmd_ctlt.Parameters.AddWithValue("@MALT", txtMaLT.Text);
                int kq = cmd_ctlt.ExecuteNonQuery();
                //
                string strDel = "DELETE FROM LIEUTRINH WHERE MALT= @MALT";
                cmd = new SqlCommand(strDel, conn);
                cmd.Parameters.AddWithValue("@MALT", txtMaLT.Text);
                int kq1 = cmd.ExecuteNonQuery();
                if (kq > 0 || kq1 > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
                conn.Close();
            }
            set_null();
            taobang();
        }
        private bool KTDuLieu()
        {
            int i;
            if (txtTenLT.Text == "" || txtThoiGianDT.Text == "" || txtGiaTien.Text == "" || txtChiecKhauLT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else if (bangDV.Rows.Count <= 1 && themDL == true)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 dịch vụ.");
                return false;
            }
            else if (bangSP.Rows.Count <= 1 && themDL == true)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 sản phẩm.");
                return false;
            }
            else if (int.TryParse(txtThoiGianDT.Text, out i) == false)
            {
                MessageBox.Show("Thời gian phải là số");
                return false;
            }
            else if (int.TryParse(txtGiaTien.Text, out i) == false)
            {
                MessageBox.Show("Giá tiền phải là số");
                return false;
            }
            else if (int.TryParse(txtChiecKhauLT.Text, out i) == false)
            {
                MessageBox.Show("Chiếc khấu phải là số");
                return false;
            }
            return true;
        }
        private void ThemLieuTrinh()
        {
            try
            {
                // Thêm liệu trình vào bảng LIEUTRINH
                string sql = "INSERT INTO LIEUTRINH (MALT, TENLT, THOIGIANDT, GIATIEN, CHIECKHAU, DIEMLT) VALUES (@MALT, @TENLT, @THOIGIANDT, @GIATIEN, @CHIECKHAU, @DIEMLT)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MALT", txtMaLT.Text);
                cmd.Parameters.AddWithValue("@TENLT", txtTenLT.Text);
                cmd.Parameters.AddWithValue("@THOIGIANDT", txtThoiGianDT.Text);
                cmd.Parameters.AddWithValue("@GIATIEN", txtGiaTien.Text);
                cmd.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhauLT.Text);
                cmd.Parameters.AddWithValue("@DIEMLT", txtDiemLT.Text);
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow row in bangSP.Rows)
                {
                    if (row.Cells["MASP"].Value != null)
                    {
                        string masp = row.Cells["MASP"].Value.ToString();
                        foreach (DataGridViewRow row2 in bangDV.Rows)
                        {
                            if (row2.Cells["MADV"].Value != null)
                            {
                                string madv = row2.Cells["MADV"].Value.ToString();
                                string sql_ctlt = "INSERT INTO CTLIEUTRINH (MALT, MASP, MADV) VALUES (@MALT, @MASP, @MADV)";
                                SqlCommand cmd_ctlt = new SqlCommand(sql_ctlt, conn);
                                cmd_ctlt.Parameters.AddWithValue("@MALT", txtMaLT.Text);
                                cmd_ctlt.Parameters.AddWithValue("@MASP", masp);
                                cmd_ctlt.Parameters.AddWithValue("@MADV", madv);
                                cmd_ctlt.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Thêm liệu trình thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void CapNhatLT()
        {
            string sql = "UPDATE LIEUTRINH SET TENLT = @TENLT, THOIGIANDT = @THOIGIANDT, GIATIEN = @GIATIEN, CHIECKHAU = @CHIECKHAU, DIEMLT = @DIEMLT WHERE MALT = @MALT";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENLT", txtTenLT.Text);
            cmd.Parameters.AddWithValue("@THOIGIANDT", txtThoiGianDT.Text);
            cmd.Parameters.AddWithValue("@GIATIEN", txtGiaTien.Text);
            cmd.Parameters.AddWithValue("@CHIECKHAU", txtChiecKhauLT.Text);
            cmd.Parameters.AddWithValue("@DIEMLT", txtDiemLT.Text);
            cmd.Parameters.AddWithValue("@MALT", txtMaLT.Text);
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
                        ThemLieuTrinh();
                    }
                    else
                    {
                        CapNhatLT();
                    }
                    conn.Close();
                    set_null();
                    disable();
                    taobang();
                    bangLT.CellClick += banglt_CellClick;
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
            bangLT.CellClick += banglt_CellClick;

        }

        private void banglt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaLT.Text = bangLT.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLT.Text = bangLT.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtThoiGianDT.Text = bangLT.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaTien.Text = bangLT.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChiecKhauLT.Text = bangLT.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiemLT.Text = bangLT.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi.");
                return;
            }
        }
        //san pham
        private void lb_themsp_Click(object sender, EventArgs e)
        {
            if (cbxSanPham.SelectedValue.ToString() != null)
            {
                foreach (DataGridViewRow row in bangSP.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == cbxSanPham.SelectedValue.ToString())
                    {
                        MessageBox.Show("Giá trị đã tồn tại.", "Thông báo");
                        return;
                    }
                }
                //
                string Masp = cbxSanPham.SelectedValue.ToString();
                string query = "SELECT * FROM SANPHAM WHERE MASP = '" + Masp + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt_sp = new DataTable();
                adapter.Fill(dt_sp);
                if (dt_sp.Rows.Count > 0)
                {
                    string giaban = dt_sp.Rows[0]["GIABAN"].ToString();
                    bangSP.Rows.Add(Masp, giaban);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm.");
            }
        }

        private void lb_xoasp_Click(object sender, EventArgs e)
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
        // ket thuc san pham
        private void lb_xoadv_Click(object sender, EventArgs e)
        {
            try
            {
                bangDV.Rows.RemoveAt(dong_dv);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private void lb_themdv_Click(object sender, EventArgs e)
        {

            if (cbxMaDV.SelectedValue != null)
            {
                foreach (DataGridViewRow row in bangDV.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == cbxMaDV.SelectedValue.ToString())
                    {
                        MessageBox.Show("Giá trị đã tồn tại.", "Thông báo");
                        return;
                    }
                }
                string Madv = cbxMaDV.SelectedValue.ToString();
                string query = "SELECT * FROM DICHVU WHERE MADV = '" + Madv + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt_dv = new DataTable();
                adapter.Fill(dt_dv);
                if (dt_dv.Rows.Count > 0)
                {
                    string tg = dt_dv.Rows[0]["THOIGIANDT"].ToString();
                    string giatien = dt_dv.Rows[0]["GIATIEN"].ToString();
                    bangDV.Rows.Add(Madv, tg, giatien);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên dịch vụ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dịch vụ.");
            }
        }
    }
}

