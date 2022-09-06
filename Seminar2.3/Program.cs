// вывод случайного 3хзначного числа и удаление 2ой цифры

void DeleteSecDigital()
{
    int x = new Random().Next(100, 1000);
    int x1 = x / 100;
    int x3 = x % 10;
    int y = x3 + x1*10;
    Console.WriteLine($"сгенерировано случайное число {x}");
    Console.WriteLine(y);
}
DeleteSecDigital();
DeleteSecDigital();