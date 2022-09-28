// Задайте M и N.Напишите программу, кот выведет все натуральные числа в промежутке от M до N.

int GetSum(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    int sum = n + GetSum(m,n - 1);
    return sum;
}

string ShowAllNumbers(int m, int n)
{
    if (n == m)
    {
        return $"{m}" ;
    }
    string result = ShowAllNumbers(m,n - 1) + " " + n;
    return result;
}

Console.WriteLine("Введите число - начало промежутка:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число - конец промежутка:");
int n = int.Parse(Console.ReadLine());

int sumNumbers = GetSum(m, n);
Console.WriteLine(sumNumbers);
string res = ShowAllNumbers(m, n);
Console.WriteLine(res);
