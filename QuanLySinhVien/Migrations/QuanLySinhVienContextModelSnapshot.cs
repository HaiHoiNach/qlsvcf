﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLySinhVien;

#nullable disable

namespace QuanLySinhVien.Migrations
{
    [DbContext(typeof(QuanLySinhVienContext))]
    partial class QuanLySinhVienContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuanLySinhVien.Khoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Khoas");
                });

            modelBuilder.Entity("QuanLySinhVien.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KhoaId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KhoaId");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("QuanLySinhVien.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LopId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LopId");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("QuanLySinhVien.Lop", b =>
                {
                    b.HasOne("QuanLySinhVien.Khoa", "Khoa")
                        .WithMany("Lops")
                        .HasForeignKey("KhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("QuanLySinhVien.SinhVien", b =>
                {
                    b.HasOne("QuanLySinhVien.Lop", "Lop")
                        .WithMany("SinhViens")
                        .HasForeignKey("LopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("QuanLySinhVien.Khoa", b =>
                {
                    b.Navigation("Lops");
                });

            modelBuilder.Entity("QuanLySinhVien.Lop", b =>
                {
                    b.Navigation("SinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
