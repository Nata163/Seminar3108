// принимает на вход 2 числа, проверяет является ли одно квадратом второго

void Square(int num1, int num2)
{
    if (num1 == num2 * num2) Console.WriteLine("Первое число является квадратом второго");
    else if (num2 == num1 * num1) Console.WriteLine("Второе число является квадратом первого");
    else Console.WriteLine("нет");
}

Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
Square(num1,num2);