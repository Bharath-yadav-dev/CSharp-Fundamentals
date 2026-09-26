using System;

namespace Day02
{
    struct PointStruct { public int X; public int Y; }  //value type
    class PointClass { public int X; public int Y; }   // REFERENCE type

    class CopyDemo
    {
        static void Main()
        {
            // ---- value type: independent copies ----
            PointStruct a = new PointStruct { X = 1, Y = 2 };
            PointStruct b = a;     // the DATA is copied
            b.X = 99;

            Console.WriteLine($"struct  a.X = {a.X}   b.X = {b.X}");
            //a.X =1 b.X = 99   -> untouched

            //----- reference type: one shared object ----
            PointClass c = new PointClass { X = 1, Y = 1 };
            PointClass d = c;   // only the REFERENCE is copied 
            d.X = 99;



             Console.WriteLine($"class   c.X = {c.X}   d.X = {d.X}");
            // c.X = 99     d.X = 99  -> same object!

            // ---- string looks like a value type, because it is immutable -----
            string s1 = "hello";
            string s2 = s1;
            s2 = s2.ToUpper();     // creates a NEW string; s1 is unaffected

            Console.WriteLine($"string  s1 = {s1}   s2 = {s2}");
            // s1 = hello  s2 HELLO
        }
    }
}
