// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.


int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должден быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основанрие: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}