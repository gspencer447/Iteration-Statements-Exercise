using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class VoteCheck
    {
        public static void CanYouVote()

        {
            Console.WriteLine("Please enter your age.");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congratulations, you are old enough to vote!");
            }
            else 
            {
                Console.WriteLine("Sorry, you aren't old enough to vote yet.");
            }
        }
    }
}
