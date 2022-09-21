// Задайте 2мерный массив размера m на n, каждый элемент массива находится
// по формуле A(mn)=m+n, выведите полученный массив

int[,] GetArray(int m, int n)
{
    int[,] array =  new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
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


Console.WriteLine("Введите количество сторок(M): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов(N): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array= GetArray(m,n);
PrintArray(array);
