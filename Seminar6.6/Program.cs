// программа, кот создает копию заданного массива с помощью поэдементного копирования

void CopyArrey(int[] arr, int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = arr[i];
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] array = new int[] { 1, 2, 3, 4, 5, 5, 7 };
int[] arrayForCopy = new int[] { 0, 0, 0, 0, 0, 0, 0 };

CopyArrey(array, arrayForCopy);
PrintArray(arrayForCopy);