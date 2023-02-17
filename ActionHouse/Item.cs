using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    public class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int CurrentBuyer { get; set; }
        public int CurrentIndex { get; set; }
        public byte isPref { get; set; }

        List<Item> items = new();

        public List<Item> Item_CreateList()
        {
            
            items.Add(
                new Item
                {
                    Name = "iPhone 12Pro",
                    Category = "elektronika",
                    Price = 4600,
                    isPref = 1
                });
            items.Add(
                new Item
                {
                    Name = "Konsola Playstation 5",
                    Category = "elektronika",
                    Price = 2899,
                    isPref = 0
                });
            items.Add(
                new Item
                {
                    Name = "Bluza Adidas Męska Szara",
                    Category = "odzież",
                    Price = 249,
                    isPref = 1
                });
            items.Add(
                new Item
                {
                    Name = "Spodnie Wranglera Arizona",
                    Category = "odzież",
                    Price = 189,
                    isPref = 0
                });
            items.Add(
                new Item
                {
                    Name = "Basen ogrodowy Premium",
                    Category = "dom i ogród",
                    Price = 1199,
                    isPref = 0
                });
            items.Add(
                new Item
                {
                    Name = "Krzesło skandynawskie granatowe",
                    Category = "dom i ogród",
                    Price = 88,
                    isPref = 0
                });

            return items;

        }

        public void SetNewItem(string Name, string Category, decimal Price, byte isPref)
        {
          

        }
    }
}
