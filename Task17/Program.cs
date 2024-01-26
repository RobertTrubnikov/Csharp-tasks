// Напишите программу, которая принимает
// на вход координаты точки (Х и Y)
// причем X =/ 0 и Y =/ 0 
// и выдает номер четверти плоскости, в которой находится эта точка


int Quater(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoorinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());



int quater = Quater(xCoorinate, yCoordinate);

string result = quater > 0 ? $"Указанные координаты соответствуют четверти {quater}" : "Введены некорректные координаты";
Console.WriteLine(result);