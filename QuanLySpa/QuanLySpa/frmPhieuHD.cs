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
    public partial class frmPhieuHD : Form
    {
        private string sohd;
        private SqlConnection conn = new SqlConnection(@"Data Source=CAOTHANG;Initial Catalog=DB_Spa;Integrated Security=True;");

        public frmPhieuHD(string Sohd, SqlConnection conn)
        {
            InitializeComponent();
            this.sohd = Sohd;
            this.conn = conn;
            LoadHD();
            LoadCTHD();
        }

        private void LoadHD()
        {
            try
            {
                string query = @"SELECT HOADON.SOHD, NHANVIEN.HOTEN as tennv, KHACHHANG.HOTEN as tenkhach,HOADON.NGAYTAO, HOADON.TONGTIEN
                                FROM HOADON
                                INNER JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH
                                INNER JOIN NHANVIEN ON HOADON.MANV = NHANVIEN.MANV
                                WHERE HOADON.SOHD = @SOHD";
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                adp.SelectCommand.Parameters.AddWithValue("@SOHD", sohd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Hiển thị dữ liệu trong label
                    lbSohd.Text = dt.Rows[0]["SOHD"].ToString();
                    lbTenKh.Text = dt.Rows[0]["tenkhach"].ToString();
                    lbManv.Text = dt.Rows[0]["tennv"].ToString();
                    lbNgayTao.Text = DateTime.Parse(dt.Rows[0]["NGAYTAO"].ToString()).ToShortDateString();
                    lb_tongtien.Text = Convert.ToDecimal(dt.Rows[0]["TONGTIEN"]).ToString("N0") + " VND";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCTHD()
        {
            try
            {
                string query = @"SELECT ROW_NUMBER() OVER (ORDER BY MASP) AS STT, TENSP, SOLUONG, GIABAN, (SOLUONG * GIABAN) AS THANHTIEN
                            FROM 
                            (   SELECT  CTHD.MASP, SANPHAM.TENSP, CTHD.SOLUONG, SANPHAM.GIABAN
                                FROM CTHD
                                JOIN SANPHAM ON CTHD.MASP = SANPHAM.MASP WHERE CTHD.SOHD = @SOHD
                                UNION ALL
                                SELECT CTHDLT.MALT AS maslt,  LIEUTRINH.TENLT AS TENLT, CTHDLT.SOLUONG AS SOLUONG, LIEUTRINH.GIATIEN AS GIABAN
                                FROM CTHDLT
                                JOIN LIEUTRINH ON CTHDLT.MALT = LIEUTRINH.MALT WHERE CTHDLT.SOHD = @SOHD
                                UNION ALL 
                                SELECT CTHDDV.MADV AS MASP, DICHVU.TENDV AS TENSP,CTHDDV.SOLUONG AS SOLUONG,DICHVU.GIATIEN AS GIABAN
                                FROM CTHDDV 
	                            JOIN DICHVU ON CTHDDV.MADV = DICHVU.MADV WHERE CTHDDV.SOHD = @SOHD
                                UNION ALL
                                SELECT CTHDGOI.MAGOIDV AS MASP, GOIDICHVU.TENGOI AS TENSP,CTHDGOI.SOLUONG AS SOLUONG, GOIDICHVU.GIATIEN AS GIABAN
                                FROM CTHDGOI
                                JOIN GOIDICHVU ON CTHDGOI.MAGOIDV = GOIDICHVU.MAGOIDV WHERE CTHDGOI.SOHD = @SOHD
                            ) AS ChiTiet";

                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                adp.SelectCommand.Parameters.AddWithValue("@SOHD", sohd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // Xóa dòng hiện có trong TableLayoutPanel 
                    tableLayoutPanel1.Controls.Clear();
                    tableLayoutPanel1.RowStyles.Clear();

                    // Thêm dòng tiêu đề
                    AddRowToTableLayoutPanel("STT", "Tên sản phẩm", "Số lượng", "Giá", "Thành tiền", isHeader: true);

                    // Thêm từng dòng dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        AddRowToTableLayoutPanel(
                            row["STT"].ToString(),
                            row["TENSP"].ToString(),
                            row["SOLUONG"].ToString(),
                            row["GIABAN"].ToString(),
                            row["THANHTIEN"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Không có chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRowToTableLayoutPanel(string stt, string tenSanPham, string soLuong, string gia, string thanhTien, bool isHeader = false)
        {
            // Thêm một dòng mới
            tableLayoutPanel1.RowCount += 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Tạo và thêm các ô (Label)
            AddCellToTableLayoutPanel(stt, isHeader);
            AddCellToTableLayoutPanel(tenSanPham, isHeader);
            AddCellToTableLayoutPanel(soLuong, isHeader);
            AddCellToTableLayoutPanel(gia, isHeader);
            AddCellToTableLayoutPanel(thanhTien, isHeader);
        }

        private void AddCellToTableLayoutPanel(string text, bool isHeader)
        {
            Label lbl = new Label
            {
                Text = text,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 10, FontStyle.Regular),
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel1.Controls.Add(lbl);
            lb_tongtien.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lb_tongtien.TextAlign = ContentAlignment.MiddleRight;

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var graphics = e.Graphics;
            var rectangle = e.CellBounds;

            using (var pen = new Pen(Color.Black, 2)) // Viền dày 2px
            {
                graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            }
        }
    }
}
