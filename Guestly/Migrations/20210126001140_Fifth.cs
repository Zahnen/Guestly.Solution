using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 3,
                column: "GuestId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 4,
                column: "GuestId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 5,
                columns: new[] { "GuestId", "RoomId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "GuestRoom",
                columns: new[] { "GuestRoomId", "GuestId", "Nights", "RoomId" },
                values: new object[,]
                {
                    { 35, 35, 3, 5 },
                    { 36, 36, 2, 4 },
                    { 37, 37, 1, 3 },
                    { 38, 38, 4, 2 },
                    { 39, 39, 5, 1 },
                    { 40, 40, 3, 2 },
                    { 41, 41, 12, 3 },
                    { 42, 42, 1, 4 },
                    { 43, 43, 4, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "RoomNumber",
                value: "105");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "RoomNumber",
                value: "110");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "RoomNumber",
                value: "111");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "RoomNumber",
                value: "188");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "Price", "RoomNumber", "RoomType" },
                values: new object[] { 150f, "190", "Suite" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { 6, 95f, "210", "Full" },
                    { 7, 85f, "211", "Baby" },
                    { 8, 85f, "215", "Baby" },
                    { 9, 95f, "220", "Full" },
                    { 10, 150f, "237", "Suite" },
                    { 11, 125f, "279", "King" },
                    { 12, 95f, "311", "Full" },
                    { 13, 110f, "333", "Queen" },
                    { 14, 110f, "345", "Queen" },
                    { 15, 85f, "366", "Baby" },
                    { 16, 85f, "369", "Baby" },
                    { 17, 110f, "375", "Queen" },
                    { 18, 125f, "380", "King" },
                    { 19, 110f, "387", "Queen" },
                    { 20, 125f, "399", "King" }
                });

            migrationBuilder.InsertData(
                table: "GuestRoom",
                columns: new[] { "GuestRoomId", "GuestId", "Nights", "RoomId" },
                values: new object[,]
                {
                    { 6, 6, 2, 6 },
                    { 26, 26, 2, 14 },
                    { 52, 52, 1, 14 },
                    { 15, 15, 3, 15 },
                    { 25, 25, 3, 15 },
                    { 53, 53, 4, 15 },
                    { 16, 16, 2, 16 },
                    { 24, 24, 5, 16 },
                    { 54, 54, 5, 16 },
                    { 17, 17, 1, 17 },
                    { 23, 23, 4, 17 },
                    { 55, 55, 3, 17 },
                    { 18, 18, 4, 18 },
                    { 22, 22, 1, 18 },
                    { 56, 56, 2, 18 },
                    { 60, 60, 3, 18 },
                    { 19, 19, 1, 19 },
                    { 21, 21, 2, 19 },
                    { 57, 57, 1, 19 },
                    { 59, 59, 5, 19 },
                    { 14, 14, 5, 14 },
                    { 51, 51, 2, 13 },
                    { 27, 27, 1, 13 },
                    { 13, 13, 4, 13 },
                    { 34, 34, 5, 6 },
                    { 44, 44, 5, 6 },
                    { 7, 7, 1, 7 },
                    { 33, 33, 4, 7 },
                    { 45, 45, 13, 7 },
                    { 8, 8, 4, 8 },
                    { 32, 32, 1, 8 },
                    { 46, 46, 2, 8 },
                    { 9, 9, 5, 9 },
                    { 20, 20, 3, 20 },
                    { 31, 31, 2, 9 },
                    { 10, 10, 3, 10 },
                    { 30, 30, 3, 10 },
                    { 48, 48, 4, 10 },
                    { 11, 11, 2, 11 },
                    { 29, 29, 5, 11 },
                    { 49, 49, 5, 11 },
                    { 12, 12, 1, 12 },
                    { 28, 28, 4, 12 },
                    { 50, 50, 3, 12 },
                    { 47, 47, 1, 9 },
                    { 58, 58, 4, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 3,
                column: "GuestId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 4,
                column: "GuestId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 5,
                columns: new[] { "GuestId", "RoomId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "RoomNumber",
                value: "104");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "RoomNumber",
                value: "345");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "RoomNumber",
                value: "210");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "RoomNumber",
                value: "111");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "Price", "RoomNumber", "RoomType" },
                values: new object[] { 95f, "206", "Full" });
        }
    }
}
