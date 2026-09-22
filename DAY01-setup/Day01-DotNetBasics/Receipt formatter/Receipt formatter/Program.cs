using System;
 
namespace Day01
{
    class Program
    {
        static void Main()
        {
            //step-1 hard code 3 items
            string item1 = "Apples";
            int qty1 = 7;
            decimal price1 = 50.00m;

            string item2 = "Milk";
            int qty2 = 3;
            decimal price2 = 25.50m;

            string item3 = "Eggs";
            int qty3 = 12;
            decimal price3 = 84.75m;


            //step-2 CAlculate totals
            decimal subtotal = (qty1 * price1) + (qty2 * price2) + (qty3 * price3);
            decimal gst = subtotal * 0.18m;
            decimal grandtotal = subtotal + gst;

            //step-3 print receipt
            Console.WriteLine("================Receipt===============");
            Console.WriteLine($"{item1,-10} x{(qty1 * price1),10:C}");
            Console.WriteLine($"{item2,-10} x{(qty2 * price2),10:C}");
            Console.WriteLine($"{item3,-10} x{(qty3 * price3),10:C}");
            Console.WriteLine("======================================");
            Console.WriteLine($"{"Subtotal",-15}  {subtotal,10:C}");
            Console.WriteLine($"{"GST (18%)",-15}  {gst,10:C}");
            Console.WriteLine($"{"Grand Total",-15} {grandtotal,10:c}");
            Console.WriteLine("======================================");
        }
    }
}
