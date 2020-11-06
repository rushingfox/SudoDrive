﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Server.Services.Implements;

namespace Server.Migrations
{
    [DbContext(typeof(PostgreSqlDataBaseService))]
    [Migration("20201106075453_AlertFileForDirectory")]
    partial class AlertFileForDirectory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Server.Models.Entities.File", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Folder")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<string>("Md5")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("StorageName")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Server.Models.Entities.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764),
                            GroupName = "Admin",
                            UpdatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764),
                            GroupName = "User",
                            UpdatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764),
                            GroupName = "Guest",
                            UpdatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764)
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToPermission", b =>
                {
                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("Permission")
                        .HasColumnType("character varying(255)")
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
                            Permission = "user.auth.refresh"
                        },
                        new
                        {
                            GroupId = 2L,
                            Permission = "user.auth.updatepassword"
                        },
                        new
                        {
                            GroupId = 3L,
                            Permission = "user.auth.register"
                        },
                        new
                        {
                            GroupId = 3L,
                            Permission = "user.auth.login"
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
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764),
                            Password = "$2a$11$zWYr68EPVnTWOfjcuYI0EuqOL4gRTTm/IcdMTX7SpefmKq3swsrQi",
                            UpdatedAt = new DateTime(2020, 11, 6, 15, 54, 50, 929, DateTimeKind.Local).AddTicks(6764),
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.File", b =>
                {
                    b.HasOne("Server.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
