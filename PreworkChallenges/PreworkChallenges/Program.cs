using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- PROJECT 3: Perfect Sequence -----

            // request integer sequence
            Console.WriteLine("Please input a sequence of numbers to check:");
            int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));

            // determine if input is a perfect sequence
            Console.WriteLine(IsPerfectSequence(input) ? "It's a Perfect Sequence!" : "Hmm... well, It's not perfect...");

        }
        static bool IsPerfectSequence(int[] sequence)
        {
            int product = 1;
            int sum = 0;
            foreach(int n in sequence)
            {
                product *= n;
                sum += n;
            }
            return product == sum;
        }
    }
}
