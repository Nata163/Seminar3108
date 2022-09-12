// программа, которая принимает на вход число и выдает количество цифр в числе

int GetCountDigit(int number)
{
    //количество цифр в числе
    int countDigit = 0;

    //временная переменная для хранения входного значения
    int tempNumber =  Math.Abs(number);

    //Подсчет цифр в входном числе
    while(tempNumber!=0)
    {
        //избавление от правой крайней цифры
        tempNumber = tempNumber/10;

        // увеличение счетчика на 1
        countDigit++;
    }
    //возврат результата
return countDigit;
}

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());

int countDigit = GetCountDigit(x);
Console.WriteLine($"Количество цифр в числе {x}: {countDigit}");

