// программа, кот принимает на вход A и B. И возводит a в степень b.
int GetPower(int a, int b)
{
    if (b == 1)
    {
        return a;
    }

    int power = a * GetPower(a , b-1);
    return power;
}
Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());

int res = GetPower(a,b);
Console.WriteLine(res);