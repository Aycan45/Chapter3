using System;

class Program
{
    static void Main()
    {
        double a = 4;
        Console.WriteLine($"a={a}");
        double b = 9;
        Console.WriteLine($"b={b}");
        double h = 4;
        Console.WriteLine($"h={h}");
        double formula = (a + b) *h/ 2;
        Console.WriteLine($"The result is {formula}");
    }
}
