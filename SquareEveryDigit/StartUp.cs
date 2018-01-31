namespace SquareEveryDigit
{
    using System;
    using System.Linq;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(9119));
        }

        /*Welcome. In this kata, you are asked to square every digit of a number.
        For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
        Note: The function accepts an integer and returns an integer
        */
        public static int SquareDigits(int n)
        {
            return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
        }
    }
}
