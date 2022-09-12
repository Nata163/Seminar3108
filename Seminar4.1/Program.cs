﻿// программа, которая принимает на вход число A и выдает на выход сумму от 1 до А

int GetSum(int number)
{
    int sum = 0;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            sum = sum + i;
        }
    }
    if (number < 0)
    {
        for (int i = 1; i >= number; i--)
        {
            sum = sum + i;
        }
    }
    return sum;
}

Console.WriteLine("Введите число: ");

try
{  
  int a = int.Parse(Console.ReadLine());

  int sum = GetSum(a);
  Console.WriteLine(sum);
}
catch(Exception ex)
{
  Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
