using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a=");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b=");
        float b = float.Parse(Console.ReadLine());
        float perimeter = 2 * a + 2 * b;
        Console.WriteLine($"The perimeter of the rectangle is {perimeter}");
        float frontage = a * b;
        Console.WriteLine($"The frontage of the rectangle is {frontage}");
    }
}

