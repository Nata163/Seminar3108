// Задайте 2мерный массив. Напишите программу, которая заменяет строки на столбцы.
// Если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillArray(int x, int y)
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
            Console.Write($"{arr[i,j]}");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowColum(int[ ,]arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i+1; j < arr.GetLength(1); j++)
        {
           int temp=0;
           temp=arr[i,j];
           arr[i,j]=arr[j,i];
           arr[j,i]=temp; 
        }   
    }  
    return arr;
}

Console.WriteLine("Задайте количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] array = FillArray(row, col);
PrintArray(array);
Console.WriteLine();
if (row==col)
{
   int[ ,] result=ChangeRowColum(array);
   PrintArray(result);
}
else Console.WriteLine("Заменить строки столбцами невозможно, т.к. количество строк и столбцов не совпадает");