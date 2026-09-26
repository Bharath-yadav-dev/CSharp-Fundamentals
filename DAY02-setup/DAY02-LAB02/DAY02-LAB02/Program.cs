using System;

class Program
{
    static void Main()
    {

        // CASE 1 : int(VALUE TYPE)
        int a = 5;
        int b = a;
        b = 10;
        Console.WriteLine($"a = {a}, b = {b}");

        //CASE 2 : string( REFERENCE TYPE but immutable)
        string s1 = "hello";
        string s2 = s1;
        s2 = "world";
        Console.WriteLine($"s1 = {s1}, s2 = {s2}");

        // CASE 3 : class (refrence type but Mutable)
        Person p1 = new Person { Name = "Alice" };
        Person p2 = p1;
        p2.Name = "Bob";
        Console.WriteLine($"p1.Name = {p1.Name},p2.Name = {p2.Name}");

        // case4 : array of int ( reference type, holds value type)
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        arr2[0] = 90;
        Console.WriteLine($"arr1[0] = {arr1[0]},arr2[0] = {arr2[0]}");

    }

}

class Person
{
    public string Name { get; set; }    
}