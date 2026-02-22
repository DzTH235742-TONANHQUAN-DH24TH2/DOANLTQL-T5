using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class QLXMDDbContext : DbContext
    {
        // Nhóm số ít (Dùng cho Form HoaDon)
        public DbSet<LoaiXe> LoaiXe { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public DbSet<XeMayDien> XeMayDien { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }

        // Nhóm số nhiều (Dùng cho các Form cũ của bạn)
        public DbSet<LoaiXe> LoaiXes { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public DbSet<XeMayDien> XeMayDiens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["QLXMDConnection"]?.ConnectionString;
                if (connectionString != null)
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
                else
                {
                    optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=QLXeMayDien; Integrated Security=True; TrustServerCertificate=True");
                }
            }
        }

        // ĐÂY LÀ PHẦN QUAN TRỌNG ĐỂ FIX LỖI "Invalid object name"
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ép Entity Framework hiểu rằng tất cả các biến trên đều trỏ về bảng có chữ 's' trong SQL
            modelBuilder.Entity<LoaiXe>().ToTable("LoaiXes");
            modelBuilder.Entity<NhaSanXuat>().ToTable("NhaSanXuats");
            modelBuilder.Entity<XeMayDien>().ToTable("XeMayDiens");
            modelBuilder.Entity<NhanVien>().ToTable("NhanViens");
            modelBuilder.Entity<KhachHang>().ToTable("KhachHangs");
            modelBuilder.Entity<HoaDon>().ToTable("HoaDons");
            modelBuilder.Entity<ChiTietHoaDon>().ToTable("ChiTietHoaDons");
        }
    }
}