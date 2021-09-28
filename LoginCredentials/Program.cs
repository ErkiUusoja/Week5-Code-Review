using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            string login;
            string Password;
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if (login == "admin" && Password == "pass1234")
            {
                Console.WriteLine("Welcome!");
            }
            else if ((login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("The password is incorrect");
            }
            else if ((login != "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("The login is incorrect");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
