// Напишите программу, которая будет принимать на вход
// два числоа и вывводить, является ли первое число кратным
// второму. Если перввое число не кратно второму, то программа вывводит остаток деления.






Console.Write("Введите перовое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Remainder(int firstPar, int secondPar)
{
    return firstPar % secondPar;
}

int remainder = Remainder(firstNumber, secondNumber);
if (remainder == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {remainder}");