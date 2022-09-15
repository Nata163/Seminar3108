// // Задайте массив из 12 элементов, заполненный случайными числами из промежитка [-9,9].
//Найдите сумму отрицательных и положительных элементов массива.
// 2 вариант решения

int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);
    }
    return array;
}

int GetSumPositivNumbers(int[] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int GetSumNegativNumbers(int[] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

var array = GetArray(12, -9, 9);
var sumPositiv = GetSumPositivNumbers(array);
var sumNegativ = GetSumNegativNumbers(array);

Console.WriteLine($"Сумма положительных чисел: {sumPositiv}" + $" Сумма отрицательных чисел: {sumNegativ}");
