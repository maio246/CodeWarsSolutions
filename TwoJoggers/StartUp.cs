namespace TwoJoggers
{
    using System;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NbrOfLaps(5, 3));
        }

        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            var outerMultiplier = 0;
            var innerMultiplier = 0;
            var isFinishTime = false;

                for (int i = 1; i <= 10000; i++)
                {
                    if (isFinishTime)
                    {
                        break;
                    }
                    for (int j = 1; j <= 10000; j++)
                    {
                        if (x * i == y * j)
                        {
                            innerMultiplier = j;
                            outerMultiplier = i;
                            isFinishTime = true;
                            break;
                        }
                    }
                }

            return new Tuple<int, int>(outerMultiplier, innerMultiplier);
        }
    }
}
