using MiniRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniRPG.Controllers
{
    public class HomeController : Controller
    {

        private FighterDb db = new FighterDb();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatePlayer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePlayer(string name, int? hp,int? lives, int? attack, int? gold)
        {
            Player player = new Player(name, hp, lives, attack, gold);
            if(ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();

                ViewBag.Message = "Player Successfully Created";
                return View();
            }
            ViewBag.Message = "Player not created";
            return View();
        }

        public ActionResult CreateMonster()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMonster(string name, int? hp, int? attack, string lootdropped)
        {
            Monster monster = new Monster(name, hp, attack, lootdropped);
            if(ModelState.IsValid)
            {
                db.Monsters.Add(monster);
                db.SaveChanges();
                ViewBag.Message = "Monster Successfully Created";
                return View();
            }
            ViewBag.Message = "Monster not created";
            return View();
        }

        public ActionResult CreateItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateItem(string itemName, int? attack)
        {
            Item item = new Item(itemName, attack);
            if(ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                ViewBag.Message = "Item Created Successfully";
                return View();
            }
            ViewBag.Message = "Item was not created!";
            return View();
        }
    }
}