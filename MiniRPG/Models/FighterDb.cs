using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiniRPG.Models
{
    public class FighterDb : DbContext
    {
        public FighterDb() : base("FighterDb") { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}