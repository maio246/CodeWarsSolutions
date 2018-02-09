namespace SortOddNumbersInsideArray
{
    using System;
    using System.Linq;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        /*You have an array of numbers.
          Your task is to sort ascending odd numbers but even numbers must be on their places.

          Zero isn't an odd number and you don't need to move it. 
          If you have an empty array, you need to return it.*/

        //better solution 
        //Queue<int> odds = new Queue<int>(array.Where(e => e%2 == 1).OrderBy(e => e));
        //return array.Select(e => e%2 == 1 ? odds.Dequeue() : e).ToArray();

        public static int[] SortArray(int[] array)
        {
            var oddNumbers = array.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();
            var oddIndexer = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0 && array[i] != 0)
                {
                    array[i] = oddNumbers[oddIndexer];
                    oddIndexer++;
                }

            return array;
        }
    }
}
