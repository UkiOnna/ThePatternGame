using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryGood.Base
{
  public  class Item
    {
       int id;
       public int Id { get { return id; } set { id = value; Id = id; } }
       public string Name { get; set; }
       public Rare Type { get; set; }

    }
}
