// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Результат: ");
        PrintNumbers(N);
    }

    static void PrintNumbers(int N)
    {
        if (N == 1)
        {
            Console.Write("1");
        }
        else
        {
            Console.Write($"{N}, ");
            PrintNumbers(N - 1);
        }
    }
}