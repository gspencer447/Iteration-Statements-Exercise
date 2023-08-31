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
            bool validNumber = int.TryParse(Console.ReadLine(), out int userAge);

            while (!validNumber) 
            {
                Console.WriteLine("Sorry, that is not a valid input. Please enter your age:");
                validNumber = int.TryParse(Console.ReadLine(),out userAge);
            }

            if (userAge < 18)
            {
                Console.WriteLine("Sorry, you aren't old enough to vote yet.");
            }
            else 
            {
                Console.WriteLine("Congratulations, you are old enough to vote!");
            }
        }
    }
}
