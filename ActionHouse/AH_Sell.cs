using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    internal class AH_Sell
    {
        public void SellItem(List<Item> items)
        {
            Console.WriteLine("Podaj nazwę przedmiotu, który chcesz sprzedać:");
            string name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Podaj kategorię przedmiotu, do której należy przedmiot:");
            string category = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Podaj cenę przedmotu, który chcesz sprzedać:");
            var isTrue = decimal.TryParse(Console.ReadLine(), out decimal result);
            decimal price;
            if (isTrue)
            {
                price = result;
            }
            else
            {
                Console.WriteLine("Podałeś błędną wartość");
                return;
            }

            Console.WriteLine("Napisz \"Tak\", jeśli przedmiotma być promowany");
            string isPrefText = Console.ReadLine();
            byte isPref;
            if (isPrefText == "Tak")
            {
                isPref = 1;
            }
            else
            {
                isPref = 0;
            }

            items.Add(new Item
            {
                Name = name,
                Category = category,
                Price = price,
                isPref = isPref
            });
        }
    }
}
