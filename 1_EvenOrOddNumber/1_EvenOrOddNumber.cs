using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = 6;
        bool result = a % 2 == 0 ? true : false ;
        Console.WriteLine($"The result is {result}");
    }
}

