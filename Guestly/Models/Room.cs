using System;
using System.Collections.Generic;

namespace Guestly.Models
{
  public class Room
  {
    public Room()
    {
      this.Guests = new HashSet<GuestRoom>();
    }

    public int RoomId { get; set; }
    public string RoomNumber { get; set; }
    public string RoomType { get; set; }
    public float Price { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection <GuestRoom> Guests { get; set; }
  }
}