using System;

namespace Day02
{
    class ConversionDemo
    {
        static void Main()
        {
            //1.IMPLICIT - NO DATA CAN BE LOST, compiler does it silently
            int small = 42;
            long big = small;
            double dbl = small;
            Console.WriteLine($"implicit: {big}, {dbl}");

            // 2. EXPLICIT (CAST) - YOU ACCEPT THE LOSS 
            double price = 3.99;
            int whole = (int)price;      // 3  -- truncates, does not round 
            byte wrapped = (byte)255;    // 44-- wraps around silently
            Console.WriteLine($"explicit: {whole},{wrapped}");

            //rounding is a different operation 
            Console.WriteLine($"rounded: {Math.Round(price)}");        //4
            Console.WriteLine($"convert: {Convert.ToInt32(price)}");   //4

            //3.STRING to NUMBER
            string good = "123";
            string bad = "abc";

            Console.WriteLine(int.Parse(good));      //123


            // Console.WriteLine(int.Parse(bad));    //FormatExceptional
            if (int.TryParse(bad, out int parsed))
                Console.WriteLine($"parsed {parsed}");
            else
                Console.WriteLine("'abc' is not a number - handled, no crash.");

            // 4.ANYTHING to STRING 
            int n = 7;
            string text = n.ToString();
            Console.WriteLine($"as text: '{text}' has length {text.Length}");


            // 5. The floating-point trap 
            Console.WriteLine(0.1 + 0.2 == 0.3);   //False (double)
            Console.WriteLine(0.1m + 0.2m == 0.3m);  // True  (decimal)
        }
    }
}






       


    
            
            
            
            
            
            
            
           