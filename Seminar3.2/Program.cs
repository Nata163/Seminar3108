// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Определение четверти точки
int GetPointArea(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return 0;
}
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

int areaNum = GetPointArea(x, y);
Console.WriteLine($"Area = {areaNum}");