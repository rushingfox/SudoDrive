﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Services.Implements;

namespace Server.Migrations.MySqlDataBaseServiceMigrations
{
    [DbContext(typeof(MySqlDataBaseService))]
    [Migration("20201103050252_InitialGroupPermissionSeed")]
    partial class InitialGroupPermissionSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Server.Models.Entities.File", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Server.Models.Entities.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083),
                            GroupName = "Admin",
                            UpdatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083),
                            GroupName = "User",
                            UpdatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083),
                            GroupName = "Guest",
                            UpdatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083)
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToPermission", b =>
                {
                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("Permission")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("GroupId", "Permission");

                    b.ToTable("GroupsToPermissionsRelation");

                    b.HasData(
                        new
                        {
                            GroupId = 1L,
                            Permission = "*"
                        },
                        new
                        {
                            GroupId = 2L,
                            Permission = "user.profile.changepassword"
                        },
                        new
                        {
                            GroupId = 3L,
                            Permission = "user.login"
                        },
                        new
                        {
                            GroupId = 3L,
                            Permission = "user.register"
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToUser", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupsToUsersRelation");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            GroupId = 1L
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083),
                            Password = "$2a$11$sc/HJpR8Xtl5TYWKP8EKkejozC6x7JChS.VcllddaFwxj3oE63.Xu",
                            UpdatedAt = new DateTime(2020, 11, 3, 13, 2, 51, 523, DateTimeKind.Local).AddTicks(5083),
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.File", b =>
                {
                    b.HasOne("Server.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToPermission", b =>
                {
                    b.HasOne("Server.Models.Entities.Group", "Group")
                        .WithMany("GroupToPermission")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToUser", b =>
                {
                    b.HasOne("Server.Models.Entities.Group", "Group")
                        .WithMany("GroupToUser")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Models.Entities.User", "User")
                        .WithMany("GroupToUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}