namespace LongestSubstring;

public class LongestSubstring
{
    public static int LengthOfLongestSubstring(string s)
    {
        int maxLength=0;
        int start = 0;
        Dictionary<char,int> keyValuePairs = new Dictionary<char, int>();
        for(int i = start; i < s.Length; i++)
        {
            if (!keyValuePairs.TryAdd(s[i], i))
            {
                if(keyValuePairs[s[i]]>=start)start=keyValuePairs[s[i]]+1;
                keyValuePairs[s[i]]=i;
            }
            if(i-start + 1>maxLength)maxLength = i-start +1;
            // Console.WriteLine("start: "+start);
            // Console.WriteLine("i: "+i);
        }
        // Console.WriteLine(maxLength);
        return maxLength;
    }
}