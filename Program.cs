using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1 method
            Console.WriteLine("Question 1: Find the largest number");
            int num1 = 10, num2 = 25;
            int largest = FindLargestNumber(num1, num2);
            Console.WriteLine($"Between {num1} and {num2}, the largest number is {largest}.\n");

            // Call Q2 method
            Console.WriteLine("Question 2: Print a Triangle Shape");
            int N = 5;
            string shape = "left"; // Change to "right" for a right-aligned triangle
            PrintTriangle(N, shape);
        }

        // Method to find the largest of two numbers
        static int FindLargestNumber(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Method to print a left or right-aligned triangle
        static void PrintTriangle(int N, string shape)
        {
            Console.WriteLine($"You chose N = {N} and Shape = {shape}\n");
            
            if (shape.ToLower() == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else if (shape.ToLower() == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new string(' ', N - i) + new string('*', i));
                }
            }
            else
            {
                Console.WriteLine("Oops! That shape isn't recognized. Please choose either 'left' or 'right'.");
            }
        }
    }
}
