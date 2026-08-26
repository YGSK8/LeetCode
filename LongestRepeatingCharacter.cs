namespace LongestRepeatingCharacter;
public class LongestRepeatingCharacter
{
    
    public static int CharacterReplacement(string s, int k)
    {
        int maxLength=0;
        int start = 0;
        int index = 0;
        int CountMaxCharacter = 0;
        bool complete = false;
        Dictionary<char,int> keyValuePairs = new Dictionary<char, int>();
        while (!complete)
        {
                Console.WriteLine("Start here element: "+ s[index]);
                Console.WriteLine("index: "+ index);
                if (!keyValuePairs.TryAdd(s[index], 1))//--creates char key, or increments count value
                {
                    keyValuePairs[s[index]]+=1;
                }
                if(keyValuePairs[s[index]]>CountMaxCharacter)CountMaxCharacter=keyValuePairs[s[index]];//--logs count of max character in current window
                Console.WriteLine($"count max character: {CountMaxCharacter}");
                Console.WriteLine("windowSize: " + (index-start+1));
                if(index-start+1<=CountMaxCharacter+k){
                    if(index-start+1 > maxLength)maxLength=index-start+1;
                    if(index < s.Length-1){
                        Console.WriteLine("incrementing index");
                        index++;
                        }
                    else complete = true;
                    }
                else if (index-start+1 > CountMaxCharacter + k)
                {
                    Console.WriteLine("reducing window size");
                    if(index-start+1==maxLength)maxLength--;
                    keyValuePairs[s[start]]-=1;
                    start++;
                    if(index < s.Length-1){index++;}
                }
            
        }
        Console.WriteLine(maxLength);
        return maxLength;
    }
}