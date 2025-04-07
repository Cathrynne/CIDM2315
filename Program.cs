using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating customer objects
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        Console.WriteLine("Customer Report\n");

        TotalCredits(customer_list);
        Console.WriteLine();

        AmarilloAverageAge(customer_list);
        Console.WriteLine();

        CanyonAge(customer_list);

        Console.WriteLine("\nEnd of report.");
    }

    // Q1: Calculate and print total credit
    public static void TotalCredits(Customer[] customer_list)
    {
        double total = 0;

        foreach (Customer c in customer_list)
        {
            total += c.customerCredit;
        }

        Console.WriteLine("Total credit of all customers: $" + total.ToString("F2"));
    }

    // Q2: Calculate and print average age of Amarillo customers
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int totalAge = 0;
        int count = 0;

        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Amarillo")
            {
                totalAge += c.customerAge;
                count++;
            }
        }

        if (count > 0)
        {
            double average = (double)totalAge / count;
            Console.WriteLine("Average age of Amarillo customers: " + average.ToString("F1") + " years");
        }
        else
        {
            Console.WriteLine("No customers found in Amarillo.");
        }
    }

    // Q3: Print names of Canyon customers over age 30
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Customers in Canyon over 30 years old:");

        bool found = false;
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Canyon" && c.customerAge > 30)
            {
                Console.WriteLine("- " + c.customerName + " (" + c.customerAge + " years old)");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No Canyon customers over 30 found.");
        }
    }
}

// Q0: Customer class
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
