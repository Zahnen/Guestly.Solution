using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class RemoveFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "LifetimeRevenue",
                table: "Guests",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                column: "LifetimeRevenue",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2,
                column: "LifetimeRevenue",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3,
                column: "LifetimeRevenue",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 4,
                column: "LifetimeRevenue",
                value: 750);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 5,
                column: "LifetimeRevenue",
                value: 450);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 6,
                column: "LifetimeRevenue",
                value: 190);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 7,
                column: "LifetimeRevenue",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 8,
                column: "LifetimeRevenue",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 9,
                column: "LifetimeRevenue",
                value: 475);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 10,
                column: "LifetimeRevenue",
                value: 450);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 11,
                column: "LifetimeRevenue",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 12,
                column: "LifetimeRevenue",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 13,
                column: "LifetimeRevenue",
                value: 440);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 14,
                column: "LifetimeRevenue",
                value: 550);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 15,
                column: "LifetimeRevenue",
                value: 255);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 16,
                column: "LifetimeRevenue",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 17,
                column: "LifetimeRevenue",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 18,
                column: "LifetimeRevenue",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 19,
                column: "LifetimeRevenue",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 20,
                column: "LifetimeRevenue",
                value: 375);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 21,
                column: "LifetimeRevenue",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 22,
                column: "LifetimeRevenue",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 23,
                column: "LifetimeRevenue",
                value: 440);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 24,
                column: "LifetimeRevenue",
                value: 425);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 25,
                column: "LifetimeRevenue",
                value: 255);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 26,
                column: "LifetimeRevenue",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 27,
                column: "LifetimeRevenue",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 28,
                column: "LifetimeRevenue",
                value: 380);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 29,
                column: "LifetimeRevenue",
                value: 625);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 30,
                column: "LifetimeRevenue",
                value: 450);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 31,
                column: "LifetimeRevenue",
                value: 190);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 32,
                column: "LifetimeRevenue",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 33,
                column: "LifetimeRevenue",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 34,
                column: "LifetimeRevenue",
                value: 475);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 35,
                column: "LifetimeRevenue",
                value: 450);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 36,
                column: "LifetimeRevenue",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 37,
                column: "LifetimeRevenue",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 38,
                column: "LifetimeRevenue",
                value: 440);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 39,
                column: "LifetimeRevenue",
                value: 625);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 40,
                column: "LifetimeRevenue",
                value: 330);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 41,
                column: "LifetimeRevenue",
                value: 1020);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 42,
                column: "LifetimeRevenue",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 43,
                column: "LifetimeRevenue",
                value: 600);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 44,
                column: "LifetimeRevenue",
                value: 475);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 45,
                column: "LifetimeRevenue",
                value: 1105);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 46,
                column: "LifetimeRevenue",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 47,
                column: "LifetimeRevenue",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 48,
                column: "LifetimeRevenue",
                value: 600);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 49,
                column: "LifetimeRevenue",
                value: 625);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 50,
                column: "LifetimeRevenue",
                value: 285);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 51,
                column: "LifetimeRevenue",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 52,
                column: "LifetimeRevenue",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 53,
                column: "LifetimeRevenue",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 54,
                column: "LifetimeRevenue",
                value: 425);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 55,
                column: "LifetimeRevenue",
                value: 330);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 56,
                column: "LifetimeRevenue",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 57,
                column: "LifetimeRevenue",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 58,
                column: "LifetimeRevenue",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 59,
                columns: new[] { "Email", "FirstName", "LastName", "LifetimeRevenue" },
                values: new object[] { "BeelzebubRules@email.com", "Hades", "Beelzebub", 550 });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 60,
                column: "LifetimeRevenue",
                value: 375);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "Price",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "Price",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "Price",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "Price",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "Price",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "Price",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "Price",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "Price",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "Price",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "Price",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "Price",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "Price",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13,
                column: "Price",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14,
                column: "Price",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15,
                column: "Price",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16,
                column: "Price",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17,
                column: "Price",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18,
                column: "Price",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19,
                column: "Price",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20,
                column: "Price",
                value: 125);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "LifetimeRevenue",
                table: "Guests",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                column: "LifetimeRevenue",
                value: 250f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2,
                column: "LifetimeRevenue",
                value: 220f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3,
                column: "LifetimeRevenue",
                value: 340f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 4,
                column: "LifetimeRevenue",
                value: 750f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 5,
                column: "LifetimeRevenue",
                value: 450f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 6,
                column: "LifetimeRevenue",
                value: 190f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 7,
                column: "LifetimeRevenue",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 8,
                column: "LifetimeRevenue",
                value: 340f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 9,
                column: "LifetimeRevenue",
                value: 475f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 10,
                column: "LifetimeRevenue",
                value: 450f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 11,
                column: "LifetimeRevenue",
                value: 250f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 12,
                column: "LifetimeRevenue",
                value: 95f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 13,
                column: "LifetimeRevenue",
                value: 440f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 14,
                column: "LifetimeRevenue",
                value: 550f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 15,
                column: "LifetimeRevenue",
                value: 255f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 16,
                column: "LifetimeRevenue",
                value: 170f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 17,
                column: "LifetimeRevenue",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 18,
                column: "LifetimeRevenue",
                value: 500f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 19,
                column: "LifetimeRevenue",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 20,
                column: "LifetimeRevenue",
                value: 375f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 21,
                column: "LifetimeRevenue",
                value: 220f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 22,
                column: "LifetimeRevenue",
                value: 125f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 23,
                column: "LifetimeRevenue",
                value: 440f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 24,
                column: "LifetimeRevenue",
                value: 425f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 25,
                column: "LifetimeRevenue",
                value: 255f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 26,
                column: "LifetimeRevenue",
                value: 220f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 27,
                column: "LifetimeRevenue",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 28,
                column: "LifetimeRevenue",
                value: 380f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 29,
                column: "LifetimeRevenue",
                value: 625f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 30,
                column: "LifetimeRevenue",
                value: 450f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 31,
                column: "LifetimeRevenue",
                value: 190f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 32,
                column: "LifetimeRevenue",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 33,
                column: "LifetimeRevenue",
                value: 340f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 34,
                column: "LifetimeRevenue",
                value: 475f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 35,
                column: "LifetimeRevenue",
                value: 450f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 36,
                column: "LifetimeRevenue",
                value: 300f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 37,
                column: "LifetimeRevenue",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 38,
                column: "LifetimeRevenue",
                value: 440f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 39,
                column: "LifetimeRevenue",
                value: 625f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 40,
                column: "LifetimeRevenue",
                value: 330f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 41,
                column: "LifetimeRevenue",
                value: 1020f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 42,
                column: "LifetimeRevenue",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 43,
                column: "LifetimeRevenue",
                value: 600f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 44,
                column: "LifetimeRevenue",
                value: 475f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 45,
                column: "LifetimeRevenue",
                value: 1105f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 46,
                column: "LifetimeRevenue",
                value: 170f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 47,
                column: "LifetimeRevenue",
                value: 95f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 48,
                column: "LifetimeRevenue",
                value: 600f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 49,
                column: "LifetimeRevenue",
                value: 625f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 50,
                column: "LifetimeRevenue",
                value: 285f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 51,
                column: "LifetimeRevenue",
                value: 220f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 52,
                column: "LifetimeRevenue",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 53,
                column: "LifetimeRevenue",
                value: 340f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 54,
                column: "LifetimeRevenue",
                value: 425f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 55,
                column: "LifetimeRevenue",
                value: 330f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 56,
                column: "LifetimeRevenue",
                value: 250f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 57,
                column: "LifetimeRevenue",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 58,
                column: "LifetimeRevenue",
                value: 500f);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 59,
                columns: new[] { "Email", "FirstName", "LastName", "LifetimeRevenue" },
                values: new object[] { "TheDevil@email.com", "Satan", "Lucifer", 550f });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 60,
                column: "LifetimeRevenue",
                value: 375f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "Price",
                value: 125f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "Price",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "Price",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "Price",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "Price",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "Price",
                value: 95f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "Price",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "Price",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "Price",
                value: 95f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "Price",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "Price",
                value: 125f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "Price",
                value: 95f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13,
                column: "Price",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14,
                column: "Price",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15,
                column: "Price",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16,
                column: "Price",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17,
                column: "Price",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18,
                column: "Price",
                value: 125f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19,
                column: "Price",
                value: 110f);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20,
                column: "Price",
                value: 125f);
        }
    }
}
