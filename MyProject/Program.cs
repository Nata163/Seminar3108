// квадрат числа

//определение входного числа
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

//получение квадрата входного числа
int result = number * number;

//вывод результата
Console.WriteLine($"Квадрат числа {number} = {result}");

int result_2= Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {result_2}");