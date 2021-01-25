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
          new Guest {GuestId = 1, FirstName = "Jack", LastName = "Daniel", Email =  "jd@email.com", PhoneNumber = "1223334444"},
          new Guest {GuestId = 2, FirstName = "Drew", LastName = "Mason", Email = "thisisdrew@email.com", PhoneNumber = "5673451231"},
          new Guest {GuestId = 3, FirstName = "Matthew", LastName = "Patel", Email = "matthewpatel@email.com", PhoneNumber = "192837465"},
          new Guest {GuestId = 4, FirstName = "Seth", LastName = "Doray", Email = "sethdoray@email.com", PhoneNumber = "5033505003"},
          new Guest {GuestId = 5, FirstName = "Richard", LastName = "Richardson", Email = "doublerich@email.com", PhoneNumber = "9717717771"},
          new Guest {GuestId = 6, FirstName = "Caleb", LastName = "Edwards", Email = "cal3b3dwards@email.com", PhoneNumber = "2736498710"},
          new Guest {GuestId = 7, FirstName = "Shoyo", LastName = "Hinita", Email = "volleyballrox@email.com", PhoneNumber = "1133224433"},
          new Guest {GuestId = 8, FirstName = "Riley", LastName = "Keys", Email = "rileykeys@email.com", PhoneNumber = "4252075079"},
          new Guest {GuestId = 9, FirstName = "Parker", LastName = "Wallenburger", Email = "heyyouparkit@email.com", PhoneNumber = "5555599999"},
          new Guest {GuestId = 10, FirstName = "Nigel", LastName = "Dogo", Email = "mydognigel@email.com", PhoneNumber = "3333333333"},
          new Guest {GuestId = 11, FirstName = "Rick", LastName = "Ellis", Email = "rickiede@email.com", PhoneNumber = "4155558956"},
          new Guest {GuestId = 12, FirstName = "Alex", LastName = "Calder", Email = "acathome@email.com", PhoneNumber = "5065558989"},
          new Guest {GuestId = 13, FirstName = "Erica", LastName = "Bell", Email = "elbell@email.com", PhoneNumber = "9715558562"},
          new Guest {GuestId = 14, FirstName = "Bobby", LastName = "DeNicola", Email = "denicolab@email.com", PhoneNumber = "7075559846"},
          new Guest {GuestId = 15, FirstName = "Ellie", LastName = "Munoz", Email = "emmunoz@email.com", PhoneNumber = "5035556231"},
          new Guest {GuestId = 16, FirstName = "Joshua", LastName = "McTeller", Email = "jmcteller@email.com", PhoneNumber = "4155558894"},
          new Guest {GuestId = 17, FirstName = "Natalie", LastName = "Lass", Email = "nnatell@email.com", PhoneNumber = "5415558896"},
          new Guest {GuestId = 18, FirstName = "Tripp", LastName = "Ford", Email = "tridoublep@email.com", PhoneNumber = "5035552483"},
          new Guest {GuestId = 19, FirstName = "Willie", LastName = "Ford", Email = "wilford@email.com", PhoneNumber = "4155556472"},
          new Guest {GuestId = 20, FirstName = "Kaitlin", LastName = "Wozniak", Email = "katwoz@email.com", PhoneNumber = "5035558258"},
          new Guest {GuestId = 21, FirstName = "Madalyn", LastName = "Lathem", Email = "madalynl11@email.com", PhoneNumber = "6514553861"},
          new Guest {GuestId = 22, FirstName = "Sean", LastName = "Mercado", Email = "sean.mercado04@email.com", PhoneNumber = "5018988936"},
          new Guest {GuestId = 23, FirstName = "Viktoria", LastName = "Nielsen", Email = "viktoriaaksnes@email.com", PhoneNumber = "7843247148"},
          new Guest {GuestId = 24, FirstName = "Nao", LastName = "Oka", Email = "now@email.com", PhoneNumber = "3193198947"},
          new Guest {GuestId = 25, FirstName = "Bernie", LastName = "Hancock", Email = "bernie@mittens.com", PhoneNumber = "2778649180"},
          new Guest {GuestId = 26, FirstName = "Eleanor", LastName = "Pratte", Email = "pratte16@email.com", PhoneNumber = "4529407334"},
          new Guest {GuestId = 27, FirstName = "Aurora", LastName = "Berg", Email = "aurorabergen@email.com", PhoneNumber = "1338214188"},
          new Guest {GuestId = 28, FirstName = "Frodo", LastName = "Baggins", Email = "mr.underhill@email.com", PhoneNumber = "5385970949"},
          new Guest {GuestId = 29, FirstName = "Aya", LastName = "Takano", Email = "takanoart@email.com", PhoneNumber = "2969397018"},
          new Guest {GuestId = 30, FirstName = "Rick", LastName = "Deckard", Email = "deckard.rick@email.com", PhoneNumber = "6192533993"},
          new Guest {GuestId = 31, FirstName = "Happy", LastName = "Gilmore", Email = "happy_golfmore@email.com", PhoneNumber = "1234578900"},
          new Guest {GuestId = 32, FirstName = "Joyce", LastName= "Summers", Email= "joycesummers@email.com", PhoneNumber= "1987899876"},
          new Guest {GuestId = 33, FirstName = "Harmony", LastName= "Kendall", Email= "KHarm123@email.com", PhoneNumber= "1465768945"},
          new Guest {GuestId = 34, FirstName = "Jenny", LastName= "Calendar", Email= "JennyCal@email.com", PhoneNumber= "2343546754"},
          new Guest {GuestId = 35, FirstName = "Annointed", LastName= "One", Email= "anointed1_66@email.com", PhoneNumber= "6894562341"},
          new Guest {GuestId = 36, FirstName = "Hank", LastName= "Summers", Email= "H.Sums@email.com", PhoneNumber= "1029384234"},
          new Guest {GuestId = 37, FirstName = "Jesse", LastName= "McNally", Email= "jessekmcjay@email.com", PhoneNumber= "4675823123"},
          new Guest {GuestId = 38, FirstName = "Jonathan", LastName= "Levinson", Email= "JonLev@email.com", PhoneNumber= "9858673452"},
          new Guest {GuestId = 39, FirstName = "Ethan", LastName= "Rayne", Email= "eRayne@email.com", PhoneNumber= "2384655432"},
          new Guest {GuestId = 40, FirstName = "Faith", LastName= "Lehane", Email= "gottahavefaith@email.com", PhoneNumber= "2349853456"},
          new Guest {GuestId = 41, FirstName = "Quentin", LastName= "Travers", Email= "notTaratino@email.com", PhoneNumber= "3458768676"},
          new Guest {GuestId = 42, FirstName = "Scott", LastName= "Hope", Email= "scott!@email.com", PhoneNumber= "5436667534"},
          new Guest {GuestId = 43, FirstName = "Wesley", LastName= "Pryce", Email= "asYouWish@email.com", PhoneNumber= "2345674564"},
          new Guest {GuestId = 44, FirstName = "Cordelia", LastName= "Chase", Email= "PromQueen@email.com", PhoneNumber= "5543234321"},
          new Guest {GuestId = 45, FirstName = "Buffy", LastName= "Summers", Email= "OnlyBuffyWillJudge@email.com", PhoneNumber= "8778887634"},
          new Guest {GuestId = 46, FirstName = "Rupert", LastName= "Giles", Email= "Bookguy@email.com", PhoneNumber= "4756566879"},
          new Guest {GuestId = 47, FirstName = "Willow", LastName= "Rosenberg", Email= "witchStuff@email.com", PhoneNumber= "7998884475"},
          new Guest {GuestId = 48, FirstName = "Xander", LastName= "Harris", Email= "jokesDotCom@email.com", PhoneNumber= "3334958679"},
          new Guest {GuestId = 49, FirstName = "William", LastName= "Pratt", Email= "BadBois@email.com", PhoneNumber= "4445556634"},
          new Guest {GuestId = 50, FirstName = "Amy", LastName= "Madison", Email= "ImaMouse@email.com", PhoneNumber= "2873345543"},
          new Guest {GuestId = 51, FirstName = "Cassie", LastName= "Newton", Email= "TwoNewtons@email.com", PhoneNumber= "9987896786"},
          new Guest {GuestId = 52, FirstName = "Chao", LastName= "Ahn", Email= "Alternate@email.com", PhoneNumber= "6675844776"},
          new Guest {GuestId = 53, FirstName = "Count", LastName= "Dracula", Email= "SeattleResident@email.com", PhoneNumber= "9980987867"},
          new Guest {GuestId = 54, FirstName = "Forrest", LastName= "Gates", Email= "militarystuff@email.com", PhoneNumber= "8009978865"},
          new Guest {GuestId = 55, FirstName = "India", LastName= "Cohen", Email= "Indiacohen@email.com", PhoneNumber= "9078788986"},
          new Guest {GuestId = 56, FirstName = "Janice", LastName= "Penshaw", Email= "janicePenshaw@email.com", PhoneNumber= "6678745632"},
          new Guest {GuestId = 57, FirstName = "Kathy", LastName= "Newman", Email= "KathyNewman@email.com", PhoneNumber= "1122212345"},
          new Guest {GuestId = 58, FirstName = "Kendra", LastName= "Young", Email= "KendraYoung@email.com", PhoneNumber= "4645534233"},
          new Guest {GuestId = 59, FirstName = "Satan", LastName= "Lucifer", Email= "TheDevil@email.com", PhoneNumber= "6666666666"},
          new Guest {GuestId = 60, FirstName = "Jenny", LastName= "Jenny", Email= "TheJenny@email.com", PhoneNumber= "2018675309"}
        );
    }
  }
}