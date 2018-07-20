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
    class Program
    {
        static void Main(string[] args)
        {
            //List<Item> items;
            Inventory inventar=new Inventory();
            // items.Add(inventar.Factory(Equipment.SWORD, Rare.Эпический, "Меч полководца"));
            Item sword=  inventar.Factory(Equipment.SWORD, Rare.Редкий, "Меч полководца");
            Item bow = inventar.Factory(Equipment.BOW, Rare.Обычный, "Лук героя гоблина");
            Item helmet = inventar.Factory(Equipment.HELMET, Rare.Легендарный, "Шлем огра просветителя");
            inventar.AddItem(sword);
            inventar.AddItem(bow);
            inventar.AddItem(helmet);
            inventar.Show();
            Console.ReadLine();
        }
    }
}
