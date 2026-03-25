using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data;

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        int id;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public frmHoaDon_ChiTiet() { InitializeComponent(); }
        public frmHoaDon_ChiTiet(int maHoaDon) { InitializeComponent(); id = maHoaDon; }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID"; cboNhanVien.DisplayMember = "HoTen";

            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID"; cboKhachHang.DisplayMember = "HoTen";

            cboXe.DataSource = context.XeMayDien.ToList();
            cboXe.ValueMember = "ID"; cboXe.DisplayMember = "TenXe";

            dataGridView.AutoGenerateColumns = false;

            if (id != 0)
            {
                var hd = context.HoaDon.Find(id);
                if (hd != null) { cboNhanVien.SelectedValue = hd.NhanVienID; cboKhachHang.SelectedValue = hd.KhachHangID; }

                var ct = context.ChiTietHoaDons.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    XeMayDienID = r.XeMayDienID,
                    TenXe = r.XeMayDien.TenXe,
                    SoLuongBan = (short)r.SoLuong,
                    DonGiaBan = r.DonGia,
                    ThanhTien = r.SoLuong * r.DonGia
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            dataGridView.DataSource = hoaDonChiTiet;
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (cboXe.SelectedValue == null) { MessageBox.Show("Vui lòng chọn xe!"); return; }

            int maXe = Convert.ToInt32(cboXe.SelectedValue);
            var existing = hoaDonChiTiet.FirstOrDefault(x => x.XeMayDienID == maXe);

            if (existing != null)
            {
                existing.SoLuongBan = (short)numSoLuongBan.Value;
                existing.DonGiaBan = (int)numDonGiaBan.Value;
                existing.ThanhTien = (int)(numSoLuongBan.Value * numDonGiaBan.Value);
                dataGridView.Refresh();
            }
            else
            {
                hoaDonChiTiet.Add(new DanhSachHoaDon_ChiTiet
                {
                    XeMayDienID = maXe,
                    TenXe = cboXe.Text,
                    SoLuongBan = (short)numSoLuongBan.Value,
                    DonGiaBan = (int)numDonGiaBan.Value,
                    ThanhTien = (int)(numSoLuongBan.Value * numDonGiaBan.Value)
                });
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDonChiTiet.Count == 0) { MessageBox.Show("Chưa có xe nào trong hóa đơn!"); return; }

            HoaDon hd = (id == 0) ? new HoaDon { NgayLap = DateTime.Now } : context.HoaDon.Find(id);
            hd.NhanVienID = (int)cboNhanVien.SelectedValue;
            hd.KhachHangID = (int)cboKhachHang.SelectedValue;

            if (id == 0) context.HoaDon.Add(hd);
            else
            {
                var oldCt = context.ChiTietHoaDons.Where(x => x.HoaDonID == id);
                context.ChiTietHoaDons.RemoveRange(oldCt);
            }
            context.SaveChanges();

            foreach (var item in hoaDonChiTiet)
                context.ChiTietHoaDons.Add(new ChiTietHoaDon { HoaDonID = hd.ID, XeMayDienID = item.XeMayDienID, SoLuong = item.SoLuongBan, DonGia = item.DonGiaBan });

            context.SaveChanges();
            MessageBox.Show("Lưu thành công!");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}