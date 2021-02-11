using System;
using System.Linq;

namespace ValidAnagram
{
    public class Solution {
    public bool IsAnagram(string s, string t) {
        var aArr = s.ToCharArray();
        var tArr = t.ToCharArray();

        Array.Sort(aArr);
        Array.Sort(tArr);

       /*  foreach(var a in aArr){
            Console.WriteLine(a);
        }
Console.WriteLine("________________");
        foreach(var ta in tArr){
            Console.WriteLine(ta);
        } */

        return Enumerable.SequenceEqual(tArr, aArr);

    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s  = new Solution();
            var res = s.IsAnagram("ana1gram", "nagaram");
            Console.WriteLine(res);
            Console.WriteLine("Hello World!");
        }
    }
}
