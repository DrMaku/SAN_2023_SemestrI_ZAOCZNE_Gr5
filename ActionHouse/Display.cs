using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    internal class Display
    {
        public static void Display_MainMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => ZAKUP");
            Console.WriteLine("2 => SPRZEDAŻ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("\nWYBIERZ 1, 2 LUB 3:");
        }

        public static void Display_ErrorChoose()
        {
            Console.WriteLine("Podałeś błędną wartość. Wprowadź ją ponownie.");
        }

        public static void Display_Buyer_ListItem(List<Item> items)
        {
            Console.WriteLine("LISTA PRZEDMIOTÓW NA AUKCJI");
            Console.WriteLine("-----------------------------------");
            int index = 1;
            foreach (Item item in items.OrderByDescending(x => x.isPref))
            {
                item.CurrentIndex = index;
                index++;
            }
            foreach (Item item in items.OrderByDescending(x => x.isPref))
            {

                if (item.isPref == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(item.CurrentIndex + "." + item.Name + " | " + item.Category + " | " + item.Price + " PLN");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(item.CurrentIndex + "." + item.Name + " | " + item.Category + " | " + item.Price + " PLN");
                }
            }
            Console.WriteLine("\nPODAJ NUMER PRODUKTU KTÓRY CHCESZ ZAKUPIĆ:");
        
            
        }

        public static void Display_Buyer_SetAccount()
        {
            Console.WriteLine("PODAJ NUMER KARTY KREDYTOWEJ (CZTERY CYFRY):");
        }

        public static void Display_Buyer_Result(int itemNumber, string AccountNumber,List<Item> items)
        {
            Item CurrentItem = items.First(x => x.CurrentIndex == itemNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kupiłeś przedmiot: "+CurrentItem.Name);
            Console.WriteLine("Cena: "+CurrentItem.Price);
            Console.WriteLine("Płatność kartą:" +Account.GetNameAccount(AccountNumber) + "("+AccountNumber+")");
            Console.WriteLine("Zakup zapłacony");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
