// не используя рекурсию, выведите первые n чисел Фибоначчи

int[] Fibonacci(int num)
{
    int[] result = new int[num];
    for (int i = 0; i < result.Length; i++)
    {
        if (i == 0)
        {
            result[i] = 0;
        }
        else if (i == 1)
        {
            result[i] = 1;
        }
        else result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

Console.WriteLine("До какого чиссла нужна последовательность Фибоначи:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Последовательность Фибоначи:");
int[] fibanacci = Fibonacci(number);
PrintArray(fibanacci);

