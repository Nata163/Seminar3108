// вывод 2 чисел, определение является ли 2ое кратным первому, Если не кратно, то вывод остатка

void RemainderDiv(int number1, int number2)
{
    int result = number2 % number1;
    if (result == 0) Console.WriteLine("Кратно");
    else Console.WriteLine($"Остаток равен {result}");
}

Console.Write("Введите первое число ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число ");
    int number2 = int.Parse(Console.ReadLine());

RemainderDiv(number1, number2);
Console.WriteLine();

