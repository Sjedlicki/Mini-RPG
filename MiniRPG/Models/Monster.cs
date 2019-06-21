using System;
using System.ComponentModel.DataAnnotations;

namespace MiniRPG.Models
{
    public class Monster
    {
        [Key]
        public int MonsterId { get; set; }
        public string Name { get; set; }
        public int? HP { get; set; }
        public int? Attack { get; set; }
        public string LootDropped { get; set; }

        public Random random = new Random();

        public Monster(string name,int? hp, int? attack, string lootDropped)
        {
            if (hp == null)
            {
                hp = random.Next(80, 101);
            }
            if (attack == null)
            {
                attack = random.Next(10, 21);
            }

            Name = name;
            HP = hp;            
            Attack = attack;
            LootDropped = lootDropped;
        }
    }
}