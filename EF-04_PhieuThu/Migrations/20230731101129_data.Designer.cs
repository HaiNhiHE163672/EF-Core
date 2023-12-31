﻿// <auto-generated />
using System;
using EF_04_PhieuThu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_04_PhieuThu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230731101129_data")]
    partial class data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_04_PhieuThu.Models.ChiTietPhieuThu", b =>
                {
                    b.Property<int>("ChitietphieuthuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChitietphieuthuID"));

                    b.Property<int>("NguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("PhieuthuID")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongBan")
                        .HasColumnType("int");

                    b.HasKey("ChitietphieuthuID");

                    b.HasIndex("NguyenlieuID");

                    b.HasIndex("PhieuthuID");

                    b.ToTable("ChiTietPhieuThu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.LoaiNguyenLieu", b =>
                {
                    b.Property<int>("LoainguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoainguyenlieuID"));

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenloai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoainguyenlieuID");

                    b.ToTable("LoaiNguyenLieu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.NguyenLieu", b =>
                {
                    b.Property<int>("NguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NguyenlieuID"));

                    b.Property<string>("Donvitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giaban")
                        .HasColumnType("int");

                    b.Property<int>("LoainguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("Soluongkho")
                        .HasColumnType("int");

                    b.Property<string>("Tennguyenlieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NguyenlieuID");

                    b.HasIndex("LoainguyenlieuID");

                    b.ToTable("NguyenLieu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.PhieuThu", b =>
                {
                    b.Property<int>("PhieuthuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuthuID"));

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaylap")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nhanvienlap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thanhtien")
                        .HasColumnType("int");

                    b.HasKey("PhieuthuID");

                    b.ToTable("PhieuThu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.ChiTietPhieuThu", b =>
                {
                    b.HasOne("EF_04_PhieuThu.Models.NguyenLieu", "NguyenLieu")
                        .WithMany("ChiTietPhieuThu")
                        .HasForeignKey("NguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_04_PhieuThu.Models.PhieuThu", "PhieuThu")
                        .WithMany("ChiTietPhieuThu")
                        .HasForeignKey("PhieuthuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguyenLieu");

                    b.Navigation("PhieuThu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.NguyenLieu", b =>
                {
                    b.HasOne("EF_04_PhieuThu.Models.LoaiNguyenLieu", "LoaiNguyenLieu")
                        .WithMany("NguyenLieu")
                        .HasForeignKey("LoainguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiNguyenLieu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.LoaiNguyenLieu", b =>
                {
                    b.Navigation("NguyenLieu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.NguyenLieu", b =>
                {
                    b.Navigation("ChiTietPhieuThu");
                });

            modelBuilder.Entity("EF_04_PhieuThu.Models.PhieuThu", b =>
                {
                    b.Navigation("ChiTietPhieuThu");
                });
#pragma warning restore 612, 618
        }
    }
}
