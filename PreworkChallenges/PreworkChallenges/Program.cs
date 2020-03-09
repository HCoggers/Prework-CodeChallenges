using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----- PROJECT 1: Array Max Result -----

            //Request 5-digit array from user
            Console.WriteLine("Hello. Please input 5 digits. You may use the same digit more than once.");

            string inputOne = Console.ReadLine();
            char[] arrayInput = inputOne.ToCharArray();
         
            Console.WriteLine($"You entered {inputOne}. Please select one digit from this array.");

            //Request single digit selection from user
            double inputTwo = double.Parse(Console.ReadLine());
            Console.WriteLine($"You selected {inputTwo}.");

            //Calculate score (digit * frequency)
            double multiplier = 0;
            foreach(char digit in arrayInput) 
                if (Char.GetNumericValue(digit) == inputTwo) multiplier++;

            double score = inputTwo * multiplier;

            //Print score
            Console.WriteLine($"You scored {score}!");
        }
    }
}
