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
    public partial class frmTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adp;

        private string manv_;
        public frmTaiKhoan(string maNV)
        {
            InitializeComponent();
            manv_ = maNV;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            TaoBang();
            LoadTK();
        }

        private void TaoBang()
        {
            string sql = "SELECT * FROM TAIKHOAN";
            adp = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            bangTK.DataSource = dt;
        }

        private void LoadTK()
        {
            string sql = "SELECT * FROM NHANVIEN";
            adp = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbxTK.DataSource = dt;
            cbxTK.DisplayMember = "MANV";
            cbxTK.ValueMember = "MANV";
            cbxTK.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i;
            string vaitro = cbxVaiTro.SelectedItem.ToString();
            int vt = vaitro == "Quản Trị" ? 1 : 0;
            if (string.IsNullOrEmpty(cbxTK.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(cbxVaiTro.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else if (cbxVaiTro.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return;
            }
            else if (int.TryParse(txtMatKhau.Text, out i) == false)
            {
                MessageBox.Show("Mật khẩu phải là số");
                return;
            }
            else
            {
                try
                {
                    string sqlNV = "SELECT COUNT(*) FROM TAIKHOAN  INNER JOIN NHANVIEN ON TAIKHOAN.TAIKHOAN = NHANVIEN.MANV WHERE NHANVIEN.MANV = @MANV";
                    cmd = new SqlCommand(sqlNV, conn);
                    cmd.Parameters.AddWithValue("@MANV", cbxTK.SelectedValue.ToString());
                    conn.Open();
                    int kq1 = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (kq1 > 0)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại.", "Thông báo");
                        cbxTK.Text = "";
                        return;
                    }
                    else
                    {
                        string sql = "INSERT INTO TAIKHOAN(TAIKHOAN, MATKHAU, QUYEN) VALUES (@TAIKHOAN, @MATKHAU,@QUYEN)";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TAIKHOAN", cbxTK.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@MATKHAU", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@QUYEN", vt);
                        conn.Open();
                        int kq = cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(kq > 0 ? "Thêm thành công." : "Thêm thất bại.");
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            TaoBang();
            cbxTK.Text = "";
            txtMatKhau.Text = "";
            cbxVaiTro.Text = "";
          
        }
        private void bangTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxTK.Text = bangTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMatKhau.Text = bangTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                string vaitro = bangTK.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (vaitro == "1")
                {
                    cbxVaiTro.Text = "Quản Trị";
                }
                else if (vaitro == "0")
                {
                    cbxVaiTro.Text = "Nhân Viên";
                }

            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            cbxTK.Text = "";
            txtMatKhau.Text = "";
            cbxVaiTro.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbxTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.");
                return;
            }
            if (cbxTK.Text == manv_)
            {
                MessageBox.Show("Không thể xóa tài khoản khi đang đăng nhập.");
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM TAIKHOAN WHERE TAIKHOAN = '" + cbxTK.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int kq = cmd.ExecuteNonQuery();
                        MessageBox.Show(kq > 0 ? "Xóa thành công." : "Xóa thất bại.");
                    }
                    conn.Close();
                    TaoBang();
                    cbxTK.Text = "";
                    txtMatKhau.Text = "";
                    cbxVaiTro.Text = "";
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }
    }


}

