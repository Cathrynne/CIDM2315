namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Converting Letter Grade to GPA
            Console.WriteLine("Enter a letter grade (A, B, C, D, F): ");
            string grade = Console.ReadLine(); // Get the user's grade input

            // Check if the user didn't enter anything
            if (string.IsNullOrEmpty(grade))
            {
                Console.WriteLine("Oops! You didn't enter a grade.");
            }
            else
            {
                grade = grade.ToUpper(); // Make sure the input is in uppercase

                // Now, check what grade they entered and show the corresponding GPA
                if (grade == "A")
                {
                    Console.WriteLine("GPA: 4");
                }
                else if (grade == "B")
                {
                    Console.WriteLine("GPA: 3");
                }
                else if (grade == "C")
                {
                    Console.WriteLine("GPA: 2");
                }
                else if (grade == "D")
                {
                    Console.WriteLine("GPA: 1");
                }
                else if (grade == "F")
                {
                    Console.WriteLine("GPA: 0");
                }
                else
                {
                    // If the user enters a grade that's not A, B, C, D, or F
                    Console.WriteLine("Hmm, that's not a valid grade. Please use A, B, C, D, or F.");
                }
            }

            // Q2: Finding the Smallest Number
            Console.WriteLine("\nLet's find the smallest number. Please enter three numbers:");

            int num1, num2, num3;

            // Get the first number and make sure it's valid
            Console.Write("Enter the first number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Whoops! That doesn't seem like a number. Try again.");
                Console.Write("Enter the first number: ");
            }

            // Get the second number with validation
            Console.Write("Enter the second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Oops, that wasn't a number. Give it another go.");
                Console.Write("Enter the second number: ");
            }

            // Get the third number with validation
            Console.Write("Enter the third number: ");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Hmm, that isn't a number. Please enter a valid one.");
                Console.Write("Enter the third number: ");
            }

            // Find the smallest number by comparing the inputs
            int smallest = num1; // Assume the first number is the smallest for now

            if (num2 < smallest)
            {
                smallest = num2; // If the second number is smaller, make it the smallest
            }

            if (num3 < smallest)
            {
                smallest = num3; // If the third number is smaller, make it the smallest
            }

            // Show the smallest number
            Console.WriteLine($"The smallest number is: {smallest}");

            // Bonus: Checking if a Year is a Leap Year
            Console.WriteLine("\nNow, let's check if a year is a leap year. Enter a year:");

            int year;

            // Ensure the user enters a valid year
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("That doesn't look like a valid year. Try again.");
                Console.Write("Enter a year: ");
            }

            // Check if the year is a leap year based on the rules
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                // If the year is divisible by 4 but not 100, or divisible by 400, it's a leap year
                Console.WriteLine($"{year} is a leap year!");
            }
            else
            {
                // Otherwise, it's not a leap year
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
