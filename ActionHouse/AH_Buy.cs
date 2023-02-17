using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    internal class AH_Buy
    {
        public void AH_Buy_Menu(List<Item>items)
        {
            int IN, AN;
            Display.Display_Buyer_ListItem(items);

            
            while (true)
            {
                string ItemNumber = Console.ReadLine();
                bool INisTrue = Int32.TryParse(ItemNumber, out int index);
                if (INisTrue)
                {
                    IN = Int32.Parse(ItemNumber);

                    //Chociaż poniższe warunki zostały tak napisane, to powinno to być zrobione inaczej
                    //Aby to było rzetelne powinno przeszukaćlistę items dla item z ilością większą niż 0
                    //Jednak brak czasu wymagał prostrzego podejścia
                    if(IN < items.Count() && IN > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Podałeś błędną wartość, spróbuj ponownie");
            }
            Console.Clear();

            Display.Display_Buyer_SetAccount();

            string AccountNumber;
            while (true)
            {
                AccountNumber = Console.ReadLine();
                if (!Account.AccountIsTrue(AccountNumber))
                {
                    Console.WriteLine("Podałeś błędny numer konta, spróbuj ponownie");
                }
                else
                {
                    break;
                }
            }

            AH_Buy_Functions.AH_Buy_Action(IN, AccountNumber, items);
        }
    }
}
