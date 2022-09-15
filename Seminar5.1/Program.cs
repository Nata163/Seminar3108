// Задайте массив из 12 элементов, заполненный случайными числами из промежитка [-9,9].
//Найдите сумму отрицательных и положительных элементов массива.

int[] FillArrey()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int SumPositivNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int SumNegativNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] myArray = FillArrey();
Console.WriteLine("Вывод массива: ");
PrintArray(myArray);
int sum1 = SumPositivNumbers(myArray);
Console.WriteLine($"Сумма положительных чисел в массиве равна {sum1}");
int sum2 = SumNegativNumbers(myArray);
Console.WriteLine($"Сумма отрицательных чисел в массива равна {sum2}");