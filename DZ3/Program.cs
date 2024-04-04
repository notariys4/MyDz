﻿using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        Console.WriteLine("\nМассив в обратном порядке:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }
}