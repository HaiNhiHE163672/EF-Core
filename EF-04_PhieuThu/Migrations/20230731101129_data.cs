using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_04_PhieuThu.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiNguyenLieu",
                columns: table => new
                {
                    LoainguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenloai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNguyenLieu", x => x.LoainguyenlieuID);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThu",
                columns: table => new
                {
                    PhieuthuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nhanvienlap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thanhtien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThu", x => x.PhieuthuID);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieu",
                columns: table => new
                {
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoainguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    Tennguyenlieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giaban = table.Column<int>(type: "int", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluongkho = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieu", x => x.NguyenlieuID);
                    table.ForeignKey(
                        name: "FK_NguyenLieu_LoaiNguyenLieu_LoainguyenlieuID",
                        column: x => x.LoainguyenlieuID,
                        principalTable: "LoaiNguyenLieu",
                        principalColumn: "LoainguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuThu",
                columns: table => new
                {
                    ChitietphieuthuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    PhieuthuID = table.Column<int>(type: "int", nullable: false),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuThu", x => x.ChitietphieuthuID);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuThu_NguyenLieu_NguyenlieuID",
                        column: x => x.NguyenlieuID,
                        principalTable: "NguyenLieu",
                        principalColumn: "NguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuThu_PhieuThu_PhieuthuID",
                        column: x => x.PhieuthuID,
                        principalTable: "PhieuThu",
                        principalColumn: "PhieuthuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuThu_NguyenlieuID",
                table: "ChiTietPhieuThu",
                column: "NguyenlieuID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuThu_PhieuthuID",
                table: "ChiTietPhieuThu",
                column: "PhieuthuID");

            migrationBuilder.CreateIndex(
                name: "IX_NguyenLieu_LoainguyenlieuID",
                table: "NguyenLieu",
                column: "LoainguyenlieuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuThu");

            migrationBuilder.DropTable(
                name: "NguyenLieu");

            migrationBuilder.DropTable(
                name: "PhieuThu");

            migrationBuilder.DropTable(
                name: "LoaiNguyenLieu");
        }
    }
}
