using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_02_QuanLyCongThucNauAn.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiMonAn",
                columns: table => new
                {
                    LoaimonanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenloai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMonAn", x => x.LoaimonanID);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieu",
                columns: table => new
                {
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tennguyenlieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieu", x => x.NguyenlieuID);
                });

            migrationBuilder.CreateTable(
                name: "MonAn",
                columns: table => new
                {
                    MonanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaimonanID = table.Column<int>(type: "int", nullable: false),
                    Tenmon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAn", x => x.MonanID);
                    table.ForeignKey(
                        name: "FK_MonAn_LoaiMonAn_LoaimonanID",
                        column: x => x.LoaimonanID,
                        principalTable: "LoaiMonAn",
                        principalColumn: "LoaimonanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongThuc",
                columns: table => new
                {
                    CongthucID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    MonanID = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongThuc", x => x.CongthucID);
                    table.ForeignKey(
                        name: "FK_CongThuc_MonAn_MonanID",
                        column: x => x.MonanID,
                        principalTable: "MonAn",
                        principalColumn: "MonanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongThuc_NguyenLieu_NguyenlieuID",
                        column: x => x.NguyenlieuID,
                        principalTable: "NguyenLieu",
                        principalColumn: "NguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CongThuc_MonanID",
                table: "CongThuc",
                column: "MonanID");

            migrationBuilder.CreateIndex(
                name: "IX_CongThuc_NguyenlieuID",
                table: "CongThuc",
                column: "NguyenlieuID");

            migrationBuilder.CreateIndex(
                name: "IX_MonAn_LoaimonanID",
                table: "MonAn",
                column: "LoaimonanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CongThuc");

            migrationBuilder.DropTable(
                name: "MonAn");

            migrationBuilder.DropTable(
                name: "NguyenLieu");

            migrationBuilder.DropTable(
                name: "LoaiMonAn");
        }
    }
}
