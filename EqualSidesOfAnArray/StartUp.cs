namespace EqualSidesOfAnArray
{
    using System;
    using System.Linq;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
        }
        /*You are going to be given an array of integers. 
         *Your job is to take that array and find an index N where the sum of the integers to the left of N 
         *is equal to the sum of the integers to the right of N. 
         *If there is no index that would make this happen, return -1.*/

        public static int FindEvenIndex(int[] arr)
        {
            for (int n = 0; n < arr.Length; n++)
            {
                var leftSum = arr.Take(n).Sum();
                var rightSum = arr.Skip(n + 1).Sum();

                if (leftSum == rightSum)
                {
                    return n;
                }
            }

            return -1;

        }
    }
}
