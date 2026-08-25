namespace FirstAndLast;
public class FirstAndLast
{
    public static int[] SearchRange(int[]nums,int target){

        int[] indexes = new int[2];
        int start = 0;
        int end = nums.Length-1;
        while (start <= end)
        {
            Console.WriteLine($"reaching here {start} {end}");
            int mid = start + (end-start)/2;
            if(start==end){if (nums[end]==target)start++; else end=-1;}
            else if(target>=nums[start] && target <=nums[mid])end=mid;
            else if(target>=nums[mid+1] && target <=nums[end])start = mid+1;
            else end = -1;
        }
        indexes[0]=end;

        start = 0;
        end = nums.Length-1;
        while (start <= end)
        {
            Console.WriteLine($"reaching here {start} {end}");
            int mid = start + (end-start)/2;
            if(start==end){if (nums[end]==target)start++; else end=-1;}
            else if(target>=nums[mid+1] && target <=nums[end])start = mid+1;
            else if(target>=nums[start] && target <=nums[mid])end=mid;
            else end = -1;
        }
        indexes[1]=end;
        foreach(int num in indexes)
        {
            Console.WriteLine(num);
        }
        return indexes;
    }
}