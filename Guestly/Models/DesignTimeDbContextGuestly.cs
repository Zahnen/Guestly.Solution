using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Guestly.Models
{
  public class GuestlyContextFactory : IDesignTimeDbContextFactory<GuestlyContext>
  {

    GuestlyContext IDesignTimeDbContextFactory<GuestlyContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<GuestlyContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new GuestlyContext(builder.Options);
    }
  }
}