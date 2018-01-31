namespace HighestandLowest
{
    using System;
    using System.Linq;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StartUp.HighAndLow("1 9 3 4 -5"));
        }

        //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

        //Something different then just .Min(), .Max() :)
        public static string HighAndLow(string numbers)
        {
            var asd = numbers.Split()
                .Select(int.Parse)
                .ToList()
                .Aggregate(new { Max = int.MinValue, Min = int.MaxValue }, 
                             (accumulator, o) => new { Max = Math.Max(accumulator.Max, o),
                                          Min = Math.Min(accumulator.Min, o)});

            return String.Join(" ", asd.Max, asd.Min);
        }
    }
}
