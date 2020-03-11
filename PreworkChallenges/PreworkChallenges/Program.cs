using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] someMatrix = new int[4, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 5, 7, 9 }, { 10, 20, 0 } };
            
            Console.WriteLine("Given: " + someMatrix + " The sums are:");
            int[] result = SumMatrix(someMatrix);
            foreach (int n in result)
                Console.Write($"{n}, ");
        }
        static int[] SumMatrix(int[,] matrix)
        {
            int[] sum = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int indexSum = 0;
                for (int n = 0; n < matrix.GetLength(1); n++)
                    indexSum += matrix[i,n];
                sum[i] = indexSum;
            }
            return sum;
        }
    }
}
