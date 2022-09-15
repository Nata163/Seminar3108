// Задать массив из 123 случ чисел. Найти количетво элементов в отрезке [10,99]

int[] FillArray()
{
    int[] array = new int[123];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 124);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

int CountArray (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = FillArray();
PrintArray(array);
Console.WriteLine(" ");
int result = CountArray(array);
Console.WriteLine($"В массиве значения {result} элементов лежат в промежутке от 10 до 99");

