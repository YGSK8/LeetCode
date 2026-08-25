
using System.Dynamic;
namespace Permutations;

class Permutations
{
   public static List<string> SinglePermutations(string s)
   {
       List<char> characters = new List<char>();
       List<int> integers = new List<int>();//--base integer list
       for(int x = 0; x < s.Length; x++)
        {
            characters.Add(s[x]);
            integers.Add(x);
        }
        bool flag = false;
        List<int> permutation = [..integers];
        List<string> words = new List<string>();
        List<List<int>> permutations = new List<List<int>>();
        int count = 1;
        while(flag == false)
        {   
            permutations.Add([..permutation]);
            List<IndexData> indexDatas = new List<IndexData>();
            foreach(int x in permutation)
            {
                IndexData data = new IndexData{ Index = permutation.IndexOf(x),Value = x}; //--Generate data info with index value
                if (data.Index == 0)
                {
                    for(int b = data.Index; b < permutation.Count; b++)
                    {
                        data.Options.Add(integers[b]);
                        data.SwappedOptions.Add(integers[b]);
                    }
                }
                else
                {
                    int prevIndex = data.Index-1;
                    List<int> prevSwapOptions = indexDatas[prevIndex].SwappedOptions;
                    for(int b = 1; b < indexDatas[prevIndex].SwappedOptions.Count; b++)
                    {
                        data.Options.Add(prevSwapOptions[b]);
                        data.SwappedOptions.Add(prevSwapOptions[b]);
                    }
                }
                if (data.Options[0] != data.Value)//--swap if needed!!!
                {
                    int indexOfValue = data.Options.IndexOf(data.Value);
                    int firstOption = data.Options[0];
                    data.SwappedOptions[0]= data.Value;
                    data.SwappedOptions[indexOfValue]=firstOption;
                }
                indexDatas.Add(data);
            }
            flag = false;
            List<int> modifiedList=[..permutation];
            for(int reverseIndex = permutation.Count -1;reverseIndex >= 0; reverseIndex--)
            {
                if(reverseIndex == 0 && indexDatas[reverseIndex].Value == indexDatas[reverseIndex].Options[^1]){
                    flag=true;
                    break;
                    }
                if (indexDatas[reverseIndex].Value != indexDatas[reverseIndex].Options[^1])
                {
                    List<int> newOption = [..indexDatas[reverseIndex].Options];
                    int indexOfValue = indexDatas[reverseIndex].Options.IndexOf(indexDatas[reverseIndex].Value);
                    int firstValue = indexDatas[reverseIndex].Options[0];
                    newOption[0]=indexDatas[reverseIndex].Options[indexOfValue+1];
                    newOption[indexOfValue+1] = firstValue;
                    for(int y = 1; y <= newOption.Count; y++)
                    {
                        modifiedList[^y] = newOption[^y];
                    }
                    count++;
                    break;
                }
            }
            if(flag==true)break;
            permutation = [..modifiedList];
        }
        foreach(List<int> ints in permutations)
        {
            string word = "";
            foreach(int position in ints)
            {
                word += characters[position];
            }
            if(!words.Contains(word))words.Add(word);
            Console.WriteLine("word added");
        }
        foreach(string word in words){Console.WriteLine(word);};
       return words;
   }
    public static void Display(List<int> list)
    {
        Console.Write(": ");
        foreach(int x in list)
        {
            Console.Write(x);
        }
        Console.Write("\n");
    }
}
public class IndexData
    {
        public int Index {get;init;}
        public int Value {get;init;}
        public List<int> Options {get;init;} = new List<int>();
        public List<int> SwappedOptions {get;init;} = new List<int>();
    }