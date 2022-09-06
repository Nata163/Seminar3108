// принимает на вход число и проверяет кратноли оно 7 и 23

void Div(int number1)
{
    if (number1 % 7 ==0 & number1 % 23 == 0) Console.WriteLine("да");
    else Console.WriteLine("нет");
}

Console.WriteLine("Введите число ");
int number1 = int.Parse(Console.ReadLine());
Div(number1);
