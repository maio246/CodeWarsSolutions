namespace ArraysDifferentElements
{
    using System;
    using System.Linq;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 })));
        }

        /*Instructions
          Output
          Your goal in this kata is to implement an difference function, which subtracts one list from another.

          It should remove all values from list a, which are present in list b.*/

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => b.Contains(n)).ToArray();
        }
    }
}
