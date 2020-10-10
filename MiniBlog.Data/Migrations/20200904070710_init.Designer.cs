﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniBlog.Data;

namespace MiniBlog.Data.Migrations
{
    [DbContext(typeof(MiniBlogDbContext))]
    [Migration("20200904070710_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MiniBlog.Data.Entity.AdminEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 210, DateTimeKind.Local).AddTicks(6285),
                            Password = "123456",
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 212, DateTimeKind.Local).AddTicks(1781),
                            User = "admin"
                        });
                });

            modelBuilder.Entity("MiniBlog.Data.Entity.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Category1",
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8099),
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8137)
                        },
                        new
                        {
                            Id = 2,
                            Category = "Category2",
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8199),
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8201)
                        },
                        new
                        {
                            Id = 3,
                            Category = "Category3",
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8203),
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8205)
                        },
                        new
                        {
                            Id = 4,
                            Category = "Category4",
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8207),
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8208)
                        },
                        new
                        {
                            Id = 5,
                            Category = "Category5",
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8210),
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8212)
                        },
                        new
                        {
                            Id = 6,
                            Category = "Category6",
                            CreateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8220),
                            UpdateTime = new DateTime(2020, 9, 4, 15, 7, 10, 221, DateTimeKind.Local).AddTicks(8221)
                        });
                });

            modelBuilder.Entity("MiniBlog.Data.Entity.PictureEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Big")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Origin")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("Small")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("MiniBlog.Data.Entity.PostEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Icon")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("IsShow")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Summary")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("MiniBlog.Data.Entity.PostEntity", b =>
                {
                    b.HasOne("MiniBlog.Data.Entity.CategoryEntity", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}