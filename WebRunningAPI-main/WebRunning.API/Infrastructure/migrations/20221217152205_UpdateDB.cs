using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebRunning.API.Infrastructure.migrations
{
    public partial class UpdateDB : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Por_SuKiens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ten = table.Column<string>(type: "character varying(155)", maxLength: 155, nullable: true),
                    DiaChi = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    NoiDung = table.Column<string>(type: "text", nullable: true),
                    GiaTien = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ThoiGian = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    URL_AnhDaiDien = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UpdatedDateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Por_SuKiens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Por_SuKiens");
        }

    }
}