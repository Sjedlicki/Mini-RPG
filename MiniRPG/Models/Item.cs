using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniRPG.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? Attack { get; set; }

        Random random = new Random();

        public Item(string itemName, int? attack)
        {
            if(attack == null)
            {
                Attack = random.Next(1, 5);
            }
            ItemName = itemName;
            Attack = attack;
        }
    }
}