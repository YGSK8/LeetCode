namespace TopFrequentElements;

public class TopFrequentElements
{
    public static int[] TopKFrequent(int[]nums,int k)
    {
        Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
        List<KeyValuePair<int,int>> counts = new List<KeyValuePair<int, int>>();
        foreach(int num in nums)
        {
            if(!keyValuePairs.TryAdd(num,1))keyValuePairs[num]+=1;
        }
        counts.AddRange(keyValuePairs);
        counts.Sort((x,y)=>{return x.Value.CompareTo(y.Value);});
        int[] topFrequent = new int[k];
        for(int x =0;x<k;x++)
        {
            topFrequent[x]=counts[^(1+x)].Key;
        }
        foreach(int x in topFrequent)Console.WriteLine(x);
        return topFrequent;
    }
}