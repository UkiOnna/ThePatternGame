using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryGood.Base;

namespace InventoryGood
{
   public class Sword:Weapon
    {
        public Sword(string name, Rare rare)
        {
            Name = name;
            Type = rare;
        }
    }
}
