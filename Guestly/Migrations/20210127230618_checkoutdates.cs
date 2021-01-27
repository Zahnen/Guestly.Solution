using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class checkoutdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StayDate",
                table: "GuestRoom",
                newName: "CheckoutDate");

            migrationBuilder.AddColumn<string>(
                name: "ArriveDate",
                table: "GuestRoom",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 1,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "5/22/20", "5/24/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 2,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "6/5/20", "6/6/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 3,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "1/31/20", "2/4/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 4,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "8/11/20", "8/16/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 5,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "2/28/20", "3/2/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 6,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "6/5/20", "6/7/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 7,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "7/13/20", "7/14/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 8,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "8/15/20", "8/19/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 9,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "9/30/20", "10/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 10,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/26/19", "11/29/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 11,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "12/25/19", "12/27/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 12,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "12/31/20", "1/1/21" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 13,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "1/1/20", "1/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 14,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "8/10/20", "8/15/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 15,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "10/27/19", "10/30/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 16,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "10/7/20", "10/9/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 17,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/28/20", "11/29/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 18,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "4/4/20", "4/8/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 19,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/14/19", "11/15/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 20,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "7/4/20", "7/7/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 21,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "3/15/20", "3/17/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 22,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "5/19/20", "5/20/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 23,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "5/30/20", "6/4/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 24,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "2/29/20", "3/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 25,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "6/18/20", "6/21/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 26,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "10/29/20", "10/31/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 27,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/2/20", "11/3/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 28,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "12/5/20", "12/9/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 29,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "4/1/20", "4/6/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 30,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "5/2/20", "5/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 31,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "6/3/20", "6/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 32,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "7/4/20", "7/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 33,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "8/5/20", "8/9/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 34,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "9/6/20", "9/11/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 35,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "10/7/20", "10/10/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 36,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/8/20", "11/10/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 37,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "12/10/19", "12/11/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 38,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/21/20", "11/25/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 39,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "10/11/20", "10/16/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 40,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "9/16/20", "9/19/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 41,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "8/23/20", "8/24/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 42,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "7/8/20", "7/9/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 43,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "6/10/20", "6/14/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 44,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "5/8/20", "5/13/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 45,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "4/21/20", "4/22/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 46,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "3/7/20", "3/9/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 47,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "2/3/20", "2/4/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 48,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "1/2/20", "1/6/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 49,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "12/1/19", "12/6/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 50,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "11/13/19", "11/16/19" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 51,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "10/28/20", "10/30/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 52,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "9/22/20", "9/23/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 53,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "8/24/20", "8/28/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 54,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "7/21/20", "7/26/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 55,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "6/17/20", "6/20/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 56,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "5/3/20", "5/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 57,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "4/4/20", "4/5/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 58,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "3/22/20", "3/26/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 59,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "2/10/20", "2/15/20" });

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 60,
                columns: new[] { "ArriveDate", "CheckoutDate" },
                values: new object[] { "1/1/20", "1/4/20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArriveDate",
                table: "GuestRoom");

            migrationBuilder.RenameColumn(
                name: "CheckoutDate",
                table: "GuestRoom",
                newName: "StayDate");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 1,
                column: "StayDate",
                value: "5/22/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 2,
                column: "StayDate",
                value: "6/5/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 3,
                column: "StayDate",
                value: "1/31/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 4,
                column: "StayDate",
                value: "8/11/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 5,
                column: "StayDate",
                value: "2/28/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 6,
                column: "StayDate",
                value: "6/5/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 7,
                column: "StayDate",
                value: "7/13/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 8,
                column: "StayDate",
                value: "8/15/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 9,
                column: "StayDate",
                value: "9/30/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 10,
                column: "StayDate",
                value: "11/26/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 11,
                column: "StayDate",
                value: "12/25/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 12,
                column: "StayDate",
                value: "12/31/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 13,
                column: "StayDate",
                value: "1/1/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 14,
                column: "StayDate",
                value: "8/10/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 15,
                column: "StayDate",
                value: "10/27/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 16,
                column: "StayDate",
                value: "10/7/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 17,
                column: "StayDate",
                value: "11/28/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 18,
                column: "StayDate",
                value: "4/4/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 19,
                column: "StayDate",
                value: "11/14/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 20,
                column: "StayDate",
                value: "7/4/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 21,
                column: "StayDate",
                value: "3/15/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 22,
                column: "StayDate",
                value: "5/19/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 23,
                column: "StayDate",
                value: "5/30/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 24,
                column: "StayDate",
                value: "2/29/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 25,
                column: "StayDate",
                value: "6/18/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 26,
                column: "StayDate",
                value: "10/29/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 27,
                column: "StayDate",
                value: "11/2/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 28,
                column: "StayDate",
                value: "12/5/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 29,
                column: "StayDate",
                value: "4/1/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 30,
                column: "StayDate",
                value: "5/2/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 31,
                column: "StayDate",
                value: "6/3/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 32,
                column: "StayDate",
                value: "7/4/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 33,
                column: "StayDate",
                value: "8/5/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 34,
                column: "StayDate",
                value: "09/6/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 35,
                column: "StayDate",
                value: "10/7/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 36,
                column: "StayDate",
                value: "11/8/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 37,
                column: "StayDate",
                value: "12/10/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 38,
                column: "StayDate",
                value: "11/21/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 39,
                column: "StayDate",
                value: "10/11/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 40,
                column: "StayDate",
                value: "9/16/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 41,
                column: "StayDate",
                value: "8/23/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 42,
                column: "StayDate",
                value: "7/8/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 43,
                column: "StayDate",
                value: "6/10/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 44,
                column: "StayDate",
                value: "5/8/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 45,
                column: "StayDate",
                value: "4/21/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 46,
                column: "StayDate",
                value: "3/7/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 47,
                column: "StayDate",
                value: "2/3/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 48,
                column: "StayDate",
                value: "1/2/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 49,
                column: "StayDate",
                value: "12/1/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 50,
                column: "StayDate",
                value: "11/13/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 51,
                column: "StayDate",
                value: "10/28/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 52,
                column: "StayDate",
                value: "9/22/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 53,
                column: "StayDate",
                value: "8/30/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 54,
                column: "StayDate",
                value: "7/21/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 55,
                column: "StayDate",
                value: "6/17/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 56,
                column: "StayDate",
                value: "5/3/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 57,
                column: "StayDate",
                value: "4/4/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 58,
                column: "StayDate",
                value: "3/22/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 59,
                column: "StayDate",
                value: "2/10/20");

            migrationBuilder.UpdateData(
                table: "GuestRoom",
                keyColumn: "GuestRoomId",
                keyValue: 60,
                column: "StayDate",
                value: "1/1/20");
        }
    }
}
