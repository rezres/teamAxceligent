using System.Collections.Generic;
using System.Linq;

namespace teamAxceligent
{

    public static class BiggestNeighborSum
    {
        public static int Challenge(int[] input)
        {
            //User Linq to Calculate the max occurance and populate it to a dictionary
            //this will help us later to filter the array and get the max occurance.
            var DictionaryMatch = input
                .GroupBy(No => No)
                .ToDictionary(group => group.Key, group => group.Count());
            //Console.WriteLine(string.Join(",", DictionaryMatch));
            //Get Max Value
            var max = DictionaryMatch.Max(t => t.Value);
            var ToBeSearched = input.Where(No => DictionaryMatch[No] >= max - 1).ToArray();
            var Result = 0;
            for (int i = 0; i < ToBeSearched.Length - 1; i++)
            {
                var NeighborSum = ToBeSearched[i] + ToBeSearched[i + 1];
                if (Result < NeighborSum)
                {
                    Result = NeighborSum;
                }
            }
            return Result;
        }
    }
}
