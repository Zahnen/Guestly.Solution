using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Guestly.Models;

namespace Guestly.Controllers
{
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
				new DataPoint(40, RoomRevCalc("Suite"), label:"Suite"),
				new DataPoint(10, RoomRevCalc("King"), label:"King"),
				new DataPoint(20, RoomRevCalc("Queen"), label:"Queen"),
				new DataPoint(30, RoomRevCalc("Full"), label:"Full"),
				new DataPoint(50, RoomRevCalc("Baby"), label:"Baby")
      };

			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
        return View(viewModel);
      }
      
      public float RoomRevCalc(string roomType)
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
      
      public float PropertyLifeTimeRev()
      {
        var guestList = _db.Guests.ToList();
        float rev = 0;
        foreach(Guest guest in guestList)
        {
          rev += guest.LifetimeRevenue;
        }
        return rev;
      }
    }
}
