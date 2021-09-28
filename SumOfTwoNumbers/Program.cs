using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user to enter two numbers and prints out the sum of these numbers*/
            Console.WriteLine("Enter your first number: ");
            Console.WriteLine("Enter your second number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");

        }
    }
}
