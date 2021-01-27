using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Guestly.Models
{
  public class GuestlyContext : IdentityDbContext<ApplicationUser>
  {
    public GuestlyContext(DbContextOptions<GuestlyContext> options)
      : base(options)
      {
      }

    public DbSet<Guest> Guests { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<GuestRoom> GuestRoom { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Guest>()
        .HasData(
          new Guest {GuestId = 1, FirstName = "Jack", LastName = "Daniel", Email =  "jd@email.com", PhoneNumber = "1223334444", LifetimeNights = 2, LifetimeRevenue = 250 },
          new Guest {GuestId = 2, FirstName = "Drew", LastName = "Mason", Email = "thisisdrew@email.com", PhoneNumber = "5673451231", LifetimeNights = 1, LifetimeRevenue = 220 },
          new Guest {GuestId = 3, FirstName = "Matthew", LastName = "Patel", Email = "matthewpatel@email.com", PhoneNumber = "192837465", LifetimeNights = 4, LifetimeRevenue = 340 },
          new Guest {GuestId = 4, FirstName = "Seth", LastName = "Doray", Email = "sethdoray@email.com", PhoneNumber = "5033505003", LifetimeNights = 5, LifetimeRevenue = 750 },
          new Guest {GuestId = 5, FirstName = "Richard", LastName = "Richardson", Email = "doublerich@email.com", PhoneNumber = "9717717771", LifetimeNights = 3, LifetimeRevenue = 450 },
          new Guest {GuestId = 6, FirstName = "Caleb", LastName = "Edwards", Email = "cal3b3dwards@email.com", PhoneNumber = "2736498710", LifetimeNights = 2, LifetimeRevenue = 190 },
          new Guest {GuestId = 7, FirstName = "Shoyo", LastName = "Hinita", Email = "volleyballrox@email.com", PhoneNumber = "1133224433", LifetimeNights = 1, LifetimeRevenue = 85 },
          new Guest {GuestId = 8, FirstName = "Riley", LastName = "Keys", Email = "rileykeys@email.com", PhoneNumber = "4252075079", LifetimeNights = 4, LifetimeRevenue = 340 },
          new Guest {GuestId = 9, FirstName = "Parker", LastName = "Wallenburger", Email = "heyyouparkit@email.com", PhoneNumber = "5555599999", LifetimeNights = 5, LifetimeRevenue = 475 },
          new Guest {GuestId = 10, FirstName = "Nigel", LastName = "Dogo", Email = "mydognigel@email.com", PhoneNumber = "3333333333", LifetimeNights = 3, LifetimeRevenue = 450 },
          new Guest {GuestId = 11, FirstName = "Rick", LastName = "Ellis", Email = "rickiede@email.com", PhoneNumber = "4155558956", LifetimeNights = 2, LifetimeRevenue = 250 },
          new Guest {GuestId = 12, FirstName = "Alex", LastName = "Calder", Email = "acathome@email.com", PhoneNumber = "5065558989", LifetimeNights = 1, LifetimeRevenue = 95 },
          new Guest {GuestId = 13, FirstName = "Erica", LastName = "Bell", Email = "elbell@email.com", PhoneNumber = "9715558562", LifetimeNights = 4, LifetimeRevenue = 440 },
          new Guest {GuestId = 14, FirstName = "Bobby", LastName = "DeNicola", Email = "denicolab@email.com", PhoneNumber = "7075559846", LifetimeNights = 5, LifetimeRevenue = 550 },
          new Guest {GuestId = 15, FirstName = "Ellie", LastName = "Munoz", Email = "emmunoz@email.com", PhoneNumber = "5035556231", LifetimeNights = 3, LifetimeRevenue = 255 },
          new Guest {GuestId = 16, FirstName = "Joshua", LastName = "McTeller", Email = "jmcteller@email.com", PhoneNumber = "4155558894", LifetimeNights = 2, LifetimeRevenue = 170 },
          new Guest {GuestId = 17, FirstName = "Natalie", LastName = "Lass", Email = "nnatell@email.com", PhoneNumber = "5415558896", LifetimeNights = 1, LifetimeRevenue = 110 },
          new Guest {GuestId = 18, FirstName = "Tripp", LastName = "Ford", Email = "tridoublep@email.com", PhoneNumber = "5035552483", LifetimeNights = 4, LifetimeRevenue = 500 },
          new Guest {GuestId = 19, FirstName = "Willie", LastName = "Ford", Email = "wilford@email.com", PhoneNumber = "4155556472", LifetimeNights = 1, LifetimeRevenue = 110 },
          new Guest {GuestId = 20, FirstName = "Kaitlin", LastName = "Wozniak", Email = "katwoz@email.com", PhoneNumber = "5035558258", LifetimeNights = 3, LifetimeRevenue = 375 },
          new Guest {GuestId = 21, FirstName = "Madalyn", LastName = "Lathem", Email = "madalynl11@email.com", PhoneNumber = "6514553861", LifetimeNights = 2, LifetimeRevenue = 220 },
          new Guest {GuestId = 22, FirstName = "Sean", LastName = "Mercado", Email = "sean.mercado04@email.com", PhoneNumber = "5018988936", LifetimeNights = 1, LifetimeRevenue = 125 },
          new Guest {GuestId = 23, FirstName = "Viktoria", LastName = "Nielsen", Email = "viktoriaaksnes@email.com", PhoneNumber = "7843247148", LifetimeNights = 4, LifetimeRevenue = 440 },
          new Guest {GuestId = 24, FirstName = "Nao", LastName = "Oka", Email = "now@email.com", PhoneNumber = "3193198947", LifetimeNights = 5, LifetimeRevenue = 425 },
          new Guest {GuestId = 25, FirstName = "Bernie", LastName = "Hancock", Email = "bernie@mittens.com", PhoneNumber = "2778649180", LifetimeNights = 3, LifetimeRevenue = 255 },
          new Guest {GuestId = 26, FirstName = "Eleanor", LastName = "Pratte", Email = "pratte16@email.com", PhoneNumber = "4529407334", LifetimeNights = 2, LifetimeRevenue = 220 },
          new Guest {GuestId = 27, FirstName = "Aurora", LastName = "Berg", Email = "aurorabergen@email.com", PhoneNumber = "1338214188", LifetimeNights = 1, LifetimeRevenue = 110 },
          new Guest {GuestId = 28, FirstName = "Frodo", LastName = "Baggins", Email = "mr.underhill@email.com", PhoneNumber = "5385970949", LifetimeNights = 4, LifetimeRevenue = 380 },
          new Guest {GuestId = 29, FirstName = "Aya", LastName = "Takano", Email = "takanoart@email.com", PhoneNumber = "2969397018", LifetimeNights = 5, LifetimeRevenue = 625 },
          new Guest {GuestId = 30, FirstName = "Rick", LastName = "Deckard", Email = "deckard.rick@email.com", PhoneNumber = "6192533993", LifetimeNights = 3, LifetimeRevenue = 450 },
          new Guest {GuestId = 31, FirstName = "Happy", LastName = "Gilmore", Email = "happy_golfmore@email.com", PhoneNumber = "1234578900", LifetimeNights = 2, LifetimeRevenue = 190 },
          new Guest {GuestId = 32, FirstName = "Joyce", LastName= "Summers", Email= "joycesummers@email.com", PhoneNumber= "1987899876", LifetimeNights = 1, LifetimeRevenue = 85 },
          new Guest {GuestId = 33, FirstName = "Harmony", LastName= "Kendall", Email= "KHarm123@email.com", PhoneNumber= "1465768945", LifetimeNights = 4, LifetimeRevenue = 340 },
          new Guest {GuestId = 34, FirstName = "Jenny", LastName= "Calendar", Email= "JennyCal@email.com", PhoneNumber= "2343546754", LifetimeNights = 5, LifetimeRevenue = 475 },
          new Guest {GuestId = 35, FirstName = "Annointed", LastName= "One", Email= "anointed1_66@email.com", PhoneNumber= "6894562341", LifetimeNights = 3, LifetimeRevenue = 450 },
          new Guest {GuestId = 36, FirstName = "Hank", LastName= "Summers", Email= "H.Sums@email.com", PhoneNumber= "1029384234", LifetimeNights = 2, LifetimeRevenue = 300 },
          new Guest {GuestId = 37, FirstName = "Jesse", LastName= "McNally", Email= "jessekmcjay@email.com", PhoneNumber= "4675823123", LifetimeNights = 1, LifetimeRevenue = 85 },
          new Guest {GuestId = 38, FirstName = "Jonathan", LastName= "Levinson", Email= "JonLev@email.com", PhoneNumber= "9858673452", LifetimeNights = 4, LifetimeRevenue = 440 },
          new Guest {GuestId = 39, FirstName = "Ethan", LastName= "Rayne", Email= "eRayne@email.com", PhoneNumber= "2384655432", LifetimeNights = 5, LifetimeRevenue = 625 },
          new Guest {GuestId = 40, FirstName = "Faith", LastName= "Lehane", Email= "gottahavefaith@email.com", PhoneNumber= "2349853456", LifetimeNights = 3, LifetimeRevenue = 330 },
          new Guest {GuestId = 41, FirstName = "Quentin", LastName= "Travers", Email= "notTaratino@email.com", PhoneNumber= "3458768676", LifetimeNights = 12, LifetimeRevenue = 1020 },
          new Guest {GuestId = 42, FirstName = "Scott", LastName= "Hope", Email= "scott!@email.com", PhoneNumber= "5436667534", LifetimeNights = 1, LifetimeRevenue = 150 },
          new Guest {GuestId = 43, FirstName = "Wesley", LastName= "Pryce", Email= "asYouWish@email.com", PhoneNumber= "2345674564", LifetimeNights = 4, LifetimeRevenue = 600 },
          new Guest {GuestId = 44, FirstName = "Cordelia", LastName= "Chase", Email= "PromQueen@email.com", PhoneNumber= "5543234321", LifetimeNights = 5, LifetimeRevenue = 475 },
          new Guest {GuestId = 45, FirstName = "Buffy", LastName= "Summers", Email= "OnlyBuffyWillJudge@email.com", PhoneNumber= "8778887634", LifetimeNights = 13, LifetimeRevenue = 1105 },
          new Guest {GuestId = 46, FirstName = "Rupert", LastName= "Giles", Email= "Bookguy@email.com", PhoneNumber= "4756566879", LifetimeNights = 2, LifetimeRevenue = 170 },
          new Guest {GuestId = 47, FirstName = "Willow", LastName= "Rosenberg", Email= "witchStuff@email.com", PhoneNumber= "7998884475", LifetimeNights = 1, LifetimeRevenue = 95 },
          new Guest {GuestId = 48, FirstName = "Xander", LastName= "Harris", Email= "jokesDotCom@email.com", PhoneNumber= "3334958679", LifetimeNights = 4, LifetimeRevenue = 600 },
          new Guest {GuestId = 49, FirstName = "William", LastName= "Pratt", Email= "BadBois@email.com", PhoneNumber= "4445556634", LifetimeNights = 5, LifetimeRevenue = 625 },
          new Guest {GuestId = 50, FirstName = "Amy", LastName= "Madison", Email= "ImaMouse@email.com", PhoneNumber= "2873345543", LifetimeNights = 3, LifetimeRevenue = 285 },
          new Guest {GuestId = 51, FirstName = "Cassie", LastName= "Newton", Email= "TwoNewtons@email.com", PhoneNumber= "9987896786", LifetimeNights = 2, LifetimeRevenue = 220 },
          new Guest {GuestId = 52, FirstName = "Chao", LastName= "Ahn", Email= "Alternate@email.com", PhoneNumber= "6675844776", LifetimeNights = 1, LifetimeRevenue = 110 },
          new Guest {GuestId = 53, FirstName = "Count", LastName= "Dracula", Email= "SeattleResident@email.com", PhoneNumber= "9980987867", LifetimeNights = 4, LifetimeRevenue = 340 },
          new Guest {GuestId = 54, FirstName = "Forrest", LastName= "Gates", Email= "militarystuff@email.com", PhoneNumber= "8009978865", LifetimeNights = 5, LifetimeRevenue = 425 },
          new Guest {GuestId = 55, FirstName = "India", LastName= "Cohen", Email= "Indiacohen@email.com", PhoneNumber= "9078788986", LifetimeNights = 3, LifetimeRevenue = 330 },
          new Guest {GuestId = 56, FirstName = "Janice", LastName= "Penshaw", Email= "janicePenshaw@email.com", PhoneNumber= "6678745632", LifetimeNights = 2, LifetimeRevenue = 250 },
          new Guest {GuestId = 57, FirstName = "Kathy", LastName= "Newman", Email= "KathyNewman@email.com", PhoneNumber= "1122212345", LifetimeNights = 1, LifetimeRevenue = 110 },
          new Guest {GuestId = 58, FirstName = "Kendra", LastName= "Young", Email= "KendraYoung@email.com", PhoneNumber= "4645534233", LifetimeNights = 4, LifetimeRevenue = 500 },
          new Guest {GuestId = 59, FirstName = "Hades", LastName= "Beelzebub", Email= "BeelzebubRules@email.com", PhoneNumber= "6666666666", LifetimeNights = 5, LifetimeRevenue = 550 },
          new Guest {GuestId = 60, FirstName = "Jenny", LastName= "Jenny", Email= "TheJenny@email.com", PhoneNumber= "2018675309", LifetimeNights = 3, LifetimeRevenue = 375 }
        );
      builder.Entity<Room>()
        .HasData(
          new Room {RoomId = 1, RoomNumber = "105", RoomType = "King", Price = 125 },
          new Room {RoomId = 2, RoomNumber = "110", RoomType = "Queen", Price = 110 },
          new Room {RoomId = 3, RoomNumber = "111", RoomType = "Baby", Price = 85 },
          new Room {RoomId = 4, RoomNumber = "188", RoomType = "Suite", Price = 150 },
          new Room {RoomId = 5, RoomNumber = "190", RoomType = "Suite", Price = 150 },
          new Room {RoomId = 6, RoomNumber = "210", RoomType = "Full", Price = 95 },
          new Room {RoomId = 7, RoomNumber = "211", RoomType = "Baby", Price = 85 },
          new Room {RoomId = 8, RoomNumber = "215", RoomType = "Baby", Price = 85 },
          new Room {RoomId = 9, RoomNumber = "220", RoomType = "Full", Price = 95 },
          new Room {RoomId = 10, RoomNumber = "237", RoomType = "Suite", Price = 150 },
          new Room {RoomId = 11, RoomNumber = "279", RoomType = "King", Price = 125 },
          new Room {RoomId = 12, RoomNumber = "311", RoomType = "Full", Price = 95 },
          new Room {RoomId = 13, RoomNumber = "333", RoomType = "Queen", Price = 110 },
          new Room {RoomId = 14, RoomNumber = "345", RoomType = "Queen", Price = 110 },
          new Room {RoomId = 15, RoomNumber = "366", RoomType = "Baby", Price = 85 },
          new Room {RoomId = 16, RoomNumber = "369", RoomType = "Baby", Price = 85 },
          new Room {RoomId = 17, RoomNumber = "375", RoomType = "Queen", Price = 110 },
          new Room {RoomId = 18, RoomNumber = "380", RoomType = "King", Price = 125 },
          new Room {RoomId = 19, RoomNumber = "387", RoomType = "Queen", Price = 110 },
          new Room {RoomId = 20, RoomNumber = "399", RoomType = "King", Price = 125 }
        );
      builder.Entity<GuestRoom>()
        .HasData(
          new GuestRoom {GuestRoomId = 1, GuestId = 1, RoomId = 1, Nights = 2, ArriveDate = "5/22/20", CheckoutDate = "5/24/20"},
          new GuestRoom {GuestRoomId = 2, GuestId = 2, RoomId = 2, Nights = 1, ArriveDate = "6/5/20", CheckoutDate = "6/6/20"},
          new GuestRoom {GuestRoomId = 3, GuestId = 3, RoomId = 3, Nights = 4, ArriveDate = "1/31/20", CheckoutDate = "2/4/20"},
          new GuestRoom {GuestRoomId = 4, GuestId = 4, RoomId = 4, Nights = 5, ArriveDate = "8/11/20", CheckoutDate = "8/16/20"},
          new GuestRoom {GuestRoomId = 5, GuestId = 5, RoomId = 5, Nights = 3, ArriveDate = "2/28/20", CheckoutDate = "3/2/20"},
          new GuestRoom {GuestRoomId = 6, GuestId = 6, RoomId = 6, Nights = 2, ArriveDate = "6/5/20", CheckoutDate = "6/7/20"},
          new GuestRoom {GuestRoomId = 7, GuestId = 7, RoomId = 7, Nights = 1, ArriveDate = "7/13/20", CheckoutDate = "7/14/20"},
          new GuestRoom {GuestRoomId = 8, GuestId = 8, RoomId = 8, Nights = 4, ArriveDate = "8/15/20", CheckoutDate = "8/19/20"},
          new GuestRoom {GuestRoomId = 9, GuestId = 9, RoomId = 9, Nights = 5, ArriveDate = "9/30/20", CheckoutDate = "10/5/20"},
          new GuestRoom {GuestRoomId = 10, GuestId = 10, RoomId = 10, Nights = 3, ArriveDate = "11/26/19", CheckoutDate = "11/29/19"},
          new GuestRoom {GuestRoomId = 11, GuestId = 11, RoomId = 11, Nights = 2, ArriveDate = "12/25/19", CheckoutDate = "12/27/19"},
          new GuestRoom {GuestRoomId = 12, GuestId = 12, RoomId = 12, Nights = 1, ArriveDate = "12/31/20", CheckoutDate = "1/1/21"},
          new GuestRoom {GuestRoomId = 13, GuestId = 13, RoomId = 13, Nights = 4, ArriveDate = "1/1/20", CheckoutDate = "1/5/20"},
          new GuestRoom {GuestRoomId = 14, GuestId = 14, RoomId = 14, Nights = 5, ArriveDate = "8/10/20", CheckoutDate = "8/15/20"},
          new GuestRoom {GuestRoomId = 15, GuestId = 15, RoomId = 15, Nights = 3, ArriveDate = "10/27/19", CheckoutDate = "10/30/19"},
          new GuestRoom {GuestRoomId = 16, GuestId = 16, RoomId = 16, Nights = 2, ArriveDate = "10/7/20", CheckoutDate = "10/9/20"},
          new GuestRoom {GuestRoomId = 17, GuestId = 17, RoomId = 17, Nights = 1, ArriveDate = "11/28/20", CheckoutDate = "11/29/20"},
          new GuestRoom {GuestRoomId = 18, GuestId = 18, RoomId = 18, Nights = 4, ArriveDate = "4/4/20", CheckoutDate = "4/8/20"},
          new GuestRoom {GuestRoomId = 19, GuestId = 19, RoomId = 19, Nights = 1, ArriveDate = "11/14/19", CheckoutDate = "11/15/19"},
          new GuestRoom {GuestRoomId = 20, GuestId = 20, RoomId = 20, Nights = 3, ArriveDate = "7/4/20", CheckoutDate = "7/7/20"},
          new GuestRoom {GuestRoomId = 21, GuestId = 21, RoomId = 19, Nights = 2, ArriveDate = "3/15/20", CheckoutDate = "3/17/20"},
          new GuestRoom {GuestRoomId = 22, GuestId = 22, RoomId = 18, Nights = 1, ArriveDate = "5/19/20", CheckoutDate = "5/20/20"},
          new GuestRoom {GuestRoomId = 23, GuestId = 23, RoomId = 17, Nights = 4, ArriveDate = "5/30/20", CheckoutDate = "6/4/20"},
          new GuestRoom {GuestRoomId = 24, GuestId = 24, RoomId = 16, Nights = 5, ArriveDate = "2/29/20", CheckoutDate = "3/5/20"},
          new GuestRoom {GuestRoomId = 25, GuestId = 25, RoomId = 15, Nights = 3, ArriveDate = "6/18/20", CheckoutDate = "6/21/20"},
          new GuestRoom {GuestRoomId = 26, GuestId = 26, RoomId = 14, Nights = 2, ArriveDate = "10/29/20", CheckoutDate = "10/31/20"},
          new GuestRoom {GuestRoomId = 27, GuestId = 27, RoomId = 13, Nights = 1, ArriveDate = "11/2/20", CheckoutDate = "11/3/20"},
          new GuestRoom {GuestRoomId = 28, GuestId = 28, RoomId = 12, Nights = 4, ArriveDate = "12/5/20", CheckoutDate = "12/9/20"},
          new GuestRoom {GuestRoomId = 29, GuestId = 29, RoomId = 11, Nights = 5, ArriveDate = "4/1/20", CheckoutDate = "4/6/20"},
          new GuestRoom {GuestRoomId = 30, GuestId = 30, RoomId = 10, Nights = 3, ArriveDate = "5/2/20", CheckoutDate = "5/5/20"},
          new GuestRoom {GuestRoomId = 31, GuestId = 31, RoomId = 9, Nights = 2, ArriveDate = "6/3/20", CheckoutDate = "6/5/20"},
          new GuestRoom {GuestRoomId = 32, GuestId = 32, RoomId = 8, Nights = 1, ArriveDate = "7/4/20", CheckoutDate = "7/5/20"},
          new GuestRoom {GuestRoomId = 33, GuestId = 33, RoomId = 7, Nights = 4, ArriveDate = "8/5/20", CheckoutDate = "8/9/20"},
          new GuestRoom {GuestRoomId = 34, GuestId = 34, RoomId = 6, Nights = 5, ArriveDate = "9/6/20", CheckoutDate = "9/11/20"},
          new GuestRoom {GuestRoomId = 35, GuestId = 35, RoomId = 5, Nights = 3, ArriveDate = "10/7/20", CheckoutDate = "10/10/20"},
          new GuestRoom {GuestRoomId = 36, GuestId = 36, RoomId = 4, Nights = 2, ArriveDate = "11/8/20", CheckoutDate = "11/10/20"},
          new GuestRoom {GuestRoomId = 37, GuestId = 37, RoomId = 3, Nights = 1, ArriveDate = "12/10/19", CheckoutDate = "12/11/19"},
          new GuestRoom {GuestRoomId = 38, GuestId = 38, RoomId = 2, Nights = 4, ArriveDate = "11/21/20", CheckoutDate = "11/25/20"},
          new GuestRoom {GuestRoomId = 39, GuestId = 39, RoomId = 1, Nights = 5, ArriveDate = "10/11/20", CheckoutDate = "10/16/20"},
          new GuestRoom {GuestRoomId = 40, GuestId = 40, RoomId = 2, Nights = 3, ArriveDate = "9/16/20", CheckoutDate = "9/19/20"},
          new GuestRoom {GuestRoomId = 41, GuestId = 41, RoomId = 3, Nights = 1, ArriveDate = "8/23/20", CheckoutDate = "8/24/20"},
          new GuestRoom {GuestRoomId = 42, GuestId = 42, RoomId = 4, Nights = 1, ArriveDate = "7/8/20", CheckoutDate = "7/9/20"},
          new GuestRoom {GuestRoomId = 43, GuestId = 43, RoomId = 5, Nights = 4, ArriveDate = "6/10/20", CheckoutDate = "6/14/20"},
          new GuestRoom {GuestRoomId = 44, GuestId = 44, RoomId = 6, Nights = 5, ArriveDate = "5/8/20", CheckoutDate = "5/13/20"},
          new GuestRoom {GuestRoomId = 45, GuestId = 45, RoomId = 7, Nights = 1, ArriveDate = "4/21/20", CheckoutDate = "4/22/20"},
          new GuestRoom {GuestRoomId = 46, GuestId = 46, RoomId = 8, Nights = 2, ArriveDate = "3/7/20", CheckoutDate = "3/9/20"},
          new GuestRoom {GuestRoomId = 47, GuestId = 47, RoomId = 9, Nights = 1, ArriveDate = "2/3/20", CheckoutDate = "2/4/20"},
          new GuestRoom {GuestRoomId = 48, GuestId = 48, RoomId = 10, Nights = 4, ArriveDate = "1/2/20", CheckoutDate = "1/6/20"},
          new GuestRoom {GuestRoomId = 49, GuestId = 49, RoomId = 11, Nights = 5, ArriveDate = "12/1/19", CheckoutDate = "12/6/19"},
          new GuestRoom {GuestRoomId = 50, GuestId = 50, RoomId = 12, Nights = 3, ArriveDate = "11/13/19", CheckoutDate = "11/16/19"},
          new GuestRoom {GuestRoomId = 51, GuestId = 51, RoomId = 13, Nights = 2, ArriveDate = "10/28/20", CheckoutDate = "10/30/20"},
          new GuestRoom {GuestRoomId = 52, GuestId = 52, RoomId = 14, Nights = 1, ArriveDate = "9/22/20", CheckoutDate = "9/23/20"},
          new GuestRoom {GuestRoomId = 53, GuestId = 53, RoomId = 15, Nights = 4, ArriveDate = "8/24/20", CheckoutDate = "8/28/20"},
          new GuestRoom {GuestRoomId = 54, GuestId = 54, RoomId = 16, Nights = 5, ArriveDate = "7/21/20", CheckoutDate = "7/26/20"},
          new GuestRoom {GuestRoomId = 55, GuestId = 55, RoomId = 17, Nights = 3, ArriveDate = "6/17/20", CheckoutDate = "6/20/20"},
          new GuestRoom {GuestRoomId = 56, GuestId = 56, RoomId = 18, Nights = 2, ArriveDate = "5/3/20", CheckoutDate = "5/5/20"},
          new GuestRoom {GuestRoomId = 57, GuestId = 57, RoomId = 19, Nights = 1, ArriveDate = "4/4/20", CheckoutDate = "4/5/20"},
          new GuestRoom {GuestRoomId = 58, GuestId = 58, RoomId = 20, Nights = 4, ArriveDate = "3/22/20", CheckoutDate = "3/26/20"},
          new GuestRoom {GuestRoomId = 59, GuestId = 59, RoomId = 19, Nights = 5, ArriveDate = "2/10/20", CheckoutDate = "2/15/20"},
          new GuestRoom {GuestRoomId = 60, GuestId = 60, RoomId = 18, Nights = 3, ArriveDate = "1/1/20", CheckoutDate = "1/4/20"}
        );        
    }
  }
}