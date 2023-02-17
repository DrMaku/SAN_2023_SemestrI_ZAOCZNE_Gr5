using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    internal class AH_App
    {
        AH_Functions AHF = new();
        Item AHitem = new();
        Account AHaccount = new();
        AH_Buy buy = new();
        AH_Sell sell = new();

        public void AH_MainMenu()
        {
            List<Item> items = AHitem.Item_CreateList();
            AHaccount.Account_CreateList();

            bool App = true;
            while (App == true)
            {
                Console.Clear();
                Display.Display_MainMenu();


                string Choose;
                Choose = Console.ReadLine();
                int Choose_AHF = AHF.Fun_Choose(Choose);

                if (Choose_AHF >= 1 && Choose_AHF <= 3)
                {
                    switch(Choose_AHF)
                    {
                        case 1:
                            buy.AH_Buy_Menu(items);
                            break;
                        case 2:
                            sell.SellItem(items);
                            break;
                        case 3:
                            App = false;
                            break;
                    }
                }
                else
                {
                    Display.Display_ErrorChoose();
                }
            }
        }
    }
}
