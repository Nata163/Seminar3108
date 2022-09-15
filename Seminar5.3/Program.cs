// Программа замена элементов массива: положительные заменить на соответствующие отрицательные и наоборот

int[] FillArray()
{
    var array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение элемента с индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

int[] ChangeArray (int[] arr)
{
for(int i=0; i<arr.Length;i++)
{
    arr[i]=arr[i]*(-1);
}
return arr;
}

var array = FillArray();
Console.WriteLine("Вывод массива: ");
PrintArray(array);
int[] newarray = ChangeArray(array);
Console.WriteLine("Вывод массива после замены:");
PrintArray(newarray);