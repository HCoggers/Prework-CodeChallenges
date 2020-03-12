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
                "2) Leap Year Calculator\n " +
                "3) Perfect Sequence\n ");

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
                // ----- PROJECT 3: Perfect Sequence -----
                case "3":
                    Project3();
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
        static void Project3()
        {
            // request integer sequence
            Console.WriteLine("Please input a sequence of numbers to check:");
            int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));

            // determine if input is a perfect sequence
            Console.WriteLine(IsPerfectSequence(input) ? "It's a Perfect Sequence!" : "Hmm... well, It's not perfect...");

            static bool IsPerfectSequence(int[] sequence)
            {
                int product = 1;
                int sum = 0;
                foreach (int n in sequence)
                {
                    product *= n;
                    sum += n;
                }
                return product == sum;
            }
        }
    }
}

