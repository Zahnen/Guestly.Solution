using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Guestly.Models;

namespace Guestly.Controllers
{
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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Guest guest)
    {
      _db.Guests.Add(guest);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisGuest = _db.Guests
        .Include(guest => guest.Rooms)
        .ThenInclude(join => join.Room)
        .FirstOrDefault(guest => guest.GuestId == id);
      return View(thisGuest);
    }
    
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

    [HttpPost]
    public ActionResult AddRoom(Guest guest, int RoomId)
    {
      if (RoomId != 0)
      {
        _db.GuestRoom.Add(new GuestRoom() {RoomId = RoomId, GuestId = guest.GuestId});
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = guest.GuestId});
    }

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
      _db.GuestRoom.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = joinEntry.GuestId});
    }
  }
}