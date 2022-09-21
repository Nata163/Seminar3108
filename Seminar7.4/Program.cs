// Задайте 2мерный массив. Найдите сумму элементов, находящихся на главной диагонали

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

int GetSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + arr[i, j];
            }
        }
    }
    return sum;
}


Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
int result = GetSum(array);
Console.WriteLine($"Сумма элементов главной диагонали равна {result}");
