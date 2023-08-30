using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class TwoEqual
    {
        public static void AreNumbersEqual()
        {
            Console.WriteLine("Please enter the first number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("These numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are not equal.");
            }
        }
    }
}
