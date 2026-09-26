using System;
class BulletProofUnitConverter
{
    static void Main()
    {
        Console.WriteLine("=== Bulletproof unit converter ===");

        // 1. Temperature input (Celsius -> Fahrenheit, Kelvin)
        double celsius = SafeReadDouble("Enter temperature in Celsius: ");
        double fahrenheit = (celsius * 9 / 5) + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"Celsius: {celsius} °C");
        Console.WriteLine($"Fahrenheit: {fahrenheit} °F");
        Console.WriteLine($"Kelvin: {kelvin} K");

        //2. Distance input (Kilometres -> Miles, Meters)
        double kilometres = SafeReadPositiveDouble("Enter distance in kilometres: ");
        double miles = kilometres * 0.621371;
        double metres = kilometres * 1000;


        Console.WriteLine($"kilometres: {kilometres} km");
        Console.WriteLine($"miles: {miles} mi");
        Console.WriteLine($"metres: {metres} m");

    }

    //Safe input pattern: keeps asking until valid double
    static double SafeReadDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out value))
                return value;
            Console.WriteLine("Invalid input.please enter a valid number.");
        }
    }

    //Safe input for positive doubles (e.g., distance)
    static double SafeReadPositiveDouble(string prompt)
    {
        double value;
        while(true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ; 

            if (double.TryParse(input, out value) && value >=0)
                return value;

            Console.WriteLine("Invalid input. Please enter a non-negative number.");

        }
    }

}
