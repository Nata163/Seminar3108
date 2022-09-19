// переворот одномерного массива

int[] GetReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for(int i=0; i<result.Length; i++)
    {
       result[i]=array[array.Length-1-i];
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] array= new int[]{1,2,3,4,5};
int[] result= GetReverseArray(array);
PrintArray(result);
