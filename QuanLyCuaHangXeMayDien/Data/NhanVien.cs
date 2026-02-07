using System.ComponentModel.DataAnnotations;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class NhanVien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = null!;

        [StringLength(20)]
        public string? DienThoai { get; set; }

        [StringLength(100)]
        public string? DiaChi { get; set; }

        [StringLength(50)]
        public string? TenDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; } = null!;

        public bool QuyenHan { get; set; }
    }
}