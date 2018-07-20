using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryGood.Base;
using InventoryGood.Armors;
using InventoryGood.Weapons;

namespace InventoryGood
{
    public class Inventory
    {
        const int MAX_SIZE = 3;
        List<Item> items;
        public Inventory()
        {
            //  items = things;
            items = new List<Item>();
        }

        public Item Factory(Equipment type, Rare rare, string name)
        {
            switch (type)
            {
                case Equipment.SWORD:
                    return new Sword(name, rare);

                case Equipment.BOW:
                    return new Bow(name, rare);

                case Equipment.HELMET:
                    return new Helmet(name, rare);

                default:
                    return null;

            }
        }

        public void AddItem(Item item)
        {
            if (items.Count < MAX_SIZE)
            {
                items.Add(item);
            }
            else
            {
                Console.WriteLine("Инвентарь полон");
            }
        }

        public void RemoveItem(int Id)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == Id)
                {
                    items.Remove(items[i]);
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("**********Инвентарь******");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Name + "(" + items[i].Type + ")");
            }
        }
    }
}
