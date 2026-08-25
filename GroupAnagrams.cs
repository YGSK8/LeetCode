namespace GroupAnagram;

public class GroupAnagram
{
    public static List<List<string>> GroupAnagrams(string[] strs)
    {
        List<List<string>> groups = new List<List<string>>();
        Dictionary<string,List<string>> keyValuePairs=new Dictionary<string, List<string>>();
        foreach(string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            if(!keyValuePairs.TryAdd(sorted,new List<string>(){word}))keyValuePairs[sorted].Add(word);
        }
        foreach(KeyValuePair<string,List<string>> pair in keyValuePairs)
        {
            groups.Add(pair.Value);
        }
        foreach(List<string>words in groups)
        {
            Display(words);
        }
        return groups;
    }

    public static void Display(List<String> strings)
    {
        Console.WriteLine("list:");
        foreach (string word in strings)
        {
            Console.WriteLine(word);
        }
    }
}