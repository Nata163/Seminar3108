// Задайте 2мерный массив, напишите программу, которая поменяет местами первую и посл строку массива

int[,] GetArray(int x, int y)
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] ChangeFirstAndLastRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0)
            {
                int temp = 0;
                temp = arr[i, j];
                arr[i, j] = arr[arr.GetLength(0) - 1, j];
                arr[arr.GetLength(0) - 1, j] = temp;

            }
        }
    }
    return arr;
}

Console.WriteLine("Введите число строк:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int col = int.Parse(Console.ReadLine());

int[,] array = GetArray(row, col);
PrintArray(array);
Console.WriteLine();
int[,] result = ChangeFirstAndLastRow(array);
PrintArray(result);