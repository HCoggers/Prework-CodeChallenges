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
            int inputTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"You selected {inputTwo}.");

            //Calculate score (digit * frequency)

            //Print score

        }
    }
}
