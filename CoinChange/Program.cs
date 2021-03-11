using System;

namespace CoinChange
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            var operationCountArray = new int[amount + 1];
            Array.Fill(operationCountArray, amount + 1);
            operationCountArray[0] = 0;
            for (var i = 0; i <= amount; i++)
            {
                for (var j = 0; j < coins.Length; j++)
                {
                    if (i - coins[j] >= 0)
                    {
                        operationCountArray[i] = Math.Min(operationCountArray[i], operationCountArray[i - coins[j]] + 1);
                    }
                }
            }
            return operationCountArray[amount] == amount + 1 ? -1 : operationCountArray[amount];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var res = s.CoinChange(new int[] { 1, 2, 5 }, 11);
            Console.WriteLine(res);
        }
    }
}
