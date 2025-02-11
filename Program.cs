namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Check if the number is prime
            Console.WriteLine("Enter a number for Q1:");
            int N = int.Parse(Console.ReadLine());
            CheckPrime(N);

            // Q2: Print a square pattern
            Console.WriteLine("\nEnter a number for Q2:");
            int N2 = int.Parse(Console.ReadLine());
            PrintSquarePattern(N2);

            // Q3: Print a diagonal square pattern
            Console.WriteLine("\nEnter a number for Q3:");
            int N3 = int.Parse(Console.ReadLine());
            PrintDiagonalSquarePattern(N3);

            // Bonus: Print a border square pattern
            Console.WriteLine("\nEnter a number for the Bonus question:");
            int N4 = int.Parse(Console.ReadLine());
            PrintBorderSquarePattern(N4);
        }

        // Q1: Check if N is prime
        static void CheckPrime(int N)
        {
            bool isPrime = true;

            // If N is less than or equal to 1, it's not prime
            if (N <= 1)
            {
                isPrime = false;
            }
            else
            {
                // Check divisibility from 2 to N-1
                for (int i = 2; i < N; i++)
                {
                    if (N % i == 0)
                    {
                        isPrime = false; // Found a divisor, so it's not prime
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{N} is prime");
            }
            else
            {
                Console.WriteLine($"{N} is non-prime");
            }
        }

        // Q2: Print square pattern of N rows and columns
        static void PrintSquarePattern(int N)
        {
            // Loop to create rows
            for (int i = 0; i < N; i++)
            {
                // Loop to create columns in each row
                for (int j = 0; j < N; j++)
                {
                    Console.Write("* ");
                }
                // Move to the next line after a row is printed
                Console.WriteLine();
            }
        }

        // Q3: Print diagonal square pattern (stars along the diagonal)
        static void PrintDiagonalSquarePattern(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Print star only if it's on the diagonal (where row == column)
                    if (i == j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  "); // Print space for non-diagonal cells
                    }
                }
                Console.WriteLine();
            }
        }

        // Bonus: Print border square pattern (stars along the border)
        static void PrintBorderSquarePattern(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Print star if we're on the border (first/last row or first/last column)
                    if (i == 0 || i == N - 1 || j == 0 || j == N - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  "); // Print space for the inner cells
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
