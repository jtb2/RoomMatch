using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomMatch.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    IsOrganized = table.Column<bool>(nullable: false),
                    LikesLight = table.Column<bool>(nullable: false),
                    LikesWorkingAlone = table.Column<bool>(nullable: false),
                    Sleep = table.Column<int>(nullable: false),
                    Social = table.Column<int>(nullable: false),
                    Cleanliness = table.Column<int>(nullable: false),
                    Sharing = table.Column<int>(nullable: false),
                    Sound = table.Column<int>(nullable: false),
                    Temperature = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
