using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class XTable
    {
        public static void MultiplicationTables()
        {
            Console.WriteLine("Please enter a number to see its multiplication table 1 through 12.");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Here is the multiplication table for {userNumber}");

            for (int i = 1; i <= 12; i++)
            {
                int result = userNumber * i;
                Console.WriteLine($"{userNumber} x {i} = {result}");
            }
        }
    }
}
