using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzzTalk.Migrations
{
    public partial class AddUsersToBuzzTalk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_ID = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    birth_DT = table.Column<string>(nullable: false),
                    registration_DT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
