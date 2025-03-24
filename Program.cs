// Homework7.cs
using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating customers...\n");

            // Create two customers
            Customer customer1 = new Customer(110, "Alice", 28);
            Customer customer2 = new Customer(111, "Bob", 30);

            Console.WriteLine("Initial customer info:");
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            Console.WriteLine("\nUpdating customer IDs...\n");

            // Update their IDs
            customer1.ChangeID(220);
            customer2.ChangeID(221);

            Console.WriteLine("Updated customer info:");
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            Console.WriteLine("\nComparing ages...");
            customer1.CompareAge(customer2);

            Console.WriteLine("\nDone.");
        }
    }

    class Customer
    {
        private int cus_id;
        public string cus_name;
        public int cus_age;

        // Constructor
        public Customer(int id, string name, int age)
        {
            cus_id = id;
            cus_name = name;
            cus_age = age;
        }

        // Method to update the customer's ID
        public void ChangeID(int new_id)
        {
            cus_id = new_id;
        }

        // Method to display customer info
        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
        }

        // Method to compare age and print who is older
        public void CompareAge(Customer otherCustomer)
        {
            if (this.cus_age > otherCustomer.cus_age)
            {
                Console.WriteLine($"{this.cus_name} is older.");
            }
            else if (this.cus_age < otherCustomer.cus_age)
            {
                Console.WriteLine($"{otherCustomer.cus_name} is older.");
            }
            else
            {
                Console.WriteLine($"{this.cus_name} and {otherCustomer.cus_name} are the same age.");
            }
        }
    }
}
