using System;

namespace Day01
{
    class Program
    {
        static void Main()
        {
            Console.Write("what is your name?");
            string name = Console.ReadLine();

            Console.Write("what is the name of your city?");
            string city = Console.ReadLine();

            Console.WriteLine("which language you want to learn?");
            string language = Console.ReadLine();

            int quantity = 150;
            string status = "Available";

            string today = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine("Personal Introduction Card");
            Console.WriteLine("=========================================");
            Console.WriteLine($"| {"Quantity",-10}   |   {quantity,10} |");
            Console.WriteLine($"| {"status",  -10}   |   {status,  10} |");
            Console.WriteLine($"| {"Date",    -10}   |   {today,   10} |");
            Console.WriteLine("=========================================");
        }
    }
}