using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class EvenOdd
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Please enter a number to determine if it is even or odd.");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("This number is even!");
            }
            else 
            {
                Console.WriteLine("This number is odd.");
            }
        }
    }
}
