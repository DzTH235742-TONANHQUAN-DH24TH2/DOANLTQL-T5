using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class ChiTietHoaDon
    {
        [Key]
        public int ID { get; set; }

        public int HoaDonID { get; set; }

        [ForeignKey("HoaDonID")]
        public virtual HoaDon HoaDon { get; set; } = null!;

        public int XeMayDienID { get; set; }

        [ForeignKey("XeMayDienID")]
        public virtual XeMayDien XeMayDien { get; set; } = null!;

        public int SoLuong { get; set; }

        public int DonGia { get; set; }
    }
}
    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int XeMayDienID { get; set; } // Đổi từ SanPhamID
        public string TenXe { get; set; }    // Đổi từ TenSanPham
        public short SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; }
    }