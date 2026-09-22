using System;

namespace Day01
{
    class InputDemo
    {
        static void Main()
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();

            Console.Write("What year were you born?");
            string birthYearText = Console.ReadLine(); // still a string 

            // Console.Redline always returns a string.
            // we must convert it before we can do arithmetic.
            int birthyear = int.Parse(birthYearText);
            int age = DateTime.Now.Year - birthyear;

            Console.WriteLine();
            Console.WriteLine($"Hello {name}. you are about {age} years old.");
        }
    }
}