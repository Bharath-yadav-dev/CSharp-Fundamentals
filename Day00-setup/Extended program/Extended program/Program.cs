using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your your name?");
            string name = Console.ReadLine();

            Console.Write("which programming language you want to learn");
            String language = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome to C#.");
            Console.WriteLine($"Today is {DateTime.Now:dddd, dd MMMM yyyy}.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}