using System;

namespace Day01
{
    class OutputDemo
    {
        static void Main()
        {
            Console.WriteLine("Plain texton its own linw.");
            Console.Write("No newline here. ");
            Console.WriteLine("so this continues the same line.");

            //Esacpe sequences
            Console.WriteLine("Tab\tseparated\tcolumns");
            Console.WriteLine("A \"quoted\"word");
            Console.WriteLine("C:\\Users\\Public\\file.txt");
            Console.WriteLine("Line one\nLine two");

            //Verbatim string -@turns OFF escape processing 
            Console.WriteLine(@"C:\Userss|Public|file.text");

            //interpolation - the modern way to build text 
            string name = "Asha";
            int age = 22;
            Console.WriteLine($"{name} is {age} years old.");
            Console.WriteLine($"Next year she will be {age + 1}.");

            //format specifiers inside interpolation
            decimal salary = 47500.5m;
            Console.WriteLine($"Salary: {salary:C}");  //currency
            Console.WriteLine($"Salary: {salary:N2}");  //2 decimal places 
            Console.WriteLine($"Today: {DateTime.Now:dd-MMM-yyyy}");
            Console.WriteLine($"Padded: |{name,10}|");   //right-aligned in 10 chars
            Console.WriteLine($"Padded: |{name,-10}|");  //left-align in 10 chars
        }
    }

}