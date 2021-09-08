using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class OOPS
    {
        public static void main(string[] args)
        {
            Account account = new Account();
            account.SetBalance(100, 30);
            account.BalanceDetails();
            Console.Read();


        }
    }
}
