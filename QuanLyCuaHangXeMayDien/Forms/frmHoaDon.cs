using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;
using ClosedXML.Excel;
using System.Data;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmHoaDon : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        int id;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoTen,
                NgayLap = r.NgayLap,
                TongTienHoaDon = context.ChiTietHoaDons.Where(ct => ct.HoaDonID == r.ID).Sum(ct => ct.SoLuong * ct.DonGia),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
            {
                if (MessageBox.Show("Xác nhận xóa hóa đơn này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                    var hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        var chiTietList = context.ChiTietHoaDons.Where(ct => ct.HoaDonID == id).ToList();
                        context.ChiTietHoaDons.RemoveRange(chiTietList);
                        context.HoaDon.Remove(hd);
                        context.SaveChanges();
                        frmHoaDon_Load(sender, e);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu hóa đơn ra Excel";
            saveFileDialog.Filter = "Tập tin Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // --- BẢNG 1: HÓA ĐƠN ---
                    DataTable dtHoaDon = new DataTable();
                    dtHoaDon.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("NhanVienID", typeof(int)),
                new DataColumn("KhachHangID", typeof(int)),
                new DataColumn("NgayLap", typeof(DateTime))
            });

                    // Thay context.HoaDons thành tên DbSet của bạn nếu khác (VD: context.HoaDon)
                    var listHoaDon = context.HoaDons.ToList();
                    foreach (var hd in listHoaDon)
                    {
                        dtHoaDon.Rows.Add(hd.ID, hd.NhanVienID, hd.KhachHangID, hd.NgayLap);
                    }

                    // --- BẢNG 2: CHI TIẾT HÓA ĐƠN ---
                    DataTable dtChiTiet = new DataTable();
                    dtChiTiet.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("HoaDonID", typeof(int)),
                new DataColumn("XeMayDienID", typeof(int)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(decimal))
            });

                    // Thay context.ChiTietHoaDons bằng tên DbSet của bạn
                    var listChiTiet = context.ChiTietHoaDons.ToList();
                    foreach (var ct in listChiTiet)
                    {
                        dtChiTiet.Rows.Add(ct.ID, ct.HoaDonID, ct.XeMayDienID, ct.SoLuong, ct.DonGia);
                    }

                    // --- XUẤT RA 2 SHEET ---
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(dtHoaDon, "HoaDon");
                        sheet1.Columns().AdjustToContents();

                        var sheet2 = wb.Worksheets.Add(dtChiTiet, "HoaDon_ChiTiet");
                        sheet2.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra 2 sheet (HoaDon và HoaDon_ChiTiet) thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu hóa đơn từ Excel";
            openFileDialog.Filter = "Tập tin Excel (*.xlsx)|*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        // 1. NHẬP SHEET HÓA ĐƠN
                        IXLWorksheet wsHoaDon = workbook.Worksheet("HoaDon");
                        bool firstRowHD = true;

                        foreach (IXLRow row in wsHoaDon.RowsUsed())
                        {
                            if (firstRowHD) { firstRowHD = false; continue; } // Bỏ qua dòng tiêu đề

                            HoaDon hd = new HoaDon();
                            // Đọc từ cột số 2 (cột 1 là ID tự tăng nên thường bỏ qua khi nhập mới)
                            hd.NhanVienID = Convert.ToInt32(row.Cell(2).Value.ToString());
                            hd.KhachHangID = Convert.ToInt32(row.Cell(3).Value.ToString());
                            hd.NgayLap = Convert.ToDateTime(row.Cell(4).Value.ToString());

                            context.HoaDons.Add(hd);
                        }

                        // 2. NHẬP SHEET CHI TIẾT HÓA ĐƠN
                        IXLWorksheet wsChiTiet = workbook.Worksheet("HoaDon_ChiTiet");
                        bool firstRowCT = true;

                        foreach (IXLRow row in wsChiTiet.RowsUsed())
                        {
                            if (firstRowCT) { firstRowCT = false; continue; }

                            // Tên class có thể là ChiTietHoaDon hoặc HoaDon_ChiTiet tùy bạn thiết kế
                            ChiTietHoaDon ct = new ChiTietHoaDon();
                            ct.HoaDonID = Convert.ToInt32(row.Cell(2).Value.ToString());
                            ct.XeMayDienID = Convert.ToInt32(row.Cell(3).Value.ToString());
                            ct.SoLuong = Convert.ToInt32(row.Cell(4).Value.ToString());
                            ct.DonGia = Convert.ToInt32(row.Cell(5).Value.ToString());

                            context.ChiTietHoaDons.Add(ct);
                        }

                        // Lưu tất cả vào Database
                        context.SaveChanges();
                        MessageBox.Show("Đã nhập thành công dữ liệu từ 2 sheet.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Kiểm tra lại tên sheet (phải là HoaDon và HoaDon_ChiTiet) hoặc định dạng số liệu.\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}