using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_02_NhanVien.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuAn",
                columns: table => new
                {
                    DuanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenduan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuAn", x => x.DuanID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    NhanvienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sodienthoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hesoluong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.NhanvienID);
                });

            migrationBuilder.CreateTable(
                name: "PhanCong",
                columns: table => new
                {
                    PhancongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sogiolam = table.Column<int>(type: "int", nullable: false),
                    NhanvienID = table.Column<int>(type: "int", nullable: false),
                    DuanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCong", x => x.PhancongID);
                    table.ForeignKey(
                        name: "FK_PhanCong_DuAn_DuanID",
                        column: x => x.DuanID,
                        principalTable: "DuAn",
                        principalColumn: "DuanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanCong_NhanVien_NhanvienID",
                        column: x => x.NhanvienID,
                        principalTable: "NhanVien",
                        principalColumn: "NhanvienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_DuanID",
                table: "PhanCong",
                column: "DuanID");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_NhanvienID",
                table: "PhanCong",
                column: "NhanvienID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhanCong");

            migrationBuilder.DropTable(
                name: "DuAn");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
