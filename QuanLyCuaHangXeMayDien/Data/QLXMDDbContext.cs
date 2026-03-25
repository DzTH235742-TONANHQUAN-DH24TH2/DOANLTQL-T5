using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class QLXMDDbContext : DbContext
    {
        // Nhóm dùng cho Form HoaDon (Số ít)
        public DbSet<LoaiXe> LoaiXe { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public DbSet<XeMayDien> XeMayDien { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }

        // Nhóm dùng cho các Form cũ (Số nhiều)
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
                    optionsBuilder.UseSqlServer(connectionString);
                else
                    optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=QLXeMayDien; Integrated Security=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Ép EF tìm đúng bảng có chữ 's' trong SQL Server
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