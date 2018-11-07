using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y:");
        int y = int.Parse(Console.ReadLine());
        bool isInCircle = (x * x + y * y <= 5) ? true : false;
        Console.WriteLine($"The point O ({x};{y}) is in K(0;0)?: {isInCircle}");
        bool isOutsideRec= (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
        Console.WriteLine($"The point 0 ({x};{y}) is outside rectangle ((-1, 1), (5, 5)?: {isOutsideRec}");
    }
}

