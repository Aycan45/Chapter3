using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x:");
        byte x = byte.Parse(Console.ReadLine());
        Console.Write("Enter y:");
        byte y = byte.Parse(Console.ReadLine());
        bool isInCircle = (x * x + y * y <= 5) ? true : false;
        Console.WriteLine($"The point O ({x};{y}) is in K(0;0)?: {isInCircle}");
    }
}

