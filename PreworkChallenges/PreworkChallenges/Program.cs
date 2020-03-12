using System;
using System.Linq;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harry's MAGICAL Code Projects!\n \tpress any key...");
            Console.ReadKey();
            MainMenu();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select a challenge: \n " +
                "1) Array Max Result\n " +
                "2) Leap Year Calculator\n " +
                "3) Perfect Sequence\n " + 
                "4) Sum of Rows\n" +
                "X - exit Program");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
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
                // ----- PROJECT 4: Sum of Rows -----
                case "4":
                    Project4();
                    break;
                // --- exit ---
                case "x":
                    break;
                // --- reload ---
                default:
                    MainMenu();
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

            Console.ReadLine();
            MainMenu();

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

            Console.ReadLine();
            MainMenu();
        }
        static void Project3()
        {
            // request integer sequence
            Console.WriteLine("Please input a sequence of numbers to check:");
            int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));

            // determine if input is a perfect sequence
            Console.WriteLine(IsPerfectSequence(input) ? "It's a Perfect Sequence!" : "Hmm... well, It's not perfect...");

            Console.ReadLine();
            MainMenu();

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
        static void Project4()
        {
            int[,] someMatrix = RequestMatrix();

            ShowMatrix(someMatrix);

            Console.WriteLine("\nIn your matrix The sums of each row are:");
            int[] result = SumMatrix(someMatrix);
            foreach (int n in result)
                Console.Write($" {n} ");

            Console.ReadLine();
            MainMenu();

            static int[] SumMatrix(int[,] matrix)
            {
                int[] sum = new int[matrix.GetLength(0)];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int indexSum = 0;
                    for (int n = 0; n < matrix.GetLength(1); n++)
                        indexSum += matrix[i, n];
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
            static void ShowMatrix(int[,] matrix)
            {
                Console.Clear();
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    Console.WriteLine(" ");
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        Console.Write($"[{matrix[r, c]}] ");
                    }
                }
            }
        }
    }
}

