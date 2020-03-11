using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] someMatrix = RequestMatrix();
            
            Console.WriteLine("Given your matrix The sums of each row are:");
            int[] result = SumMatrix(someMatrix);
            foreach (int n in result)
                Console.Write($" {n} ");
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
        static int[,] RequestMatrix()
        {
            Console.WriteLine("A matrix is a rectangular set of numbers. Basically, a list of lists of equal length. Let's make one!");
            Console.WriteLine("How many Rows?");
            int rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many Columns?");
            int cols = Int32.Parse(Console.ReadLine());

            int[,] result = new int[rows, cols];
            Console.WriteLine($"You have an empty Matrix, {rows} by {cols}");
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    string input;
                    int output;
                    do
                    {
                        Console.WriteLine($"Row {r + 1}, Column {c + 1} Please fill in a number");
                        input = Console.ReadLine();
                    } while (!Int32.TryParse(input, out output));

                    result[r, c] = output;
                }
            
            return result;
        }
    }
}
