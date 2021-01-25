using System;
using System.Collections.Generic;

namespace Guestly.Models
{
  public class GuestRoom
  {
    public int GuestRoomId { get; set; }
    public int GuestId { get; set; }
    public int RoomId { get; set; }
    public int Nights { get; set; }
    public Guest Guest { get; set; }
    public Room Room { get; set; }
  }
}