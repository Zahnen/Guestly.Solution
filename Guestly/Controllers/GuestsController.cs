using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Guestly.Models;
using Guestly.ViewModels;
using System;

namespace Guestly.Controllers
{
  [Authorize]
  public class GuestsController : Controller
  {
    private readonly GuestlyContext _db;
    public GuestsController(GuestlyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Guest> guestList = _db.Guests.ToList();
      return View(guestList);
    }

    [HttpPost]
    public ActionResult Index(string firstName, string lastName, string email, string phoneNumber, string revenue, string nights)
    {
      var guestList = _db.Guests.AsQueryable();

      if(!String.IsNullOrEmpty(firstName))
      {
        guestList = guestList.Where(entry=>entry.FirstName == firstName || entry.FirstName.Contains(firstName));
      }

      if(!String.IsNullOrEmpty(lastName))
      {
        guestList = guestList.Where(entry=>entry.LastName == lastName || entry.FirstName.Contains(lastName));
      }
      
      if(!String.IsNullOrEmpty(email))
      {
        guestList = guestList.Where(entry=>entry.Email == email);
      }
      
      if(!String.IsNullOrEmpty(phoneNumber))
      {
        guestList = guestList.Where(entry=>entry.PhoneNumber == phoneNumber);
      }
      
      if(!String.IsNullOrEmpty(revenue))
      {
        var revenueFloat = float.Parse(revenue);
        guestList = guestList.Where(entry=>entry.LifetimeRevenue >= revenueFloat);
      }
      
      if(!String.IsNullOrEmpty(nights))
      {
        var nightsInt = int.Parse(nights);
        guestList = guestList.Where(entry=>entry.LifetimeNights >= nightsInt);
      }
      
      return View(guestList.ToList());
    }

    [Authorize(Roles = "Admin")]
    public ActionResult Create()
    {
      ViewBag.RoomId = new SelectList(_db.Rooms, "RoomId", "RoomNumber");
      return View();
    }

    [HttpPost]
    public ActionResult Create(CreateGuestAndStayViewModel guest, string dateOfArrival)
    { 
      if(guest.RoomId != 0 && guest.Nights != 0)
      {
        var thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == guest.RoomId);
        var revenue = guest.Nights * thisRoom.Price;
        var nights = guest.Nights;
        var thisGuest = new Guest(){FirstName = guest.FirstName, LastName = guest.LastName, Email = guest.Email, PhoneNumber = guest.PhoneNumber, City = guest.City, State = guest.State, Country = guest.Country,  LifetimeRevenue = revenue, LifetimeNights = nights};
        _db.Guests.Add(thisGuest);

        string[] splitDate = dateOfArrival.Split("-");
        int year = int.Parse(splitDate[0]);
        int month = int.Parse(splitDate[1]);
        int day = int.Parse(splitDate[2]);

        DateTime arriveDate = new DateTime(year, month, day);
        DateTime checkoutDate = arriveDate.AddDays(nights);
        string arrive = arriveDate.ToString("d");
        string checkout = checkoutDate.ToString("d");

        _db.GuestRoom.Add(new GuestRoom(){GuestId = thisGuest.GuestId, RoomId = guest.RoomId, Nights = guest.Nights, ArriveDate = arrive, CheckoutDate = checkout});
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        var thisGuest = new Guest(){FirstName = guest.FirstName, LastName = guest.LastName, Email = guest.Email, PhoneNumber = guest.PhoneNumber, City = guest.City, State = guest.State, Country = guest.Country};
        _db.Guests.Add(thisGuest);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      var thisGuest = _db.Guests
        .Include(guest => guest.Rooms)
        .ThenInclude(join => join.Room)
        .FirstOrDefault(guest => guest.GuestId == id);
      return View(thisGuest);
    }
    
    [Authorize(Roles = "Admin")]
    public ActionResult Edit(int id)
    {
      var thisGuest = _db.Guests.FirstOrDefault(guest => guest.GuestId == id);
      return View(thisGuest);
    }

    [HttpPost]
    public ActionResult Edit(Guest guest)
    {
      _db.Entry(guest).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = guest.GuestId });
    }

    [Authorize(Roles = "Admin")]
    public ActionResult AddRoom(int id)
    {
      var thisGuest = _db.Guests.FirstOrDefault(guest => guest.GuestId == id);
      ViewBag.RoomId = new SelectList(_db.Rooms, "RoomId", "RoomNumber");
      return View(thisGuest);
    }

    [HttpPost]
    public ActionResult AddRoom(Guest guest, int RoomId, int newNights, string dateOfArrival)
    {
      var thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == RoomId);
      var thisRevenue = newNights * thisRoom.Price;
      guest.LifetimeRevenue += thisRevenue;
      guest.LifetimeNights += newNights;
      _db.Entry(guest).State = EntityState.Modified;

      string[] splitDate = dateOfArrival.Split("-");
      int year = int.Parse(splitDate[0]);
      int month = int.Parse(splitDate[1]);
      int day = int.Parse(splitDate[2]);

      DateTime arriveDate = new DateTime(year, month, day);
      DateTime checkoutDate = arriveDate.AddDays(newNights);
      string arrive = arriveDate.ToString("d");
      string checkout = checkoutDate.ToString("d");
      if (RoomId != 0)
      {
        _db.GuestRoom.Add(new GuestRoom() {RoomId = RoomId, GuestId = guest.GuestId, Nights = newNights, ArriveDate = arrive, CheckoutDate = checkout});
      } 
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = guest.GuestId});
    }

    [Authorize(Roles = "Admin")]
    public ActionResult Delete(int id)
    {
      var thisGuest = _db.Guests.FirstOrDefault(guest => guest.GuestId == id);
      return View(thisGuest);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisGuest = _db.Guests.FirstOrDefault(guest => guest.GuestId == id);
      _db.Guests.Remove(thisGuest);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    [HttpPost]
    public ActionResult RemoveRoom(int joinId)
    {
      var joinEntry = _db.GuestRoom.FirstOrDefault(entry => entry.GuestRoomId == joinId);
      var thisGuest = _db.Guests.FirstOrDefault(guest => guest.GuestId == joinEntry.GuestId);
      var thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == joinEntry.RoomId);
      var thisRevenue = joinEntry.Nights * joinEntry.Room.Price;
      thisGuest.LifetimeRevenue -= thisRevenue;
      thisGuest.LifetimeNights -= joinEntry.Nights;
      _db.Entry(thisGuest).State = EntityState.Modified;
      _db.GuestRoom.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = joinEntry.GuestId});
    }
  }
}

