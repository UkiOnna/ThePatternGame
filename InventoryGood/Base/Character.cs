using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryGood.Base
{
    public class Character
    {
        int id;
        public int Id { get { return id; } set { id = value; Id = id; } }
        public string Nickname { get; set; }


    }
}
