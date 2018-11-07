using System;

class Program
{
    static void Main()
    {
        int number = 45764;
        bool isSeven = (number / 100) % 10 == 7 ? true : false;
        Console.WriteLine("Third digit of {0} is 7 {1}", number, isSeven);
    }
}

