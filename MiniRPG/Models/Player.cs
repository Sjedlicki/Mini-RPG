using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniRPG.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int? HP { get; set; }
        public int? Lives { get; set; }
        public int? Attack { get; set; }
        public int? Gold { get; set; }


        public Player(string name, int? hp, int? lives, int? attack, int? gold)
        {
            Random random = new Random();
            Name = name;
            if(hp == null)
            {
                hp = random.Next(80, 121);
            }
            if(lives == null)
            {
                lives = 3;
            }
            if (attack == null)
            {
                attack = random.Next(10, 26);
            }
            if (gold == null)
            {
                gold = random.Next(500, 1001);
            }

            HP = hp;
            Lives = lives;
            Attack = attack;
            Gold = gold;
        }
    }
}