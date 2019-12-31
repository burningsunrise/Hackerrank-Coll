using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCakeCandles
{
    class Solution
    {
        readonly int[] howTall = new int[] { 18, 90, 90, 13, 90, 75, 90, 8, 90, 43 };

        public Solution()
        {
            Console.WriteLine(ThisIsAMethod(howTall));
        }

        private int ThisIsAMethod(int[] ar)
        {
            int highestNum = int.MinValue;
            int count = 0;
            foreach (var num in ar)
            {
                if (num > highestNum)
                {
                    highestNum = num;
                }
            }
            foreach (var num in ar)
            {
                if (num == highestNum)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
