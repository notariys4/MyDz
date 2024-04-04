using System;

class Program
{
    static void Main()
    {
        int m = 3;
        int n = 2;
        Console.WriteLine("Функция Аккермана для m = " + m + " и n = " + n + " равняется: " + Ackermann(m, n));
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}