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
            ViewBag.Players = db.Players.ToList();
            ViewBag.Monsters = db.Monsters.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult PickFighters(int? playerId, int? monsterId)
        {
            ViewBag.Players = db.Players.ToList();
            ViewBag.Monsters = db.Monsters.ToList();

            if (playerId != null)
            {
                Session["Player"] = db.Players.Find(playerId);
                
            }
            if (monsterId != null)
            {
                Session["Monster"] = db.Monsters.Find(monsterId);

            }

            ViewBag.Player = Session["Player"];
            ViewBag.Monster = Session["Monster"];

            return View();
        }

        public ActionResult Fight()
        {
            ViewBag.Player = Session["Player"];
            ViewBag.Monster = Session["Monster"];
            return View();
        }
    }
}