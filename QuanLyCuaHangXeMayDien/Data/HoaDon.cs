using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }

        public DateTime NgayLap { get; set; } = DateTime.Now;

        public int NhanVienID { get; set; }

        [ForeignKey("NhanVienID")]
        public virtual NhanVien NhanVien { get; set; } = null!;

        public int KhachHangID { get; set; }

        [ForeignKey("KhachHangID")]
        public virtual KhachHang KhachHang { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string? HoVaTenNhanVien { get; set; }
        public int KhachHangID { get; set; }
        public string? HoVaTenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public double? TongTienHoaDon { get; set; }
        public string? XemChiTiet { get; set; }
    }
}
