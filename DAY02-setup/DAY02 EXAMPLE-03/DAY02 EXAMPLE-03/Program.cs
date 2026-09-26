using System;

namespace Day02
{
    class SafeInput
    {
        static void Main()
        {
            int age;
            while (true)
            {
                Console.WriteLine("Enter your age (1-120):");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out age))
                {
                    Console.WriteLine(" That is not a whole number. Try again.");
                    continue;
                }
                if (age < 1 || age > 120)
                {
                    Console.WriteLine(" Out of range.Try again.");
                    continue;
                }
                break;   // valid - leave the loop

            }
            Console.WriteLine($"Thank you. Age recorded as {age}.");
        }
    }
}