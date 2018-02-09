namespace SplitStringsInPairsOfTwo
{
    using System;
    using System.Collections.Generic;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Solution("abcdef")));
        }

        /*
         Complete the solution so that it splits the string into pairs of two characters. 
         If the string contains an odd number of characters then it should replace the missing 
         second character of the final pair with an underscore ('_').*/

        //best solution:
        /* if (str.Length%2 != 0)
              str += "_";
           return Enumerable.Range(0, str.Length)
              .Where(x => x%2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();*/

        public static string[] Solution(string str)
        {
            var result = new List<string>();

            for (int i = 0; i < str.Length; i+= 2)
            {
                if (i % 2 == 0 && i == str.Length - 1)
                {
                    result.Add(str[i] + "_");
                    continue;
                }

                result.Add(string.Concat( str[i], str[i + 1]));
            }

            return result.ToArray();
        }
    }
}
