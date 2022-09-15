// задайте массив. Напишите программу, котора определяет присутствует ли  данное число в массиве.

bool CheckNumber(int number, int[] array)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
        else result = false;
    }
    return result;
}

int[] arr = new int[] { 6, 7, 19, 345, 3 };

Console.WriteLine("Введите число. которое нужно проверить: ");
int num = int.Parse(Console.ReadLine());

bool result= CheckNumber(num, arr);
Console.WriteLine(result);



