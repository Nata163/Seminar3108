// Задайте 2мерный массив. Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты


int[,] GetArray(int x, int y)
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
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
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GetArrayChange(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && j != 0 && i != 0)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
    return arr;
}


Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
int[,] newarray = GetArrayChange(array);
PrintArray(newarray);

