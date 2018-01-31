﻿namespace NaturalNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(6));
        }

        /*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
        Note: If the number is a multiple of both 3 and 5, only count it once.*/

        public static int Solution(int n)
        {
            return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
    }
}
