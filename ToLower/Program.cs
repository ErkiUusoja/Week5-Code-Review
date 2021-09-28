using System;

namespace ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program asks the user to write a word in Uppercase and displays this input in lowercase*/
            Console.WriteLine("Enter an uppercase word: ");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine(userInput);            
        }
    }
}
