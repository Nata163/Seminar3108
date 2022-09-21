// Задайте двухмерный массив размером m*n? заполненный случайными числами

int n = 0;
int m = 0;

Console.WriteLine("Введите число строк(N): ");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int number);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата(N)");
    return;
}
else
{
    n = number;
}

Console.WriteLine("Введите число столбцов(M): ");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int number1);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата(M)");
    return;
}
else
{
    m = number1;
}

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}