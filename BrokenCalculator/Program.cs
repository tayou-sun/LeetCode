using System;

namespace BrokenCalculator
{
    public class Solution
    {
        public int BrokenCalc(int X, int Y)
        {
            var res = 0;

            while (Y > X)
            {
                res++;
                if (Y % 2 == 1)
                {
                    Y++;
                }
                else
                {
                    Y = Y / 2;
                }
            }

            return res + X - Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var res = s.BrokenCalc(1, 1000000000);

            Console.WriteLine(res);
            Console.WriteLine("Hello World!");
        }
    }
}
