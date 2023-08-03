﻿// <auto-generated />
using System;
using EF_03_KhoaHoc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_03_KhoaHoc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_03_KhoaHoc.Models.HocVien", b =>
                {
                    b.Property<int>("HocVienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HocVienID"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhoaHocID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HocVienID");

                    b.HasIndex("KhoaHocID");

                    b.ToTable("HocVien");
                });

            modelBuilder.Entity("EF_03_KhoaHoc.Models.KhoaHoc", b =>
                {
                    b.Property<int>("KhoaHocID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KhoaHocID"));

                    b.Property<int>("HocPhi")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKhoaHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhoaHocID");

                    b.ToTable("KhoaHoc");
                });

            modelBuilder.Entity("EF_03_KhoaHoc.Models.NgayHoc", b =>
                {
                    b.Property<int>("NgayHocID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NgayHocID"));

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhoaHocID")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NgayHocID");

                    b.HasIndex("KhoaHocID");

                    b.ToTable("NgayHoc");
                });

            modelBuilder.Entity("EF_03_KhoaHoc.Models.HocVien", b =>
                {
                    b.HasOne("EF_03_KhoaHoc.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("HocViens")
                        .HasForeignKey("KhoaHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("EF_03_KhoaHoc.Models.NgayHoc", b =>
                {
                    b.HasOne("EF_03_KhoaHoc.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("NgayHocs")
                        .HasForeignKey("KhoaHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("EF_03_KhoaHoc.Models.KhoaHoc", b =>
                {
                    b.Navigation("HocViens");

                    b.Navigation("NgayHocs");
                });
#pragma warning restore 612, 618
        }
    }
}
