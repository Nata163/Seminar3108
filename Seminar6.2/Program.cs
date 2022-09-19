// // переворот одномерного массива без использования второго массива
int[] GetReverseArray2(int[] array)
{
    int tempStorage = array[0];
    for(int i=0; i<array.Length/2; i++)
    {
       tempStorage = array[i];
       array[i]=array[array.Length-1-i];
       array[array.Length-1-i]=tempStorage;
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

int[] array= new int[]{1,2,3,4,5};
int[] result= GetReverseArray2(array);
PrintArray(result);