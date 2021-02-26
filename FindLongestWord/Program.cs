using System;
using System.Collections.Generic;
using System.Linq;

namespace FindLongestWord
{
    public class Solution
    {
        public string FindLongestWord(string s, IList<string> d)
        {

            var res = "";
            var ss = String.Concat(s.OrderBy(c => c).Distinct());
            foreach (var elem in d)
            {
                var a = String.Concat(elem.OrderBy(c => c).Distinct());
                if (ss.Contains(a) && a.Length > res.Length)
                {
                    res = a;
                }


            }


            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var res = s.FindLongestWord("abpcplea", new List<string>() { "ale", "apple", "monkey", "plea" });
            Console.WriteLine(res);
        }
    }
}
