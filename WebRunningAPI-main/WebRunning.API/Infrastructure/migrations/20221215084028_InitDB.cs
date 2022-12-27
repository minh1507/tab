using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebRunning.API.Infrastructure.migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Por_KhoaHocs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ten = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    MoTa = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    NoiDung = table.Column<string>(type: "text", nullable: true),
                    URL_AnhDaiDien = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    IdMonHoc = table.Column<Guid>(type: "uuid", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    HocPhi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    HocPhiGoc = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    HocPhiGiamGia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Por_KhoaHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Por_Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ma = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Ten = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    URL = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    IdMenuCha = table.Column<Guid>(type: "uuid", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Por_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Por_MonHocs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ma = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Ten = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    IdMonHocCha = table.Column<Guid>(type: "uuid", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Por_MonHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Por_NhomTinTucs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ma = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Ten = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    IdMenuCha = table.Column<Guid>(type: "uuid", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Por_NhomTinTucs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Por_TinTucs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TieuDe = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    MoTa = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    NoiDung = table.Column<string>(type: "text", nullable: true),
                    URL_AnhDaiDien = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    NgayXuatBan = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TrangThai = table.Column<int>(type: "integer", nullable: false),
                    TinNoiBat = table.Column<bool>(type: "boolean", nullable: false),
                    TinMoi = table.Column<bool>(type: "boolean", nullable: false),
                    LuotXem = table.Column<int>(type: "integer", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Por_TinTucs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Authtokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    AccessToken = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    RefeshToken = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Authtokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Configs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Value = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Configs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Extension = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Path = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ObjectId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ObjectType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Notification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Receiver = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    DetailsURL = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ObjectId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ObjectType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ResourceId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsFunc = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Resources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Url = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Icon = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UserName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    PassWord = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Email = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsSystem = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Users_Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: true),
                    OrganId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Users_Roles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Por_KhoaHocs");

            migrationBuilder.DropTable(
                name: "Por_Menus");

            migrationBuilder.DropTable(
                name: "Por_MonHocs");

            migrationBuilder.DropTable(
                name: "Por_NhomTinTucs");

            migrationBuilder.DropTable(
                name: "Por_TinTucs");

            migrationBuilder.DropTable(
                name: "Sys_Authtokens");

            migrationBuilder.DropTable(
                name: "Sys_Categories");

            migrationBuilder.DropTable(
                name: "Sys_Configs");

            migrationBuilder.DropTable(
                name: "Sys_Files");

            migrationBuilder.DropTable(
                name: "Sys_Notification");

            migrationBuilder.DropTable(
                name: "Sys_Organizations");

            migrationBuilder.DropTable(
                name: "Sys_Permissions");

            migrationBuilder.DropTable(
                name: "Sys_Resources");

            migrationBuilder.DropTable(
                name: "Sys_Roles");

            migrationBuilder.DropTable(
                name: "Sys_Users");

            migrationBuilder.DropTable(
                name: "Sys_Users_Roles");
        }
    }
}
