// Напишите программу, которая приниамет на вход
// трехзначное число и на выходе показывает последнюю цифру
// этого числа


Console.WriteLine("Введите трехзначное целое цисло");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
    int LastDigit = number%10;
    Console.WriteLine($"Последняя цифра числа: {LastDigit}");
}