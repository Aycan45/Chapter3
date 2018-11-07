using System;

class Program
{
    static void Main()
    {
        int n = 35, p = 6, i = 1, mask = i << p;
        Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");
    }
}

