namespace Combinations;
using Recusions;

public class Combinations
{
    public static List<List<int>> Combintations(int n, int k)
    {
        List<List<int>>combinations = new List<List<int>>();
        Backtrack(1,k,n,[],combinations);
        return combinations;
    }
    public static void Backtrack(int start, int length, int n,List<int>combination,List<List<int>>combinations)
    {
        if(combination.Count==length){
            
            combinations.Add([..combination]);
            Recursions.Display(combination);
            return;}//--base case
        for(int i = start; i <= n; i++)
        {
            combination.Add(i);//--adds element
            Backtrack(i+1,length,n,combination,combinations);//--recurse
            combination.RemoveAt(combination.Count-1);//--remove last element
        }
    }
    
}