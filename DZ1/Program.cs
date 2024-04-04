using System;

class Program
{
    static void Main()
    {
        int m = 1;
        int n = 10;
        Console.WriteLine("Все натуральные числа в промежутке от " + m + " до " + n + ":");
        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m > n)
        {
            return;
        }
        Console.Write(m + " ");
        PrintNumbers(m + 1, n);
    }
}