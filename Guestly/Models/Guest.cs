using System;
using System.Collections.Generic;

namespace Guestly.Models
{
  public class Guest
  {
    public Guest()
    {
      this.Rooms = new HashSet<GuestRoom>();
      this.LifetimeRevenue = 0;
      this.LifetimeNights = 0;
    }

    public int GuestId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int LifetimeNights { get; set; }
    public int LifetimeRevenue { get; set; }
    public ICollection <GuestRoom> Rooms { get; set; }
  }
}