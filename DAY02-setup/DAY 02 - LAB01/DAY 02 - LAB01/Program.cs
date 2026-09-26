using System;
class Program
{
    static void Main()
    {
        Console.WriteLine($"{"Type",-10} {"MinValue",-25} {"MaxValue",-25} {"Size (bytes)",-15}");
        Console.WriteLine(new string('-', 80));

        Console.WriteLine($"{"byte",-10} {byte.MinValue,-25} {byte.MaxValue,-25} {sizeof(byte),-15}");
        Console.WriteLine($"{"short",-10} {short.MinValue,-25} {short.MaxValue,-25} {sizeof(short),-15}");
        Console.WriteLine($"{"int",-10} {int.MinValue,-25} {int.MaxValue,-25} {sizeof(int),-15}");
        Console.WriteLine($"{"long",-10} {long.MinValue,-25} {int.MaxValue,-25} {sizeof(long),-15}");
        Console.WriteLine($"{"float",-10} {float.MinValue,-25} {float.MaxValue,-25} {sizeof(float),-15}");
        Console.WriteLine($"{"double",-10} {double.MinValue,-25} {double.MaxValue,-25} {sizeof(double),-15}");
        Console.WriteLine($"{"decimal",-10} {decimal.MinValue,-25} {decimal.MaxValue,-25} {sizeof(decimal),-15}");
    }
}

class OverflowDemo
{
   
    public static void Run()
    {
        int x = int.MaxValue;
        Console.WriteLine($"Before overflow: {x}");

        x = x + 1;
        Console.WriteLine($"After overflow: {x}");
        //Explanation: int.MaxValue is 2,147,483,647. Adding 1 wraps around to int.MinValue (-2,147,483,648).
        // This is called *overflow*. By default, C# does not throw an error.


    }
}

class CheckedDemo
{
    public static void Run()
    {
        try
        {
            checked
            {
                int y = int.MaxValue;
                y = y + 1;  // This will throw OverflowEXception 
                Console.WriteLine(y);

            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow detected: "+ ex.Message);
        }
    }
}