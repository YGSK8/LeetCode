namespace BinarySeach;
public class BinarySeach
{
    public static int IndexOfTarget(int[] sortedArray, int target)
    {
        int start = 0;
        int end = sortedArray.Length-1;
        bool completed = false;
        int halfwayIndex = (end - start + 1)/2;
        while (!completed)
        {
            if(target == sortedArray[halfwayIndex])return halfwayIndex;
            if (target < sortedArray[halfwayIndex])
            {
                if (start == end)
                {
                    if(sortedArray[start]==target){Console.WriteLine("match");return start;}
                    else {Console.WriteLine("here");return -1;}
                }
                end = halfwayIndex-1;
                int length = end-start+1;
                halfwayIndex = start + (length/2);
            }
            if(target > sortedArray[halfwayIndex])
            {
                if (halfwayIndex == end)
                {
                    if(sortedArray[halfwayIndex]==target){Console.WriteLine("match in increasing loop");return halfwayIndex;}
                    else {Console.WriteLine("not matching in increasing loop");return -1;}
                }
                start = halfwayIndex + 1;
                int length = end-start +1;
                halfwayIndex = start + (length/2);
            }
        }
        return -1;
    }
    public static int CorrectIndexOfTarget(int[] sortedArray, int target)
    {
        int start = 0;
        int end = sortedArray.Length-1;
        while (start<=end)
        {
            int halfwayIndex = start+(end - start)/2;
            if(target == sortedArray[halfwayIndex])return halfwayIndex;
            else if (target < sortedArray[halfwayIndex])
            {
                end = halfwayIndex-1;

            }
            else if(target > sortedArray[halfwayIndex])
            {
                start = halfwayIndex + 1;
            }
        }
        return -1;
    }
}