using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryGood.Base;

namespace InventoryGood.Armors
{
   public class Helmet:Armor
    {
        public Helmet(string name,Rare rare)
        {
            Name = name;
            Type = rare;
        }
    }
}
