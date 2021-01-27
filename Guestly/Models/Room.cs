using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
    public int Price { get; set; }
    public ICollection <GuestRoom> Guests { get; set; }
  }
}