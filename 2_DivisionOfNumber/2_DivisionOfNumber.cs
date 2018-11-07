using System;

class Program
{
    static void Main()
    {
        int number = 36;
        bool even = number % 35 == 0 ? true : false;
        Console.WriteLine("{0} is divisible by both 5 and 7 {1}?", number, even );
    }
}

