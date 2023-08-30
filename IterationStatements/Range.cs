using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class Range
    {
        public static void InTheRange()

        {
            Console.WriteLine("Please enter a number that falls within the range of -10 and 10.");
            int userNumber = int.Parse(Console.ReadLine()); 
            int highRange = 10;
            int lowRange = -10;
            //must establish the ranges as variables

            if (userNumber >= lowRange && userNumber <= highRange) 
            {
                Console.WriteLine("Your number is within the range.");
            }
            else
            {
                Console.WriteLine("Your number is outside of the range.");
            }
        }
    }
}
