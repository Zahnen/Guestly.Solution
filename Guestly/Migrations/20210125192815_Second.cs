using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestly.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_AspNetUsers_UserId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_UserId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Guests");

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "GuestId", "Email", "FirstName", "LastName", "LifetimeNights", "LifetimeRevenue", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "jd@email.com", "Jack", "Daniel", 0, 0f, "1223334444" },
                    { 33, "KHarm123@email.com", "Harmony", "Kendall", 0, 0f, "1465768945" },
                    { 34, "JennyCal@email.com", "Jenny", "Calendar", 0, 0f, "2343546754" },
                    { 35, "anointed1_66@email.com", "Annointed", "One", 0, 0f, "6894562341" },
                    { 36, "H.Sums@email.com", "Hank", "Summers", 0, 0f, "1029384234" },
                    { 37, "jessekmcjay@email.com", "Jesse", "McNally", 0, 0f, "4675823123" },
                    { 38, "JonLev@email.com", "Jonathan", "Levinson", 0, 0f, "9858673452" },
                    { 39, "eRayne@email.com", "Ethan", "Rayne", 0, 0f, "2384655432" },
                    { 40, "gottahavefaith@email.com", "Faith", "Lehane", 0, 0f, "2349853456" },
                    { 41, "notTaratino@email.com", "Quentin", "Travers", 0, 0f, "3458768676" },
                    { 42, "scott!@email.com", "Scott", "Hope", 0, 0f, "5436667534" },
                    { 43, "asYouWish@email.com", "Wesley", "Pryce", 0, 0f, "2345674564" },
                    { 44, "PromQueen@email.com", "Cordelia", "Chase", 0, 0f, "5543234321" },
                    { 32, "joycesummers@email.com", "Joyce", "Summers", 0, 0f, "1987899876" },
                    { 45, "OnlyBuffyWillJudge@email.com", "Buffy", "Summers", 0, 0f, "8778887634" },
                    { 47, "witchStuff@email.com", "Willow", "Rosenberg", 0, 0f, "7998884475" },
                    { 48, "jokesDotCom@email.com", "Xander", "Harris", 0, 0f, "3334958679" },
                    { 49, "BadBois@email.com", "William", "Pratt", 0, 0f, "4445556634" },
                    { 50, "ImaMouse@email.com", "Amy", "Madison", 0, 0f, "2873345543" },
                    { 51, "TwoNewtons@email.com", "Cassie", "Newton", 0, 0f, "9987896786" },
                    { 52, "Alternate@email.com", "Chao", "Ahn", 0, 0f, "6675844776" },
                    { 53, "SeattleResident@email.com", "Count", "Dracula", 0, 0f, "9980987867" },
                    { 54, "militarystuff@email.com", "Forrest", "Gates", 0, 0f, "8009978865" },
                    { 55, "Indiacohen@email.com", "India", "Cohen", 0, 0f, "9078788986" },
                    { 56, "janicePenshaw@email.com", "Janice", "Penshaw", 0, 0f, "6678745632" },
                    { 57, "KathyNewman@email.com", "Kathy", "Newman", 0, 0f, "1122212345" },
                    { 58, "KendraYoung@email.com", "Kendra", "Young", 0, 0f, "4645534233" },
                    { 46, "Bookguy@email.com", "Rupert", "Giles", 0, 0f, "4756566879" },
                    { 31, "happy_golfmore@email.com", "Happy", "Gilmore", 0, 0f, "1234578900" },
                    { 30, "deckard.rick@email.com", "Rick", "Deckard", 0, 0f, "6192533993" },
                    { 29, "takanoart@email.com", "Aya", "Takano", 0, 0f, "2969397018" },
                    { 2, "thisisdrew@email.com", "Drew", "Mason", 0, 0f, "5673451231" },
                    { 3, "matthewpatel@email.com", "Matthew", "Patel", 0, 0f, "192837465" },
                    { 4, "sethdoray@email.com", "Seth", "Doray", 0, 0f, "5033505003" },
                    { 5, "doublerich@email.com", "Richard", "Richardson", 0, 0f, "9717717771" },
                    { 6, "cal3b3dwards@email.com", "Caleb", "Edwards", 0, 0f, "2736498710" },
                    { 7, "volleyballrox@email.com", "Shoyo", "Hinita", 0, 0f, "1133224433" },
                    { 8, "rileykeys@email.com", "Riley", "Keys", 0, 0f, "4252075079" },
                    { 9, "heyyouparkit@email.com", "Parker", "Wallenburger", 0, 0f, "5555599999" },
                    { 10, "mydognigel@email.com", "Nigel", "Dogo", 0, 0f, "3333333333" },
                    { 11, "rickiede@email.com", "Rick", "Ellis", 0, 0f, "4155558956" },
                    { 12, "acathome@email.com", "Alex", "Calder", 0, 0f, "5065558989" },
                    { 13, "elbell@email.com", "Erica", "Bell", 0, 0f, "9715558562" },
                    { 14, "denicolab@email.com", "Bobby", "DeNicola", 0, 0f, "7075559846" },
                    { 15, "emmunoz@email.com", "Ellie", "Munoz", 0, 0f, "5035556231" },
                    { 16, "jmcteller@email.com", "Joshua", "McTeller", 0, 0f, "4155558894" },
                    { 17, "nnatell@email.com", "Natalie", "Lass", 0, 0f, "5415558896" },
                    { 18, "tridoublep@email.com", "Tripp", "Ford", 0, 0f, "5035552483" },
                    { 19, "wilford@email.com", "Willie", "Ford", 0, 0f, "4155556472" },
                    { 20, "katwoz@email.com", "Kaitlin", "Wozniak", 0, 0f, "5035558258" },
                    { 21, "madalynl11@email.com", "Madalyn", "Lathem", 0, 0f, "6514553861" },
                    { 22, "sean.mercado04@email.com", "Sean", "Mercado", 0, 0f, "5018988936" },
                    { 23, "viktoriaaksnes@email.com", "Viktoria", "Nielsen", 0, 0f, "7843247148" },
                    { 24, "now@email.com", "Nao", "Oka", 0, 0f, "3193198947" },
                    { 25, "bernie@mittens.com", "Bernie", "Hancock", 0, 0f, "2778649180" },
                    { 26, "pratte16@email.com", "Eleanor", "Pratte", 0, 0f, "4529407334" },
                    { 27, "aurorabergen@email.com", "Aurora", "Berg", 0, 0f, "1338214188" },
                    { 28, "mr.underhill@email.com", "Frodo", "Baggins", 0, 0f, "5385970949" },
                    { 59, "TheDevil@email.com", "Satan", "Lucifer", 0, 0f, "6666666666" },
                    { 60, "TheJenny@email.com", "Jenny", "Jenny", 0, 0f, "2018675309" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 60);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Guests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_UserId",
                table: "Guests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_AspNetUsers_UserId",
                table: "Guests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
