using System;
using System.Collections.Generic;

namespace MinimizeDeviation
{

    public class Solution
    {
        public int MinimumDeviation(int[] nums)
        {
            var set = new SortedSet<int>();

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    set.Add(num);
                }
                else
                {
                    set.Add(num * 2);   
                }
            }

            var min = set.Max - set.Min;
            
            while(set.Max % 2 == 0)
            {
                var last = set.Max;
                set.Remove(last);
                set.Add(last / 2);
                min = Math.Min(min, set.Max - set.Min);
            }

            return min;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var s = new Solution();
            var a = new int[] { 1, 2, 3, 4 };
            s.MinimumDeviation(a);
            Console.WriteLine("Hello World!");
        }
    }
}
