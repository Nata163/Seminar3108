// вывод 2 чисел, определение является ли 2ое кратным первому, Если не кратно, то вывод остатка

void RemainderDiv()
{
    int number1 = new Random().Next(1,10);
    int number2 = new Random().Next(10,1000);
    int result = number2 % number1;
    Console.WriteLine($"Сгенерировано первое число {number1}");
    Console.WriteLine($"Сгенерировано второе число {number2}");
    if (result > 0) Console.WriteLine($"Остаток равен {result}");
    else Console.WriteLine("Кратно");
}

RemainderDiv();
RemainderDiv();
