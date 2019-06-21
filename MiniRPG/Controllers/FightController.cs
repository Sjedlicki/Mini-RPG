using MiniRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniRPG.Controllers
{
    public class FightController : Controller
    {
        private FighterDb db = new FighterDb();
        // GET: Fight
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PickFighters()
        {
            return View(db);
        }

        public ActionResult Fight()
        {
            return View();
        }
    }
}