using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeteoIT2.Models;
using MeteoIT2.Extension;

namespace MeteoIT2.Models
{
    public class StationsController : Controller
    {
        Entities db = new Entities();
        // GET: Stations
        public ActionResult Index()
        {
            var Stations = db.Stations;
            return View(Stations);
        }
    }
}