using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomMatch.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    A1 = table.Column<bool>(nullable: false),
                    A2 = table.Column<bool>(nullable: false),
                    A3 = table.Column<bool>(nullable: false),
                    A4 = table.Column<bool>(nullable: false),
                    A5 = table.Column<bool>(nullable: false),
                    A6 = table.Column<bool>(nullable: false),
                    A7 = table.Column<bool>(nullable: false),
                    A8 = table.Column<bool>(nullable: false),
                    A9 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
