using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;

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
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();

            hd = context.HoaDon.Select(r => new DanhSachHoaDon
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
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
            {
                if (MessageBox.Show("Xác nhận xóa hóa đơn này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
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

        private void frmHoaDon_Load_1(object sender, EventArgs e)
        {

        }
    }
}