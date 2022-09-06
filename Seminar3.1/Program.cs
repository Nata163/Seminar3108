int[] nums = new int[10] { 10, 24, 45, 67, 77, 10, 11, 1, 66, 44 };

int max = nums[0] ;
for (int i = 0; i < nums.Length; i++)
{
    if(nums[i]>max)
    {
        max = nums[i];
    }
}
Console.Clear();
Console.WriteLine(max);
