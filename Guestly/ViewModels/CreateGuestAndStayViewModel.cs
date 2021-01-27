using Guestly.Models;
using System.Collections.Generic;

namespace Guestly.ViewModels
{
  public class CreateGuestAndStayViewModel
  {
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int RoomId {get; set;}
    public int RoomNumber {get; set;}
    public int Nights {get; set;}
  }
}