using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class PosNeg
    {
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter a number to determine whether it is positive or negative.");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else
            {
                Console.WriteLine("Your number is zero.");
            }
        }
    }
}
