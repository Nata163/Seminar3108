//является ли первое число квадратом второго int number = int.Parse(Console.ReadLine())

//вводим числа
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(number2, 2));
//проверяем равенство и выводим результат
if ( result == number1 )
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}