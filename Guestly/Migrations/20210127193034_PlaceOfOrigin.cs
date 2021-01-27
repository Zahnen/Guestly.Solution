using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class PlaceOfOrigin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Guests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Guests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Guests",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Lynchburg", "United States", "TN" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Albuquerque", "United States", "NM" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Arlington", "United States", "VA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 4,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Boston", "United States", "MA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 5,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Laredo", "United States", "TX" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 6,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Seattle", "United States", "WA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 7,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Karasuno", "Japan", "Miyagi" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 8,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Fresno", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 9,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Washington", "United States", "DC" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 10,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Tulsa", "United States", "OK" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 11,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Tampa", "United States", "FL" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 12,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Greensboro", "United States", "NC" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 13,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Nashville", "United States", "TN" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 14,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Pittsburgh", "United States", "PA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 15,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Riverside", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 16,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Toledo", "United States", "OH" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 17,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "St. Paul", "United States", "MN" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 18,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Detroit", "United States", "MI" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 19,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Cleveland", "United States", "OH" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 20,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Sacramento", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 21,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "San Antonio", "United States", "TX" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 22,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Las Vegas", "United States", "NV" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 23,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "New Orleans", "United States", "LA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 24,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Garland", "United States", "TX" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 25,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Montgomery", "United States", "AB" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 26,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Oakland", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 27,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Boise", "United States", "ID" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 28,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "The Shire", "Middle Earth", "Eriador" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 29,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Tokyo", "Japan", "Tokyo" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 30,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Chula Vista", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 31,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Vancouver", "Canada", "BC" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 32,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "San Diego", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 33,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Durham", "United States", "NC" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 34,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Reno", "United States", "NV" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 35,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Long Beach", "United States", "CA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 36,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Portland", "United States", "OR" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 37,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Atlanta", "United States", "GA" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 38,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Adelaide", "South Africa", "Eastern Cape" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 39,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "ekuPhakameni", "South Africa", "KwaZulu-Natal" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 40,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Hillcrest", "South Africa", "KwaZulu-Natal" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 41,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Montpellier", "France", "Occitanie" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 42,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Nantes", "France", "Pays de la Loire" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 43,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Nice", "France", "Cote d'Azure" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 44,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Marseille", "France", "Bouches-du-Rhone" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 45,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Paris", "France", "Ile-de-France" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 46,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Istanbul", "Turkey", "Istanbul" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 47,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Ankara", "Turkey", "Ankara" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 48,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Izmir", "Turkey", "Izmir" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 49,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Bursa", "Turkey", "Bursa" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 50,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Adana", "Turkey", "Adana" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 51,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Milan", "Italy", "Lombardy" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 52,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Naples", "Italy", "Campania" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 53,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Turin", "Italy", "Piedmont" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 54,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Palermo", "Italy", "Cicily" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 55,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Rome", "Italy", "Lazio" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 56,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Peristeri", "Greece", "Attica" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 57,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Larissa", "Greece", "Thessaly" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 58,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Patras", "Greece", "Western Greece" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 59,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Thessaloniki", "Greece", "Macedonia" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 60,
                columns: new[] { "City", "Country", "State" },
                values: new object[] { "Jersey City", "United States", "NJ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Guests");
        }
    }
}
