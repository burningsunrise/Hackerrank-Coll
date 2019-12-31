using System;

namespace MiniMaxiSum
{
    class Program
    {
        
        static void MiniMaxSum(int[] num) {
            int lowest = 0;
            int highest = 0;
            long maximumSum = 0;
            long minimumSum = 0;
            for (int i = 0; i < num.Length; i++)
            { 
                // find highest
                if (i+1 < num.Length && num[i] > num[i + 1] && num[i] > num[highest])
                {
                    highest = i;
                }
                else if (i+1 < num.Length && num[i + 1] > num[i] && num[i + 1] > num[highest])
                {
                    highest = i + 1;
                }

                // find lowest
                if (i + 1 < num.Length && num[i] < num[i + 1] && num[i] < num[lowest])
                {
                    lowest = i;
                }
                else if (i + 1 < num.Length && num[i + 1] < num[i] && num[i + 1] < num[lowest])
                {
                    lowest = i + 1;
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (i == highest)
                {
                    continue;
                }
                maximumSum += num[i];
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (i == lowest)
                {
                    continue;
                }
                minimumSum += num[i];
            }
            Console.WriteLine($"{maximumSum} {minimumSum}");

        }
        static void Main(string[] args)
        {
            var arr = new[] {1, 2, 3, 4, 5};
            MiniMaxSum(arr);
        }
    }
}
