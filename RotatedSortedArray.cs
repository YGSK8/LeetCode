using System.Runtime.CompilerServices;

namespace RotatedSortedArray;
public class RotatedSortedArray{
    public static int Search(int[]nums,int target)
    {
        int start = 0;
        int end = nums.Length-1;

        while (start < end)
        {
            int mid = start + (end-start)/2;
            Console.WriteLine($"Start index: {start} Start value: {nums[start]}");
            Console.WriteLine($"mid index: {mid} mid value: {nums[mid]}");
            Console.WriteLine($"end index: {end} end value: {nums[end]}");
            if (nums[mid] <= nums[start])//--unsorted path
            {
                Console.WriteLine("unsorted path");
                if(nums[start]==target){Console.WriteLine($"this path {start}");return start;}
                if(nums[mid]==target){Console.WriteLine($"second path {mid}");return mid;}
                else if(nums[mid]>target)end=mid;
                else start = mid + 1;
            }
            if (nums[mid] >= nums[start])//--sorted path
            {
                Console.WriteLine("sorted path");
                if(nums[mid]==target){Console.WriteLine($"this path {mid}");return mid;}
                else if(nums[start]==target){Console.WriteLine($"second path {start}");return start;}
                else if(nums[mid]>target && nums[start] < target)
                {
                    end = mid;
                }
                else start = mid + 1;
            }
        }
        if(nums[start]!=target){Console.WriteLine(-1);return -1;}
        else {Console.WriteLine(start);return start;}
    }

    public static int CorrectSearch(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length-1;

        while (start < end)
        {
            int mid = start + (end-start)/2;
            if (nums[mid] >= nums[start])
            {
                if(target>=nums[start] && target <=nums[mid]) end = mid;
                else start = mid+1;
            }
            else
            {
                if(target>=nums[mid+1] && target <= nums[end])
                {
                    start = mid + 1;
                }
                else end = mid;
            }
        }
        Console.WriteLine(nums[start]);
        if(nums[start]!=target)return -1;
        else return start;
    }
}