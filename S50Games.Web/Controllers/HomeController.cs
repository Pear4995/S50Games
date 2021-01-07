using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using S50Games.Web.Data;
using S50Games.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace S50Games.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            List<Stage> stages = db.Stages.ToList(); // select, load all stages from database --> List<Stages>

            ViewBag.Stages = stages;
            return View();
        }

        public IActionResult CreateGame(string stageId)
        {
            var g = new Game();
            g.StartDate = DateTime.Now;
            g.Stage = db.Stages.SingleOrDefault(x => x.StageId == stageId);
            var p = db.Players.SingleOrDefault(x => x.DisplayName == User.Identity.Name);
            if (p == null)
            {
                p = new Player();
                p.DisplayName = User.Identity.Name;
                p.Id = Guid.NewGuid();
                db.Add(p);
                db.SaveChanges();
            }
            g.Player = p;
            db.Add(g);
            db.SaveChanges();

            return RedirectToAction("Index", "Games", new { id = g.Id });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
