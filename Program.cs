using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Question 1: Find the Largest of Two Numbers ---
            Console.WriteLine("Welcome to Homework5!");
            Console.WriteLine("Let's start with Question 1: Finding the largest of two numbers.");
            int largestOfTwo = Q1_method();
            Console.WriteLine($"Great! The largest number you entered is: {largestOfTwo}");
            Console.WriteLine();

            // --- Question 2: Find the Largest of Four Numbers using Q1_method ---
            Console.WriteLine("Now, onto Question 2: Finding the largest among four numbers.");
            int largestOfFour = Q2_method();
            Console.WriteLine($"Awesome! The largest number among your four entries is: {largestOfFour}");
            Console.WriteLine();

            // --- Question 3: Create an Account ---
            Console.WriteLine("Finally, let's create an account. Please follow the instructions below:");
            createAccount();

            // End of Homework5 demonstration.
            Console.WriteLine("Thank you for using Homework5! Have a great day!");
        }

        // Q1_method: Reads two integers from the keyboard and returns the larger one.
        static int Q1_method()
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Compare the two numbers using a helper method.
            return GetMax(num1, num2);
        }

        // Helper method to compare two integers and return the larger.
        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Q2_method: Reads four integers from the keyboard and returns the largest one.
        // It uses the GetMax method (from Q1) to make the comparisons.
        static int Q2_method()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            int d = int.Parse(Console.ReadLine());

            // First, get the max of the first pair and the second pair.
            int maxPair1 = GetMax(a, b);
            int maxPair2 = GetMax(c, d);

            // Then, compare the two results to get the overall largest.
            return GetMax(maxPair1, maxPair2);
        }

        // checkAge: Determines if the user is at least 18 years old based on their birth year.
        static bool checkAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age >= 18;
        }

        // createAccount: Guides the user through creating an account.
        // It asks for username, password (twice), and birth year, then checks if the user is old enough
        // and if the passwords match before confirming account creation.
        static void createAccount()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Console.Write("Please re-enter your password: ");
            string confirmPassword = Console.ReadLine();

            Console.Write("Enter your birth year (e.g., 1995): ");
            int birthYear = int.Parse(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password == confirmPassword)
                {
                    Console.WriteLine("Congratulations! Your account has been created successfully.");
                }
                else
                {
                    Console.WriteLine("Oops! The passwords did not match. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you must be at least 18 years old to create an account.");
            }
        }
    }
}
