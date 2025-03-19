using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLySpa
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "SELECT * FROM TAIKHOAN WHERE TAIKHOAN COLLATE Latin1_General_BIN = '"+tk+ "' AND MATKHAU = '"+mk+"'"; 
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmMain main_ = new frmMain(txtTaiKhoan.Text);
                    foreach (DataRow dr in dt.Rows)
                    {
                        main_.kt = int.Parse(dr["QUYEN"].ToString());
                    }
                    string update = string.Format("UPDATE  NHANVIEN SET TRANGTHAI = N'Đang hoạt động' where MANV = @MANV ");
                    SqlCommand cmd = new SqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@MANV", tk);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng nhập thành công.");
                    this.Hide();
                    main_.ShowDialog();
                    //check nho mat khau
                    Properties.Settings.Default.isSave = chkGhiNho.Checked;
                    if(chkGhiNho.Checked)
                    {
                        Properties.Settings.Default.username = txtTaiKhoan.Text;
                        Properties.Settings.Default.pass = txtMatKhau.Text;
                    }
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản.");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }
        //load from
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           
            if(Properties.Settings.Default.isSave)
            {
                txtTaiKhoan.Text  = Properties.Settings.Default.username;
                txtMatKhau.Text= Properties.Settings.Default.pass;
                chkGhiNho.Checked = true;
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
