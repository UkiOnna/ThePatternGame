using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryGood.Base;

namespace InventoryGood.Weapons
{
   public class Bow:Weapon
    {
        public Bow(string name, Rare rare)
        {
            Name = name;
            Type = rare;
        }
    }
}
