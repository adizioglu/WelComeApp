/*
I want a C# consele application, it will welcome the user to our application 
and then it will ask first name, then it will ask last name. 
Finally, it will greet with first and last name.
*/

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our application!");

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}
