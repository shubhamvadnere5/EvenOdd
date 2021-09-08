using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num  = 5 ;
            if(num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else 
            {
                Console.WriteLine("Odd number");
            }
            Console.ReadLine();
        }
    }
}
