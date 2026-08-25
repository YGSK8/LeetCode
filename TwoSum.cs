namespace TwoSum;

using System.Diagnostics.CodeAnalysis;
using Recusions;

public class TwoSumBackTracking //--wrong! Not he correct solution
{
    public static int[] TwoIndex(List<int>candidates,int target)
    {
        List<int> final = new List<int>();
        bool shouldStop = false;
        Helper(0,candidates,[],target,ref shouldStop,final);
        int [] indexes = final.ToArray();
        return indexes;
    }
    public static void Helper(int start, List<int>input,List<int> combination,int remaining,ref bool stop,List<int>final)
    {
        if(combination.Count==2 && remaining == 0)
        {
            foreach(int val in combination)
            {
                final.Add(input.IndexOf(val));
            }
            Recursions.Display(final);
            stop=true;
            return;
        }
        if(combination.Count == 2)
        {
            return;
        }
        for(int i = start; i < input.Count; i++)
        {
            combination.Add(input[i]);
            remaining-=input[i];
            Helper(i+1,input,combination,remaining,ref stop,final);
            if(stop==true){;break;}
            remaining+=input[i];
            combination.RemoveAt(combination.Count-1);
        }
    }
}

public class TwoSum
{
    public static int[] TwoSumHash(int[]nums, int target)
    {
        Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
        int[] indexes = new int[2];
        for(int i = 0; i < nums.Length; i++)//--populate dictionary
        {
            if (keyValuePairs.ContainsKey(nums[i]))
            {
                indexes[0]=keyValuePairs[nums[i]];
                indexes[1]=i;
                break;
            }
            else keyValuePairs[target-nums[i]]=i;
        }
        foreach(int x in indexes)Console.WriteLine(x);
        return indexes;
    }

    public static int[] TwoSumPointer(int[]numbers, int target)
    {
        int right = 0;
        int left = numbers.Length-1;
        while (numbers[right] + numbers[left] != target)
        {
            if(left==right+1){right++;left =numbers.Length;}
            else{left--;}
        }
        Console.WriteLine((right+1) +" "+ (left+1));
        return [right+1,left+1];
    }

    public static int[] TwoSumPointerCorrect(int[]numbers, int target)
    {
        int left = 0;
        int right = numbers.Length-1;

        while (left < right)
        {
            int sum = numbers[left]+numbers[right];
            if(sum==target){Console.WriteLine("final: "+(left+1)+(right+1));return[left+1,right+1];}
            if(sum>target)right--;
            else left++;
        }
        return [];
    }
}