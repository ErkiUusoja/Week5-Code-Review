using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            Console.WriteLine("Enter your number: ");

            int userNumber = Convert.ToInt32(Console.ReadLine());
            if(userNumber < 0)
            {
                Console.WriteLine("The number is negative.");
            } 
            else if(userNumber > 0)
            {
                Console.WriteLine("The number is positive.");
            }

        }
    }
}
