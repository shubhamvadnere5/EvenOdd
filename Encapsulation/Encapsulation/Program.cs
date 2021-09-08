using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Account
    {
        private double balance;

        public void GetBalance()
        {
            return balance;
        }
        public void SetBalance(double amount, int v)
        {
            if(amount>0)
            balance =+amount;
            else
            {
                Console.WriteLine("Please Pass +ve Value");
                return balance;
            }
        }
        public void BalanceDetails()
        {
            Console.WriteLine("Acoount Balance=" +balance);
            Console.ReadLine();
        }
    }
}
