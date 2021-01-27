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
      List<DataPoint> dataPoints = new List<DataPoint>{
				new DataPoint(10, 22, label:"King"),
				new DataPoint(20, 36, label:"Queen"),
				new DataPoint(30, 42, label:"Full"),
				new DataPoint(40, 51, label:"Suite"),
				new DataPoint(50, 40, label:"Baby"),
      };

			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
        return View();
      }

    }
}
