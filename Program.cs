namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given values
            double X = 2.5;
            double Y = 3.3;

            // Calculate Z based on the linear equation Z = 4*X*X + 3*Y
            double Z = 4 * X * X + 3 * Y;

            // Print the result in the desired format
            Console.WriteLine($"The value of Z when X = {X} and Y = {Y} is: {Z:F2}");
        }
    }
}
