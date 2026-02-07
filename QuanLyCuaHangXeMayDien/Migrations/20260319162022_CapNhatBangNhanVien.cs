using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCuaHangXeMayDien.Migrations
{
    /// <inheritdoc />
    public partial class CapNhatBangNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "NhanViens",
                newName: "DiaChi");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NhanViens",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "QuyenHan",
                table: "NhanViens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TenDangNhap",
                table: "NhanViens",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuyenHan",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "TenDangNhap",
                table: "NhanViens");

            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "NhanViens",
                newName: "Email");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NhanViens",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
