﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebRunning.API.Infrastructure;

namespace WebRunning.API.Infrastructure.migrations
{
    [DbContext(typeof(DomainDbContext))]
    [Migration("20221217175059_UpdateDB1")]
    partial class UpdateDB1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebRunning.API.Model.Por_DangKyTuVan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("NoiDung")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(155)
                        .HasColumnType("character varying(155)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_DangKyTuVans");
                });

            modelBuilder.Entity("WebRunning.API.Model.Por_KhoaHoc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HocPhi")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("HocPhiGiamGia")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("HocPhiGoc")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("IdMonHoc")
                        .HasColumnType("uuid");

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("text");

                    b.Property<string>("Ten")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("integer");

                    b.Property<string>("URL_AnhDaiDien")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_KhoaHocs");
                });

            modelBuilder.Entity("WebRunning.API.Model.Por_Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdMenuCha")
                        .HasColumnType("uuid");

                    b.Property<string>("Ma")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Ten")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("integer");

                    b.Property<string>("URL")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_Menus");
                });

            modelBuilder.Entity("WebRunning.API.Model.Por_MonHoc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdMonHocCha")
                        .HasColumnType("uuid");

                    b.Property<string>("Ma")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Ten")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_MonHocs");
                });

            modelBuilder.Entity("WebRunning.API.Model.Por_NhomTinTuc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdMenuCha")
                        .HasColumnType("uuid");

                    b.Property<string>("Ma")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Ten")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_NhomTinTucs");
                });

            modelBuilder.Entity("WebRunning.API.Model.Por_SuKien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("GiaTien")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("text");

                    b.Property<string>("Ten")
                        .HasMaxLength(155)
                        .HasColumnType("character varying(155)");

                    b.Property<DateTimeOffset>("ThoiGian")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("URL_AnhDaiDien")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_SuKiens");
                });

            modelBuilder.Entity("WebRunning.API.Model.Por_TinTuc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LuotXem")
                        .HasColumnType("integer");

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTimeOffset>("NgayXuatBan")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NoiDung")
                        .HasColumnType("text");

                    b.Property<string>("TieuDe")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("TinMoi")
                        .HasColumnType("boolean");

                    b.Property<bool>("TinNoiBat")
                        .HasColumnType("boolean");

                    b.Property<int>("TrangThai")
                        .HasColumnType("integer");

                    b.Property<string>("URL_AnhDaiDien")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Por_TinTucs");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_AuthToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AccessToken")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RefeshToken")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.HasKey("Id");

                    b.ToTable("Sys_Authtokens");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sys_Categories");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Config", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Value")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("Sys_Configs");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Extension")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ObjectId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ObjectType")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Path")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sys_Files");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DetailsURL")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ObjectId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ObjectType")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Receiver")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sys_Notification");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sys_Organizations");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsFunc")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sys_Permissions");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Icon")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Name")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Url")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.HasKey("Id");

                    b.ToTable("Sys_Resources");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sys_Roles");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("FullName")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean");

                    b.Property<string>("PassWord")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<DateTimeOffset?>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.HasKey("Id");

                    b.ToTable("Sys_Users");
                });

            modelBuilder.Entity("WebRunning.API.Model.Sys_User_Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("OrganId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Sys_Users_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
