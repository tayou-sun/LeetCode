using System;
using System.Collections.Generic;

namespace LongestHarmoniousSubsequence
{
    public class Solution
    {
        // Время
        /*  public int FindLHS(int[] nums)
         {
             var res = 0;

             for (var i = 0; i < (1 << nums.Length); i++)
             {
                 var min = int.MaxValue;
                 var max = int.MinValue;
                 var count = 0;
                 for (var j = 0; j < nums.Length; j++)
                 {
                     if ((i & (1 << j)) != 0)
                     {
                         min = Math.Min(min, nums[j]);
                         max = Math.Max(max, nums[j]);
                         count++;
                     }

                 }

                 if (max - min == 1)
                 {
                     res = Math.Max(res, count);
                 }
             }

             return res;
         }
  */
        // Время
        /*  public int FindLHS(int[] nums)
         {
             var res = 0;

             for (var i = 0; i < nums.Length; i++)
             {
                 var count = 0;
                 var flag = false;
                 for (var j = 0; j < nums.Length; j++)
                 {
                     if (nums[j] == nums[i])
                         count++;
                     if (nums[i] + 1 == nums[j])
                     {
                         count++;
                         flag = true;
                     }

                 }

                 if (flag)
                     res = Math.Max(res, count);

             }
             return res;
         }
     */
        public int FindLHS(int[] nums)
        {
            var res = 0;

            var dict = new Dictionary<int, int>();

            foreach (var n in nums)
            {
                if (dict.ContainsKey(n))
                    dict[n]++;
                else
                    dict.Add(n, 1);
            }

            foreach (var d in dict.Keys)
            {
                if (dict.ContainsKey(d + 1))
                    res = Math.Max(res, dict[d] + dict[d + 1]);
            }

            return res;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var ar = new int[] { 1, 2, 3 };
            var s = new Solution();
            Console.WriteLine(s.FindLHS(ar));
            //Console.WriteLine("Hello World!");
        }
    }
}
