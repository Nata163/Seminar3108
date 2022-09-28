// Программа принимает число и выводит сумму цифр в числе

int GetSumDitgit(int n)
{
    if (n < 10)
    {
        return n;
    }

    int sum = n % 10 + GetSumDitgit(n / 10);
    return sum;
}
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int res = GetSumDitgit(num);
Console.WriteLine(res);