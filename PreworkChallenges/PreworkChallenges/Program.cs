using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- PROJECT 2: Leap Year Calculator -----

            //enter a year
            Console.WriteLine("Please enter any year you can think of:");
            int year = Int32.Parse(Console.ReadLine());

            //determine if it is a leap year
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                Console.WriteLine("Congratulations! you found a Leap Year!");
            else
                Console.WriteLine("Nah, man, that's just a normal 365-day year.");
        }
    }
}
