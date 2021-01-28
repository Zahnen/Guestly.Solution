using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Guestly.Models;

namespace Guestly.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
      private readonly GuestlyContext _db;

      public HomeController(GuestlyContext db)
      {
        _db = db;
      }

      public ActionResult Index()
      {
        var viewModel = new MyBabyView();
        viewModel.AllGuests = _db.Guests.ToList();
        viewModel.AllRooms = _db.Rooms.ToList();
        List<DataPoint> dataPoints = new List<DataPoint>{
          new DataPoint(10, RoomRevCalc("Suite"), label:"Suite"),
          new DataPoint(20, RoomRevCalc("King"), label:"King"),
          new DataPoint(30, RoomRevCalc("Queen"), label:"Queen"),
          new DataPoint(40, RoomRevCalc("Full"), label:"Full"),
          new DataPoint(50, RoomRevCalc("Baby"), label:"Baby")
        };

			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
			ViewBag.TotalRev = PropertyLifeTimeRev();
      ViewBag.TotalNights = PropertyLifeTimeNights();
      ViewBag.TotalGuests = PropertyLifeTimeGuests();

        return View(viewModel);
      }
      
      public int RoomRevCalc(string roomType)
      {
        var roomsQuery = _db.Rooms.AsQueryable();
        var joinQuery = _db.GuestRoom.AsQueryable();
        var totalRoomsOfType = roomsQuery.Where(entry=>entry.RoomType == roomType).ToList();
        var price = _db.Rooms.FirstOrDefault(entry=>entry.RoomType == roomType).Price;
        var counter = 0;
        for(int i=0; i<totalRoomsOfType.Count; i++)
        {
          var roomOfTypeId = totalRoomsOfType[i].RoomId;
          var staysOfType = joinQuery.Where(entry=>entry.RoomId == roomOfTypeId);
          foreach(GuestRoom stay in staysOfType)
          {
            counter += stay.Nights;
          }
        }
        return price * counter;
      }
      
      public int PropertyLifeTimeRev()
      {
        var guestList = _db.Guests.ToList();
        int rev = 0;
        foreach(Guest guest in guestList)
        {
          rev += guest.LifetimeRevenue;
        }
        return rev;
      }

      public int PropertyLifeTimeNights()
      {
        var guestRoomList = _db.GuestRoom.ToList();
        int totalNights = 0;
        foreach(GuestRoom guestRoom in guestRoomList)
        {
          totalNights += guestRoom.Nights;
        }
        return totalNights;
      }
      public int PropertyLifeTimeGuests()
      {
        var guestList = _db.Guests.ToList();
        int totalGuests = 0;
        foreach(Guest guest in guestList)
        {
          totalGuests += 1;
        }
        return totalGuests;
      }
    }
}
