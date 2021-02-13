using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveKDigits
{

    public class Solution
    {
        public string RemoveKdigits(string num, int k)
        {
            var stack = new Stack<char>();
            foreach (var n in num)
            {
                while (stack.Count > 0 && stack.Peek() - '0' > n - '0' && k > 0)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(n);

            }


            while (stack.Count > 0 && k > 0)
            {

                stack.Pop();
                k--;
            }

            var r = stack.ToArray();
            Array.Reverse(r);
            var res = String.Join("", r).TrimStart('0');

            return res.Length == 0 ? "0" : res;
        }
    }
    class Program
    {
        static void Main(string[] argss)
        {
            var s = new Solution();
            //var res = s.RemoveKdigits("1432219", 3);
            var res = s.RemoveKdigits("10", 1);
            Console.WriteLine(res);
        }
    }
}
