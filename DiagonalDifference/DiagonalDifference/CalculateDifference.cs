using System;
using System.Collections.Generic;
using System.Text;

namespace DiagonalDifference
{
    class CalculateDifference
    {
        private readonly List<List<int>> arr = new List<List<int>> {
            new List<int> { 11, 2, 4 },
            new List<int> { 4, 5, 6 },
            new List<int> { 10, 8, - 12 }
        };

        public CalculateDifference()
        {
            Console.WriteLine(FindTheDifference(arr));
        }

        private static int FindTheDifference(List<List<int>> arr)
        {
            int leftSum = 0;
            int rightSum = 0;
            int count = arr.Count-1;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (j == i)
                    {
                        leftSum += arr[i][j];
                    }
                    if (j == count)
                    {
                        rightSum += arr[i][count];
                    }
                }
                count--;
            }
            return Math.Abs(leftSum - rightSum);
        }
    }
}
