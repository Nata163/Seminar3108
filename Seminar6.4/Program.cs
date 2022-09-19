// программа, кот преобразовывает числа из деситичных в двоичное

string GetBinary(string num)
{
    string res = String.Empty;
    int i = int.Parse(num);
    while (i > 0)
    {
        int temp = i % 2;
        res = temp + res;
        i = i / 2;
    }
    return res;
}

Console.WriteLine("Введите число:");
string number = Console.ReadLine();

string result = GetBinary(number);
Console.WriteLine(result);

