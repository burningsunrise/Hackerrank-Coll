using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    class Program
    {
        static List<int> CompareTriplets(List<int> a, List<int> b) {
            List<int> score = new List<int>() {0,0};
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    score[0]++;
                }
                else if (a[i] < b[i])
                {
                    score[1]++;
                }

            }
            return score;
        }
        
        static void Main(string[] args)
        {
            List<int> a = new List<int> {5, 6, 7};

            List<int> b = new List<int> {3, 6 ,10};

            List<int> result = CompareTriplets(a, b);
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}