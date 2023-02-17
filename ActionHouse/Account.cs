using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionHouse
{
    public class Account
    {
        string Name { get; set; }
        string Number { get; set; }
        decimal Balance { get; set; }

        public static List<Account> Accounts = new();

        public void Account_CreateList()
        {
            Accounts.Add(new Account
            {
                Name = "Visa",
                Number = "0001",
                Balance = 100
            });

            Accounts.Add(new Account
            {
                Name = "Mastercard",
                Number = "0002",
                Balance = 10000
            });

            Accounts.Add(new Account
            {
                Name = "American Express",
                Number = "0003",
                Balance = 3000
            });

            Accounts.Add(new Account
            {
                Name = "Diners Club",
                Number = "0004",
                Balance = 1000
            });
        }

        public static bool AccountIsTrue(string AskNumber)
        {
            if(Accounts.Any(i => i.Number == AskNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static decimal Getbalance(string AskNumber)
        {
            return Accounts.First(x => x.Number == AskNumber).Balance;
        }

        public static void SetBalance(string AskNumber, decimal Price)
        {
            Accounts[Accounts.FindIndex(x => x.Number == AskNumber)].Balance -= Price;
        }

        public static string GetNameAccount(string AskNumber)
        {
            return Accounts.First(x => x.Number == AskNumber).Name;
        }
    }
}
