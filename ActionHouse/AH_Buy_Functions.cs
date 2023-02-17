using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    internal class AH_Buy_Functions
    {
        public static void AH_Buy_Action(int IN, string AN, List<Item> items)
        {


            Item currentItem = items.First(x => x.CurrentIndex == IN);

            decimal Price = currentItem.Price;
            decimal Balance = Account.Getbalance(AN);

            if(Price > Balance)
            {
                Console.WriteLine("Brak środków na koncie");
                return;
            }

            Display.Display_Buyer_Result(IN, AN, items);

            Account.SetBalance(AN, Price);
            items.Remove(currentItem);


        }
    }
}
