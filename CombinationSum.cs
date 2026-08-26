namespace CombinationSum;

public class CombinationSum
{
    public static List<List<int>> Combinations(List<int> candidates,int target)
    {
        List<List<int>> combinations = new List<List<int>>();
        helper(candidates,[],combinations,0,target);
        return combinations;
    }
    public static void helper(List<int> candidates,List<int> combination,List<List<int>>combinations,int start,int remaining)
    {
        if(remaining==0){
            combinations.Add([..combination]);
            return;
            }
        if(remaining<0){return;}
        for(int i = start; i < candidates.Count; i++)
        {
            combination.Add(candidates[i]);
            remaining -= candidates[i];
            helper(candidates,combination,combinations,i,remaining);
            combination.Remove(candidates[i]);
            remaining += candidates[i];
        }
    }
}