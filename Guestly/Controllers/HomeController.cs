using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Collections.Generic;
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
        return View(viewModel);
      }

    }
}
