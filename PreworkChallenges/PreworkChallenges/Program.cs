using System;
using System.Linq;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a challenge: \n " +
                "1) Array Max Result\n " +
                "2) Leap Year Calculator\n ");

            string choice = Console.ReadLine();
            switch(choice)
            {
                // ----- PROJECT 1: Array Max Result -----
                case "1": 
                    Project1();
                    break;
                // ----- PROJECT 2: Leap Year Calculator -----
                case "2":
                    Project2();
                    break;
            }

        }
            static void Project1()
        {
            //Request 5-digit array from user
            Console.WriteLine("Hello. Please input 5 digits. You may use the same digit more than once.");

            string arrayInput = Console.ReadLine();
            int[] input1 = Array.ConvertAll(arrayInput.ToCharArray(), c => (int)Char.GetNumericValue(c));

            //Request single digit selection from user
            Console.WriteLine($"You entered {arrayInput}. Please select one digit from this array.");

            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"You selected {input2}.");

            //Calculate score (digit * frequency)
            int score = ArrayScore(input1, input2);

            Console.WriteLine($"You scored {score}!");
        

            static int ArrayScore(int[] numbers, int guess)
            {
                int multiplier = 0;

                foreach (int number in numbers)
                    if (number == guess) multiplier++;

                return multiplier * guess;
            }
        }
        static void Project2() {
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

