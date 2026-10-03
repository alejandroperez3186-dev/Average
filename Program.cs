using System;
using System.Runtime.InteropServices;

namespace Integers

{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0;
            int num2 = 0;


            // Grabs the first number from the user

            Console.WriteLine("Enter the first number: ");

            // Checks if the input is a valid integer

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer: ");
            }

            // Grabs the second number from the user

            Console.WriteLine("Enter the second number: ");

            // Checks if the input is a valid integer

            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer: ");
            }
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"The first number ({num1}) is greater than the second number ({num2}).");
            }
            else
            {
                Console.WriteLine($"The second number ({num2}) is greater than the first number ({num1}).");
            }

            // This equation calculates the average of the two numbers and displays it to the user

            int equation = (num1 + num2) / 2;

            Console.WriteLine($"The equation result is: {equation}");


        }
    }
}
