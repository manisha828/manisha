using System;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Sample Console App!");

            // Ask for user's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Let's do a quick calculation.");

            // Ask for two numbers
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calculate product and division
            int product = num1 * num2;
            double division = (num2 != 0) ? (double)num1 / num2 : double.NaN;

            // Display result
            Console.WriteLine($"The product of {num1} and {num2} is: {product}");

            if (num2 != 0)
                Console.WriteLine($"The division of {num1} by {num2} is: {division}");
            else
                Console.WriteLine("Division by zero is not allowed.");

            // Wait before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
