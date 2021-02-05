using System;
using System.Text;
using System.Collections.Generic;

namespace SimplifyPath
{

    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var res = new StringBuilder();

            var stack = new Stack<string>();

            var arr = path.Trim('/').Split('/');

            foreach (var a in arr)
            {
                if (a.Length == 0)
                    continue;
                if (a == ".")
                    continue;

                if (a == "..")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    continue;
                }
                stack.Push(a);
            }

            var reverseStack = new Stack<string>();

            if (stack.Count == 0)
                res.Append("/");
            else {

                while (stack.Count > 0)
                {   
                    reverseStack.Push(stack.Pop());
                }

                while (reverseStack.Count > 0)
                {
                    res.Append("/");
                    res.Append(reverseStack.Pop());
                }
        }
        return res.ToString();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var res = s.SimplifyPath("/a/./b/../../c/");

            Console.WriteLine(res);

            Console.WriteLine("Hello World!");
        }
    }
}
