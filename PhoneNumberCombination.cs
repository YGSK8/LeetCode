namespace PhoneNumberCombination;
public class PhoneNumber
{
    public static Dictionary<int,string> numberDicitonary = new Dictionary<int, string>()
    {
        {2,"abc"},{3,"def"},{4,"ghi"},{5,"jkl"},{6,"mno"},{7,"pqrs"},{8,"tuv"},{9,"wxyz"}
    };

    public static List<string> LetterCombinations(string digits)
    {
        List<string> combinations = new List<string>();
        Helper(numberDicitonary,digits,0,[],combinations);
        return combinations;
    }
    public static void Helper(Dictionary<int,string> numberDicitonary,string digits,int start,List<char> combination,List<String>combinations)
    {
        if(combination.Count == digits.Length)
        {
            string text = String.Concat([..combination]);
            combinations.Add(text);
            // Display(combination);
            return;

        }
        for(int i = 0; i < numberDicitonary[digits[start]-'0'].Length; i++)
        {
            combination.Add(numberDicitonary[digits[start]-'0'][i]);//--adds char to combination
            Helper(numberDicitonary,digits,start+1,combination,combinations);
            combination.RemoveAt(combination.Count-1);
        }
    }

    public static void Display(List<char> list)
    {
        foreach(char character in list)
        {
            Console.Write(character);
        }
        Console.WriteLine("");
    }

}

public class CombinationSum{

    public static List<List<int>> Combination(List<int>candidates,int target)
    {
        List<List<int>> combinations = new List<List<int>>();
        Helper(target,0,candidates,[],combinations);
        return combinations;
    }
    
    public static void Helper(int remaining, int start,List<int> input,List<int> combination,List<List<int>>combinations)
    {
        if (remaining == 0)
        {
            combinations.Add([..combination]);
            // Recursions.Display(combination);
            return;
        }
        if(remaining<0){
            return;
        }
        for(int i = start; i < input.Count; i++)
        {
            combination.Add(input[i]);
            remaining-=input[i];
            Helper(remaining,i,input,combination,combinations);
            remaining+=input[i];
            combination.RemoveAt(combination.Count-1);
        }
    }
}