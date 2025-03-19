
using QuanLySpa.Image;
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
    public partial class frmHoaDon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");
        private Form currentFormChild;
        private string manv;
        public frmHoaDon(string maNV)
        {
            InitializeComponent();
            manv = maNV;
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
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnChonHD_Click(object sender, EventArgs e)
        {
            if (cbxHD.SelectedItem != null && cbxHD.SelectedItem.ToString() != "")
            {
                string selectedItem = cbxHD.SelectedItem.ToString(); ;  // Lấy giá trị đã chọn

                // Dựa vào giá trị đã chọn, mở form tương ứng truyền manv
                if (selectedItem == "Hóa đơn liệu trình")
                {
                    OpenChildForm(new frmHDLieuTrinh(manv));
                }

                else if (selectedItem == "Hóa đơn sản phẩm")
                {
                    OpenChildForm(new frmHDSanPham(manv));
                }
                else if (selectedItem == "Hóa đơn dịch vụ")
                {
                    OpenChildForm(new frmHDDichVu(manv));
                }
                else if (selectedItem == "Hóa đơn gói dịch vụ")
                {
                    OpenChildForm(new frmHDGoiDichVu(manv));
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại hóa đơn hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại hóa đơn!");
            }

        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            // Thêm các giá trị vào ComboBox
            cbxHD.Items.Add("Hóa đơn liệu trình");
            cbxHD.Items.Add("Hóa đơn sản phẩm");
            cbxHD.Items.Add("Hóa đơn dịch vụ");
            cbxHD.Items.Add("Hóa đơn gói dịch vụ");
        }
    }
}
