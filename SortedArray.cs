namespace SortedArray;

public class SortedArray
{
    public static int FindMin(int[] nums)
    {
        int start = 0;
        int end = nums.Length-1;
        int min = int.MaxValue;

        while (start <= end)
        {
            int mid = start + (end-start)/2;
            Console.WriteLine($"check - start:{start} end:{end} mid:{mid}");
            if(start==end) break;
            if (nums[mid] < nums[start])
            {
                Console.WriteLine($"first check - start:{start} end:{end} mid:{mid}");
                end = mid;
            }
            else if (nums[mid] > nums[start])
            {
                Console.WriteLine($"second check - start:{start} end:{end} mid:{mid}");
                if(nums[start]<min){min = nums[start];}
                start = mid +1;
            }
            else if (nums[mid] == nums[start])
            {
                if (nums[start] < nums[end])
                {
                    end = start;
                }
                else start = end;
            }
        }
        // Console.WriteLine(nums[start]);
        Console.WriteLine(Math.Min(nums[start],min));
        return Math.Min(nums[start],min);
    }

     public static int FindMinCorrect(int[] nums)
    {
        int start = 0;
        int end = nums.Length-1;
        while (start < end)
        {
            int mid = start + (end-start)/2;
            // Console.WriteLine($"startIndex={start} value = {nums[start]}");
            // Console.WriteLine($"midIndex={mid} value = {nums[mid]}");
            // Console.WriteLine($"endIndex={end} value = {nums[end]}");
            if (nums[mid] <nums[end])
            {
                // Console.WriteLine("mid<end");
                end =mid;
            }
            else if (nums[mid] > nums[end])
            {
                // Console.WriteLine("mid>end");
                start = mid + 1;
            }
            
        }
        return nums[start];
    }
}