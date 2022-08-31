// все целые числа в промежетке от -n до n

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int startNumber = Math.Abs(number) * -1;

while (startNumber <= number)
{
    Console.WriteLine(startNumber);
    startNumber = startNumber+1;
}