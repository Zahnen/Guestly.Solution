using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class dateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StayDate",
                table: "GuestRoom",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StayDate",
                table: "GuestRoom");
        }
    }
}
