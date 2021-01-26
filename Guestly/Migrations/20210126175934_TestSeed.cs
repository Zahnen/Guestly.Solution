using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class TestSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                columns: new[] { "LifetimeNights", "LifetimeRevenue" },
                values: new object[] { 2, 250f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                columns: new[] { "LifetimeNights", "LifetimeRevenue" },
                values: new object[] { 0, 0f });
        }
    }
}
