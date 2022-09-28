// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до Т.

string GetAllDigits(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string result = GetAllDigits(n - 1) + " " + n;
    return result;
}

int GetSumNumbers(int n)
{
    if (n == 0)
    {
        return 0;
    }
    int sum = n + GetSumNumbers(n - 1);
    return sum;
}

Console.WriteLine("Введите число:");
int n=int.Parse(Console.ReadLine());

string res= GetAllDigits(n);
Console.WriteLine($"{res}");

int sum=GetSumNumbers(n);
Console.WriteLine($"{sum}");
