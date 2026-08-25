namespace Palindrome;
public class Palindrome
{
    public static bool IsPalindrome(string s)
    {
        List<char> chars = new List<char>();
        for(int x = 0; x < s.Length; x++)
        {
            if(Char.IsLetterOrDigit(s[x]))chars.Add(Char.ToLower(s[x]));
        }
        for(int x = 0; x < chars.Count; x++)
        {
            if(chars[x]!=chars[^(1+x)])return false;
        }
        return true;
    }

    public static bool TwoPointerPalindrome(string s)
    {
        int right = 0;
        int left = s.Length-1;
        while (right < left)
        {
            while (right<left && !char.IsLetterOrDigit(s[right]))right++;
            while (right<left && !char.IsLetterOrDigit(s[left]))left--;
            if(Char.ToLower(s[right])!=Char.ToLower(s[left]))return false;
            right++;
            left--;
        }
        return true;
    }
}