namespace SearchInsert;
public class SearchInsert
{
    public static int SearchInsertMethod(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length-1;

        while (start <= end)
        {
            int mid = start + (end-start)/2;
            if(target==nums[mid]){start = mid;break;}
            else if (target > nums[mid])start = mid +1;
            else end = mid -1;
        }
        Console.WriteLine(start);
        return start;
    }
}