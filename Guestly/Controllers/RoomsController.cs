using Guestly.Models;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Guestly.Controllers
{
  public class RoomsController : Controller
  {

    private readonly GuestlyContext _db;

    public RoomsController(GuestlyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Room> model = _db.Rooms.ToList();
      return View(model);
    }
    [Authorize]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Room room)
    {
      _db.Rooms.Add(room);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisRoom = _db.Rooms
        .Include(room => room.Guests)
        .ThenInclude(join => join.Guest)
        .FirstOrDefault(room => room.RoomId == id);
      return View(thisRoom);
    }

    [Authorize]
    public ActionResult Edit(int id)
    {
      var thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == id);
      return View(thisRoom);
    }

    [HttpPost]
    public ActionResult Edit(Room room)
    {
      _db.Entry(room).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddGuest(int id)
    {
      var thisRoom = _db.Rooms.FirstOrDefault(entry => entry.RoomId == id);
      ViewBag.GuestId = new SelectList(_db.Guests, "GuestId", "FirstName", "LastName");
      return View(thisRoom);
    }

    [HttpPost]
    public ActionResult AddGuest(Room room, int GuestId)
    {
      if (GuestId != 0)
      {
        var returnedJoin = _db.GuestRoom
          .Any(join => join.GuestId == GuestId && join.RoomId == room.RoomId);
          if(!returnedJoin)
          {
            _db.GuestRoom.Add(new GuestRoom() { GuestId = GuestId, RoomId = room.RoomId });
          }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult Delete(int id)
    {
      var thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == id);
      return View(thisRoom);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == id);
      _db.Rooms.Remove(thisRoom);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteGuest(int joinId)
    {
      var joinEntry = _db.GuestRoom.FirstOrDefault(entry => entry.GuestRoomId == joinId);
      _db.GuestRoom.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}