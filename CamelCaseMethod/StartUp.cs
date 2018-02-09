namespace CamelCaseMethod
{
    using System;
    using System.Globalization;
    using System.Linq;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello world!".CamelCase());
        }

        /*Write simple .camelCase method 
         (camel_case function in PHP or CamelCase in C#) for strings.
         All words must have their first letter capitalized without spaces.*/

        public static string CamelCase(this string str)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str).Replace(" ", "");
        }
    }
}
