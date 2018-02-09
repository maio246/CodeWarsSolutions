namespace SumofDigitsDigitalRoot
{
    using System;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(493193));
        }

        /*In this kata, you must create a digital root function.
    
        A digital root is the recursive sum of all the digits in a number. 
        Given n, take the sum of the digits of n. If that value has two digits, 
        continue reducing in this way until a single-digit number is produced. 
        This is only applicable to the natural numbers.*/

        //best solution return (int)(1 + (n - 1) % 9);

        public static int DigitalRoot(long n)
        {
            var timesToRotate = n.ToString().Length;
            long sum = 0;

            while (n > 0)
            {
                var tail = n % 10;
                n /= 10;
                sum += tail;
            }

            while (sum > 10)
            {
                var num1 = sum % 10;
                var num2 = sum / 10;
                sum = num1 + num2;
            }

            return (int)sum;
        }
    }
}
