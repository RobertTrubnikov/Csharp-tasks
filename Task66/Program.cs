// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbers(m, n);
        Console.WriteLine("Сумма натуральных элементов в интервале от {0} до {1}: {2}", m, n, sum);
    }

    static int SumNaturalNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + SumNaturalNumbers(m + 1, n);
        }
    }
}