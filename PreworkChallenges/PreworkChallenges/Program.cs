using System;
using System.Linq;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----- PROJECT 1: Array Max Result -----

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
        }

        static int ArrayScore(int[] numbers, int guess)
        {
            int multiplier = 0;

            foreach (int number in numbers)
                if (number == guess) multiplier++;

            return multiplier * guess;
        }
    }
}
