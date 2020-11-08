﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Server.Services.Implements;

namespace Server.Migrations
{
    [DbContext(typeof(PostgreSqlDataBaseService))]
    partial class PostgreSqlDataBaseServiceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Server.Models.Entities.File", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

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

                    b.Property<string>("Permission")
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

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Folder");

                    b.HasIndex("Guid");

                    b.HasIndex("Path");

                    b.HasIndex("Status");

                    b.HasIndex("UserId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Server.Models.Entities.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

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
                            CreatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558),
                            GroupName = "Admin",
                            UpdatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558),
                            GroupName = "User",
                            UpdatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558),
                            GroupName = "Guest",
                            UpdatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558)
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToPermission", b =>
                {
                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("Permission")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

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
                            GroupId = 2L,
                            Permission = "storage.file.list.basic"
                        },
                        new
                        {
                            GroupId = 2L,
                            Permission = "storage.file.upload.basic"
                        },
                        new
                        {
                            GroupId = 2L,
                            Permission = "storage.file.delete.basic"
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
                        .UseIdentityByDefaultColumn();

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

                    b.HasIndex("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558),
                            Password = "$2a$11$X.zD2cmCAI9hUm22571DKOXnyzuBqQ6y425Ex4Hm1HyE08X2CXzMC",
                            UpdatedAt = new DateTime(2020, 11, 8, 16, 33, 42, 850, DateTimeKind.Local).AddTicks(1558),
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Server.Models.Entities.File", b =>
                {
                    b.HasOne("Server.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.Entities.GroupToPermission", b =>
                {
                    b.HasOne("Server.Models.Entities.Group", "Group")
                        .WithMany("GroupToPermission")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
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

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.Entities.Group", b =>
                {
                    b.Navigation("GroupToPermission");

                    b.Navigation("GroupToUser");
                });

            modelBuilder.Entity("Server.Models.Entities.User", b =>
                {
                    b.Navigation("GroupToUser");
                });
#pragma warning restore 612, 618
        }
    }
}
