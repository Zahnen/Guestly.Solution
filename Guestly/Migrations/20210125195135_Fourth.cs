using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GuestRoom",
                columns: new[] { "GuestRoomId", "GuestId", "Nights", "RoomId" },
                values: new object[,]
                {
                    { 1, 1, 2, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 5, 4, 3 },
                    { 4, 10, 5, 4 },
                    { 5, 1, 3, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 5);
        }
    }
}
