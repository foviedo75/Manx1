using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manx1.Migrations
{
    public partial class v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    AutoID = table.Column<Guid>(nullable: false),
                    AutoPatente = table.Column<string>(maxLength: 7, nullable: false),
                    AutoColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.AutoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autos");
        }
    }
}
