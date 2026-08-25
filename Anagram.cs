namespace Anagram;

public class Anagram
{
    public static bool CheckAnagram(string a,string b)
    {

        Dictionary<char,int> keyValuePairs = new Dictionary<char, int>();
        if (a.Length!=b.Length)return false;
        {
            for(int x = 0; x < a.Length; x++)
            {
                if (!keyValuePairs.ContainsKey(a[x]))keyValuePairs.Add(a[x],1);//--can use tryadd instead, refactoring can be done
                else keyValuePairs[a[x]]+=1;
            }
            for(int y = 0; y < b.Length; y++)
            {
                if(!keyValuePairs.ContainsKey(b[y]))return false;
                else {
                    keyValuePairs[b[y]]-=1;
                    if(keyValuePairs[b[y]]<0) return false;
                    }
            }
            return true;
        }
    }
}